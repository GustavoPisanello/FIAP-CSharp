using System.ComponentModel.DataAnnotations;

namespace Fiap.Banco.API.Models
{
    public class Funcionario
    {
        [Key]
        public int funcId { get; set; }
    }
}
