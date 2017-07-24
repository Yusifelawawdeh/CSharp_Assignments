using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StatisticApp
{

    public class NewsSearch
    {
        [JsonProperty(PropertyName = "_type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "readLink")]
        public string ReadLink { get; set; }
        [JsonProperty(PropertyName = "totalEstimatedMatches")]
        public int TotalEstimatedMatches { get; set; }
        [JsonProperty(PropertyName="value")]
        public List<NewsSearch> NewsValues { get; set; }
    }

}
