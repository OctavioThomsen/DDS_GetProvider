using System.ComponentModel.DataAnnotations;

namespace backEnd.Models
{
    public class Producto
    {
        [Key]
        public int ID_PRODUCTO { get; set; }

        [Required]
        public string NOMBRE { get; set; }

        [Required]
        public string TIPO_DISPONIBILIDAD { get; set; }

        [Required]
        public int ID_MARCA { get; set; }

        [Required]
        public int ID_SUBCATEGORIA { get; set; }
    }
}
