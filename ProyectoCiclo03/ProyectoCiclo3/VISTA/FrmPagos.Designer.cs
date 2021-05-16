
namespace WilianMiranda01.VISTA
{
    partial class FrmPagos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgPagos = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.cbBuscarConsumidor = new System.Windows.Forms.ComboBox();
            this.btnBuscarConsumidor = new System.Windows.Forms.Button();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.btnModificarPago = new System.Windows.Forms.Button();
            this.btnEliminarPago = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagos)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1024, 106);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 50);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(431, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIÓN DE PAGOS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(20, 562);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 70);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.dtgPagos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(20, 177);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20);
            this.panel4.Size = new System.Drawing.Size(1024, 385);
            this.panel4.TabIndex = 3;
            // 
            // dtgPagos
            // 
            this.dtgPagos.AllowUserToAddRows = false;
            this.dtgPagos.AllowUserToDeleteRows = false;
            this.dtgPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPagos.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dtgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPagos.Location = new System.Drawing.Point(23, 23);
            this.dtgPagos.Name = "dtgPagos";
            this.dtgPagos.ReadOnly = true;
            this.dtgPagos.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orchid;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgPagos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPagos.Size = new System.Drawing.Size(978, 340);
            this.dtgPagos.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel5.Controls.Add(this.btnRefrescar);
            this.panel5.Controls.Add(this.cbBuscarConsumidor);
            this.panel5.Controls.Add(this.btnBuscarConsumidor);
            this.panel5.Controls.Add(this.btnRegistrarPago);
            this.panel5.Controls.Add(this.btnModificarPago);
            this.panel5.Controls.Add(this.btnEliminarPago);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(20, 126);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(1024, 45);
            this.panel5.TabIndex = 4;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.ForeColor = System.Drawing.Color.Black;
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(551, 5);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(36, 35);
            this.btnRefrescar.TabIndex = 6;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.MouseLeave += new System.EventHandler(this.btnRefrescar_MouseLeave);
            this.btnRefrescar.MouseHover += new System.EventHandler(this.btnRefrescar_MouseHover);
            this.btnRefrescar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRefrescar_MouseMove);
            // 
            // cbBuscarConsumidor
            // 
            this.cbBuscarConsumidor.FormattingEnabled = true;
            this.cbBuscarConsumidor.Location = new System.Drawing.Point(166, 10);
            this.cbBuscarConsumidor.Name = "cbBuscarConsumidor";
            this.cbBuscarConsumidor.Size = new System.Drawing.Size(379, 27);
            this.cbBuscarConsumidor.TabIndex = 5;
            // 
            // btnBuscarConsumidor
            // 
            this.btnBuscarConsumidor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscarConsumidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarConsumidor.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarConsumidor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarConsumidor.Image")));
            this.btnBuscarConsumidor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarConsumidor.Location = new System.Drawing.Point(5, 5);
            this.btnBuscarConsumidor.Name = "btnBuscarConsumidor";
            this.btnBuscarConsumidor.Size = new System.Drawing.Size(155, 35);
            this.btnBuscarConsumidor.TabIndex = 4;
            this.btnBuscarConsumidor.Text = "       Consumidor:";
            this.btnBuscarConsumidor.UseVisualStyleBackColor = true;
            this.btnBuscarConsumidor.Click += new System.EventHandler(this.btnBuscarConsumidor_Click);
            this.btnBuscarConsumidor.MouseLeave += new System.EventHandler(this.btnBuscarConsumidor_MouseLeave);
            this.btnBuscarConsumidor.MouseHover += new System.EventHandler(this.btnBuscarConsumidor_MouseHover);
            this.btnBuscarConsumidor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBuscarConsumidor_MouseMove);
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPago.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarPago.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarPago.Image")));
            this.btnRegistrarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarPago.Location = new System.Drawing.Point(587, 5);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(144, 35);
            this.btnRegistrarPago.TabIndex = 2;
            this.btnRegistrarPago.Text = "     Registrar";
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            this.btnRegistrarPago.MouseLeave += new System.EventHandler(this.btnRegistrarPago_MouseLeave);
            this.btnRegistrarPago.MouseHover += new System.EventHandler(this.btnRegistrarPago_MouseHover);
            this.btnRegistrarPago.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRegistrarPago_MouseMove);
            // 
            // btnModificarPago
            // 
            this.btnModificarPago.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnModificarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPago.ForeColor = System.Drawing.Color.Black;
            this.btnModificarPago.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarPago.Image")));
            this.btnModificarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarPago.Location = new System.Drawing.Point(731, 5);
            this.btnModificarPago.Name = "btnModificarPago";
            this.btnModificarPago.Size = new System.Drawing.Size(144, 35);
            this.btnModificarPago.TabIndex = 1;
            this.btnModificarPago.Text = "     Modificar";
            this.btnModificarPago.UseVisualStyleBackColor = true;
            this.btnModificarPago.Click += new System.EventHandler(this.btnModificarPago_Click);
            this.btnModificarPago.MouseLeave += new System.EventHandler(this.btnModificarPago_MouseLeave);
            this.btnModificarPago.MouseHover += new System.EventHandler(this.btnModificarPago_MouseHover);
            this.btnModificarPago.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnModificarPago_MouseMove);
            // 
            // btnEliminarPago
            // 
            this.btnEliminarPago.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPago.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarPago.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarPago.Image")));
            this.btnEliminarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPago.Location = new System.Drawing.Point(875, 5);
            this.btnEliminarPago.Name = "btnEliminarPago";
            this.btnEliminarPago.Size = new System.Drawing.Size(144, 35);
            this.btnEliminarPago.TabIndex = 0;
            this.btnEliminarPago.Text = "     Eliminar";
            this.btnEliminarPago.UseVisualStyleBackColor = true;
            this.btnEliminarPago.Click += new System.EventHandler(this.btnEliminarPago_Click);
            this.btnEliminarPago.MouseLeave += new System.EventHandler(this.btnEliminarPago_MouseLeave);
            this.btnEliminarPago.MouseHover += new System.EventHandler(this.btnEliminarPago_MouseHover);
            this.btnEliminarPago.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEliminarPago_MouseMove);
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1064, 652);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmPagos";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "FrmPagos";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagos)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgPagos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBuscarConsumidor;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.Button btnModificarPago;
        private System.Windows.Forms.Button btnEliminarPago;
        private System.Windows.Forms.ComboBox cbBuscarConsumidor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefrescar;
    }
}