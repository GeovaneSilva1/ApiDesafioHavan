﻿using System.ComponentModel.DataAnnotations.Schema;

namespace LojaVirtual.ProductApi.Models
{
    [Table("tabelaprecos")]
    public class TabelaPreco
    {
        public int Id { get; set; }
        public string? Descricao { get; set; } 
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public ICollection<Produto>? Produtos { get; set; }
    }
}
