using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    public class Cuento_Bancaria
    {
        private int Num_Cuenta;
        private string Nombre_Titular;

        public Cuento_Bancaria()
        {
        }

        public string getNombre_Titular()
        {
            return Nombre_Titular;
        }
        public void setNombre_Titilar(string Nombre_Titualar)
        {
            this.Nombre_Titular = Nombre_Titualar;
        }
        public int getNum_Cuenta()
        {
            return Num_Cuenta;
        }
        public void setNum_Cuenta(int Num_Cuenta)
        {
            this.Num_Cuenta = Num_Cuenta;
        }
    }
}