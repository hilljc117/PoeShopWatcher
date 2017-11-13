using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PoeShopWatcher.Models
{
    class AdditionalProperties
    {
        [JsonProperty("displayMode")]
        public long DisplayMode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("progress")]
        public double? Progress { get; set; }

        [JsonProperty("type")]
        public long? Type { get; set; }

        [JsonProperty("values")]
        public Values[] Values { get; set; }
    }
}
