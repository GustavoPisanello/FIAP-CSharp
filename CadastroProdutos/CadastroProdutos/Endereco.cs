using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CadastroProdutos
{
    public class Endereco
    {
        [JsonPropertyName("cep")]
        public string Cep {  get; set; }

        [JsonPropertyName("localidade")]
        public string Cidade { get; set; }

        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [JsonPropertyName("uf")]
        public string Estado { get; set; }
    }
}
