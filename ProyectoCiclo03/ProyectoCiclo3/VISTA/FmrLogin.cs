using ProyectoCiclo3.DOMINIO;
using ProyectoCiclo3.NEGOCIO;
using System;
using System.Drawing;
using System.Windows.Forms;
using WilianMiranda01.VISTA;

namespace WilianMiranda01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClsButtonColor button = new ClsButtonColor();
        ButtonColor btn = new ButtonColor();
        
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            FmrPrincipal frm = new FmrPrincipal();
            frm.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimizarVentana(object sender, EventArgs e)
        {
            
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if(WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnCerrarVentana(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario registro = new FrmRegistroUsuario();
            registro.ShowDialog();
        }

        private void btnCerrarAplicacion_MouseHover(object sender, EventArgs e)
        {
            btn.BotonRojo = btnCerrarAplicacion;
            button.Rojo(btn);
        }

        private void btnCerrarAplicacion_MouseLeave(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnCerrarAplicacion;
            button.AzulOscuro(btn);
        }

        private void btnCerrarAplicacion_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonRojo = btnCerrarAplicacion;
            button.Rojo(btn);
        }

        private void btnMinimizarAplicacion_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulClaro = btnMinimizarAplicacion;
            button.AzulClaro(btn);
        }

        private void btnMinimizarAplicacion_MouseLeave(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnMinimizarAplicacion;
            button.AzulOscuro(btn);
        }

        private void btnMinimizarAplicacion_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulClaro = btnMinimizarAplicacion;
            button.AzulClaro(btn);
        }

        private void btnIniciarSesion_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulClaro = btnIniciarSesion;
            button.AzulClaro(btn);
        }

        private void btnIniciarSesion_MouseLeave(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnIniciarSesion;
            button.AzulOscuro(btn);
        }

        private void btnIniciarSesion_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulClaro = btnIniciarSesion;
            button.AzulClaro(btn);
        }

        private void btnRegistroUsuario_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulClaro = btnRegistroUsuario;
            button.AzulClaro(btn);
        }

        private void btnRegistroUsuario_MouseLeave(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnRegistroUsuario;
            button.AzulOscuro(btn);
        }

        private void btnRegistroUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulClaro = btnRegistroUsuario;
            button.AzulClaro(btn);
        }

        int posX = 0;
        int posY = 0;
        private void panel3_MouseMove_1(object sender, MouseEventArgs e)
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
