using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    public class Cuenta_Corriente : Cuento_Bancaria
    {
        private double Saldo;
        private double Porcentaje;
        private double Mantenimiento;

        public Cuenta_Corriente()
        {
        }
        public double getSaldo()
        {
            return Saldo;
        }
        public void setSaldo(double Saldo)
        {
            this.Saldo = Saldo;
        }
        public double getPorcentaje()
        {
            return Porcentaje;
        }
        public void setPorcentaje(double Porcentaje)
        {
            this.Porcentaje = Porcentaje;
        }
        public double getMantenimiento()
        {
            return Mantenimiento;
        }
        public void setMantenimiento(double Mantenimiento)
        {
            this.Mantenimiento = Mantenimiento;
        }

        public double Resul()
        {
            double Suma = this.Saldo + this.Porcentaje;
            double Resul = Suma - this.Mantenimiento;
            return Resul;
        }
    }
}