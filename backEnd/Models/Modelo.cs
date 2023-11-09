using System.ComponentModel.DataAnnotations;

namespace backEnd.Models
{
    public class Modelo
    {
        [Key]
        public int ID_MODELO { get; set; }

        [Required]
        public string NOMBRE { get; set; }
    }
}
