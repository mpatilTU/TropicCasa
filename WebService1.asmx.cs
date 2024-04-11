using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services;

namespace tropicasa
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public string GetTime()
        {
            return DateTime.Now.ToString();
        }

        [WebMethod]
        public string GetUser(string uemail)
        {
            DatabaseConnection db = new DatabaseConnection();

            return "User Not found";
        }

        [WebMethod]
        public string GetHomes()
        {
            string url = "https://cis-iis2.temple.edu/Spring2023/CIS3342_tuk54604/WebsAPITest/api/Homes"; //fixed

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    // Return the JSON data
                    return reader.ReadToEnd();
                }
            }
        }
    }
}