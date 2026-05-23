using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cine.Recompensas
{
    public class ModelCanje
    {
        public int Id { get; set; }

        public int RecompensaId { get; set; }

        public int UsuarioId { get; set; }

        public int PuntosUtilizados { get; set; }

        public DateTime FechaCanje { get; set; }

        public string Estado { get; set; } = string.Empty;
    }
}
