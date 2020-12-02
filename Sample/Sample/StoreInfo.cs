using Newtonsoft.Json.Linq;
using StoreInfo.Api;
using StoreInfo.Client;
using StoreInfo.Model;
using System;
using System.Diagnostics;
using System.IO;

namespace Sample
{
    class StoreInfo
    {
        static void Main(string[] args)
        {
            // read in json file
            JObject authConfig = JObject.Parse(File.ReadAllText(@"..\..\..\..\gulpfile.config.json"));

            // Configure API key authorization: X-Auth-Token
            Configuration config = Configuration.Default;
            config.ApiKey.Add("X-Auth-Token", (string)authConfig["accessToken"]);
            config.BasePath = config.BasePath.Replace("{$$.env.store_hash}", (string)authConfig["storeId"]);

            StoreInformationApi apiInstance = new StoreInformationApi(config);
            string accept = "application/json";
            string contentType = "application/json";

            try
            {
                // Get Store Information
                StoreInformation storeInfo = apiInstance.StoreGet(accept, contentType);
                Debug.WriteLine(storeInfo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreInformationApi.StoreGet: " + e.ToString());
            }
        }
    }
}


