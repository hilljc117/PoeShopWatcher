using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PoeShopWatcher.Models
{
    public class Stash
    {
        [JsonProperty("accountName")]
        public object AccountName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }

        [JsonProperty("lastCharacterName")]
        public object LastCharacterName { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("stash")]
        public object Name { get; set; }

        [JsonProperty("stashType")]
        public string StashType { get; set; }
    }
}
