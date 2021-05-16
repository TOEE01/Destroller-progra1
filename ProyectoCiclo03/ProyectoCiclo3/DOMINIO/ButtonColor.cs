using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCiclo3.DOMINIO
{
    class ButtonColor
    {
        //Parametros
        private Button botonAzulClaro;
        private Button botonAzulOscuro;
        private Button botonRojo;

        
        public Button BotonAzulClaro { get => botonAzulClaro; set => botonAzulClaro = value; }
        public Button BotonAzulOscuro { get => botonAzulOscuro; set => botonAzulOscuro = value; }
        public Button BotonRojo { get => botonRojo; set => botonRojo = value; }
    }
}
