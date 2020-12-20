using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
                public Form2()
        {
            InitializeComponent();
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "USUARIO")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.LightGray;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }


        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "CONTRASEÑA";
                txtusuario.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;

            }
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost; User Id=postgres; Password=123456;Database=juego;");
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                    String query = "SELECT * FROM usuario where nombre=@nombre and contraseña=@contraseña";
                    NpgsqlCommand funcion1 = new NpgsqlCommand(query, conexion);
                    funcion1.CommandType = CommandType.Text;
                    funcion1.Parameters.AddWithValue("@nombre", txtusuario.Text);
                    funcion1.Parameters.AddWithValue("@contraseña", txtpass.Text);
                    int count = Convert.ToInt32(funcion1.ExecuteScalar());
                    if (count == 1||count==2||count==3||count==4|| count == 5||count == 6 || count == 7 || count == 8 || count == 9 || count == 10)
                    {
                        Form4 juego = new Form4();
                        juego.Show();
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario incorrecto ");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexion.Close();
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Form3 juego1 = new Form3();
            juego1.Show();

        }
    }
}
