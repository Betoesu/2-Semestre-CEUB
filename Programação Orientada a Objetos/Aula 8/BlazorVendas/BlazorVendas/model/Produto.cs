namespace BlazorVendas.model
{
    public class Produto
    {
        public Int32 Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Int32 QuantidadeEstoque { get; set; }
        public string UnidadeMedida { get; set; }
        public double PrecoUnitario { get; set; }
        public string ImgProduto { get; set; }


        public void Adicionar()
        {
            //Adiciona no banco de dados
        }

        public void Excluir(Int32 id)
        {
            //Exclui do banco de dados 
        }

        public void Alterar(Int32 id)
        {
            //Altera algo no banco de dados
        }

        public string PesquisarProdutoPorId(Int32 id)
        {
            string resultado = "";
            return resultado;
        }

        public string ListarTodosProdutos()
        {
            string resultado = "";
            return resultado;
        }

      
    }
}
