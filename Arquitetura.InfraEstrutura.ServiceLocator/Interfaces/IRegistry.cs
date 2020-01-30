namespace Arquitetura.InfraEstrutura.ServiceLocator.Interfaces
{
    public interface IRegistry
    {
        T Resolve<T>();
    }
}
