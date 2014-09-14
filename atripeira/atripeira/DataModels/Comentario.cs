using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atripeira.DataModels
{
    public class Comentario
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "nome")]
        public string nome { get; set; }

        [JsonProperty(PropertyName = "comentario")]
        public string comentario { get; set; }

        [JsonProperty(PropertyName = "idRest")]
        public string idRest { get; set; }

        [JsonProperty(PropertyName = "pais")]
        public string pais { get; set; }
    }
}
