namespace Sistema_Ventas_Inventario_Papeleria
{
    partial class Empleados
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_eliminarEmp = new System.Windows.Forms.Button();
            this.btn_editarEmp = new System.Windows.Forms.Button();
            this.btn_guardarEmp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_IdEmpleado = new System.Windows.Forms.TextBox();
            this.cbo_estado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_rol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_confirmContra = new System.Windows.Forms.TextBox();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nomCom = new System.Windows.Forms.TextBox();
            this.nombre_empleado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_auditarEmple = new System.Windows.Forms.Button();
            this.data_empleAdmin = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_empleAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btn_limpiar);
            this.panel1.Controls.Add(this.btn_eliminarEmp);
            this.panel1.Controls.Add(this.btn_editarEmp);
            this.panel1.Controls.Add(this.btn_guardarEmp);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_IdEmpleado);
            this.panel1.Controls.Add(this.cbo_estado);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbo_rol);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_confirmContra);
            this.panel1.Controls.Add(this.txt_contra);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_correo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_nomCom);
            this.panel1.Controls.Add(this.nombre_empleado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 517);
            this.panel1.TabIndex = 0;
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
            this.btn_limpiar.Location = new System.Drawing.Point(126, 454);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(112, 31);
            this.btn_limpiar.TabIndex = 45;
            this.btn_limpiar.Text = "Limpiar Datos";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_eliminarEmp
            // 
            this.btn_eliminarEmp.BackColor = System.Drawing.Color.Red;
            this.btn_eliminarEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminarEmp.FlatAppearance.BorderSize = 0;
            this.btn_eliminarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarEmp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarEmp.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_eliminarEmp.Location = new System.Drawing.Point(13, 454);
            this.btn_eliminarEmp.Name = "btn_eliminarEmp";
            this.btn_eliminarEmp.Size = new System.Drawing.Size(107, 31);
            this.btn_eliminarEmp.TabIndex = 44;
            this.btn_eliminarEmp.Text = "Eliminar";
            this.btn_eliminarEmp.UseVisualStyleBackColor = false;
            this.btn_eliminarEmp.Click += new System.EventHandler(this.btn_eliminarEmp_Click);
            // 
            // btn_editarEmp
            // 
            this.btn_editarEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.btn_editarEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editarEmp.FlatAppearance.BorderSize = 0;
            this.btn_editarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editarEmp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarEmp.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_editarEmp.Location = new System.Drawing.Point(13, 417);
            this.btn_editarEmp.Name = "btn_editarEmp";
            this.btn_editarEmp.Size = new System.Drawing.Size(225, 31);
            this.btn_editarEmp.TabIndex = 43;
            this.btn_editarEmp.Text = "Modificar Datos";
            this.btn_editarEmp.UseVisualStyleBackColor = false;
            this.btn_editarEmp.Click += new System.EventHandler(this.btn_editarEmp_Click);
            // 
            // btn_guardarEmp
            // 
            this.btn_guardarEmp.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_guardarEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardarEmp.FlatAppearance.BorderSize = 0;
            this.btn_guardarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardarEmp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarEmp.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_guardarEmp.Location = new System.Drawing.Point(13, 380);
            this.btn_guardarEmp.Name = "btn_guardarEmp";
            this.btn_guardarEmp.Size = new System.Drawing.Size(225, 31);
            this.btn_guardarEmp.TabIndex = 42;
            this.btn_guardarEmp.Text = "Guardar";
            this.btn_guardarEmp.UseVisualStyleBackColor = false;
            this.btn_guardarEmp.Click += new System.EventHandler(this.btn_guardarEmp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(75, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Id Empleado:";
            // 
            // txt_IdEmpleado
            // 
            this.txt_IdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdEmpleado.Location = new System.Drawing.Point(159, 61);
            this.txt_IdEmpleado.Name = "txt_IdEmpleado";
            this.txt_IdEmpleado.Size = new System.Drawing.Size(79, 20);
            this.txt_IdEmpleado.TabIndex = 20;
            this.txt_IdEmpleado.Text = "0";
            this.txt_IdEmpleado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbo_estado
            // 
            this.cbo_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_estado.FormattingEnabled = true;
            this.cbo_estado.Location = new System.Drawing.Point(131, 342);
            this.cbo_estado.Name = "cbo_estado";
            this.cbo_estado.Size = new System.Drawing.Size(107, 21);
            this.cbo_estado.TabIndex = 15;
            this.cbo_estado.SelectedIndexChanged += new System.EventHandler(this.cbo_estado_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(156, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Estado:";
            // 
            // cbo_rol
            // 
            this.cbo_rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_rol.FormattingEnabled = true;
            this.cbo_rol.Location = new System.Drawing.Point(13, 342);
            this.cbo_rol.Name = "cbo_rol";
            this.cbo_rol.Size = new System.Drawing.Size(107, 21);
            this.cbo_rol.TabIndex = 13;
            this.cbo_rol.SelectedIndexChanged += new System.EventHandler(this.cbo_rol_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rol:";
            // 
            // txt_confirmContra
            // 
            this.txt_confirmContra.Location = new System.Drawing.Point(13, 291);
            this.txt_confirmContra.Name = "txt_confirmContra";
            this.txt_confirmContra.PasswordChar = '*';
            this.txt_confirmContra.Size = new System.Drawing.Size(225, 20);
            this.txt_confirmContra.TabIndex = 11;
            // 
            // txt_contra
            // 
            this.txt_contra.Location = new System.Drawing.Point(13, 232);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.PasswordChar = '*';
            this.txt_contra.Size = new System.Drawing.Size(225, 20);
            this.txt_contra.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Confirmar Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña:";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(13, 176);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(225, 20);
            this.txt_correo.TabIndex = 7;
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_nomCom
            // 
            this.txt_nomCom.Location = new System.Drawing.Point(13, 122);
            this.txt_nomCom.Name = "txt_nomCom";
            this.txt_nomCom.Size = new System.Drawing.Size(225, 20);
            this.txt_nomCom.TabIndex = 5;
            this.txt_nomCom.TextChanged += new System.EventHandler(this.txt_nomCom_TextChanged);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.btn_auditarEmple);
            this.panel2.Controls.Add(this.data_empleAdmin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(290, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 517);
            this.panel2.TabIndex = 1;
            // 
            // btn_auditarEmple
            // 
            this.btn_auditarEmple.BackColor = System.Drawing.Color.Crimson;
            this.btn_auditarEmple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_auditarEmple.FlatAppearance.BorderSize = 0;
            this.btn_auditarEmple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_auditarEmple.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_auditarEmple.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_auditarEmple.Location = new System.Drawing.Point(397, 18);
            this.btn_auditarEmple.Name = "btn_auditarEmple";
            this.btn_auditarEmple.Size = new System.Drawing.Size(159, 31);
            this.btn_auditarEmple.TabIndex = 46;
            this.btn_auditarEmple.Text = "Auditar Empleados";
            this.btn_auditarEmple.UseVisualStyleBackColor = false;
            this.btn_auditarEmple.Click += new System.EventHandler(this.btn_auditarEmple_Click);
            // 
            // data_empleAdmin
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_empleAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_empleAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_empleAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.IdEmpleado,
            this.NombreEmpleado,
            this.Correo,
            this.Contraseña,
            this.NombreRol,
            this.Estado,
            this.FechaIngreso});
            this.data_empleAdmin.Location = new System.Drawing.Point(15, 61);
            this.data_empleAdmin.MultiSelect = false;
            this.data_empleAdmin.Name = "data_empleAdmin";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.data_empleAdmin.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.data_empleAdmin.RowTemplate.Height = 28;
            this.data_empleAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_empleAdmin.Size = new System.Drawing.Size(541, 422);
            this.data_empleAdmin.TabIndex = 2;
            this.data_empleAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_empleAdmin_CellClick);
            this.data_empleAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.data_empleAdmin.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_empleAdmin_CellFormatting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSeleccionar.Width = 35;
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.DataPropertyName = "IdEmpleado";
            this.IdEmpleado.HeaderText = "IdEmpleado";
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.Width = 70;
            // 
            // NombreEmpleado
            // 
            this.NombreEmpleado.DataPropertyName = "NombreEmpleado";
            this.NombreEmpleado.HeaderText = "NombreEmpleado";
            this.NombreEmpleado.Name = "NombreEmpleado";
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.Width = 65;
            // 
            // Contraseña
            // 
            this.Contraseña.DataPropertyName = "Contraseña";
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Width = 75;
            // 
            // NombreRol
            // 
            this.NombreRol.DataPropertyName = "NombreRol";
            this.NombreRol.HeaderText = "Rol";
            this.NombreRol.Name = "NombreRol";
            this.NombreRol.Width = 55;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 50;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.HeaderText = "FechaIngreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPLEADOS";
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_empleAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_empleAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nombre_empleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nomCom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.ComboBox cbo_estado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_rol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_confirmContra;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.TextBox txt_IdEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_eliminarEmp;
        private System.Windows.Forms.Button btn_editarEmp;
        private System.Windows.Forms.Button btn_guardarEmp;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_auditarEmple;
    }
}