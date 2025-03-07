using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class marcas
    {
        [Key]
        [DisplayName("Id de Marca")]
        public int id_marcas { get; set; }

        [Required(ErrorMessage = "El nombre de la marca NO es opcional")]
        [DisplayName("Nombre de la Marca")]
        public string? nombre_marca { get; set; }
        [DisplayName("Estado")]
        [StringLength(1, ErrorMessage ="La cantidad maxima de caracteres valida es {1}")]
        public string? estados { get; set; }
     
    }
}
