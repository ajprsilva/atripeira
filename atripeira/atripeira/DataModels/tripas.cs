using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atripeira.DataModels
{
    public class tripas
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "historia")]
        public string historia { get; set; }

        [JsonProperty(PropertyName = "ingredientes")]
        public string ingredientes { get; set; }

        [JsonProperty(PropertyName = "receita")]
        public string receita { get; set; }
    }
}
