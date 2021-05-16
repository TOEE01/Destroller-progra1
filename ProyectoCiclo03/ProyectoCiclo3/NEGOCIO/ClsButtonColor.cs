using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoCiclo3.DOMINIO;
using System.Windows.Forms;

namespace ProyectoCiclo3.NEGOCIO
{
    class ClsButtonColor
    {

        public void AzulClaro(ButtonColor btn)
        {
            btn.BotonAzulClaro.BackColor = Color.FromArgb(67, 194, 243);
        }
        public void AzulOscuro(ButtonColor btn)
        {
            btn.BotonAzulOscuro.BackColor = Color.FromArgb(51, 124, 173);
        }
        public void Rojo(ButtonColor btn)
        {
            btn.BotonRojo.BackColor = Color.Crimson;
        }
    }
}
