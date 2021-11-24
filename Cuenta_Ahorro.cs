using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    public class Cuenta_Ahorro : Cuento_Bancaria
    {
        private double Saldo_C;
        private double Porcentaje;

        public Cuenta_Ahorro()
        {
        }
        public void setSaldo_C(double Saldo_C)
        {
            this.Saldo_C = Saldo_C;
        }
        public double getSaldo_C()
        {
            return Saldo_C;
        }
        public void setPorcentaje(double Porcentaje)
        {
            this.Porcentaje = Porcentaje;
        }
        public double getPorcentaje()
        {
            return Porcentaje;
        }
        public double Calcular()
        {
            double Calcular = this.Porcentaje * this.Saldo_C;
            return Calcular;
        }
    }
}