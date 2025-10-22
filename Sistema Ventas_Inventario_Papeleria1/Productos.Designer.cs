namespace Sistema_Ventas_Inventario_Papeleria
{
    partial class Productos
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_productos = new System.Windows.Forms.Label();
            this.data_Product = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_buscar = new System.Windows.Forms.ComboBox();
            this.txt_buscarP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_CodigoProducto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_IdProducto = new System.Windows.Forms.TextBox();
            this.btn_eliminarP = new System.Windows.Forms.Button();
            this.btn_limpiarP = new System.Windows.Forms.Button();
            this.btn_modificarP = new System.Windows.Forms.Button();
            this.fecha_regis = new System.Windows.Forms.DateTimePicker();
            this.btn_guardarProductos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_estado = new System.Windows.Forms.ComboBox();
            this.cbo_CategoriaProductos = new System.Windows.Forms.ComboBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_NomProducto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_registrarInventario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_Product)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 18;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.labelFecha.Location = new System.Drawing.Point(694, 41);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(49, 16);
            this.labelFecha.TabIndex = 20;
            this.labelFecha.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(749, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "lbFechaaaaaaa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_productos
            // 
            this.txt_productos.AutoSize = true;
            this.txt_productos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.txt_productos.Location = new System.Drawing.Point(33, 25);
            this.txt_productos.Name = "txt_productos";
            this.txt_productos.Size = new System.Drawing.Size(354, 32);
            this.txt_productos.TabIndex = 19;
            this.txt_productos.Text = "REGISTRAR PRODUCTOS";
            this.txt_productos.Click += new System.EventHandler(this.txt_productos_Click);
            // 
            // data_Product
            // 
            this.data_Product.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.NombreProducto,
            this.Descripcion,
            this.NombreCategoria,
            this.PrecioVenta,
            this.Estado,
            this.FechaRegistro,
            this.CodigoProducto,
            this.btn_Seleccionar});
            this.data_Product.Location = new System.Drawing.Point(39, 122);
            this.data_Product.MultiSelect = false;
            this.data_Product.Name = "data_Product";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.data_Product.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.data_Product.RowTemplate.Height = 28;
            this.data_Product.Size = new System.Drawing.Size(813, 190);
            this.data_Product.TabIndex = 24;
            this.data_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Product_CellClick);
            this.data_Product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_empleAdmin_CellContentClick);
            this.data_Product.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_Product_CellFormatting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Width = 70;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Width = 70;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 130;
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.HeaderText = "Categoria";
            this.NombreCategoria.Name = "NombreCategoria";
            this.NombreCategoria.Width = 80;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "PrecioVenta";
            this.PrecioVenta.Name = "PrecioVenta";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 70;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "FechaRegistro";
            this.FechaRegistro.Name = "FechaRegistro";
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "CodigoProducto";
            this.CodigoProducto.Name = "CodigoProducto";
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.HeaderText = "";
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_Seleccionar.Width = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Buscar por:";
            // 
            // cbo_buscar
            // 
            this.cbo_buscar.FormattingEnabled = true;
            this.cbo_buscar.Location = new System.Drawing.Point(128, 88);
            this.cbo_buscar.Name = "cbo_buscar";
            this.cbo_buscar.Size = new System.Drawing.Size(152, 21);
            this.cbo_buscar.TabIndex = 30;
            // 
            // txt_buscarP
            // 
            this.txt_buscarP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_buscarP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_buscarP.Location = new System.Drawing.Point(313, 86);
            this.txt_buscarP.Multiline = true;
            this.txt_buscarP.Name = "txt_buscarP";
            this.txt_buscarP.Size = new System.Drawing.Size(163, 23);
            this.txt_buscarP.TabIndex = 31;
            this.txt_buscarP.TextChanged += new System.EventHandler(this.txt_buscarP_TextChanged_1);
            this.txt_buscarP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_buscarP_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.txt_CodigoProducto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_IdProducto);
            this.groupBox2.Controls.Add(this.btn_eliminarP);
            this.groupBox2.Controls.Add(this.btn_limpiarP);
            this.groupBox2.Controls.Add(this.btn_modificarP);
            this.groupBox2.Controls.Add(this.fecha_regis);
            this.groupBox2.Controls.Add(this.btn_guardarProductos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbo_estado);
            this.groupBox2.Controls.Add(this.cbo_CategoriaProductos);
            this.groupBox2.Controls.Add(this.txt_precio);
            this.groupBox2.Controls.Add(this.txt_Descripcion);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_NomProducto);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 334);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(813, 207);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "";
            this.groupBox2.Text = "Registrar Productos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_CodigoProducto
            // 
            this.txt_CodigoProducto.AutoSize = true;
            this.txt_CodigoProducto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoProducto.ForeColor = System.Drawing.Color.Black;
            this.txt_CodigoProducto.Location = new System.Drawing.Point(543, 122);
            this.txt_CodigoProducto.Name = "txt_CodigoProducto";
            this.txt_CodigoProducto.Size = new System.Drawing.Size(173, 19);
            this.txt_CodigoProducto.TabIndex = 52;
            this.txt_CodigoProducto.Text = "CODIGO PRODUCTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(645, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Id Producto:";
            // 
            // txt_IdProducto
            // 
            this.txt_IdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdProducto.Location = new System.Drawing.Point(729, 0);
            this.txt_IdProducto.Name = "txt_IdProducto";
            this.txt_IdProducto.Size = new System.Drawing.Size(79, 20);
            this.txt_IdProducto.TabIndex = 50;
            this.txt_IdProducto.Text = "0";
            // 
            // btn_eliminarP
            // 
            this.btn_eliminarP.BackColor = System.Drawing.Color.Red;
            this.btn_eliminarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminarP.FlatAppearance.BorderSize = 0;
            this.btn_eliminarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarP.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_eliminarP.Location = new System.Drawing.Point(363, 158);
            this.btn_eliminarP.Name = "btn_eliminarP";
            this.btn_eliminarP.Size = new System.Drawing.Size(135, 31);
            this.btn_eliminarP.TabIndex = 49;
            this.btn_eliminarP.Text = "Eliminar";
            this.btn_eliminarP.UseVisualStyleBackColor = false;
            this.btn_eliminarP.Click += new System.EventHandler(this.btn_eliminarP_Click);
            // 
            // btn_limpiarP
            // 
            this.btn_limpiarP.BackColor = System.Drawing.Color.Crimson;
            this.btn_limpiarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiarP.FlatAppearance.BorderSize = 0;
            this.btn_limpiarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiarP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiarP.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_limpiarP.Location = new System.Drawing.Point(547, 158);
            this.btn_limpiarP.Name = "btn_limpiarP";
            this.btn_limpiarP.Size = new System.Drawing.Size(135, 31);
            this.btn_limpiarP.TabIndex = 48;
            this.btn_limpiarP.Text = "Limpiar Datos";
            this.btn_limpiarP.UseVisualStyleBackColor = false;
            this.btn_limpiarP.Click += new System.EventHandler(this.btn_limpiarP_Click);
            // 
            // btn_modificarP
            // 
            this.btn_modificarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.btn_modificarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modificarP.FlatAppearance.BorderSize = 0;
            this.btn_modificarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificarP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarP.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_modificarP.Location = new System.Drawing.Point(186, 158);
            this.btn_modificarP.Name = "btn_modificarP";
            this.btn_modificarP.Size = new System.Drawing.Size(135, 31);
            this.btn_modificarP.TabIndex = 47;
            this.btn_modificarP.Text = "Modificar Datos";
            this.btn_modificarP.UseVisualStyleBackColor = false;
            this.btn_modificarP.Click += new System.EventHandler(this.btn_modificarP_Click);
            // 
            // fecha_regis
            // 
            this.fecha_regis.Location = new System.Drawing.Point(547, 78);
            this.fecha_regis.Name = "fecha_regis";
            this.fecha_regis.Size = new System.Drawing.Size(200, 23);
            this.fecha_regis.TabIndex = 45;
            // 
            // btn_guardarProductos
            // 
            this.btn_guardarProductos.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_guardarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardarProductos.FlatAppearance.BorderSize = 0;
            this.btn_guardarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardarProductos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarProductos.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_guardarProductos.Location = new System.Drawing.Point(21, 158);
            this.btn_guardarProductos.Name = "btn_guardarProductos";
            this.btn_guardarProductos.Size = new System.Drawing.Size(135, 31);
            this.btn_guardarProductos.TabIndex = 41;
            this.btn_guardarProductos.Text = "Guardar";
            this.btn_guardarProductos.UseVisualStyleBackColor = false;
            this.btn_guardarProductos.Click += new System.EventHandler(this.btn_guardarProductos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Estado:";
            // 
            // cbo_estado
            // 
            this.cbo_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_estado.FormattingEnabled = true;
            this.cbo_estado.Items.AddRange(new object[] {
            "Activo",
            "No Activo"});
            this.cbo_estado.Location = new System.Drawing.Point(412, 78);
            this.cbo_estado.Name = "cbo_estado";
            this.cbo_estado.Size = new System.Drawing.Size(107, 24);
            this.cbo_estado.TabIndex = 37;
            this.cbo_estado.SelectedIndexChanged += new System.EventHandler(this.cbo_estado_SelectedIndexChanged);
            // 
            // cbo_CategoriaProductos
            // 
            this.cbo_CategoriaProductos.FormattingEnabled = true;
            this.cbo_CategoriaProductos.Items.AddRange(new object[] {
            "Escritura",
            "Papeleria general",
            "Adhesivos y correctores",
            "Material escolar básico",
            "Arte y dibujo"});
            this.cbo_CategoriaProductos.Location = new System.Drawing.Point(100, 124);
            this.cbo_CategoriaProductos.Name = "cbo_CategoriaProductos";
            this.cbo_CategoriaProductos.Size = new System.Drawing.Size(221, 24);
            this.cbo_CategoriaProductos.TabIndex = 34;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(412, 33);
            this.txt_precio.Multiline = true;
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(107, 23);
            this.txt_precio.TabIndex = 14;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(114, 79);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(207, 23);
            this.txt_Descripcion.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "Nombre Producto:";
            // 
            // txt_NomProducto
            // 
            this.txt_NomProducto.Location = new System.Drawing.Point(150, 33);
            this.txt_NomProducto.Multiline = true;
            this.txt_NomProducto.Name = "txt_NomProducto";
            this.txt_NomProducto.Size = new System.Drawing.Size(171, 23);
            this.txt_NomProducto.TabIndex = 8;
            this.txt_NomProducto.TextChanged += new System.EventHandler(this.txt_NomProducto_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(544, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Fecha de registro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(350, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Precio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Descripción:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Categoria:";
            // 
            // btn_registrarInventario
            // 
            this.btn_registrarInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.btn_registrarInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrarInventario.FlatAppearance.BorderSize = 0;
            this.btn_registrarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrarInventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarInventario.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_registrarInventario.Location = new System.Drawing.Point(652, 78);
            this.btn_registrarInventario.Name = "btn_registrarInventario";
            this.btn_registrarInventario.Size = new System.Drawing.Size(200, 31);
            this.btn_registrarInventario.TabIndex = 43;
            this.btn_registrarInventario.Text = "Registrar Stock ";
            this.btn_registrarInventario.UseVisualStyleBackColor = false;
            this.btn_registrarInventario.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Sistema_Ventas_Inventario_Papeleria.Properties.Resources.icono_buscar;
            this.pictureBox1.Location = new System.Drawing.Point(482, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 565);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_buscarP);
            this.Controls.Add(this.cbo_buscar);
            this.Controls.Add(this.btn_registrarInventario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_productos);
            this.Controls.Add(this.data_Product);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Product)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_productos;
        private System.Windows.Forms.DataGridView data_Product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_buscar;
        private System.Windows.Forms.TextBox txt_buscarP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_NomProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbo_CategoriaProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_estado;
        private System.Windows.Forms.Button btn_guardarProductos;
        private System.Windows.Forms.Button btn_registrarInventario;
        private System.Windows.Forms.DateTimePicker fecha_regis;
        private System.Windows.Forms.Button btn_modificarP;
        private System.Windows.Forms.Button btn_limpiarP;
        private System.Windows.Forms.Button btn_eliminarP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_IdProducto;
        private System.Windows.Forms.Label txt_CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Seleccionar;
    }
}