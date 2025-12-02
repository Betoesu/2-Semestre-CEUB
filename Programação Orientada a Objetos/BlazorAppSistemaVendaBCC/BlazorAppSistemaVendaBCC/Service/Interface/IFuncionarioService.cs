using BlazorAppSistemaVendaBCC.Entitites;

namespace BlazorAppSistemaVendaBCC.Service.Interface
{
    public interface IFuncionarioService
    {
        Task AdicionarAsync(Funcionario funcionario);

        Task AlterarAsync(Funcionario funcionario);

        Task ExcluirAsync(int id);

        Task<IEnumerable<Funcionario>> ListarTodos();
        Task<Funcionario> PesquisarPorId(int id);
    }
}   


