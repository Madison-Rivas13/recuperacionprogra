using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoCatalogo
{
    public partial class FormPrincipal : Form
    {
        string connectionString = "server=localhost;database=catalogoplaylist;user=madisson;password=abc123;";
        MySqlConnection connection;

        public FormPrincipal()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            CargarCatalogoPeliculas();
        }


        private void CargarCatalogoPeliculas()
        {
            string query = "SELECT Id, Titulo FROM catalogo";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["Titulo"].ToString());
                    item.Tag = reader["Id"];
                    lvPeliculas.Items.Add(item);
                }
                connection.Close();
            }
        }

        private void lvPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPeliculas.SelectedItems.Count > 0)
            {
                int CatalogoId = (int)lvPeliculas.SelectedItems[0].Tag;
                MostrarImagen(CatalogoId);
            }
        }

        private void MostrarImagen(int CatalogoId)
        {
            string query = "SELECT ImagenUrl FROM Catalogo WHERE Id = @CatalogoId";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@CatalogoId", CatalogoId);
                connection.Open();
                byte[] imageData = (byte[])cmd.ExecuteScalar();
                connection.Close();

                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pbPelicula.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbPelicula.Image = null;
                }
            }
        }

        private void lvPeliculas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CargarCatalogoPeliculas();
        }

        private void pbPelicula_Click(object sender, EventArgs e)
        {
            MostrarImagen();
        }

        private void MostrarImagen()
        {
            throw new NotImplementedException();
        }

        private void btnAgregarPelicula_Click(object sender, EventArgs e)
        {

        }
    }
}
