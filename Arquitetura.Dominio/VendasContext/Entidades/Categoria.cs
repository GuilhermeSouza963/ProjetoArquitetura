using System;
using System.Collections.Generic;
using System.Text;

namespace Arquitetura.Dominio.VendasContext.Entidades
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public IList<Produto> Produtos { get; set; }
    }
}
