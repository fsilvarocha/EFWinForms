using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFWinForms.DesckTop.Models
{
    public class Produto : Entity
    {
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [MaxLength(100)]
        public string Nome { get; set; }
        public Categoria Categoria { get; set; }
        public IEnumerable<Categoria> Categorias { get; set; }
    }
}
