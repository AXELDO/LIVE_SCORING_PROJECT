using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebAppLiveScoring.Helpers
{
    public static class ConvertData
    {
        public static List<T> ConvertJsonDataToObject<T>(string JsonData)
        {
            return JsonConvert.DeserializeObject<List<T>>(JsonData) ;
        }
    }
}
