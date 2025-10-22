namespace Sistema_Ventas_Inventario_Papeleria
{
    partial class AuditarInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exit_admin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.data_movimientos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdAuditoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_movimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_admin
            // 
            this.exit_admin.AutoSize = true;
            this.exit_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_admin.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_admin.ForeColor = System.Drawing.Color.Black;
            this.exit_admin.Location = new System.Drawing.Point(594, 2);
            this.exit_admin.Name = "exit_admin";
            this.exit_admin.Size = new System.Drawing.Size(18, 18);
            this.exit_admin.TabIndex = 77;
            this.exit_admin.Text = "X";
            this.exit_admin.Click += new System.EventHandler(this.exit_admin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.data_movimientos);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(21, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 255);
            this.panel2.TabIndex = 76;
            // 
            // data_movimientos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_movimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_movimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.IdAuditoria,
            this.IdMovimiento,
            this.IdProducto,
            this.TipoMovimiento,
            this.Cantidad,
            this.IdEmpleado,
            this.FechaMovimiento});
            this.data_movimientos.Location = new System.Drawing.Point(15, 61);
            this.data_movimientos.MultiSelect = false;
            this.data_movimientos.Name = "data_movimientos";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.data_movimientos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.data_movimientos.RowTemplate.Height = 28;
            this.data_movimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_movimientos.Size = new System.Drawing.Size(541, 167);
            this.data_movimientos.TabIndex = 2;
            this.data_movimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_movimientos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "MOVIMIENTO INVENTARIO";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSeleccionar.Width = 35;
            // 
            // IdAuditoria
            // 
            this.IdAuditoria.DataPropertyName = "IdAuditoria";
            this.IdAuditoria.HeaderText = "IdAuditoria";
            this.IdAuditoria.Name = "IdAuditoria";
            this.IdAuditoria.Width = 70;
            // 
            // IdMovimiento
            // 
            this.IdMovimiento.DataPropertyName = "IdMovimiento";
            this.IdMovimiento.HeaderText = "IdMovimiento";
            this.IdMovimiento.Name = "IdMovimiento";
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "IdProducto";
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Width = 65;
            // 
            // TipoMovimiento
            // 
            this.TipoMovimiento.DataPropertyName = "TipoMovimiento";
            this.TipoMovimiento.HeaderText = "TipoMovimiento";
            this.TipoMovimiento.Name = "TipoMovimiento";
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 130;
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.DataPropertyName = "IdEmpleado";
            this.IdEmpleado.HeaderText = "IdEmpleado";
            this.IdEmpleado.Name = "IdEmpleado";
            // 
            // FechaMovimiento
            // 
            this.FechaMovimiento.DataPropertyName = "FechaMovimiento";
            this.FechaMovimiento.HeaderText = "FechaMovimiento";
            this.FechaMovimiento.Name = "FechaMovimiento";
            // 
            // AuditarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(613, 284);
            this.Controls.Add(this.exit_admin);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuditarInventario";
            this.Text = "AuditarInventario";
            this.Load += new System.EventHandler(this.AuditarInventario_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuditarInventario_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AuditarInventario_MouseMove);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_movimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit_admin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView data_movimientos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAuditoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaMovimiento;
    }
}