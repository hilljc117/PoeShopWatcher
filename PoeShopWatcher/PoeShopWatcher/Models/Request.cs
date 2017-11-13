using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PoeShopWatcher.Models
{
    public class Request
    {
        [JsonProperty("next_change_id")]
        public string NextChangeId { get; set; }

        [JsonProperty("stashes")]
        public Stash[] Stashes { get; set; }

        public static Request FromJson(string json) => JsonConvert.DeserializeObject<Request>(json, Converter.Settings);
    }
}
