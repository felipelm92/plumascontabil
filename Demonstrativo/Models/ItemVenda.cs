﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Demonstrativo.Models
{
    public class ItemVenda
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("VendaId")]
        public Venda Venda { get; set; }
        public int VendaId { get; set; }

        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }

        public double Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}