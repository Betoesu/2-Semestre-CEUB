using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BlazorAppSistemaVendaBCC.Entitites
{
    [Table("tbPedido")]
    public class Pedido
    {
        
        public int Id { get; set; }

        [Column("dataPedido")]
        public DateTime DataPedido { get; set; }

        [Column("funcionarioId")]
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }

        [Column("clienteId")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [Column("valor")]
        public decimal ValorTotal { get; set; }

        public ICollection<ItemVenda> ItensVenda { get; set; }
    }
}
