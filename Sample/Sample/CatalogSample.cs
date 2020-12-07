using Catalog.Api;
using Catalog.Client;
using Catalog.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class CatalogSample
    {
        private ProductsApi productsApi;

        public CatalogSample(JObject authConfig)
        {
            Configuration config = Configuration.Default;
            config.ApiKey.Add("X-Auth-Token", (string)authConfig["accessToken"]);
            config.BasePath = config.BasePath.Replace("{$$.env.store_hash}", (string)authConfig["storeId"]);

            this.productsApi = new ProductsApi(config);
        }

        public void getProducts()
        {
            try
            {
                InlineResponse2001 response = this.productsApi.GetProducts();
                foreach (var product in response.Data)
                {
                    Debug.WriteLine(product);
                }
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProducts: " + e.ToString());
            }
        }

    }
}
