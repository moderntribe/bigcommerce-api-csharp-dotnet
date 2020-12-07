using Widgets.Client;
using Newtonsoft.Json.Linq;
using Widgets.Api;
using Widgets.Model;
using System.Diagnostics;
using System;

namespace Sample
{
    internal class WidgetSample
    {
        private WidgetApi widgetApi;

        public WidgetSample(JObject authConfig)
        {
            Configuration config = Configuration.Default;
            config.ApiKey.Add("X-Auth-Token", (string)authConfig["accessToken"]);
            config.BasePath = config.BasePath.Replace("{$$.env.store_hash}", (string)authConfig["storeId"]);

            this.widgetApi = new WidgetApi(config);
        }

        public void getWidgets()
        {
            try
            {
                InlineResponse2001 response = this.widgetApi.GetWidgets();
                Debug.WriteLine(response);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetApi.GetWidgets: " + e.ToString());
            }
        }

    }
}