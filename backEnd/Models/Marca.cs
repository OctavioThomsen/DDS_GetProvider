using System.ComponentModel.DataAnnotations;

namespace backEnd.Models
{
    public class Marca
    {
        [Key]
        public int ID_MARCA { get; set; }

        [Required]
        public string NOMBRE { get; set; }
    }
}
