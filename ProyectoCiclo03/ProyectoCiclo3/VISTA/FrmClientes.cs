using ProyectoCiclo3.DAO;
using ProyectoCiclo3.DOMINIO;
using ProyectoCiclo3.MODELO;
using ProyectoCiclo3.MODELO.ViewModels;
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
using static ProyectoCiclo3.MODELO.ViewModels.ConsumidoresViewModel;

namespace WilianMiranda01.VISTA
{
    public partial class FrmClientes : Form
    {
        //FmrPrincipal p = new FmrPrincipal();
        //CCClientes cliente = new CCClientes();
        public FrmClientes()
        {
            InitializeComponent();
        }

        ClsButtonColor button = new ClsButtonColor();
        ButtonColor btn = new ButtonColor();

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            //Llamada al método 
            ejecutar();
            dtgGestionDeConsumidores.Columns[0].Width = 70;
            dtgGestionDeConsumidores.Columns[1].Width = 180;
            dtgGestionDeConsumidores.Columns[2].Width = 180;
            dtgGestionDeConsumidores.Columns[3].Width = 110;
            dtgGestionDeConsumidores.Columns[4].Width = 200;
            dtgGestionDeConsumidores.Columns[5].Width = 100;
        }
        
        //Método utilizado para leer los datos del sp en el dtgGestionDeConsumidores
        private void ejecutar()
        {
            ClsDMostrarConsumidores mostrarConsumidores = new ClsDMostrarConsumidores();
            dtgGestionDeConsumidores.DataSource = mostrarConsumidores.Consultar();
            btnCantidadDeClientes.Text = dtgGestionDeConsumidores.Rows.Count.ToString();
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarClientes clientes = new FrmAgregarClientes();
            clientes.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgGestionDeConsumidores.SelectedRows.Count > 0)
            {
                FrmModificarCliente modificar = new FrmModificarCliente();
                modificar.txtIdCliente.Text = dtgGestionDeConsumidores.CurrentRow.Cells[0].Value.ToString();
                modificar.txtNombre.Text = dtgGestionDeConsumidores.CurrentRow.Cells[1].Value.ToString();
                modificar.txtApellidos.Text = dtgGestionDeConsumidores.CurrentRow.Cells[2].Value.ToString();
                modificar.txtDUI.Text = dtgGestionDeConsumidores.CurrentRow.Cells[3].Value.ToString();
                modificar.txtEmail.Text = dtgGestionDeConsumidores.CurrentRow.Cells[4].Value.ToString();
                modificar.txtTelefono.Text = dtgGestionDeConsumidores.CurrentRow.Cells[5].Value.ToString();           
                modificar.comunidad = dtgGestionDeConsumidores.CurrentRow.Cells[6].Value.ToString();

                modificar.ShowDialog();
            }

            else
            {
                MessageBox.Show("Seleccione un registro que desea modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgGestionDeConsumidores.SelectedRows.Count > 0)
            {
                FrmEliminarCliente eliminar = new FrmEliminarCliente();

                eliminar.txtIdCliente.Text = dtgGestionDeConsumidores.CurrentRow.Cells[0].Value.ToString();
                eliminar.txtNombre.Text = dtgGestionDeConsumidores.CurrentRow.Cells[1].Value.ToString();
                eliminar.txtApellidos.Text = dtgGestionDeConsumidores.CurrentRow.Cells[2].Value.ToString();
                eliminar.txtDUI.Text = dtgGestionDeConsumidores.CurrentRow.Cells[3].Value.ToString();
                eliminar.txtEmail.Text = dtgGestionDeConsumidores.CurrentRow.Cells[4].Value.ToString();
                eliminar.txtTelefono.Text = dtgGestionDeConsumidores.CurrentRow.Cells[5].Value.ToString();
                eliminar.txtComunidad.Text= dtgGestionDeConsumidores.CurrentRow.Cells[6].Value.ToString();

                eliminar.ShowDialog();
            }

            else
            {
                MessageBox.Show("Seleccione el registro que desea eliminar");
            }
        }
        #region Eventos del Mouse de los botones en el formulario
        private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnBuscar;
            button.AzulOscuro(btn);
            btnBuscar.ForeColor = Color.White;
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.WhiteSmoke;
            btnBuscar.ForeColor = Color.Black;
        }

