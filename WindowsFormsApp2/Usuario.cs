using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Usuario
    {
        int id;
        string nombre, contraseña, conContraseña;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string ConContraseña { get => conContraseña; set => conContraseña = value; }
        public int Id { get => id; set => id = value; }
    }
}
