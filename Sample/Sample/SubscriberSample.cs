using Subscribers.Client;
using Newtonsoft.Json.Linq;
using Subscribers.Api;
using Subscribers.Model;
using System.Diagnostics;
using System;

namespace Sample
{
    internal class SubscriberSample
    {
        private SubscribersApi subscribersApi;

        public SubscriberSample(JObject authConfig)
        {
            Configuration config = Configuration.Default;
            config.ApiKey.Add("X-Auth-Token", (string)authConfig["accessToken"]);
            config.BasePath = config.BasePath.Replace("{$$.env.store_hash}", (string)authConfig["storeId"]);

            this.subscribersApi = new SubscribersApi(config);
        }

        public void getSubscribers()
        {
            try
            {
                SubscriberCollectionResponse response = this.subscribersApi.GetSubscribers();
                Debug.WriteLine(response);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscribersApi.GetSubscribers: " + e.ToString());
            }
        }

    }
}