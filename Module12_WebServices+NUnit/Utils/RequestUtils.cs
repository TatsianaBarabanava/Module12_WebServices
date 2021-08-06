using System;
using System.Configuration;
using System.IO;
using System.Net;

namespace Module12_API.Utils
{
    public static class RequestUtils
    {
        public static string url = ConfigurationManager.AppSettings.Get("StartUrl");
        public static string userEndpoint = ConfigurationManager.AppSettings.Get("UsersEndpoint");
        public static string getRequest = "GET";

        public static string MakeGETRequest(string endpoint, HttpStatusCode expectedCode)
        {
            HttpWebResponse response = GetRequestResponse(endpoint, getRequest);
            string responseBody = String.Empty;

            if (response.StatusCode == expectedCode)
            {
                using (Stream s = response.GetResponseStream())
                {
                    using (StreamReader r = new StreamReader(s))
                    {
                        responseBody = r.ReadToEnd();
                    }
                }
                return responseBody;
            }
            else throw new Exception("Unexpected Code");
        }

        public static HttpWebResponse GetRequestResponse(string endpoint, string method)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url + endpoint);
            request.Method = method;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            return response;
        }
    }
}
