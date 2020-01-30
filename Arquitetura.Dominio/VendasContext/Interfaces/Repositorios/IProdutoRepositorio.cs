using Arquitetura.Dominio.VendasContext.Entidades;
using System.Collections.Generic;

namespace Arquitetura.Dominio.VendasContext.Interfaces.Repositorios
{
    public interface IProdutoRepositorio
    {
        void Adicionar(Produto produto);
        void Excluir(Produto categoria);
        void Atualizar(Produto categoria);
        IEnumerable<Produto> ListarTodos();
        Produto BuscarPor(int idProduto);
    }
}
