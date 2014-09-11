using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atripeira.DataModels
{
    public class restaurante
    {

        public string Id { get; set; }

        [JsonProperty(PropertyName = "nome")]
        public string nome { get; set; }
        //public string morada { get; set; }

        //public Image foto { get; set; }
        [JsonProperty(PropertyName = "morada")]
        public string morada { get; set; }

        [JsonProperty(PropertyName = "Pontuacao")]
        public string Pontuacao { get; set; }

        [JsonProperty(PropertyName = "totalVotos")]
        public int totalVotos { get; set; }
    }
}
