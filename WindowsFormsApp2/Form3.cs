using Npgsql;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }

        }

        private void txtctr_Leave(object sender, EventArgs e)
        {
            if (txtctr.Text == "CONTRASEÑA")
            {
                txtctr.Text = "";
                txtctr.ForeColor = Color.DimGray;
            }

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtctr.Text == "USUARIO")
            {
                txtctr.Text = "";
                txtctr.ForeColor = Color.DimGray;
            }

        }

        private void txtctr_Enter(object sender, EventArgs e)
        {
            if (txtctr.Text == "CONTRASEÑA")
            {
                txtctr.Text = "";
                txtctr.ForeColor = Color.LightGray;
            }

        }

        private void txtRegistro_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = txtUsuario.Text;
            usuario.Contraseña = txtctr.Text;
            usuario.ConContraseña = TXTpass.Text;

            try
            {

            
            Controlador controlador = new Controlador();
          string respuesta =  controlador.ctrRegistro(usuario);
            if (respuesta.Length > 0)
            {
                MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (TXTpass.Text == "CONFIRMAR CONTRASEÑA")
            {
                TXTpass.Text = "";
                TXTpass.ForeColor = Color.LightGray;
            }

        }

        private void TXTpass_Leave(object sender, EventArgs e)
        {
            if (TXTpass.Text == "CONFIRMAR CONTRASEÑA")
            {
                TXTpass.Text = "";
                TXTpass.ForeColor = Color.DimGray;
            }

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {

            Form2 juego2 = new Form2();
            juego2.Show();
        }

     

    }
}
