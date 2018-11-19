using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FrotaSisWeb.Models.SisModels
{
    public partial class SisMarcas
    {
        public decimal IdMarca { get; set; }
        public string DescMarca { get; set; }

        [Display(Name = "Cadastro de Materiais")]
        public bool Usacadmat { get; set; }
        [Display(Name = "Cadastro de Veículos")]
        public bool Usacadveic { get; set; }
        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }
    }
}
