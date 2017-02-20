using LeagueDataAnalyzer2.ExternalDataProvider.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.ExternalDataProvider
{
    class ApiConnector
    {
        public static string GetDataFromUrl(string url)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    Console.WriteLine(url);
                    return webClient.DownloadString(url);
                }
            }
            catch(WebException we)
            {
                throw new ResourceNotFoundException("Api Connector: "+url,we);
            }
            catch(Exception e)
            {
                throw new ExternalApiException("Unknown Exception", e);
            }
        }
    }
}
