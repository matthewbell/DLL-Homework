using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web;
using System.Xml;


namespace MyDynamicLibrary
{
    public class weatherRESTquery
    {
        public static string Get_URI(string lat, string lon, string dataChoice)
        {

            string startTime = System.Xml.XmlConvert.ToString(DateTime.Now);
            string endTime = System.Xml.XmlConvert.ToString(DateTime.Now.AddDays(1));

            string uri = "http://graphical.weather.gov/xml/sample_products/browser_interface/ndfdXMLclient.php?whichClient=NDFDgen&lat=" + lat + "&lon=" + lon + "&product=time-series&begin=" + startTime + "&end=" + endTime + "&Unit=e&" + dataChoice;
            //Console.WriteLine(uri);
            //System.Threading.Thread.Sleep(20000);


            string responseString = "";
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uri);

                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                responseString = reader.ReadToEnd();

                reader.Close();
                responseStream.Close();
                response.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
                System.Threading.Thread.Sleep(5000);
            }
            return responseString;

        }

        public static String formatXML(String xmlString)
        {
            StringBuilder output = new StringBuilder();
            int avgtemp = 0;
            int i = 0;
            using (XmlReader reader = XmlReader.Create(new StringReader(xmlString)))
            {
                if (reader.ReadToFollowing("name"))
                    output.AppendLine("Average " + reader.ReadElementContentAsString());
                // get average temp over all times
                while (reader.ReadToFollowing("value"))
                {
                    avgtemp += reader.ReadElementContentAsInt();
                    i++;
                }
                if (avgtemp > 0) { avgtemp = avgtemp / i; }
                output.AppendLine(avgtemp.ToString() + " degrees Fahrenheit");
            }
            return output.ToString();
        }
    }
}



