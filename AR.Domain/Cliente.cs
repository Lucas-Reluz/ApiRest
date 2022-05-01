using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AR.Domain
{
    #region Tabela de Clientes
    [Table ("tb_clientes")]
    public class Cliente
    {
        [Key]
        public Guid ID { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(70, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]
        public string Name { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
    }
}
#endregion