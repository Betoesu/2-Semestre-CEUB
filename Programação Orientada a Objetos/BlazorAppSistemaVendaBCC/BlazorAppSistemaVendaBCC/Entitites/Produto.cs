using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppSistemaVendaBCC.Entitites
{
    [Table("tbProduto")]
    public class Produto
    {
        
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("quantidadeEstoque")]
        public int QuantidadeEstoque { get; set; }

        [Column("unidadeMedida")]
        public string UnidadeMedida { get; set; }

        [Column("precoUnitario")]
        public decimal PrecoUnitario { get; set; }
        public string ImagemProduto { get; set; }

        public ICollection<ItemVenda> ItensVenda { get; set; }
    }
}
