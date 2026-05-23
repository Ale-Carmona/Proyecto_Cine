using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cine.Logros
{
    public class ModelLogro
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public int Puntos { get; set; }
        public string Requisitos { get; set; } = string.Empty;
        public bool Activo { get; set; }
        public int CategoriaId { get; set; }
    }
}
