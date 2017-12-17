using Newtonsoft.Json;

namespace ClienteWikidata.Models
{
    public class WikidataEntity
    {
        [JsonIgnore]
        public string Head { get; set; }

        public WikidataResults Results { get; set; }
    }
}
