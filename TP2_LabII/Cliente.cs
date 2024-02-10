using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_LabII
{
    [Serializable]
    public class Cliente
    {
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contraseña { get; set; }
        public string CorreoElectronico { get; set; }
        public int Dni { get; set; }

        public Cliente(string nombre, string apellido, int dni, string correoElectronico, string contraseña, string usuario)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(correoElectronico))
            {
                throw new ArgumentException("El nombre, apellido y correo electrónico son campos obligatorios.");
            }

            if (!EsDniValido(dni))
            {
                throw new ArgumentException("El DNI no es válido.");
            }

            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            CorreoElectronico = correoElectronico;
            Contraseña = contraseña;
            Usuario = usuario;
        }

        public string ObtenerDatosCompletos()
        {
            return $"Nombre: {Nombre}, Apellido: {Apellido}, DNI: {Dni}, Correo Electrónico: {CorreoElectronico}";
        }

        public override string ToString()
        {
            return $"{Nombre};{Apellido};{Dni};{CorreoElectronico};{Contraseña};{Usuario}";
        }

        private bool EsDniValido(int dni)
        {
            string dniString = dni.ToString();
            return dniString.Length == 8 && dniString.All(char.IsDigit);
        }
    }

}
