using Newtonsoft.Json.Linq;
using OrdersV3.Api;
using OrdersV3.Client;
using OrdersV3.Model;
using System;
using System.Diagnostics;

namespace Sample
{
    class OrdersSample
    {
        private TransactionsApi transactionsApi;

        public OrdersSample(JObject authConfig)
        {
            Configuration config = Configuration.Default;
            config.ApiKey.Add("X-Auth-Token", (string)authConfig["accessToken"]);
            config.BasePath = config.BasePath.Replace("{$$.env.store_hash}", (string)authConfig["storeId"]);

            this.transactionsApi = new TransactionsApi(config);
        }

        public void getTransactions()
        {
            try
            {
                // Get Themes
                InlineResponse200 response = this.transactionsApi.GetTransactions(123);
                foreach (var transaction in response.Data)
                {
                    Debug.WriteLine(transaction);
                }
            }
            catch (Exception e)
            {
                Debug.Print("Got the expected 404: " + e.Message);
            }
        }

    }
}
