using Arquitetura.Aplicacao.Service;
using Arquitetura.Dominio.VendasContext.Interfaces.Repositorios;
using Arquitetura.Dominio.VendasContext.Interfaces.Services;
using Arquitetura.InfraEstrutura.Data.Repositorios.VendasContext;
using Arquitetura.InfraEstrutura.Data.Transacao;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;
using SimpleInjector.Integration.AspNetCore.Mvc;
using SimpleInjector.Lifestyles;

namespace Arquitetura.InfraEstrutura.Hosting
{
    public class InjecaoDependenciaConfig
    {
        private static Container _container;
        private static Lifestyle _lifestyle;
        public static Container GetContainer()
        {
            return _container;
        }
        public static Container CreateInstance(Lifestyle lifestyle)
        {
            _lifestyle = lifestyle;
            _container = new Container();
            return _container;
        }

        public static void Config()
        {
            //Repositórios
            _container.Register(typeof(IProdutoRepositorio), typeof(ProdutoRepositorio), _lifestyle);
            _container.Register(typeof(ICategoriaRepositorio), typeof(CategoriaRepositorio), _lifestyle);

            //Services
            _container.Register(typeof(ICategoriaService), typeof(CategoriaService), _lifestyle);
            _container.Register(typeof(IProdutoService), typeof(ProdutoService), _lifestyle);

            _container.Register(typeof(IUnitOfWork), typeof(UnitOfWork), _lifestyle);
        }

        public static void IntegrateSimpleInjector(IServiceCollection services)
        {
            _container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IControllerActivator>(new SimpleInjectorControllerActivator(_container));
            services.AddSingleton<IViewComponentActivator>(new SimpleInjectorViewComponentActivator(_container));

            services.EnableSimpleInjectorCrossWiring(_container);
            services.UseSimpleInjectorAspNetRequestScoping(_container);
        }
    }
}
