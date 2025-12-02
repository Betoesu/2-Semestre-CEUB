using BlazorAppSistemaVendaBCC.Data.Context;
using BlazorAppSistemaVendaBCC.Entitites;
using BlazorAppSistemaVendaBCC.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppSistemaVendaBCC.Service.Inplementation
{
    public class ProdutoService : IProdutoService
    {
        private readonly SQLServerContext _context;

        public ProdutoService(SQLServerContext context)
        {
            _context = context;
        }
        public async Task AdicionarAsync(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
        }

        public async Task AlterarAsync(Produto produto)
        {
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();
        }

        public async Task ExcluirAsync(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Produto>> ListarTodos()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> PesquisarPorId(int id)
        {
            return await _context.Produtos.FindAsync(id);
        }
    }
}                   
