using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppSistemaVendaBCC.Entitites
{
    [Table("tbCliente")]
    public class Cliente
    {

        [Key]
        [Column("IdCliente")]
        
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("cpfCnpj")]
        public string CpfCnpj { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("telefone")]
        public string Telefone { get; set; }

        [Column("endereco")]
        public string Endereco { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
