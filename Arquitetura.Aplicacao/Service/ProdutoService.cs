using Arquitetura.Dominio.VendasContext.Entidades;
using Arquitetura.Dominio.VendasContext.Interfaces.Repositorios;
using Arquitetura.Dominio.VendasContext.Interfaces.Services;
using System.Collections.Generic;

namespace Arquitetura.Aplicacao.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepositorio _produtoRepositorio;



        public ProdutoService(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }
        public void Adicionar(Produto produto)
        {
            _produtoRepositorio.Adicionar(produto);
        }

        public void Atualizar(Produto produto)
        {
            _produtoRepositorio.Atualizar(produto);
        }

        public Produto BuscarPor(int idProduto)
        {
            return _produtoRepositorio.BuscarPor(idProduto);
        }

        public void Excluir(Produto produto)
        {
            _produtoRepositorio.Excluir(produto);
        }

        public IEnumerable<Produto> ListarTodos()
        {
            return _produtoRepositorio.ListarTodos();
        }
    }
}
