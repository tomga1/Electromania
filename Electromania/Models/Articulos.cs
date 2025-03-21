using System.ComponentModel.DataAnnotations;

namespace Electromania.Models
{
    public class Articulos
    {
        [Key]
        public int Id { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public string FichaTecnica { get; set; } = string.Empty;
        public string UrlImagen { get; set; } = string.Empty;
        public bool Estado { get; set; } = true;
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
