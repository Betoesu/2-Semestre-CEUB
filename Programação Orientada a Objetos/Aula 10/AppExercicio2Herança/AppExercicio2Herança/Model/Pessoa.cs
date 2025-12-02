using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicio2Herança.Model
{
    public class Pessoa
    {
        private string cpf;
        private string telefone;
        private DateTime dataNascimento;
        private string endereco;
        private string nome;

        public string Cpf { get => cpf; set => cpf = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Nome { get => nome; set => nome = value; }
    }


}
