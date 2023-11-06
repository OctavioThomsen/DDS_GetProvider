using System.ComponentModel.DataAnnotations;

namespace backEnd.Models
{
    public class Categoria
    {
        [Key]
        public int ID_CATEGORIA { get; set; }

        [Required]
        public string NOMBRE { get; set; }
    }
}
