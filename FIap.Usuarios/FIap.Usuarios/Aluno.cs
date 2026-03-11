using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace FIap.Usuarios
{
    public class Aluno
    {
        [JsonPropertyName("id")]
        public string RM { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("CEP")]
        public string CEP { get; set; }

        [JsonPropertyName("street")]
        public string Logradouro { get; set; }

        [JsonPropertyName("neighbor")]
        public string Bairro { get; set; }

        [JsonPropertyName("state")]
        public string Estado { get; set; }

    }
}
