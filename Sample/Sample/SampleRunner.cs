using Newtonsoft.Json.Linq;
using System.IO;

namespace Sample
{
    class SampleRunner
    {
        static void Main(string[] args)
        {
            // read in json file (see Readme.md for instructions)
            JObject authConfig = JObject.Parse(File.ReadAllText(@"..\..\..\..\gulpfile.config.json"));

            StoreInfoSample storeInfoSample = new StoreInfoSample(authConfig);
            storeInfoSample.getStoreInfo();

            ThemesSample themesSample = new ThemesSample(authConfig);
            themesSample.getStoreThemes();

            CartSample cartSample = new CartSample(authConfig);
            cartSample.getACart();

            CatalogSample catalogSample = new CatalogSample(authConfig);
            catalogSample.getProducts();

            OrdersSample ordersSample = new OrdersSample(authConfig);
            ordersSample.getTransactions();

            WidgetSample widgetSample = new WidgetSample(authConfig);
            widgetSample.getWidgets();

            SubscriberSample subscriberSample = new SubscriberSample(authConfig);
            subscriberSample.getSubscribers();

            PriceListsSample priceListsSample = new PriceListsSample(authConfig);
            priceListsSample.getPriceList();
        }
    }
}


