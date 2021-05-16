using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCiclo3.MODELO.ViewModels
{
    public class PagosViewModel
    {
        public int Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public decimal Monto { get; set; }

        public decimal? Cancelado { get; set; }

        public decimal? Pendiente { get; set; }

        public decimal? Impuesto { get; set; }

        public string Estado { get; set; }
    }
}
