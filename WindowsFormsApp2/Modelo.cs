using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Modelo
    {
        public int Registro(Usuario usuario)
        {
            NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost; User Id=postgres; Password=123456;Database=juego;");
            conexion.Open();
            string query = "INSERT INTO usuario(nombre,contraseña) VALUES (@nombre,@contraseña)";
            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }
        public bool existeUsuario(string usuario)
        {
            NpgsqlDataReader reader;
            NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost; User Id=postgres; Password=123456;Database=juego;");
            conexion.Open();
            string query = "SELECT idUsuario from usuario where nombre like @nombre";
            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombre", usuario);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
