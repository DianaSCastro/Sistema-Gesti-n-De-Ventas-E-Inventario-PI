using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sistema_Ventas_Inventario_Papeleria
{

    public partial class MainForm : Form
    {
        public int IdEmpleado { get; set; } // 'admin' o 'empleado'
        public string EmpleadoRol {  get; set; }
        public string Username { get; set; } // Propiedad para recibir el nombre de usuario
       
        // Variable para almacenar la posición del mouse
        private Point _lastPoint;

        public MainForm()
        {
            InitializeComponent();
         
            customDesing();
            //ConfigurarModulos(); // Configura los módulos según el rol

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConfigurarModulos();

            label2.Text = IdEmpleado.ToString(); // Muestra el nombre de usuario en label2
            if (EmpleadoRol == "Administrador")
            {
                txt_MenuUsuario.Text = "ADMINISTRADOR";
            }
            else if (EmpleadoRol == "Empleado")
            {
                txt_MenuUsuario.Text = "EMPLEADO";
            }

        }
        private void customDesing()
        {

            panel_submenu.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panel_submenu.Visible == true)
                panel_submenu.Visible = false; 
        }

        private void showsubmenu(Panel subMenu)

        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

            }

        private void ConfigurarModulos()
        {
            // Verifica el rol del usuario y oculta los módulos no permitidos
            if (EmpleadoRol == "Empleado")
            {
                // Oculta botones o módulos exclusivos de administrador
                btn_GestEmpleados.Visible = false;
                btn_GestClientes.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                btn_GestProductos.Visible = false;
                btn_inventario.Visible = false;
                pictureBox3.Visible = false;
                picBox_inventario.Visible = false;


            }
            else if (EmpleadoRol == "Administrador")
            {
                // Asegúrate de que todos los módulos estén visibles para el administrador
                btn_GestEmpleados.Visible = true;
                btn_GestClientes.Visible = true;
            }
        }


        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            frmVentas ventasForm = new frmVentas(EmpleadoRol, IdEmpleado);
           

            // Limpiar el panel antes de agregar el formulario nuevo
            if (panel_conector.Controls.Count > 0)
                panel_conector.Controls.RemoveAt(0);

            // Crear una instancia del formulario de ventas pasando el rol del usuario
            frmVentas formularioVentas = new frmVentas(EmpleadoRol,IdEmpleado);
            formularioVentas.TopLevel = false;
            formularioVentas.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            panel_conector.Controls.Add(formularioVentas);
            panel_conector.Tag = formularioVentas;

            // Mostrar el formulario de ventas
            formularioVentas.Show();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            // Guarda la posición donde se presionó el mouse
            _lastPoint = e.Location;
        }
        // Evento para capturar la posición del mouse al hacer clic
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        // Evento para mover el formulario cuando se arrastra
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            // Si el botón izquierdo del mouse está presionado
            if (e.Button == MouseButtons.Left)
            {
                // Mueve el formulario a la nueva posición del mouse
                this.Location = new Point(
                    this.Left + (e.X - _lastPoint.X),
                    this.Top + (e.Y - _lastPoint.Y)
                );
            }
        }

        // Si deseas que el formulario sea movido al arrastrar desde cualquier parte
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            // Se puede agregar aquí algo si deseas realizar alguna acción después de soltar el mouse
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void btn_GestEmpleados_Click(object sender, EventArgs e)
        {

            // Limpiar el panel antes de agregar el formulario nuevo
            if (panel_conector.Controls.Count > 0)
                panel_conector.Controls.RemoveAt(0);

            // Crear una instancia del formulario de empleados
            Empleados formularioEmpleados = new Empleados();
            formularioEmpleados.TopLevel = false;
            formularioEmpleados.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            panel_conector.Controls.Add(formularioEmpleados);
            panel_conector.Tag = formularioEmpleados;

            // Mostrar el formulario de empleados
            formularioEmpleados.Show();
        }


        private void panel_conector_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_GestClientes_Click(object sender, EventArgs e)
        {
            if (panel_conector.Controls.Count > 0)
                panel_conector.Controls.RemoveAt(0);

            // Crear una instancia del formulario de ventas
            Clientes formularioClientes = new Clientes();
            formularioClientes.TopLevel = false;
            formularioClientes.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            panel_conector.Controls.Add(formularioClientes);
            panel_conector.Tag = formularioClientes;

            // Mostrar el formulario de ventas
            formularioClientes.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_GestProductos_Click(object sender, EventArgs e)
        {
            // Verifica si ya hay un formulario en el panel y lo elimina si es necesario
            if (panel_conector.Controls.Count > 0)
                panel_conector.Controls.RemoveAt(0);

            // Crear una instancia del formulario de productos con el rol de usuario
            Productos formularioProductos = new Productos(EmpleadoRol);
            formularioProductos.TopLevel = false;
            formularioProductos.Dock = DockStyle.Fill;

            // Agregar el formulario al panel y configurarlo para que se ajuste
            panel_conector.Controls.Add(formularioProductos);
            panel_conector.Tag = formularioProductos;

            // Mostrar el formulario de productos
            formularioProductos.Show();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            // Aquí puedes limpiar las variables relacionadas con la sesión
            Username = ""; // Limpiar nombre de usuario
            EmpleadoRol = ""; // Limpiar rol

            // Ocultar el MainForm (o cualquier formulario en el que estés)
            this.Hide();

            // Crear una nueva instancia del formulario de login
            Login loginForm = new Login();

            // Mostrar el formulario de login
            loginForm.Show();
        }

        private void txt_MenuUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            //showsubmenu(panel_submenu);
            // Verifica si ya hay un formulario en el panel y lo elimina si es necesario
            if (panel_conector.Controls.Count > 0)
                panel_conector.Controls.RemoveAt(0);

            // Crear una instancia del formulario de productos con el rol de usuario
            Inventario formularioInventario = new Inventario();
            formularioInventario.TopLevel = false;
            formularioInventario.Dock = DockStyle.Fill;

            // Agregar el formulario al panel y configurarlo para que se ajuste
            panel_conector.Controls.Add(formularioInventario);
            panel_conector.Tag = formularioInventario;

            // Mostrar el formulario de productos
            formularioInventario.Show();
        }

       
        private void subtn_adminInven_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
        }

        private void panel_submenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void subtn_stock_Click(object sender, EventArgs e)
        {
            //hideSubMenu();

            //// Verifica si ya hay un formulario en el panel y lo elimina si es necesario
            //if (panel_conector.Controls.Count > 0)
            //    panel_conector.Controls.RemoveAt(0);

            //// Crear una instancia del formulario de productos con el rol de usuario
            //Inventario formularioInventario = new Inventario ();
            //formularioInventario.TopLevel = false;
            //formularioInventario.Dock = DockStyle.Fill;

            //// Agregar el formulario al panel y configurarlo para que se ajuste
            //panel_conector.Controls.Add(formularioInventario);
            //panel_conector.Tag = formularioInventario;

            //// Mostrar el formulario de productos
            //formularioInventario.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void picBox_inventario_Click(object sender, EventArgs e)
        {

        }
    }
}
