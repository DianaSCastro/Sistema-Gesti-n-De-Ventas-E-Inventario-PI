namespace Sistema_Ventas_Inventario_Papeleria
{
    partial class Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.data_empleClientes = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_eliminarClientes = new System.Windows.Forms.Button();
            this.btn_editarClientes = new System.Windows.Forms.Button();
            this.btn_guardarClientes = new System.Windows.Forms.Button();
            this.txt_telCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_IdCliente = new System.Windows.Forms.TextBox();
            this.txt_correoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nomComCliente = new System.Windows.Forms.TextBox();
            this.nombre_empleado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_auditarClientes = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_empleClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.btn_auditarClientes);
            this.panel2.Controls.Add(this.data_empleClientes);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(290, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 517);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // data_empleClientes
            // 
            this.data_empleClientes.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_empleClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data_empleClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_empleClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.NombreCliente,
            this.Correo,
            this.Telefono,
            this.FechaIngreso,
            this.btnSeleccionar});
            this.data_empleClientes.Location = new System.Drawing.Point(15, 61);
            this.data_empleClientes.MultiSelect = false;
            this.data_empleClientes.Name = "data_empleClientes";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.data_empleClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.data_empleClientes.RowTemplate.Height = 28;
            this.data_empleClientes.Size = new System.Drawing.Size(541, 422);
            this.data_empleClientes.TabIndex = 2;
            this.data_empleClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_empleClientes_CellClick);
            this.data_empleClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_empleClientes_CellContentClick);
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Width = 70;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "NombreCliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Width = 130;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.Width = 80;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 70;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "FechaIngreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Width = 110;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSeleccionar.Width = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "CLIENTES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btn_limpiar);
            this.panel1.Controls.Add(this.btn_eliminarClientes);
            this.panel1.Controls.Add(this.btn_editarClientes);
            this.panel1.Controls.Add(this.btn_guardarClientes);
            this.panel1.Controls.Add(this.txt_telCliente);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_IdCliente);
            this.panel1.Controls.Add(this.txt_correoCliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_nomComCliente);
            this.panel1.Controls.Add(this.nombre_empleado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 517);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.Crimson;
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_limpiar.Location = new System.Drawing.Point(13, 453);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(225, 31);
            this.btn_limpiar.TabIndex = 46;
            this.btn_limpiar.Text = "Limpiar Datos";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_eliminarClientes
            // 
            this.btn_eliminarClientes.BackColor = System.Drawing.Color.Red;
            this.btn_eliminarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminarClientes.FlatAppearance.BorderSize = 0;
            this.btn_eliminarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarClientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarClientes.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_eliminarClientes.Location = new System.Drawing.Point(13, 416);
            this.btn_eliminarClientes.Name = "btn_eliminarClientes";
            this.btn_eliminarClientes.Size = new System.Drawing.Size(225, 31);
            this.btn_eliminarClientes.TabIndex = 47;
            this.btn_eliminarClientes.Text = "Eliminar";
            this.btn_eliminarClientes.UseVisualStyleBackColor = false;
            this.btn_eliminarClientes.Click += new System.EventHandler(this.btn_eliminarClientes_Click);
            // 
            // btn_editarClientes
            // 
            this.btn_editarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.btn_editarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editarClientes.FlatAppearance.BorderSize = 0;
            this.btn_editarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editarClientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarClientes.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_editarClientes.Location = new System.Drawing.Point(13, 379);
            this.btn_editarClientes.Name = "btn_editarClientes";
            this.btn_editarClientes.Size = new System.Drawing.Size(225, 31);
            this.btn_editarClientes.TabIndex = 46;
            this.btn_editarClientes.Text = "Modificar Datos";
            this.btn_editarClientes.UseVisualStyleBackColor = false;
            this.btn_editarClientes.Click += new System.EventHandler(this.btn_editarClientes_Click);
            // 
            // btn_guardarClientes
            // 
            this.btn_guardarClientes.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_guardarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardarClientes.FlatAppearance.BorderSize = 0;
            this.btn_guardarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardarClientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarClientes.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_guardarClientes.Location = new System.Drawing.Point(13, 342);
            this.btn_guardarClientes.Name = "btn_guardarClientes";
            this.btn_guardarClientes.Size = new System.Drawing.Size(225, 31);
            this.btn_guardarClientes.TabIndex = 45;
            this.btn_guardarClientes.Text = "Guardar";
            this.btn_guardarClientes.UseVisualStyleBackColor = false;
            this.btn_guardarClientes.Click += new System.EventHandler(this.btn_guardarClientes_Click);
            // 
            // txt_telCliente
            // 
            this.txt_telCliente.Location = new System.Drawing.Point(13, 237);
            this.txt_telCliente.Name = "txt_telCliente";
            this.txt_telCliente.Size = new System.Drawing.Size(225, 20);
            this.txt_telCliente.TabIndex = 26;
            this.txt_telCliente.TextChanged += new System.EventHandler(this.txt_telCliente_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(75, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "ID Cliente:";
            // 
            // txt_IdCliente
            // 
            this.txt_IdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdCliente.Location = new System.Drawing.Point(159, 61);
            this.txt_IdCliente.Name = "txt_IdCliente";
            this.txt_IdCliente.Size = new System.Drawing.Size(79, 20);
            this.txt_IdCliente.TabIndex = 20;
            this.txt_IdCliente.Text = "0";
            // 
            // txt_correoCliente
            // 
            this.txt_correoCliente.Location = new System.Drawing.Point(13, 176);
            this.txt_correoCliente.Name = "txt_correoCliente";
            this.txt_correoCliente.Size = new System.Drawing.Size(225, 20);
            this.txt_correoCliente.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Correo:";
            // 
            // txt_nomComCliente
            // 
            this.txt_nomComCliente.Location = new System.Drawing.Point(13, 122);
            this.txt_nomComCliente.Name = "txt_nomComCliente";
            this.txt_nomComCliente.Size = new System.Drawing.Size(225, 20);
            this.txt_nomComCliente.TabIndex = 5;
            // 
            // nombre_empleado
            // 
            this.nombre_empleado.AutoSize = true;
            this.nombre_empleado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_empleado.Location = new System.Drawing.Point(10, 94);
            this.nombre_empleado.Name = "nombre_empleado";
            this.nombre_empleado.Size = new System.Drawing.Size(115, 16);
            this.nombre_empleado.TabIndex = 4;
            this.nombre_empleado.Text = "Nombre Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(49, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "DETALLES";
            // 
            // btn_auditarClientes
            // 
            this.btn_auditarClientes.BackColor = System.Drawing.Color.Crimson;
            this.btn_auditarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_auditarClientes.FlatAppearance.BorderSize = 0;
            this.btn_auditarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_auditarClientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_auditarClientes.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_auditarClientes.Location = new System.Drawing.Point(397, 18);
            this.btn_auditarClientes.Name = "btn_auditarClientes";
            this.btn_auditarClientes.Size = new System.Drawing.Size(159, 31);
            this.btn_auditarClientes.TabIndex = 47;
            this.btn_auditarClientes.Text = "Auditar Clientes";
            this.btn_auditarClientes.UseVisualStyleBackColor = false;
            this.btn_auditarClientes.Click += new System.EventHandler(this.btn_auditarClientes_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_empleClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView data_empleClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_IdCliente;
        private System.Windows.Forms.TextBox txt_correoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nomComCliente;
        private System.Windows.Forms.Label nombre_empleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_telCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_eliminarClientes;
        private System.Windows.Forms.Button btn_editarClientes;
        private System.Windows.Forms.Button btn_guardarClientes;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.Button btn_auditarClientes;
    }
}