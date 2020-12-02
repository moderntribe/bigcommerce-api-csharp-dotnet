using Newtonsoft.Json.Linq;
using StoreInfo.Api;
using StoreInfo.Client;
using StoreInfo.Model;
using System;
using System.Diagnostics;
using System.IO;
using Themes.Api;
using Themes.Model;

namespace Sample
{
    class SampleRunner
    {
        static void Main(string[] args)
        {
            // read in json file
            JObject authConfig = JObject.Parse(File.ReadAllText(@"..\..\..\..\gulpfile.config.json"));

            StoreInfoCheck(authConfig);
            ThemesCheck(authConfig);
        }

        private static void ThemesCheck(JObject authConfig)
        {
            Themes.Client.Configuration config = Themes.Client.Configuration.Default;
            config.ApiKey.Add("X-Auth-Token", (string)authConfig["accessToken"]);
            config.BasePath = config.BasePath.Replace("{$$.env.store_hash}", (string)authConfig["storeId"]);

            ThemesApi themesApi = new ThemesApi(config);
            string accept = "application/json";
            string contentType = "application/json";

            try
            {
                // Get Store Information
                ThemesCollectionResponse themes = themesApi.GetStoreThemes(accept, contentType);
                foreach(var item in themes.Data)
                {
                    Debug.WriteLine(item);
                }
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreInformationApi.StoreGet: " + e.ToString());
            }

        }

        private static void StoreInfoCheck(JObject authConfig)
        {
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


