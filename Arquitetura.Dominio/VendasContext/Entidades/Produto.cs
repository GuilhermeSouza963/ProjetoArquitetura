namespace Arquitetura.Dominio.VendasContext.Entidades
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        // Métodos
        public bool PodeVender()
        {
            return Quantidade > 0;
        }

        public void Vendeu()
        {
            if (PodeVender())
                Quantidade--;
        }

        public void Comprou(int qtde)
        {
            Quantidade += qtde;
        }
    }
}
