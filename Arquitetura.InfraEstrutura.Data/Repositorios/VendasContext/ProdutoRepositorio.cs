using Arquitetura.Dominio.VendasContext.Entidades;
using Arquitetura.Dominio.VendasContext.Interfaces.Repositorios;
using Arquitetura.InfraEstrutura.Data.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Arquitetura.InfraEstrutura.Data.Repositorios.VendasContext
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly ArquiteturaContext _context;

        public ProdutoRepositorio(ArquiteturaContext context)
        {
            _context = context;
        }
        public void Adicionar(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Atualizar(Produto produto)
        {
            _context.Produtos.Attach(produto);
            _context.Entry(produto).State = EntityState.Modified;
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }

        public Produto BuscarPor(int idProduto)
        {
            return _context.Produtos.FirstOrDefault(x => x.ProdutoId == idProduto);
        }

        public void Excluir(Produto produto)
        {
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }

        public IEnumerable<Produto> ListarTodos()
        {
            return _context.Produtos.AsQueryable().ToList();
        }
    }
}
