namespace Sistema_Ventas_Inventario_Papeleria
{
    partial class VisorReporteV
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_personalizar = new System.Windows.Forms.Button();
            this.dateTimePickerFrm = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrm2 = new System.Windows.Forms.DateTimePicker();
            this.btm_guardarRV = new System.Windows.Forms.Button();
            this.label_RV1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_hoy = new System.Windows.Forms.Button();
            this.btn_7dias = new System.Windows.Forms.Button();
            this.btn_mes = new System.Windows.Forms.Button();
            this.btn_año = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Ventas_Inventario_Papeleria.Reportes.ReporteVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(220, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(650, 565);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.btn_año);
            this.panel1.Controls.Add(this.btn_mes);
            this.panel1.Controls.Add(this.btn_7dias);
            this.panel1.Controls.Add(this.btn_hoy);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_RV1);
            this.panel1.Controls.Add(this.btm_guardarRV);
            this.panel1.Controls.Add(this.dateTimePickerFrm2);
            this.panel1.Controls.Add(this.dateTimePickerFrm);
            this.panel1.Controls.Add(this.btn_personalizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 565);
            this.panel1.TabIndex = 1;
            // 
            // btn_personalizar
            // 
            this.btn_personalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.btn_personalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_personalizar.FlatAppearance.BorderSize = 0;
            this.btn_personalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_personalizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_personalizar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_personalizar.Location = new System.Drawing.Point(27, 253);
            this.btn_personalizar.Name = "btn_personalizar";
            this.btn_personalizar.Size = new System.Drawing.Size(172, 35);
            this.btn_personalizar.TabIndex = 44;
            this.btn_personalizar.Text = "Personalizar Fecha";
            this.btn_personalizar.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerFrm
            // 
            this.dateTimePickerFrm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrm.Location = new System.Drawing.Point(88, 312);
            this.dateTimePickerFrm.Name = "dateTimePickerFrm";
            this.dateTimePickerFrm.Size = new System.Drawing.Size(111, 20);
            this.dateTimePickerFrm.TabIndex = 2;
            // 
            // dateTimePickerFrm2
            // 
            this.dateTimePickerFrm2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrm2.Location = new System.Drawing.Point(88, 365);
            this.dateTimePickerFrm2.Name = "dateTimePickerFrm2";
            this.dateTimePickerFrm2.Size = new System.Drawing.Size(111, 20);
            this.dateTimePickerFrm2.TabIndex = 45;
            // 
            // btm_guardarRV
            // 
            this.btm_guardarRV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.btm_guardarRV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_guardarRV.FlatAppearance.BorderSize = 0;
            this.btm_guardarRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_guardarRV.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_guardarRV.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btm_guardarRV.Location = new System.Drawing.Point(27, 405);
            this.btm_guardarRV.Name = "btm_guardarRV";
            this.btm_guardarRV.Size = new System.Drawing.Size(172, 35);
            this.btm_guardarRV.TabIndex = 46;
            this.btm_guardarRV.Text = "Guardar";
            this.btm_guardarRV.UseVisualStyleBackColor = false;
            // 
            // label_RV1
            // 
            this.label_RV1.AutoSize = true;
            this.label_RV1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RV1.ForeColor = System.Drawing.Color.White;
            this.label_RV1.Location = new System.Drawing.Point(38, 316);
            this.label_RV1.Name = "label_RV1";
            this.label_RV1.Size = new System.Drawing.Size(29, 16);
            this.label_RV1.TabIndex = 5;
            this.label_RV1.Text = "De:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Hasta:";
            // 
            // btn_hoy
            // 
            this.btn_hoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.btn_hoy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hoy.FlatAppearance.BorderSize = 0;
            this.btn_hoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hoy.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoy.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_hoy.Location = new System.Drawing.Point(27, 24);
            this.btn_hoy.Name = "btn_hoy";
            this.btn_hoy.Size = new System.Drawing.Size(172, 35);
            this.btn_hoy.TabIndex = 48;
            this.btn_hoy.Text = "Hoy";
            this.btn_hoy.UseVisualStyleBackColor = false;
            this.btn_hoy.Click += new System.EventHandler(this.btn_hoy_Click);
            // 
            // btn_7dias
            // 
            this.btn_7dias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.btn_7dias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_7dias.FlatAppearance.BorderSize = 0;
            this.btn_7dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7dias.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7dias.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_7dias.Location = new System.Drawing.Point(27, 78);
            this.btn_7dias.Name = "btn_7dias";
            this.btn_7dias.Size = new System.Drawing.Size(172, 35);
            this.btn_7dias.TabIndex = 49;
            this.btn_7dias.Text = "Últimos 7 días";
            this.btn_7dias.UseVisualStyleBackColor = false;
            // 
            // btn_mes
            // 
            this.btn_mes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.btn_mes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mes.FlatAppearance.BorderSize = 0;
            this.btn_mes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mes.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_mes.Location = new System.Drawing.Point(27, 137);
            this.btn_mes.Name = "btn_mes";
            this.btn_mes.Size = new System.Drawing.Size(172, 35);
            this.btn_mes.TabIndex = 50;
            this.btn_mes.Text = "Este mes";
            this.btn_mes.UseVisualStyleBackColor = false;
            // 
            // btn_año
            // 
            this.btn_año.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(11)))), ((int)(((byte)(49)))));
            this.btn_año.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_año.FlatAppearance.BorderSize = 0;
            this.btn_año.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_año.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_año.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_año.Location = new System.Drawing.Point(27, 195);
            this.btn_año.Name = "btn_año";
            this.btn_año.Size = new System.Drawing.Size(172, 35);
            this.btn_año.TabIndex = 51;
            this.btn_año.Text = "Este año";
            this.btn_año.UseVisualStyleBackColor = false;
            // 
            // VisorReporteV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 565);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisorReporteV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisorReporteV";
            this.Load += new System.EventHandler(this.VisorReporteV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrm;
        private System.Windows.Forms.Button btn_personalizar;
        private System.Windows.Forms.Button btm_guardarRV;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrm2;
        private System.Windows.Forms.Button btn_7dias;
        private System.Windows.Forms.Button btn_hoy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_RV1;
        private System.Windows.Forms.Button btn_año;
        private System.Windows.Forms.Button btn_mes;
    }
}