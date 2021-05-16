using ProyectoCiclo3.DAO;
using ProyectoCiclo3.DOMINIO;
using ProyectoCiclo3.MODELO;
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

namespace WilianMiranda01.VISTA
{
    public partial class FrmEliminarCliente : Form
    {
        public FrmEliminarCliente()
        {
            InitializeComponent();
        }

        ClsButtonColor button = new ClsButtonColor();
        ButtonColor btn = new ButtonColor();
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    ClsDConsumidores consumidores = new ClsDConsumidores();

                    consumidores.EliminarConsumidor(Convert.ToInt32(txtIdCliente.Text));

                    this.Dispose();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulClaro = btnEliminar;
            button.AzulClaro(btn);
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnCancelar;
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
    }
}
