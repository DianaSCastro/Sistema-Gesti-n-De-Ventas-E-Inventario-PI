namespace Sistema_Ventas_Inventario_Papeleria
{
    partial class Inventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_auditarInven = new System.Windows.Forms.Button();
            this.txt_inventario = new System.Windows.Forms.Label();
            this.data_Inventario = new System.Windows.Forms.DataGridView();
            this.IdInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_Inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_auditarInven
            // 
            this.btn_auditarInven.BackColor = System.Drawing.Color.Crimson;
            this.btn_auditarInven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_auditarInven.FlatAppearance.BorderSize = 0;
            this.btn_auditarInven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_auditarInven.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_auditarInven.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_auditarInven.Location = new System.Drawing.Point(682, 78);
            this.btn_auditarInven.Name = "btn_auditarInven";
            this.btn_auditarInven.Size = new System.Drawing.Size(159, 31);
            this.btn_auditarInven.TabIndex = 52;
            this.btn_auditarInven.Text = "Auditar Inventario";
            this.btn_auditarInven.UseVisualStyleBackColor = false;
            this.btn_auditarInven.Click += new System.EventHandler(this.btn_auditarInven_Click);
            // 
            // txt_inventario
            // 
            this.txt_inventario.AutoSize = true;
            this.txt_inventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.txt_inventario.Location = new System.Drawing.Point(26, 40);
            this.txt_inventario.Name = "txt_inventario";
            this.txt_inventario.Size = new System.Drawing.Size(412, 32);
            this.txt_inventario.TabIndex = 61;
            this.txt_inventario.Text = "INVENTARIO DE PRODUCTOS";
            // 
            // data_Inventario
            // 
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(2);
            this.data_Inventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_Inventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.data_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Inventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdInventario,
            this.CodigoProducto,
            this.NombreProducto,
            this.NombreCategoria,
            this.FechaMovimiento,
            this.TipoMovimiento,
            this.Cantidad,
            this.StockActual,
            this.Editar});
            this.data_Inventario.Location = new System.Drawing.Point(32, 125);
            this.data_Inventario.MultiSelect = false;
            this.data_Inventario.Name = "data_Inventario";
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.data_Inventario.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.data_Inventario.RowTemplate.Height = 28;
            this.data_Inventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Inventario.Size = new System.Drawing.Size(809, 400);
            this.data_Inventario.TabIndex = 65;
            this.data_Inventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Inventario_CellContentClick);
            this.data_Inventario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_Inventario_CellFormatting);
            // 
            // IdInventario
            // 
            this.IdInventario.HeaderText = "IdInventario";
            this.IdInventario.Name = "IdInventario";
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "CodigoProducto";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.Width = 110;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Width = 110;
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.HeaderText = "Categoria";
            this.NombreCategoria.Name = "NombreCategoria";
            this.NombreCategoria.Width = 110;
            // 
            // FechaMovimiento
            // 
            this.FechaMovimiento.HeaderText = "Fecha Movimiento";
            this.FechaMovimiento.Name = "FechaMovimiento";
            this.FechaMovimiento.Width = 150;
            // 
            // TipoMovimiento
            // 
            this.TipoMovimiento.HeaderText = "Tipo Movimiento";
            this.TipoMovimiento.Name = "TipoMovimiento";
            this.TipoMovimiento.Width = 80;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 70;
            // 
            // StockActual
            // 
            this.StockActual.HeaderText = "Stock Actual";
            this.StockActual.Name = "StockActual";
            this.StockActual.Width = 70;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.Width = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(754, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "lbFechaaaaa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.labelFecha.Location = new System.Drawing.Point(699, 40);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(49, 16);
            this.labelFecha.TabIndex = 62;
            this.labelFecha.Text = "Fecha:";
            this.labelFecha.Click += new System.EventHandler(this.labelFecha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 60;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(870, 565);
            this.Controls.Add(this.btn_auditarInven);
            this.Controls.Add(this.txt_inventario);
            this.Controls.Add(this.data_Inventario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Inventario_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Inventario_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.data_Inventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_inventario;
        private System.Windows.Forms.DataGridView data_Inventario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editar;
        private System.Windows.Forms.Button btn_auditarInven;
    }
}