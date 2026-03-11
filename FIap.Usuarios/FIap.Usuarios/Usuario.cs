using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace FIap.Usuarios
{
    public class Usuario
    {
        [JsonPropertyName("name")]
        public string Nome {  get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("pswd")]
        public string Senha { get; set; }
    }
}
