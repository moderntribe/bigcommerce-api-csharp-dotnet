using Newtonsoft.Json.Linq;
using PriceLists.Api;
using PriceLists.Client;
using PriceLists.Model;
using System;
using System.Diagnostics;

namespace Sample
{
    internal class PriceListsSample
    {
        private PriceListsApi priceListsApi;

        public PriceListsSample(JObject authConfig)
        {
            Configuration config = Configuration.Default;
            config.ApiKey.Add("X-Auth-Token", (string)authConfig["accessToken"]);
            config.BasePath = config.BasePath.Replace("{$$.env.store_hash}", (string)authConfig["storeId"]);

            this.priceListsApi = new PriceListsApi(config);
        }

        public void getPriceList()
        {
            try
            {
                PriceListResponse1 response = this.priceListsApi.GetPriceList(123);
                Debug.WriteLine(response.Data.ToString());
            }
            catch (Exception e)
            {

                Debug.Print("Got expected 404: " + e.Message);
            }
        }
    }
}