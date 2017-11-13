using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PoeShopWatcher.Models
{
    public class Values
    {
        public long? Long;
        public string String;

        public Values(JsonReader reader, JsonSerializer serializer)
        {
            Long = null;
            String = null;

            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    Long = serializer.Deserialize<long>(reader);
                    break;
                case JsonToken.String:
                case JsonToken.Date:
                    String = serializer.Deserialize<string>(reader);
                    break;
                default: throw new Exception("Cannot convert Values");
            }
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (Long != null)
            {
                serializer.Serialize(writer, Long);
                return;
            }
            if (String != null)
            {
                serializer.Serialize(writer, String);
                return;
            }
            throw new Exception("Union must not be null");
        }
    }
}
