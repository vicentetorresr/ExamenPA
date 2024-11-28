﻿using System;
using System.Collections.Generic;

namespace Examen_Torres_Reyes.Models
{
    public partial class Ubicacion
    {
        public Ubicacion()
        {
            Proveedors = new HashSet<Proveedor>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Proveedor> Proveedors { get; set; }
    }
}
