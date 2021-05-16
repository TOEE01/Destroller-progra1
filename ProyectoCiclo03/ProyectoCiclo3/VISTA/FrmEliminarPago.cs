using ProyectoCiclo3.DOMINIO;
using ProyectoCiclo3.NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCiclo3.VISTA
{
    public partial class FrmEliminarPago : Form
    {
        public FrmEliminarPago()
        {
            InitializeComponent();
        }

        ClsButtonColor button = new ClsButtonColor();
        ButtonColor btn = new ButtonColor();

        int posX = 0;
        int posY = 0;
        private void pnlCabeceraEliminarCliente_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }

            else
            {
                Left += (e.X - posX);
                Top += (e.Y - posY);
            }
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulClaro = btnEliminar;
            button.AzulClaro(btn);
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnEliminar;
            button.AzulOscuro(btn);
        }

        private void btnEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulClaro = btnEliminar;
            button.AzulClaro(btn);

        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulClaro = btnCancelar;
            button.AzulClaro(btn);
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnCancelar;
            button.AzulOscuro(btn);
        }

        private void btnCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulClaro = btnCancelar;
            button.AzulClaro(btn);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }   
    }
}
