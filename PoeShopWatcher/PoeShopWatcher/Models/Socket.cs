using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PoeShopWatcher.Models
{
    public class Socket
    {
        [JsonProperty("attr")]
        public string Attr { get; set; }

        [JsonProperty("group")]
        public long Group { get; set; }
    }
}
