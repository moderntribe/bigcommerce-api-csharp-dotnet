using Scripts.Client;
using Newtonsoft.Json.Linq;
using Scripts.Api;
using System.Diagnostics;
using System;
using Scripts.Model;

namespace Sample
{
    internal class ScriptsSample
    {
        private ScriptsApi scriptsApi;

        public ScriptsSample(JObject authConfig)
        {
            Configuration config = Configuration.Default;
            config.ApiKey.Add("X-Auth-Token", (string)authConfig["accessToken"]);
            config.BasePath = config.BasePath.Replace("{$$.env.store_hash}", (string)authConfig["storeId"]);

            this.scriptsApi = new ScriptsApi(config);
        }

        public void getSubscribers()
        {
            try
            {
                ScriptsResponse scriptsResponse = this.scriptsApi.GetScripts("application/json", "application/json");
                Debug.WriteLine(scriptsResponse);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscribersApi.GetSubscribers: " + e.ToString());
            }
        }

    }
}