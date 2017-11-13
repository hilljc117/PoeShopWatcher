using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using PoeShopWatcher.Models;

namespace PoeShopWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string responseFromServer = "";
            Stream dataStream;


            WebRequest request = WebRequest.Create("http://api.pathofexile.com/public-stash-tabs");

            using (WebResponse response = request.GetResponse())
            {
                if (((HttpWebResponse)response).StatusDescription == "OK")
                {
                    dataStream = response.GetResponseStream();
                    using (StreamReader reader = new StreamReader(dataStream))
                    {
                        responseFromServer = reader.ReadToEnd();
                    }
                }
            }

            var data = Response.FromJson(responseFromServer);

            Console.ReadLine();
        }
    }
}