        private void btnBuscar_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulOscuro = btnBuscar;
            button.AzulOscuro(btn);
            btnBuscar.ForeColor = Color.White;
        }

        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnAgregar;
            button.AzulOscuro(btn);
            btnAgregar.ForeColor = Color.White;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.BackColor = Color.WhiteSmoke;
            btnAgregar.ForeColor = Color.Black;
        }

        private void btnAgregar_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulOscuro = btnAgregar;
            button.AzulOscuro(btn);
            btnAgregar.ForeColor = Color.White;
        }

        private void btnModificar_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnModificar;
            button.AzulOscuro(btn);
            btnModificar.ForeColor = Color.White;
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.BackColor = Color.WhiteSmoke;
            btnModificar.ForeColor = Color.Black;
        }

        private void btnModificar_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulOscuro = btnModificar;
            button.AzulOscuro(btn);
            btnModificar.ForeColor = Color.White;
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btn.BotonRojo = btnEliminar;
            button.Rojo(btn);
            btnEliminar.ForeColor = Color.White;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.WhiteSmoke;
            btnEliminar.ForeColor = Color.Black;
        }

        private void btnEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonRojo = btnEliminar;
            button.Rojo(btn);
            btnEliminar.ForeColor = Color.White;
        }

        #endregion
        public void btnRefrescar_Click(object sender, EventArgs e)
        {
            ejecutar();
        }

        private void btnRefrescar_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnRefrescar;
            button.AzulOscuro(btn);
            btnRefrescar.ForeColor = Color.White;
        }

        private void btnRefrescar_MouseLeave(object sender, EventArgs e)
        {
            btnRefrescar.BackColor = Color.WhiteSmoke;
            btnRefrescar.ForeColor = Color.Black;
        }

        private void btnRefrescar_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulOscuro = btnRefrescar;
            button.AzulOscuro(btn);
            btnRefrescar.ForeColor = Color.White;
        }

        //Evento click para buscar Consumidores
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscador(cbBuscarCliente.Text.Trim());

            //Agregar al historial de busqueda
            cbBuscarCliente.Items.Add(cbBuscarCliente.Text);
        }

        private void Buscador(string busqueda = null)
        {
            using (ACAPOLAMIEntities bd = new ACAPOLAMIEntities())
            {
                //Consulta
                IQueryable<ConsumidoresViewModel> buscar = (
                    from consumidor in bd.Consumidores
                    from comunidad in bd.Comunidades
                    where comunidad.idComunidad == consumidor.idComunidad_FK
                    select new ConsumidoresViewModel
                    {
                        Id = consumidor.idConsumidor,
                        Nombres = consumidor.nombresConsumidor,
                        Apellidos = consumidor.apellidosConsumidor,
                        Dui = consumidor.numeroDocumento,
                        Correo = consumidor.correo,
                        Telefono = consumidor.telefono,
                        Comunidad = comunidad.nombreComunidad
                    });

                //Condicion para que sea diferente de nulo y vacio
                if (busqueda != null && !busqueda.Equals(""))
                {
                    //Empresion lamda para crear las condiciones de busquedas
                    buscar = buscar.Where(d => busqueda == d.Id.ToString() || d.Nombres == busqueda || busqueda == d.Apellidos
                    || busqueda == d.Dui || busqueda == d.Correo || busqueda == d.Telefono
                    || busqueda == d.Comunidad);
                }

                //Pasamos la lista de consultas al dataGridView
                dtgGestionDeConsumidores.DataSource = buscar.ToList();
            }
        }
    }
}
