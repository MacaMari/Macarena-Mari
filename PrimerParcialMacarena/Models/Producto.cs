using System.ComponentModel.DataAnnotations;

namespace PrimerParcialMacarena.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(20, ErrorMessage = "El campo no puede tener más de 20 caracteres")]
        public string Nombre { get; set; } = string.Empty;


        [Required(ErrorMessage = "El campo es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
        public int Precio { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]

        public string Marca { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo es obligatorio")]
        public bool Favorito { get; set; }

        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
