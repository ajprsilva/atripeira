using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atripeira.DataModels
{
    class Cosinha
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "idRest")]
        public string idRest { get; set; }

        [JsonProperty(PropertyName = "data")]
        public string data { get; set; }

    }
}
