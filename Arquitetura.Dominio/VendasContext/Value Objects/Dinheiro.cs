namespace Arquitetura.Dominio.VendasContext.Value_Objects
{
    public class Dinheiro
    {
        public string Moeda { get; private set; }
        public decimal Valor { get; private set; }

        public Dinheiro(string moeda, decimal valor)
        {
            // validar parametros...
            Moeda = moeda;
            Valor = valor;
        }

        public Dinheiro Somar(Dinheiro dinheiro)
        {
            return new Dinheiro(dinheiro.Moeda, Valor + dinheiro.Valor);
        }
    }
}
