using PoeShopWatcher.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PoeShopWatcher
{
    internal static class Watcher
    {
        internal static void Run()
        {
            string URL = "http://api.pathofexile.com/public-stash-tabs";
            Dictionary<string, Stash> stashes = new Dictionary<string, Stash>();


            string apiResponse = RetrieveStashes(URL);
            var data = Response.FromJson(apiResponse);
            stashes = UpdateStashes(stashes, data.Stashes);

            URL += @"/?id={0}";

            while (true)
            {
                Thread.Sleep(1000);
                apiResponse = RetrieveStashes(String.Format(URL, data.NextChangeId));
                data = Response.FromJson(apiResponse);
                stashes = UpdateStashes(stashes, data.Stashes);
                DB.Insert(stashes);
            }
        }

        private static string RetrieveStashes(string url)
        {
            string responseFromServer = "";
            Stream dataStream;

            WebRequest request = WebRequest.Create(url);
            using (WebResponse response = request.GetResponse())
            {
                if (((HttpWebResponse)response).StatusCode == HttpStatusCode.OK)
                {
                    dataStream = response.GetResponseStream();
                    using (StreamReader reader = new StreamReader(dataStream))
                    {
                        responseFromServer = reader.ReadToEnd();
                    }
                }
            }

            return responseFromServer;
        }

        private static Dictionary<string, Stash> UpdateStashes(Dictionary<string, Stash> dict, Stash[] stashes)
        {
            foreach(Stash stash in stashes)
            {
                dict.Remove(stash.Id);
                dict.Add(stash.Id, stash);
            }

            return dict;
        }
    }
}
