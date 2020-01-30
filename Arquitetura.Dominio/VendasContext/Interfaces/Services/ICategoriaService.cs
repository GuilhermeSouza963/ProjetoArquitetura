using Arquitetura.Dominio.VendasContext.Entidades;
using System.Collections.Generic;

namespace Arquitetura.Dominio.VendasContext.Interfaces.Services
{
    public interface ICategoriaService
    {
        void Adicionar(Categoria categoria);
        void Excluir(Categoria categoria);
        void Atualizar(Categoria categoria);
        IEnumerable<Categoria> ListarTodos();
        Categoria BuscarPor(int idCategoria);
    }
}
