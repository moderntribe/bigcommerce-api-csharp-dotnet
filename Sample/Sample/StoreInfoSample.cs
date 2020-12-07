using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using StoreInfo.Api;
using StoreInfo.Client;
using StoreInfo.Model;

namespace Sample
{
    class StoreInfoSample
    {
        private StoreInformationApi storeInfoApi;

        public StoreInfoSample(JObject authConfig)
        {
            Configuration config = Configuration.Default;
            config.ApiKey.Add("X-Auth-Token", (string)authConfig["accessToken"]);
            config.BasePath = config.BasePath.Replace("{$$.env.store_hash}", (string)authConfig["storeId"]);

            this.storeInfoApi = new StoreInformationApi(config);
        }

        public void getStoreInfo()
        {
            string accept = "application/json";
            string contentType = "application/json";

            try
            {
                // Get Store Information
                StoreInformation storeInfo = this.storeInfoApi.StoreGet(accept, contentType);
                Debug.WriteLine(storeInfo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreInformationApi.StoreGet: " + e.ToString());
            }
        }
    }
}
