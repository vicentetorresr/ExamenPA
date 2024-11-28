using System;
using System.Collections.Generic;

namespace Examen_Torres_Reyes.Models
{
    public partial class TipoProducto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Estado { get; set; }
    }
}
