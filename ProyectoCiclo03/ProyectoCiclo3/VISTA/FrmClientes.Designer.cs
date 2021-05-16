
namespace WilianMiranda01.VISTA
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlControlesCRUD = new System.Windows.Forms.Panel();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.cbBuscarCliente = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCantidadDeClientes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContenedorDataGrid = new System.Windows.Forms.Panel();
            this.dtgGestionDeConsumidores = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlControlesCRUD.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlContenedorDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGestionDeConsumidores)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(22, 587);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 44);
            this.panel3.TabIndex = 5;
            // 
            // pnlControlesCRUD
            // 
            this.pnlControlesCRUD.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlControlesCRUD.Controls.Add(this.btnRefrescar);
            this.pnlControlesCRUD.Controls.Add(this.cbBuscarCliente);
            this.pnlControlesCRUD.Controls.Add(this.btnBuscar);
            this.pnlControlesCRUD.Controls.Add(this.btnAgregar);
            this.pnlControlesCRUD.Controls.Add(this.btnModificar);
            this.pnlControlesCRUD.Controls.Add(this.btnEliminar);
            this.pnlControlesCRUD.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControlesCRUD.Location = new System.Drawing.Point(22, 118);
            this.pnlControlesCRUD.Name = "pnlControlesCRUD";
            this.pnlControlesCRUD.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlControlesCRUD.Size = new System.Drawing.Size(1020, 48);
            this.pnlControlesCRUD.TabIndex = 6;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.Transparent;
            this.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.Color.Black;
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(494, 5);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(40, 38);
            this.btnRefrescar.TabIndex = 7;
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            this.btnRefrescar.MouseLeave += new System.EventHandler(this.btnRefrescar_MouseLeave);
            this.btnRefrescar.MouseHover += new System.EventHandler(this.btnRefrescar_MouseHover);
            this.btnRefrescar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRefrescar_MouseMove);
            // 
            // cbBuscarCliente
            // 
            this.cbBuscarCliente.FormattingEnabled = true;
            this.cbBuscarCliente.Location = new System.Drawing.Point(172, 11);
            this.cbBuscarCliente.Name = "cbBuscarCliente";
            this.cbBuscarCliente.Size = new System.Drawing.Size(316, 27);
            this.cbBuscarCliente.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(6, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 38);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "     Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            this.btnBuscar.MouseHover += new System.EventHandler(this.btnBuscar_MouseHover);
            this.btnBuscar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBuscar_MouseMove);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(534, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 38);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "     Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
            this.btnAgregar.MouseHover += new System.EventHandler(this.btnAgregar_MouseHover);
            this.btnAgregar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAgregar_MouseMove);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(694, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(160, 38);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "     Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnModificar.MouseLeave += new System.EventHandler(this.btnModificar_MouseLeave);
            this.btnModificar.MouseHover += new System.EventHandler(this.btnModificar_MouseHover);
            this.btnModificar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnModificar_MouseMove);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(854, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 38);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "     Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            this.btnEliminar.MouseHover += new System.EventHandler(this.btnEliminar_MouseHover);
            this.btnEliminar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEliminar_MouseMove);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.btnCantidadDeClientes);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(22, 556);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1020, 31);
            this.panel4.TabIndex = 7;
            // 
            // btnCantidadDeClientes
            // 
            this.btnCantidadDeClientes.AutoSize = true;
            this.btnCantidadDeClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCantidadDeClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCantidadDeClientes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantidadDeClientes.ForeColor = System.Drawing.Color.Gray;
            this.btnCantidadDeClientes.Location = new System.Drawing.Point(145, 0);
            this.btnCantidadDeClientes.Name = "btnCantidadDeClientes";
            this.btnCantidadDeClientes.Size = new System.Drawing.Size(71, 19);
            this.btnCantidadDeClientes.TabIndex = 1;
            this.btnCantidadDeClientes.Text = "Clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de Clientes: ";
            // 
            // pnlContenedorDataGrid
            // 
            this.pnlContenedorDataGrid.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlContenedorDataGrid.Controls.Add(this.dtgGestionDeConsumidores);
            this.pnlContenedorDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContenedorDataGrid.Location = new System.Drawing.Point(22, 172);
            this.pnlContenedorDataGrid.Name = "pnlContenedorDataGrid";
            this.pnlContenedorDataGrid.Padding = new System.Windows.Forms.Padding(22, 21, 22, 21);
            this.pnlContenedorDataGrid.Size = new System.Drawing.Size(1020, 384);
            this.pnlContenedorDataGrid.TabIndex = 8;
            // 
            // dtgGestionDeConsumidores
            // 
            this.dtgGestionDeConsumidores.AllowUserToAddRows = false;
            this.dtgGestionDeConsumidores.AllowUserToDeleteRows = false;
            this.dtgGestionDeConsumidores.AllowUserToOrderColumns = true;
            this.dtgGestionDeConsumidores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgGestionDeConsumidores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgGestionDeConsumidores.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGestionDeConsumidores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgGestionDeConsumidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGestionDeConsumidores.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgGestionDeConsumidores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgGestionDeConsumidores.Location = new System.Drawing.Point(26, 21);
            this.dtgGestionDeConsumidores.Margin = new System.Windows.Forms.Padding(56, 0, 56, 3);
            this.dtgGestionDeConsumidores.MaximumSize = new System.Drawing.Size(1667, 379);
            this.dtgGestionDeConsumidores.MultiSelect = false;
            this.dtgGestionDeConsumidores.Name = "dtgGestionDeConsumidores";
            this.dtgGestionDeConsumidores.ReadOnly = true;
            this.dtgGestionDeConsumidores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGestionDeConsumidores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgGestionDeConsumidores.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orchid;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dtgGestionDeConsumidores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgGestionDeConsumidores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgGestionDeConsumidores.Size = new System.Drawing.Size(971, 339);
            this.dtgGestionDeConsumidores.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(22, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1020, 97);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 50);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(410, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "GESTIÓN DE CONSUMIDORES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1064, 652);
            this.Controls.Add(this.pnlContenedorDataGrid);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlControlesCRUD);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmClientes";
            this.Padding = new System.Windows.Forms.Padding(22, 21, 22, 21);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.pnlControlesCRUD.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlContenedorDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGestionDeConsumidores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlControlesCRUD;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label btnCantidadDeClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlContenedorDataGrid;
        private System.Windows.Forms.ComboBox cbBuscarCliente;
        public System.Windows.Forms.DataGridView dtgGestionDeConsumidores;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}