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
            string xml = "";
            
            try
            {
                using (var webClient = new WebClient())
                {
                    xml = webClient.DownloadString(url);
                }
            }
            catch(Exception e)
            {
                //add something to the log
                throw (e);
            }

            return xml;
        }
    }
}
