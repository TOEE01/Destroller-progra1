
namespace ProyectoCiclo3.VISTA
{
    partial class FrmEliminarPago
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
            this.pnlContenerdorEliminarPago = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPendiente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCancelado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaDePago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCabeceraEliminarCliente = new System.Windows.Forms.Panel();
            this.pnlContenerdorEliminarPago.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenerdorEliminarPago
            // 
            this.pnlContenerdorEliminarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlContenerdorEliminarPago.Controls.Add(this.pnlContenedor);
            this.pnlContenerdorEliminarPago.Controls.Add(this.pnlCabeceraEliminarCliente);
            this.pnlContenerdorEliminarPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenerdorEliminarPago.Location = new System.Drawing.Point(0, 0);
            this.pnlContenerdorEliminarPago.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContenerdorEliminarPago.Name = "pnlContenerdorEliminarPago";
            this.pnlContenerdorEliminarPago.Size = new System.Drawing.Size(566, 477);
            this.pnlContenerdorEliminarPago.TabIndex = 5;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(133)))), ((int)(((byte)(206)))));
            this.pnlContenedor.Controls.Add(this.panel4);
            this.pnlContenedor.Controls.Add(this.panel3);
            this.pnlContenedor.Controls.Add(this.panel2);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 30);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.pnlContenedor.Size = new System.Drawing.Size(566, 447);
            this.pnlContenedor.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCancelar);
            this.panel4.Controls.Add(this.btnEliminar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(20, 384);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panel4.Size = new System.Drawing.Size(526, 43);
            this.panel4.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(302, 3);
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
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(53, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(161, 36);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar Registro";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            this.btnEliminar.MouseHover += new System.EventHandler(this.btnEliminar_MouseHover);
            this.btnEliminar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEliminar_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.panel3.Controls.Add(this.txtPendiente);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtApellidos);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtCancelado);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtImpuesto);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtIdPago);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtFechaDePago);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtEstado);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtMonto);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtNombres);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 47);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(526, 317);
            this.panel3.TabIndex = 4;
            // 
            // txtPendiente
            // 
            this.txtPendiente.Enabled = false;
            this.txtPendiente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPendiente.Location = new System.Drawing.Point(150, 179);
            this.txtPendiente.Name = "txtPendiente";
            this.txtPendiente.Size = new System.Drawing.Size(356, 26);
            this.txtPendiente.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "Pendiente: ";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(150, 83);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(356, 26);
            this.txtApellidos.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Apellidos: ";
            // 
            // txtCancelado
            // 
            this.txtCancelado.Enabled = false;
            this.txtCancelado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancelado.Location = new System.Drawing.Point(150, 147);
            this.txtCancelado.Name = "txtCancelado";
            this.txtCancelado.Size = new System.Drawing.Size(356, 26);
            this.txtCancelado.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cancelado: ";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuesto.Location = new System.Drawing.Point(150, 211);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(356, 26);
            this.txtImpuesto.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Impuesto: ";
            // 
            // txtIdPago
            // 
            this.txtIdPago.Enabled = false;
            this.txtIdPago.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPago.Location = new System.Drawing.Point(150, 19);
            this.txtIdPago.Name = "txtIdPago";
            this.txtIdPago.Size = new System.Drawing.Size(356, 26);
            this.txtIdPago.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código: ";
            // 
            // txtFechaDePago
            // 
            this.txtFechaDePago.Enabled = false;
            this.txtFechaDePago.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaDePago.Location = new System.Drawing.Point(150, 275);
            this.txtFechaDePago.Name = "txtFechaDePago";
            this.txtFechaDePago.Size = new System.Drawing.Size(356, 26);
            this.txtFechaDePago.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de pago: ";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(150, 243);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(356, 26);
            this.txtEstado.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado: ";
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(150, 115);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(356, 26);
            this.txtMonto.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Monto: ";
            // 
            // txtNombres
            // 
            this.txtNombres.Enabled = false;
            this.txtNombres.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(150, 51);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(356, 26);
            this.txtNombres.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 58);
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
            this.panel2.Size = new System.Drawing.Size(526, 47);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(146, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "ELIMINAR REGISTRO DE PAGO";
            // 
            // pnlCabeceraEliminarCliente
            // 
            this.pnlCabeceraEliminarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.pnlCabeceraEliminarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabeceraEliminarCliente.Location = new System.Drawing.Point(0, 0);
            this.pnlCabeceraEliminarCliente.Name = "pnlCabeceraEliminarCliente";
            this.pnlCabeceraEliminarCliente.Size = new System.Drawing.Size(566, 30);
            this.pnlCabeceraEliminarCliente.TabIndex = 2;
            this.pnlCabeceraEliminarCliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCabeceraEliminarCliente_MouseMove);
            // 
            // FrmEliminarPago
            // 
            this.AcceptButton = this.btnEliminar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 477);
            this.Controls.Add(this.pnlContenerdorEliminarPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEliminarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlContenerdorEliminarPago.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenerdorEliminarPago;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtIdPago;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtFechaDePago;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCabeceraEliminarCliente;
        public System.Windows.Forms.TextBox txtCancelado;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtPendiente;
        private System.Windows.Forms.Label label10;
    }
}