using Arquitetura.Dominio.VendasContext.Entidades;
using Arquitetura.Dominio.VendasContext.Interfaces.Repositorios;
using Arquitetura.InfraEstrutura.Data.EntityFramework.Context;
using Arquitetura.InfraEstrutura.Data.Transacao;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Arquitetura.InfraEstrutura.Data.Repositorios.VendasContext
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly ArquiteturaContext _context;
        private readonly IUnitOfWork _unitOfWork;


        public CategoriaRepositorio(ArquiteturaContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }
        public void Adicionar(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            _unitOfWork.Commit();
        }

        public void Atualizar(Categoria categoria)
        {
            _context.Categorias.Attach(categoria);
            _context.Entry(categoria).State = EntityState.Modified;
            _context.Categorias.Update(categoria);
            _unitOfWork.Commit();
        }

        public Categoria BuscarPor(int idCategoria)
        {
            return _context.Categorias.FirstOrDefault(x => x.CategoriaId == idCategoria);
        }

        public void Excluir(Categoria categoria)
        {
            _context.Categorias.Remove(categoria);
            _unitOfWork.Commit();
        }

        public IEnumerable<Categoria> ListarTodos()
        {
            return _context.Categorias.AsQueryable().ToList();
        }
    }
}
