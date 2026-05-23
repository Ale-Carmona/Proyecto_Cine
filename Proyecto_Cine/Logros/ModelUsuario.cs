using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cine.Logros
{
    public class ModelUsuario
    {
        public int Id { get; set; }
        public int LogroId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaObtencion { get; set; }
    }
}
