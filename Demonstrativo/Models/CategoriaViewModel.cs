﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demonstrativo.Models
{
    public class CategoriaViewModel
    {
        public string Descricao { get; set; }
        public List<ContaViewModel> Contas { get; set; }
    }
}
