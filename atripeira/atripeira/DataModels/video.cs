using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atripeira.DataModels
{
    public class video
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "nome")]
        public string nome { get; set; }

        [JsonProperty(PropertyName = "idVideo")]
        public string idVideo { get; set; }
    }
}
