using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PoeShopWatcher.Models
{
    public class Item
    {
        [JsonProperty("additionalProperties")]
        public AdditionalProperties[] AdditionalProperties { get; set; }

        [JsonProperty("corrupted")]
        public bool Corrupted { get; set; }

        [JsonProperty("descrText")]
        public string DescrText { get; set; }

        [JsonProperty("explicitMods")]
        public string[] ExplicitMods { get; set; }

        [JsonProperty("flavourText")]
        public string[] FlavourText { get; set; }

        [JsonProperty("frameType")]
        public long FrameType { get; set; }

        [JsonProperty("h")]
        public long H { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("identified")]
        public bool Identified { get; set; }

        [JsonProperty("ilvl")]
        public long Ilvl { get; set; }

        [JsonProperty("implicitMods")]
        public string[] ImplicitMods { get; set; }

        [JsonProperty("inventoryId")]
        public string InventoryId { get; set; }

        [JsonProperty("league")]
        public string League { get; set; }

        [JsonProperty("lockedToCharacter")]
        public bool LockedToCharacter { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nextLevelRequirements")]
        public AdditionalProperties[] NextLevelRequirements { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("properties")]
        public AdditionalProperties[] Properties { get; set; }

        [JsonProperty("requirements")]
        public AdditionalProperties[] Requirements { get; set; }

        [JsonProperty("secDescrText")]
        public string SecDescrText { get; set; }

        [JsonProperty("socketedItems")]
        public object[] SocketedItems { get; set; }

        [JsonProperty("sockets")]
        public Socket[] Sockets { get; set; }

        [JsonProperty("support")]
        public bool? Support { get; set; }

        [JsonProperty("typeLine")]
        public string TypeLine { get; set; }

        [JsonProperty("utilityMods")]
        public string[] UtilityMods { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("w")]
        public long W { get; set; }

        [JsonProperty("x")]
        public long X { get; set; }

        [JsonProperty("y")]
        public long Y { get; set; }
    }
}
