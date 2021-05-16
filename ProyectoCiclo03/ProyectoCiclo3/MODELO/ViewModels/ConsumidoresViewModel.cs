using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCiclo3.MODELO.ViewModels
{
    // Clase para guardar la consulta de forma temporal en las entidades
    public class ConsumidoresViewModel
    {
        public int Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Dui { get; set; }

        public string Correo { get; set; }

        public string Telefono { get; set; }

        public string Comunidad { get; set; }
    }
}
