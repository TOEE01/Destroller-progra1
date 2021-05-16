
namespace WilianMiranda01.VISTA
{
    partial class FrmRegistroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelarRegistro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pnlCabeceraRegistroUsuario = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarAplicacion = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCabeceraRegistroUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelarRegistro
            // 
            this.btnCancelarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnCancelarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarRegistro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnCancelarRegistro.Location = new System.Drawing.Point(208, 305);
            this.btnCancelarRegistro.Name = "btnCancelarRegistro";
            this.btnCancelarRegistro.Size = new System.Drawing.Size(167, 43);
            this.btnCancelarRegistro.TabIndex = 25;
            this.btnCancelarRegistro.Text = "Cancelar Registro";
            this.btnCancelarRegistro.UseVisualStyleBackColor = false;
            this.btnCancelarRegistro.Click += new System.EventHandler(this.btnRegistroUsuario_Click);
            this.btnCancelarRegistro.MouseLeave += new System.EventHandler(this.btnCancelarRegistro_MouseLeave);
            this.btnCancelarRegistro.MouseHover += new System.EventHandler(this.btnCancelarRegistro_MouseHover);
            this.btnCancelarRegistro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCancelarRegistro_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(142, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "REGISTRO";
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnRegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(31, 305);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(167, 43);
            this.btnRegistrarUsuario.TabIndex = 21;
            this.btnRegistrarUsuario.Text = "Registrarse";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = false;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            this.btnRegistrarUsuario.MouseLeave += new System.EventHandler(this.btnRegistrarUsuario_MouseLeave);
            this.btnRegistrarUsuario.MouseHover += new System.EventHandler(this.btnRegistrarUsuario_MouseHover);
            this.btnRegistrarUsuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRegistrarUsuario_MouseMove);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(32, 183);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(343, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(31, 115);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(344, 26);
            this.txtUsuario.TabIndex = 1;
            // 
            // pnlCabeceraRegistroUsuario
            // 
            this.pnlCabeceraRegistroUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.pnlCabeceraRegistroUsuario.Controls.Add(this.panel1);
            this.pnlCabeceraRegistroUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabeceraRegistroUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlCabeceraRegistroUsuario.Name = "pnlCabeceraRegistroUsuario";
            this.pnlCabeceraRegistroUsuario.Size = new System.Drawing.Size(403, 30);
            this.pnlCabeceraRegistroUsuario.TabIndex = 26;
            this.pnlCabeceraRegistroUsuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCabeceraRegistroUsuario_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrarAplicacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(370, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(33, 30);
            this.panel1.TabIndex = 13;
            // 
            // btnCerrarAplicacion
            // 
            this.btnCerrarAplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnCerrarAplicacion.BackgroundImage = global::ProyectoCiclo3.Properties.Resources.window_close_icon_135015__1_;
            this.btnCerrarAplicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarAplicacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarAplicacion.FlatAppearance.BorderSize = 0;
            this.btnCerrarAplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarAplicacion.Location = new System.Drawing.Point(7, 0);
            this.btnCerrarAplicacion.Name = "btnCerrarAplicacion";
            this.btnCerrarAplicacion.Size = new System.Drawing.Size(26, 30);
            this.btnCerrarAplicacion.TabIndex = 0;
            this.btnCerrarAplicacion.UseVisualStyleBackColor = false;
            this.btnCerrarAplicacion.Click += new System.EventHandler(this.btnCerrarAplicacion_Click);
            this.btnCerrarAplicacion.MouseLeave += new System.EventHandler(this.btnCerrarAplicacion_MouseLeave);
            this.btnCerrarAplicacion.MouseHover += new System.EventHandler(this.btnCerrarAplicacion_MouseHover);
            this.btnCerrarAplicacion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrarAplicacion_MouseMove);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(31, 249);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(343, 26);
            this.textBox1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Confirmar contraseña:";
            // 
            // FrmRegistroUsuario
            // 
            this.AcceptButton = this.btnRegistrarUsuario;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(133)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(403, 383);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlCabeceraRegistroUsuario);
            this.Controls.Add(this.btnCancelarRegistro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegistrarUsuario);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmRegistroUsuario_Load);
            this.pnlCabeceraRegistroUsuario.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel pnlCabeceraRegistroUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarAplicacion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}