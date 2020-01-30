using Arquitetura.Dominio.VendasContext.Entidades;
using NHibernate;
using NHibernate.Cfg;
using System;

namespace Arquitetura.InfraEstrutura.Data
{
    public class NHibernateConfig
    {
            #region Atributos
            private static readonly ISessionFactory fabricaDeSessao;
            private const String CodSessaoAtual = "nhibernate.current_session";
            #endregion
            static NHibernateConfig()
            {
                try
                {
                    ISessionFactory fabrica = new Configuration().Configure()
                    .AddAssembly("DATA").BuildSessionFactory();

                }
                catch (Exception)
                {

                    throw;
                }
            }
            #region Métodos de Controle
            public static ISession PegaSessaoEmUso()
            {
                ISession sessao = fabricaDeSessao.GetCurrentSession();

                if (sessao == null)
                {
                    sessao = fabricaDeSessao.OpenSession();
                }

                return sessao;
            }
            public static void FecharSessao()
            {
                ISession sessao = fabricaDeSessao.GetCurrentSession();

                if (sessao != null)
                {
                    sessao.Close();
                }
            }
            public static void FecharFabricaDeSessao()
            {
                if (fabricaDeSessao != null || !fabricaDeSessao.IsClosed)
                {
                    fabricaDeSessao.Close();
                }
            }

        #endregion
        public void Adicionar(Categoria categoria)
        {
            ISession sessao = NHibernateConfig.PegaSessaoEmUso();
            ITransaction transacao = sessao.BeginTransaction();

            sessao.Save(categoria);
            transacao.Commit();

            NHibernateConfig.FecharSessao();
        }
    }



}
