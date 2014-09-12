using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atripeira.DataModels
{
    public class carta
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "nome")]
        public string nome { get; set; }

        [JsonProperty(PropertyName = "descricao")]
        public string descricao { get; set; }

        [JsonProperty(PropertyName = "preco")]
        public string preco { get; set; }

        [JsonProperty(PropertyName = "idRest")]
        public int idRest { get; set; }
    }
}
