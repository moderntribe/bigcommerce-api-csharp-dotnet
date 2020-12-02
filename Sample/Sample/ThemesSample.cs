using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using Themes.Api;
using Themes.Client;
using Themes.Model;

namespace Sample
{
    class ThemesSample
    {
        private ThemesApi themesApi;

        public ThemesSample(JObject authConfig)
        {
            Configuration config = Configuration.Default;
            config.ApiKey.Add("X-Auth-Token", (string)authConfig["accessToken"]);
            config.BasePath = config.BasePath.Replace("{$$.env.store_hash}", (string)authConfig["storeId"]);

            this.themesApi = new ThemesApi(config);
        }

        public void getStoreThemes()
        {
            try
            {
                // Get Themes
                ThemesCollectionResponse themes = this.themesApi.GetStoreThemes("application/json", "application/json");
                foreach (var item in themes.Data)
                {
                    Debug.WriteLine(item);
                }
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThemesApi.GetStoreThemes: " + e.ToString());
            }
        }

    }
}
