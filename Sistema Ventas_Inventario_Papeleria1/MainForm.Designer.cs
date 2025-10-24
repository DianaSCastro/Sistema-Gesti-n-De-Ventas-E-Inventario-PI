namespace Sistema_Ventas_Inventario_Papeleria
{
    partial class MainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit_admin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_submenu = new System.Windows.Forms.Panel();
            this.subtn_adminInven = new System.Windows.Forms.Button();
            this.subtn_stock = new System.Windows.Forms.Button();
            this.picBox_inventario = new System.Windows.Forms.PictureBox();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_MenuUsuario = new System.Windows.Forms.Label();
            this.btn_Ventas = new System.Windows.Forms.Button();
            this.btn_GestClientes = new System.Windows.Forms.Button();
            this.btn_GestEmpleados = new System.Windows.Forms.Button();
            this.btn_GestProductos = new System.Windows.Forms.Button();
            this.panel_conector = new System.Windows.Forms.Panel();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_submenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.exit_admin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(111)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 35);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown_1);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // exit_admin
            // 
            this.exit_admin.AutoSize = true;
            this.exit_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_admin.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_admin.ForeColor = System.Drawing.Color.White;
            this.exit_admin.Location = new System.Drawing.Point(1070, 9);
            this.exit_admin.Name = "exit_admin";
            this.exit_admin.Size = new System.Drawing.Size(18, 18);
            this.exit_admin.TabIndex = 0;
            this.exit_admin.Text = "X";
            this.exit_admin.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btn_Reportes);
            this.panel1.Controls.Add(this.panel_submenu);
            this.panel1.Controls.Add(this.picBox_inventario);
            this.panel1.Controls.Add(this.btn_inventario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_cerrarSesion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txt_MenuUsuario);
            this.panel1.Controls.Add(this.btn_Ventas);
            this.panel1.Controls.Add(this.btn_GestClientes);
            this.panel1.Controls.Add(this.btn_GestEmpleados);
            this.panel1.Controls.Add(this.btn_GestProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 565);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_submenu
            // 
            this.panel_submenu.BackColor = System.Drawing.Color.LightCoral;
            this.panel_submenu.Controls.Add(this.subtn_adminInven);
            this.panel_submenu.Controls.Add(this.subtn_stock);
            this.panel_submenu.Location = new System.Drawing.Point(-7, 495);
            this.panel_submenu.Name = "panel_submenu";
            this.panel_submenu.Size = new System.Drawing.Size(245, 14);
            this.panel_submenu.TabIndex = 24;
            this.panel_submenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_submenu_Paint);
            // 
            // subtn_adminInven
            // 
            this.subtn_adminInven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subtn_adminInven.FlatAppearance.BorderSize = 0;
            this.subtn_adminInven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtn_adminInven.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtn_adminInven.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.subtn_adminInven.Location = new System.Drawing.Point(7, 64);
            this.subtn_adminInven.Name = "subtn_adminInven";
            this.subtn_adminInven.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.subtn_adminInven.Size = new System.Drawing.Size(230, 40);
            this.subtn_adminInven.TabIndex = 23;
            this.subtn_adminInven.Text = "Administrar Inventario";
            this.subtn_adminInven.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subtn_adminInven.UseVisualStyleBackColor = true;
            this.subtn_adminInven.Click += new System.EventHandler(this.subtn_adminInven_Click);
            // 
            // subtn_stock
            // 
            this.subtn_stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subtn_stock.FlatAppearance.BorderSize = 0;
            this.subtn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtn_stock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtn_stock.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.subtn_stock.Location = new System.Drawing.Point(7, 18);
            this.subtn_stock.Name = "subtn_stock";
            this.subtn_stock.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.subtn_stock.Size = new System.Drawing.Size(230, 40);
            this.subtn_stock.TabIndex = 22;
            this.subtn_stock.Text = "Stock ";
            this.subtn_stock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subtn_stock.UseVisualStyleBackColor = true;
            this.subtn_stock.Click += new System.EventHandler(this.subtn_stock_Click);
            // 
            // picBox_inventario
            // 
            this.picBox_inventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_inventario.Image = global::Sistema_Ventas_Inventario_Papeleria.Properties.Resources.icono_inventario;
            this.picBox_inventario.Location = new System.Drawing.Point(12, 363);
            this.picBox_inventario.Name = "picBox_inventario";
            this.picBox_inventario.Size = new System.Drawing.Size(39, 40);
            this.picBox_inventario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_inventario.TabIndex = 21;
            this.picBox_inventario.TabStop = false;
            this.picBox_inventario.Click += new System.EventHandler(this.picBox_inventario_Click);
            // 
            // btn_inventario
            // 
            this.btn_inventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inventario.FlatAppearance.BorderSize = 0;
            this.btn_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventario.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventario.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_inventario.Location = new System.Drawing.Point(0, 363);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btn_inventario.Size = new System.Drawing.Size(230, 40);
            this.btn_inventario.TabIndex = 20;
            this.btn_inventario.Text = "Inventario de Productos";
            this.btn_inventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventario.UseVisualStyleBackColor = true;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(34, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "MENÚ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cerrarSesion
            // 
            this.btn_cerrarSesion.BackColor = System.Drawing.Color.White;
            this.btn_cerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrarSesion.FlatAppearance.BorderSize = 0;
            this.btn_cerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_cerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrarSesion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrarSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrarSesion.Location = new System.Drawing.Point(46, 522);
            this.btn_cerrarSesion.Name = "btn_cerrarSesion";
            this.btn_cerrarSesion.Size = new System.Drawing.Size(135, 31);
            this.btn_cerrarSesion.TabIndex = 18;
            this.btn_cerrarSesion.Text = "Cerrar Sesión";
            this.btn_cerrarSesion.UseVisualStyleBackColor = false;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.btn_cerrarSesion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(146, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID EMPLEADO:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Ventas_Inventario_Papeleria.Properties.Resources.icono_menu_administrador;
            this.pictureBox1.Location = new System.Drawing.Point(71, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Sistema_Ventas_Inventario_Papeleria.Properties.Resources.icono_clientess;
            this.pictureBox6.Location = new System.Drawing.Point(12, 271);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(39, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Sistema_Ventas_Inventario_Papeleria.Properties.Resources.icono_empleados1;
            this.pictureBox5.Location = new System.Drawing.Point(12, 225);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Sistema_Ventas_Inventario_Papeleria.Properties.Resources.icono_productos;
            this.pictureBox3.Location = new System.Drawing.Point(12, 317);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Sistema_Ventas_Inventario_Papeleria.Properties.Resources.icono_ventas;
            this.pictureBox2.Location = new System.Drawing.Point(12, 179);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            // 
            // txt_MenuUsuario
            // 
            this.txt_MenuUsuario.AutoSize = true;
            this.txt_MenuUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MenuUsuario.ForeColor = System.Drawing.SystemColors.Menu;
            this.txt_MenuUsuario.Location = new System.Drawing.Point(80, 146);
            this.txt_MenuUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MenuUsuario.Name = "txt_MenuUsuario";
            this.txt_MenuUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.txt_MenuUsuario.Size = new System.Drawing.Size(122, 19);
            this.txt_MenuUsuario.TabIndex = 6;
            this.txt_MenuUsuario.Text = "labelTipoUsuario";
            this.txt_MenuUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_MenuUsuario.Click += new System.EventHandler(this.txt_MenuUsuario_Click);
            // 
            // btn_Ventas
            // 
            this.btn_Ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ventas.FlatAppearance.BorderSize = 0;
            this.btn_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ventas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ventas.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_Ventas.Location = new System.Drawing.Point(0, 179);
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btn_Ventas.Size = new System.Drawing.Size(230, 40);
            this.btn_Ventas.TabIndex = 6;
            this.btn_Ventas.Text = "Ventas";
            this.btn_Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ventas.UseVisualStyleBackColor = true;
            this.btn_Ventas.Click += new System.EventHandler(this.btn_Ventas_Click);
            // 
            // btn_GestClientes
            // 
            this.btn_GestClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GestClientes.FlatAppearance.BorderSize = 0;
            this.btn_GestClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GestClientes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GestClientes.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_GestClientes.Location = new System.Drawing.Point(0, 271);
            this.btn_GestClientes.Name = "btn_GestClientes";
            this.btn_GestClientes.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btn_GestClientes.Size = new System.Drawing.Size(230, 40);
            this.btn_GestClientes.TabIndex = 8;
            this.btn_GestClientes.Text = "Gestion de Clientes";
            this.btn_GestClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GestClientes.UseVisualStyleBackColor = true;
            this.btn_GestClientes.Click += new System.EventHandler(this.btn_GestClientes_Click);
            // 
            // btn_GestEmpleados
            // 
            this.btn_GestEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GestEmpleados.FlatAppearance.BorderSize = 0;
            this.btn_GestEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GestEmpleados.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GestEmpleados.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_GestEmpleados.Location = new System.Drawing.Point(0, 225);
            this.btn_GestEmpleados.Name = "btn_GestEmpleados";
            this.btn_GestEmpleados.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btn_GestEmpleados.Size = new System.Drawing.Size(230, 40);
            this.btn_GestEmpleados.TabIndex = 8;
            this.btn_GestEmpleados.Text = "Gestion de Empleados";
            this.btn_GestEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GestEmpleados.UseVisualStyleBackColor = true;
            this.btn_GestEmpleados.Click += new System.EventHandler(this.btn_GestEmpleados_Click);
            // 
            // btn_GestProductos
            // 
            this.btn_GestProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GestProductos.FlatAppearance.BorderSize = 0;
            this.btn_GestProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GestProductos.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GestProductos.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_GestProductos.Location = new System.Drawing.Point(0, 317);
            this.btn_GestProductos.Name = "btn_GestProductos";
            this.btn_GestProductos.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btn_GestProductos.Size = new System.Drawing.Size(230, 40);
            this.btn_GestProductos.TabIndex = 8;
            this.btn_GestProductos.Text = "Registro Productos";
            this.btn_GestProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GestProductos.UseVisualStyleBackColor = true;
            this.btn_GestProductos.Click += new System.EventHandler(this.btn_GestProductos_Click);
            // 
            // panel_conector
            // 
            this.panel_conector.Location = new System.Drawing.Point(230, 35);
            this.panel_conector.Name = "panel_conector";
            this.panel_conector.Size = new System.Drawing.Size(870, 565);
            this.panel_conector.TabIndex = 2;
            this.panel_conector.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_conector_Paint);
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reportes.FlatAppearance.BorderSize = 0;
            this.btn_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reportes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reportes.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_Reportes.Location = new System.Drawing.Point(0, 409);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btn_Reportes.Size = new System.Drawing.Size(230, 40);
            this.btn_Reportes.TabIndex = 25;
            this.btn_Reportes.Text = "Reportes de Ventas";
            this.btn_Reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reportes.UseVisualStyleBackColor = true;
            this.btn_Reportes.Click += new System.EventHandler(this.btn_Reportes_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel_conector);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1100, 0);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_submenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label exit_admin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_GestProductos;
        private System.Windows.Forms.Button btn_GestEmpleados;
        private System.Windows.Forms.Button btn_Ventas;
        private System.Windows.Forms.Button btn_GestClientes;
        private System.Windows.Forms.Label txt_MenuUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_conector;
        private System.Windows.Forms.Button btn_cerrarSesion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBox_inventario;
        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.Button subtn_adminInven;
        private System.Windows.Forms.Button subtn_stock;
        private System.Windows.Forms.Panel panel_submenu;
        private System.Windows.Forms.Button btn_Reportes;
    }
}