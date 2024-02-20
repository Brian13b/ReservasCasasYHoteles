using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_LabII
{
    [Serializable]
    public class Habitacion
    {
        public string Tipo { get; set; }
        public int Numero { get; set; }
        public bool Disponible { get; set; }

        private static int numero = 10;

        public Habitacion(string tipo)
        {
            Tipo = tipo;
            Disponible = true;

            if (tipo == "Simple")
                Numero = 100 + numero;

            else if (tipo == "Doble")
            {
                Numero = 200 + numero;
            }

            else if (tipo == "Triple")
            {
                Numero = 300 + numero;
            }

            numero++;   
        }

        public double Incremento()
        {
            double incremento = 1;

            if (Tipo == "Doble")
            {
                incremento = 1.8; 
            }
            else if (Tipo == "Triple")
            {
                incremento = 2.5; 
            }

            return incremento;
        }
    }   
}
