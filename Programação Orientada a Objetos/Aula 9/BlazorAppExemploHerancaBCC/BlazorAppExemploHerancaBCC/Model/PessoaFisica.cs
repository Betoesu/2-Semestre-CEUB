namespace BlazorAppExemploHerancaBCC.Model
{
    public class PessoaFisica:Pessoa
    {
        private string cpf;
        private string rg;
        private DateTime dataNascimento;

        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
    }
}
