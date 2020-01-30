using Arquitetura.Dominio.VendasContext.Interfaces.Repositorios;
using Arquitetura.InfraEstrutura.Data.Repositorios.VendasContext;
using System.Collections.Generic;

namespace Arquitetura.InfraEstrutura.ServiceLocator
{
    public class Registry
    {
        private readonly Dictionary<object, object> services;

        public Registry()
        {
            this.services = new Dictionary<object, object>();

            //this.services.Add(typeof(IProdutoRepositorio), new ProdutoRepositorio());
            //this.services.Add(typeof(ICategoriaRepositorio), new CategoriaRepositorio());

        }

        public T Resolve<T>()
        {
            return (T)this.services[typeof(T)];
        }
    }
}
