namespace Sistema_Ventas_Inventario_Papeleria
{
    partial class Stock
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
            this.groupBox_inventario = new System.Windows.Forms.GroupBox();
            this.exit_admin = new System.Windows.Forms.Label();
            this.cbo_mov = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_registrarStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_inventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_inventario
            // 
            this.groupBox_inventario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox_inventario.Controls.Add(this.exit_admin);
            this.groupBox_inventario.Controls.Add(this.cbo_mov);
            this.groupBox_inventario.Controls.Add(this.label11);
            this.groupBox_inventario.Controls.Add(this.txt_cantidad);
            this.groupBox_inventario.Controls.Add(this.button3);
            this.groupBox_inventario.Controls.Add(this.button2);
            this.groupBox_inventario.Controls.Add(this.txt_stock);
            this.groupBox_inventario.Controls.Add(this.label12);
            this.groupBox_inventario.Controls.Add(this.txt_registrarStock);
            this.groupBox_inventario.Controls.Add(this.label7);
            this.groupBox_inventario.Controls.Add(this.label8);
            this.groupBox_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_inventario.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_inventario.Location = new System.Drawing.Point(11, 10);
            this.groupBox_inventario.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_inventario.Name = "groupBox_inventario";
            this.groupBox_inventario.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_inventario.Size = new System.Drawing.Size(354, 209);
            this.groupBox_inventario.TabIndex = 72;
            this.groupBox_inventario.TabStop = false;
            this.groupBox_inventario.Tag = "";
            this.groupBox_inventario.Text = "Registro de Movimiento";
            this.groupBox_inventario.Enter += new System.EventHandler(this.groupBox_inventario_Enter);
            // 
            // exit_admin
            // 
            this.exit_admin.AutoSize = true;
            this.exit_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_admin.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_admin.ForeColor = System.Drawing.Color.Black;
            this.exit_admin.Location = new System.Drawing.Point(331, 0);
            this.exit_admin.Name = "exit_admin";
            this.exit_admin.Size = new System.Drawing.Size(18, 18);
            this.exit_admin.TabIndex = 73;
            this.exit_admin.Text = "X";
            this.exit_admin.Click += new System.EventHandler(this.exit_admin_Click);
            // 
            // cbo_mov
            // 
            this.cbo_mov.FormattingEnabled = true;
            this.cbo_mov.Items.AddRange(new object[] {
            "Entrada",
            "Salida"});
            this.cbo_mov.Location = new System.Drawing.Point(150, 94);
            this.cbo_mov.Name = "cbo_mov";
            this.cbo_mov.Size = new System.Drawing.Size(171, 24);
            this.cbo_mov.TabIndex = 53;
            this.cbo_mov.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 15);
            this.label11.TabIndex = 52;
            this.label11.Text = "Tipo Movimiento:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(150, 124);
            this.txt_cantidad.Multiline = true;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(171, 24);
            this.txt_cantidad.TabIndex = 43;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button3.Location = new System.Drawing.Point(186, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 31);
            this.button3.TabIndex = 42;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button2.Location = new System.Drawing.Point(21, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 31);
            this.button2.TabIndex = 41;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(150, 65);
            this.txt_stock.Multiline = true;
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(171, 24);
            this.txt_stock.TabIndex = 13;
            this.txt_stock.TextChanged += new System.EventHandler(this.txt_stock_TextChanged);
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
            // txt_registrarStock
            // 
            this.txt_registrarStock.Location = new System.Drawing.Point(150, 33);
            this.txt_registrarStock.Multiline = true;
            this.txt_registrarStock.Name = "txt_registrarStock";
            this.txt_registrarStock.Size = new System.Drawing.Size(171, 24);
            this.txt_registrarStock.TabIndex = 8;
            this.txt_registrarStock.TextChanged += new System.EventHandler(this.txt_registrarStock_TextChanged);
            this.txt_registrarStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_registrarStock_KeyDown);
            this.txt_registrarStock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_registrarStock_MouseDown);
            this.txt_registrarStock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txt_registrarStock_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Código Producto:";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(377, 230);
            this.Controls.Add(this.groupBox_inventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Stock_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Stock_MouseMove);
            this.groupBox_inventario.ResumeLayout(false);
            this.groupBox_inventario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_inventario;
        private System.Windows.Forms.ComboBox cbo_mov;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_registrarStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label exit_admin;
        internal System.Windows.Forms.TextBox txt_cantidad;
    }
}