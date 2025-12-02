using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppSistemaVendaBCC.Entitites
{
    [Table("tbItemVenda")]
    public class ItemVenda
    {
     
        [Column("produtoId")]
        public int ProdutoId { get; set; }

      
        public Produto Produto { get; set; }

        [Column("pedidoId")]
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        [Column("quantidadeProduto")]
        public int QuantidadeProduto {  get; set; }

        [Column("precoUnitario")]

        public decimal PrecoUnitario {  get; set; }

    }
}
