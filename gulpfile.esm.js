import gulp from 'gulp';
import cleaner from 'gulp-clean';
import { exec } from 'child_process';
import log from 'fancy-log';
import mustache from 'gulp-mustache';
import rename from 'gulp-rename';
import download from 'gulp-download2';
import fs from 'fs';
import { find } from 'lodash';
import merge from 'gulp-merge-json';
import { artifactVersion } from './swagger.config.json';

const apis = [
  // disappeared as of Oct 4, 2020
  // {
  //   name: 'wishlists',
  //   url: 'https://developer.bigcommerce.com/api-reference/customer-subscribers/wishlist-api/BigCommerce_Wishlist_API.oas2.json',
  //   packageName: 'Wishlists',
  // },
  {
    name: 'widgets',
    url: 'https://developer.bigcommerce.com/api-reference/store-management/widgets/widgets.v3.json',
    packageName: 'Widgets',
  },
  {
    name: 'themes',
    url: 'https://developer.bigcommerce.com/api-reference/store-management/themes/themes.v3.json',
    packageName: 'Themes',
    patch: 'themes.patch',
  },
  {
    name: 'catalog',
    url: 'https://developer.bigcommerce.com/api-reference/store-management/catalog/catalog.v3.json',
    packageName: 'Catalog',
    patch: 'catalog.patch',
  },
  {
    name: 'subscribers',
    url: 'https://developer.bigcommerce.com/api-reference/store-management/subscribers/subscribers.v3.json',
    packageName: 'Subscribers',
    patch: 'subscribers.patch',
  },
  {
    name: 'storeInfo',
    url: 'https://developer.bigcommerce.com/api-reference/store-management/store-information-api/store_information.v2.json',
    packageName: 'StoreInfo',
    patch: 'store_info.patch',
  },
  {
    name: 'scripts',
    url: 'https://developer.bigcommerce.com/api-reference/store-management/scripts/scripts.v3.json',
    packageName: 'Scripts',
    patch: 'scripts.patch',
  },
  {
    name: 'priceLists',
    url: 'https://developer.bigcommerce.com/api-reference/store-management/price-lists/price_lists.v3.json',
    packageName: 'PriceLists',
    patch: 'pricelists.patch',
  },
  // wrong content-type header
  // {
  //   name: 'ordersV2',
  //   url: 'https://developer.bigcommerce.com/api-reference/store-management/orders/BigCommerce_Orders_API.oas2.json',
  //   packageName: 'OrdersV2',
  // },
  {
    name: 'ordersV3',
    url: 'https://developer.bigcommerce.com/api-reference/store-management/order-transactions/orders.v3.json',
    packageName: 'OrdersV3',
    patch: 'ordersv3.patch',
  },
  // spec has gone missing
  // {
  //   name: 'sites',
  //   url: 'https://developer.bigcommerce.com/api-reference/cart-checkout/sites-routes-api/BigCommerce_Sites_Routes_API.oas2.json',
  //   packageName: 'sites',
  // },
  // error in spec file logic (can't build client)
  // {
  //   name: 'channels',
  //   url: 'https://developer.bigcommerce.com/api-reference/store-management/channels/channels.v3.json',
  //   packageName: 'Channels',
  // },
  {
    name: 'carts',
    url: 'https://developer.bigcommerce.com/api-reference/store-management/carts/carts.v3.json',
    packageName: 'Carts',
    patch: 'carts.patch',
  }
];

const installSwagger = (done) => {
  try {
    fs.accessSync('./bin/swagger-codegen-cli.jar');
    return done();
  } catch (err) {
    return download({
        url: 'https://repo1.maven.org/maven2/io/swagger/codegen/v3/swagger-codegen-cli/3.0.21/swagger-codegen-cli-3.0.21.jar',
        file: 'swagger-codegen-cli.jar',
       })
      .pipe(gulp.dest('bin'));    
  }
};

const clean = api => (
  () => (
    gulp
      .src([
        `clients/${api.name}/*`,
        `!clients/${api.name}/node_modules`,
        `!clients/${api.name}/test`,
      ],
      { read: false, allowEmpty: true })
      .pipe(cleaner())
  )
)

const codegen = api => done => {
  // java -jar bin/swagger-codegen-cli.jar  config-help -l java
  console.info(api);
  return exec(
    `java -jar bin/swagger-codegen-cli.jar generate \
  -i ${api.url} \
  -l csharp \
  -DpackageName=${api.packageName} \
  -c swagger.config.json \
  -o clients/${api.name}`,
    { cwd: '.' },
    (err, stdout, stderr) => {
      log(stdout);
      log(stderr);
      done(err);
    },
  );
};

const postCleanup = api => () => (
  gulp
    .src([
      `clients/${api.name}/.travis.yml`,
      `clients/${api.name}/git_push.sh`,
      `clients/${api.name}/mocha.opts`,
    ],
    { read: false, allowEmpty: true })
    .pipe(cleaner())
);

const applyPatch = api => (done) => {
  // duplicate the src dir to src.orig
  // make the fix in src
  // rm -rf src/bin src/obj
  // diff -ur src.orig src > ../../resources/patches/catalog_api.patch
  // to patch an unfixed src: cd src && patch -p1 -i ../../../resources/patches/catalog_api.patch
  // add the patch prop to api above
  if (api.patch) {
    exec(
      `patch -p1 -i ../../../resources/patches/${api.patch}`,
      { cwd: `./clients/${api.name}/src` },
      (err, stdout, stderr) => {
        log(stdout);
        log(stderr);
        done(err);
      },
    )
  } else {
    done();
  }
};

const applyCustomFixes = api => (done) => {
  if (api.name === 'storeInfo') {
    return exec(
      `mv clients/${api.artifactId}/src/main/java/com/bigcommerce/model/TimeZone.java \
      clients/${api.artifactId}/src/main/java/com/bigcommerce/model/Timezone.java`,
      { cwd: '.' },
      (err, stdout, stderr) => {
        log(stdout);
        log(stderr);
        done(err);
      },
    );      
  }
  done();
}

const buildClean = (api) => {
  return gulp.series(
    Object.assign(clean(api), { displayName: 'clean' }),
    installSwagger,
    Object.assign(codegen(api), { displayName: 'codegen' }),
    Object.assign(applyPatch(api), { displayName: 'applyPatch' }),
    // Object.assign(applyCustomFixes(api), { displayName: 'applyCustomFixes' }),
    Object.assign(postCleanup(api), { displayName: 'postCleanup' }),
  );
};

const buildOne = async (done) => {
  const [,,,arg,value] = process.argv;
  if (arg !== '--name' || !value) {
    console.info('Usage: gulp buildOne --name [api.name]');
    return done();
  }
  const api = find(apis, { name: value });
  if (!api) {
    console.warn(`No such api: ${value}`);
    console.info('Usage: gulp buildOne --name [api.name]');
    return done();    
  }
  await buildClean(api)();
  return done();
};
const buildAll = gulp.series(apis.map(api => buildClean(api)));

// given some env props, creates a master config, then creates all the test support config files, so they can run
// just keep your gulpfile.config.json around, and you don't have to run this
const testSupport = async (done) => {
  const config = {
    clientId: process.env.clientId,
    accessToken: process.env.accessToken,
    storeId: process.env.storeId,
  };
  await fs.writeFileSync('gulpfile.config.json', JSON.stringify(config));
  done();
};

// export tasks
export {
  buildAll, buildOne, testSupport,
};

export default buildAll;
