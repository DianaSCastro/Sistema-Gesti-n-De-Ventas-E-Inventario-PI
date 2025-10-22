using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
using CapaNegocio;
using CapaEntidad;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace Sistema_Ventas_Inventario_Papeleria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Load += Login_Load;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            // Agregar las opciones al ComboBox solo una vez cuando el formulario cargue
            login_rol.Items.Clear();  // Limpiamos cualquier ítem previo (en caso de que haya)
            login_rol.Items.Add("Administrador");
            login_rol.Items.Add("Empleado");
        }

        private void login_btn_Click(object sender, EventArgs e)
        {   
            string Correo = login_us.Text.Trim();
            string Contraseña = login_pass.Text.Trim();
            string NombreRol = login_rol.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(Correo) || string.IsNullOrEmpty(Contraseña) || string.IsNullOrEmpty(NombreRol))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valida al empleado según su nombre, contraseña y rol
            Empleado empleado = new CN_Empleado().ValidarEmpleado( Correo, Contraseña, NombreRol);

            if (empleado != null)
            {
                MessageBox.Show($"Bienvenido {empleado.NombreEmpleado}, Rol: {empleado.oTipoRol.NombreRol}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Crear una instancia del formulario MainForm, pasando el nombre de usuario y el rol
                MainForm form = new MainForm
                {
                    IdEmpleado = empleado.IdEmpleado,   // Asigna el nombre de usuario al formulario
                    EmpleadoRol = empleado.oTipoRol.NombreRol  // Asigna el rol de usuario al formulario
                };

                form.Show();
                this.Hide();  // Oculta el formulario de login
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos o tu estado podría estar desactivado, comunícate con tu administrador si es el caso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_pass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }
    }
}
