using Arquitetura.Dominio.VendasContext.Entidades;
using Arquitetura.Dominio.VendasContext.Interfaces.Repositorios;
using Arquitetura.Dominio.VendasContext.Interfaces.Services;
using System.Collections.Generic;

namespace Arquitetura.Aplicacao.Service
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public CategoriaService(ICategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }
        public void Adicionar(Categoria categoria)
        {
            _categoriaRepositorio.Adicionar(categoria);
        }

        public void Atualizar(Categoria categoria)
        {
            _categoriaRepositorio.Atualizar(categoria);
        }

        public Categoria BuscarPor(int idCategoria)
        {
            return _categoriaRepositorio.BuscarPor(idCategoria);
        }

        public void Excluir(Categoria categoria)
        {
            _categoriaRepositorio.Excluir(categoria);
        }

        public IEnumerable<Categoria> ListarTodos()
        {
            return _categoriaRepositorio.ListarTodos();
        }
    }
}
