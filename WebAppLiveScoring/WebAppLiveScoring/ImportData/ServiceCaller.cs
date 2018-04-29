using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebAppLiveScoring.ImportData
{
    public static class ServiceCaller
    {
       public static string GetJsonDataFromUrl(string Url)
        {
            string JsonData = string.Empty;
          
            try
            {
                WebRequest request = WebRequest.Create(Url);
                WebResponse ws = request.GetResponse();
                using (StreamReader responseStream = new StreamReader(ws.GetResponseStream()))
                {
                    JsonData = responseStream.ReadToEnd();
                    responseStream.Close();
                }
                
            } catch(Exception ex)
            {

            }

            return JsonData;
        }
    }
}
