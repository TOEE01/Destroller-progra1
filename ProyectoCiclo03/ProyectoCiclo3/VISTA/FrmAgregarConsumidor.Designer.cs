
namespace WilianMiranda01.VISTA
{
    partial class FrmAgregarClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContenerdorAgregarCliente = new System.Windows.Forms.Panel();
            this.pnlContenedorAgregarCliente = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbComunidad = new System.Windows.Forms.ComboBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreNuevoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCabeceraAgregarCliente = new System.Windows.Forms.Panel();
            this.pnlContenerdorAgregarCliente.SuspendLayout();
            this.pnlContenedorAgregarCliente.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(804, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTES";
            // 
            // pnlContenerdorAgregarCliente
            // 
            this.pnlContenerdorAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlContenerdorAgregarCliente.Controls.Add(this.pnlContenedorAgregarCliente);
            this.pnlContenerdorAgregarCliente.Controls.Add(this.pnlCabeceraAgregarCliente);
            this.pnlContenerdorAgregarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenerdorAgregarCliente.Location = new System.Drawing.Point(0, 0);
            this.pnlContenerdorAgregarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContenerdorAgregarCliente.Name = "pnlContenerdorAgregarCliente";
            this.pnlContenerdorAgregarCliente.Size = new System.Drawing.Size(544, 372);
            this.pnlContenerdorAgregarCliente.TabIndex = 1;
            // 
            // pnlContenedorAgregarCliente
            // 
            this.pnlContenedorAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(133)))), ((int)(((byte)(206)))));
            this.pnlContenedorAgregarCliente.Controls.Add(this.panel4);
            this.pnlContenedorAgregarCliente.Controls.Add(this.panel3);
            this.pnlContenedorAgregarCliente.Controls.Add(this.panel2);
            this.pnlContenedorAgregarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorAgregarCliente.Location = new System.Drawing.Point(0, 30);
            this.pnlContenedorAgregarCliente.Name = "pnlContenedorAgregarCliente";
            this.pnlContenedorAgregarCliente.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.pnlContenedorAgregarCliente.Size = new System.Drawing.Size(544, 342);
            this.pnlContenedorAgregarCliente.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCancelar);
            this.panel4.Controls.Add(this.btnAgregar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(20, 280);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panel4.Size = new System.Drawing.Size(504, 42);
            this.panel4.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(290, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 36);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
            this.btnCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCancelar_MouseMove);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(53, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(161, 36);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
            this.btnAgregar.MouseHover += new System.EventHandler(this.btnAgregar_MouseHover);
            this.btnAgregar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAgregar_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.panel3.Controls.Add(this.cbComunidad);
            this.panel3.Controls.Add(this.txtDUI);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtTelefono);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtApellidos);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtNombreNuevoCliente);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 47);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(504, 212);
            this.panel3.TabIndex = 4;
            // 
            // cbComunidad
            // 
            this.cbComunidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComunidad.FormattingEnabled = true;
            this.cbComunidad.Location = new System.Drawing.Point(122, 173);
            this.cbComunidad.Name = "cbComunidad";
            this.cbComunidad.Size = new System.Drawing.Size(369, 27);
            this.cbComunidad.TabIndex = 6;
            this.cbComunidad.SelectedIndexChanged += new System.EventHandler(this.cbComunidad_SelectedIndexChanged);
            // 
            // txtDUI
            // 
            this.txtDUI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDUI.Location = new System.Drawing.Point(122, 77);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(369, 26);
            this.txtDUI.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "DUI: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Comunidad: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(122, 141);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(369, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "E-mail: ";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(122, 109);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(369, 26);
            this.txtTelefono.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono: ";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(122, 45);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(369, 26);
            this.txtApellidos.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellidos: ";
            // 
            // txtNombreNuevoCliente
            // 
            this.txtNombreNuevoCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreNuevoCliente.Location = new System.Drawing.Point(122, 13);
            this.txtNombreNuevoCliente.Name = "txtNombreNuevoCliente";
            this.txtNombreNuevoCliente.Size = new System.Drawing.Size(369, 26);
            this.txtNombreNuevoCliente.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombres: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(133)))), ((int)(((byte)(206)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 47);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(161, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "NUEVO CONSUMIDOR";
            // 
            // pnlCabeceraAgregarCliente
            // 
            this.pnlCabeceraAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.pnlCabeceraAgregarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabeceraAgregarCliente.Location = new System.Drawing.Point(0, 0);
            this.pnlCabeceraAgregarCliente.Name = "pnlCabeceraAgregarCliente";
            this.pnlCabeceraAgregarCliente.Size = new System.Drawing.Size(544, 30);
            this.pnlCabeceraAgregarCliente.TabIndex = 2;
            this.pnlCabeceraAgregarCliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCabeceraAgregarCliente_MouseMove);
            // 
            // FrmAgregarClientes
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 372);
            this.Controls.Add(this.pnlContenerdorAgregarCliente);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAgregarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INGRESAR CLIENTE";
            this.pnlContenerdorAgregarCliente.ResumeLayout(false);
            this.pnlContenedorAgregarCliente.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlContenerdorAgregarCliente;
        private System.Windows.Forms.Panel pnlCabeceraAgregarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlContenedorAgregarCliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreNuevoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cbComunidad;
    }
}