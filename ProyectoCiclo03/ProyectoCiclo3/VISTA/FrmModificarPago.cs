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

namespace ProyectoCiclo3.VISTA
{
    public partial class FrmModificarPago : Form
    {
        public FrmModificarPago()
        {
            InitializeComponent();
            ListarEstadosCB();
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
            btn.BotonAzulClaro = btnModificar;
            button.AzulClaro(btn);
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnModificar;
            button.AzulOscuro(btn);
        }

        private void btnEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulClaro = btnModificar;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private string idEstado = "";

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstado.SelectedValue != null)
            {
                idEstado = cbEstado.SelectedValue.ToString();
            }
        }

        //metodo para listar los pagos base en el combobox
        private void ListarEstadosCB()
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var lista = db.Estados.ToList();

                if (lista.Count > 0)
                {
                    cbEstado.DataSource = lista;
                    cbEstado.DisplayMember = "nombreEstado";
                    cbEstado.ValueMember = "idEstado";

                    if (cbEstado.Items.Count > 0)
                    {
                        cbEstado.SelectedIndex = -1;
                    }
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
