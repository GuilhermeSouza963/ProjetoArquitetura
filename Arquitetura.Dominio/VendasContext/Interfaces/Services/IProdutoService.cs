using Arquitetura.Dominio.VendasContext.Entidades;
using System.Collections.Generic;

namespace Arquitetura.Dominio.VendasContext.Interfaces.Services
{
    public interface IProdutoService
    {
        void Adicionar(Produto produto);
        void Excluir(Produto produto);
        void Atualizar(Produto produto);
        IEnumerable<Produto> ListarTodos();
        Produto BuscarPor(int idProduto);
    }
}
