using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WeatherServicePrgm
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string ShowWeather(string City)
        {
            string temperature = "";
            switch (City)
            {
                case "Nagpur":
                    temperature = "30 degree";
                    break;
                case "Chandrapur":
                    temperature = "32 degree";
                    break;
                case "Jammu":
                    temperature = "15 degree";
                    break;
                case "Agra":
                    temperature = "34 degree";
                    break;

                default:
                    temperature = "28 degree";
                    break;

            }
            return temperature;

        }


    }
}
