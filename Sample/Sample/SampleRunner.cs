using Newtonsoft.Json.Linq;
using System.IO;

namespace Sample
{
    class SampleRunner
    {
        static void Main(string[] args)
        {
            // read in json file
            JObject authConfig = JObject.Parse(File.ReadAllText(@"..\..\..\..\gulpfile.config.json"));

            StoreInfoSample storeInfoSample = new StoreInfoSample(authConfig);
            storeInfoSample.getStoreInfo();

            ThemesSample themesCheck = new ThemesSample(authConfig);
            themesCheck.getStoreThemes();
        }
    }
}


