using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppSistemaVendaBCC.Entitites
{
    [Table("tbFuncionario")]
    public class Funcionario
    {
        [Key]
        [Column("IdFuncionario")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("cpf")]
        public string Cpf { get;set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("cargo")]
        public string Cargo { get; set; }

        [Column("salario")]
        public decimal Salario { get; set; }

        [Column("dataAdmissao")]

        public DateTime DataAdmissao { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
