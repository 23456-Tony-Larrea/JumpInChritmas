using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Controlador
    {
        public string ctrRegistro (Usuario usuario)  {
            Modelo modelo = new Modelo();
            string respuesta = "";
            if (string.IsNullOrEmpty(usuario.Nombre)||string.IsNullOrEmpty(usuario.Contraseña)|| string.IsNullOrEmpty(usuario.ConContraseña))
                {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if (usuario.Contraseña==usuario.ConContraseña)
                {
                    if (modelo.existeUsuario(usuario.Nombre))
                    {
                        respuesta = "El nombre ya existe";
                    }
                    else
                    {
                        usuario.Contraseña = usuario.Contraseña;
                        modelo.Registro(usuario);
                    }
                }
                else
                {
                    respuesta = "las contraseñas no coinciden";
                }   
            }
            return respuesta; 
        }
        //public static string GetSHA1(String texto)
        //{
        //    SHA1 sha1 = SHA1CryptoServiceProvider.Create();
        //    Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(texto);
        //    Byte[] hash = sha1.ComputeHash(textOriginal);
        //    StringBuilder cadena = new StringBuilder();
        //    foreach (byte i in hash)
        //    {
        //        cadena.AppendFormat("{0:x2}", i);
        //    }
        //    return cadena.ToString();
        //}
    }
}
