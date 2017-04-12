using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Table("Planeta")]
    public class Planeta
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatorio")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Obrigatorio nome maior que 1 e menor que 50 caracteres")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool PossuiOxigenio { get; set; }
    }
}
