using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cine.Recompensas
{
    public class ModelRecompensas
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public int PuntosNecesarios { get; set; }

        public int Stock { get; set; }

        public string Tipo { get; set; } = string.Empty;

        public string Imagen { get; set; } = "🎬";

        public bool Disponible { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int CategoriaId { get; set; }
    }
}
