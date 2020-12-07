using Carts.Api;
using Carts.Client;
using Carts.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;

namespace Sample
{
    class CartSample
    {
        private CartApi cartApi;
        public CartSample(JObject authConfig)
        {
            Configuration config = Configuration.Default;
            config.ApiKey.Add("X-Auth-Token", (string)authConfig["accessToken"]);
            config.BasePath = config.BasePath.Replace("{$$.env.store_hash}", (string)authConfig["storeId"]);

            this.cartApi = new CartApi(config);
        }

        public void getACart()
        {
            string accept = "application/json";
            string contentType = "application/json";

            try
            {
                this.cartApi.GetACart("123", accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Got the expected 404: " + e.Message);
            }
        }
    }
}
