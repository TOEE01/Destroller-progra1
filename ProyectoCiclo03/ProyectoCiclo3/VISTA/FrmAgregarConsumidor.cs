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
    public partial class FrmAgregarClientes : Form
    {
        public FrmAgregarClientes()
        {
            InitializeComponent();
            ListarComunidades();
        }
        ClsButtonColor button = new ClsButtonColor();
        ButtonColor btn = new ButtonColor();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                if (txtApellidos.Text == "" && txtNombreNuevoCliente.Text == "" && txtDUI.Text == "")
                {
                    MessageBox.Show("El nombre completo del cliente y el DUI son datos de ingreso obligatorio");
                }

                else
                {
                    ClsDConsumidores cls = new ClsDConsumidores();

                    Consumidores clientes = new Consumidores();

                    clientes.nombresConsumidor = txtNombreNuevoCliente.Text;
                    clientes.apellidosConsumidor = txtApellidos.Text;
                    clientes.numeroDocumento = txtDUI.Text;
                    clientes.telefono = txtDUI.Text;
                    clientes.correo = txtEmail.Text;

                    if (cbComunidad.Text=="")
                    {
                        clientes.idComunidad_FK = null;
                    }

                    else
                    {
                        clientes.idComunidad_FK = Convert.ToInt32(idComunidadSeleccionado);
                    }

                    cls.InsertarUsuario(clientes);

                    Limpiar();
                }
            }
        }

        int posX = 0;
        int posY = 0;
        private void pnlCabeceraAgregarCliente_MouseMove(object sender, MouseEventArgs e)
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

        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulClaro = btnAgregar;
            button.AzulClaro(btn);
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnAgregar;
            button.AzulOscuro(btn);
        }

        private void btnAgregar_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulClaro = btnAgregar;
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

        private string idComunidadSeleccionado = "";
        private void cbComunidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbComunidad.SelectedValue != null)
            {
                idComunidadSeleccionado = cbComunidad.SelectedValue.ToString();
            }
        }

        private void ListarComunidades()
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var lista = db.Comunidades.ToList();

                if (lista.Count > 0)
                {
                    cbComunidad.DataSource = lista;
                    cbComunidad.DisplayMember = "nombreComunidad";
                    cbComunidad.ValueMember = "idComunidad";

                    if (cbComunidad.Items.Count > 0)
                    {
                        cbComunidad.SelectedIndex = -1;
                    }
                }
            }
        }

        //metodo para limpiar los textbox
        private void Limpiar()
        {
            txtApellidos.Clear();
            txtNombreNuevoCliente.Clear();
            txtDUI.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            cbComunidad.ResetText();
        }
    }
}
