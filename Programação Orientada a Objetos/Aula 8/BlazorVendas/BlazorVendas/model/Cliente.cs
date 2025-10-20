namespace BlazorVendas.model
{
    public class Cliente
    {
        private Int32 id;
        private string nome;
        private string cpfCnpj;
        private string email;
        private string telefone;
        private string endereco;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string CpfCnpj { get => cpfCnpj; set => cpfCnpj = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }

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

        public string PesquisarPorId(Int32 id)
        {
            string resultado ="";
            return resultado;
        }

        public string ListarTodos()
        {
            string resultado = "";
            return resultado;
        }

        public string PesquisarPorNome(string nome)
        {
            string resultado = "";
            return resultado;
        }
    }
}
