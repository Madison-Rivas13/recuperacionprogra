using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;

namespace proyectoCatalogo
{
    public partial class Form1 : Form
    {
        string connectionString = "server=localhost;database=catalogoplaylist;user=madisson;password=abc123;";
        MySqlConnection connection;

        public Form1()
                
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void RegistrarUsuario(string nombreUsuario, string contrasena)
        {
            string query = "INSERT INTO Usuarios (NombreUsuario, Contrasena) VALUES (@NombreUsuario, @Contrasena)";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        private bool IniciarSesion(string nombreUsuario, string contrasena)
        {
            string query = "SELECT COUNT(1) FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND Contrasena = @Contrasena";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                connection.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();
                return count == 1;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)


        {
                string nombreUsuario = txtNombreUsuario.Text;
                string contrasena = txtContrasena.Text;

                
                if (IniciarSesion(nombreUsuario, contrasena))
                {
                    MessageBox.Show("Inicio de sesión exitoso.");
                   
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
                }
          
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }







   



}


   
        

       


