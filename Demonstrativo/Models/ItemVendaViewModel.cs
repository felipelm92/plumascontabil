﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demonstrativo.Models
{
    public class ItemVendaViewModel
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public double Quantidade { get; set; }
        public decimal Preco { get; set; }
        public ProdutoViewModel Produto { get; set; }
    }
}