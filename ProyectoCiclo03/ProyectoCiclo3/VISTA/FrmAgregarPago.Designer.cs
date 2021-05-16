
namespace ProyectoCiclo3.VISTA
{
    partial class FrmAgregarPago
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
            this.pnlContenerdorAgregarPago = new System.Windows.Forms.Panel();
            this.pnlContenedorAgregarCliente = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbConsumidor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCancelado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCabeceraEliminarCliente = new System.Windows.Forms.Panel();
            this.pnlContenerdorAgregarPago.SuspendLayout();
            this.pnlContenedorAgregarCliente.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenerdorAgregarPago
            // 
            this.pnlContenerdorAgregarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlContenerdorAgregarPago.Controls.Add(this.pnlContenedorAgregarCliente);
            this.pnlContenerdorAgregarPago.Controls.Add(this.pnlCabeceraEliminarCliente);
            this.pnlContenerdorAgregarPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenerdorAgregarPago.Location = new System.Drawing.Point(0, 0);
            this.pnlContenerdorAgregarPago.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContenerdorAgregarPago.Name = "pnlContenerdorAgregarPago";
            this.pnlContenerdorAgregarPago.Size = new System.Drawing.Size(568, 342);
            this.pnlContenerdorAgregarPago.TabIndex = 4;
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
            this.pnlContenedorAgregarCliente.Size = new System.Drawing.Size(568, 312);
            this.pnlContenedorAgregarCliente.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCancelar);
            this.panel4.Controls.Add(this.btnAgregar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(20, 250);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panel4.Size = new System.Drawing.Size(528, 42);
            this.panel4.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(314, 3);
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
            this.btnAgregar.Text = "Agregar Pago";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            this.btnAgregar.MouseHover += new System.EventHandler(this.btnEliminar_MouseHover);
            this.btnAgregar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEliminar_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.panel3.Controls.Add(this.txtMonto);
            this.panel3.Controls.Add(this.cbEstado);
            this.panel3.Controls.Add(this.cbConsumidor);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtCancelado);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtImpuesto);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 47);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(528, 182);
            this.panel3.TabIndex = 4;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(150, 46);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(356, 26);
            this.txtMonto.TabIndex = 2;
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(150, 142);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(355, 27);
            this.cbEstado.TabIndex = 5;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // cbConsumidor
            // 
            this.cbConsumidor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConsumidor.FormattingEnabled = true;
            this.cbConsumidor.Location = new System.Drawing.Point(151, 12);
            this.cbConsumidor.Name = "cbConsumidor";
            this.cbConsumidor.Size = new System.Drawing.Size(355, 27);
            this.cbConsumidor.TabIndex = 1;
            this.cbConsumidor.SelectedIndexChanged += new System.EventHandler(this.cbConsumidor_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Consumidor: ";
            // 
            // txtCancelado
            // 
            this.txtCancelado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancelado.Location = new System.Drawing.Point(150, 78);
            this.txtCancelado.Name = "txtCancelado";
            this.txtCancelado.Size = new System.Drawing.Size(356, 26);
            this.txtCancelado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cancelado: ";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuesto.Location = new System.Drawing.Point(150, 110);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(356, 26);
            this.txtImpuesto.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Impuesto: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Monto: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(133)))), ((int)(((byte)(206)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 47);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(200, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "AGREGAR PAGO";
            // 
            // pnlCabeceraEliminarCliente
            // 
            this.pnlCabeceraEliminarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.pnlCabeceraEliminarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabeceraEliminarCliente.Location = new System.Drawing.Point(0, 0);
            this.pnlCabeceraEliminarCliente.Name = "pnlCabeceraEliminarCliente";
            this.pnlCabeceraEliminarCliente.Size = new System.Drawing.Size(568, 30);
            this.pnlCabeceraEliminarCliente.TabIndex = 2;
            this.pnlCabeceraEliminarCliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCabeceraEliminarCliente_MouseMove);
            // 
            // FrmAgregarPago
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 342);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContenerdorAgregarPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAgregarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlContenerdorAgregarPago.ResumeLayout(false);
            this.pnlContenedorAgregarCliente.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenerdorAgregarPago;
        private System.Windows.Forms.Panel pnlContenedorAgregarCliente;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCabeceraEliminarCliente;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtCancelado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbConsumidor;
        private System.Windows.Forms.ComboBox cbEstado;
        public System.Windows.Forms.TextBox txtMonto;
    }
}