namespace BlazorVendas.model
{
    public class ItemVenda
    {
        public Int32 ProdutoId { get; set; }
        public Int32 VendaId { get; set; }
        public Int32 QuantidadeProduto { get; set; }
        public Double PrecoUnitario { get; set; }

        public void InserirItem()
        {
            //Inserir
        }

        public void ExcluirItem()
        {
            //Exclui
        }
    }
}
