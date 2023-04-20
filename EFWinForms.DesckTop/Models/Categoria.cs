using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFWinForms.DesckTop.Models
{
    public class Categoria : Entity
    {
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [MaxLength(100)]
        public string Nome { get; set; }
    }
}
