using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

public enum RequestType { GET, POST, DELETE, PUT }
namespace RestedExample
{
    class RestClient
    {
        public string endPoint = string.Empty;

        public RequestType requestType = RequestType.GET;

        public RestClient(string urlMessage)
        {
            endPoint = urlMessage;
        }

        public string Request()
        {

            string responseString = "Error";

            HttpWebRequest request;

            try
            {
                request = (HttpWebRequest)WebRequest.Create(endPoint);
            }
            catch (Exception)
            {
                return responseString;
            }

            request.Method = requestType.ToString();


            HttpWebResponse response;

            try
            {
                response = (HttpWebResponse)request.GetResponse();

            }
            catch (Exception e)
            {
                return e.ToString();

            }

            using (response)
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {

                }
                else
                {
                    //fail
                    System.Diagnostics.Debug.WriteLine(response.StatusCode.ToString());
                    return string.Empty;
                }

                //handle the response
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            responseString = reader.ReadToEnd();
                        }
                    }
                }

            }
            return responseString;
        }


    }
}
