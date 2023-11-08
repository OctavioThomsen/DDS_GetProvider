using System.ComponentModel.DataAnnotations;

namespace backEnd.Models
{
    public class Subcategoria
    {
        [Key]
        public int ID_SUBCATEGORIA { get; set; }

        [Required]
        public string NOMBRE { get; set; }
    }
}
