using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuento_Bancaria cuento_Bancaria = new Cuento_Bancaria();
            cuento_Bancaria.getNombre_Titular();
            cuento_Bancaria.setNombre_Titilar("Karen Tumbaco");
            cuento_Bancaria.getNum_Cuenta();
            cuento_Bancaria.setNum_Cuenta(25492547);
            Console.WriteLine("El nombre del la cuenta bancaria {0} con su numero de cuenta bancaria {1}", cuento_Bancaria.getNombre_Titular(),cuento_Bancaria.getNum_Cuenta());
            Cuenta_Corriente cuenta_Corriente = new Cuenta_Corriente();
            cuenta_Corriente.getSaldo();
            cuenta_Corriente.setSaldo(200);
            cuenta_Corriente.getPorcentaje();
            cuenta_Corriente.setPorcentaje(0.5);
            cuenta_Corriente.getMantenimiento();
            cuenta_Corriente.setMantenimiento(0.1);
            Console.WriteLine("Su saldo en la ceunta corriente es de :"+cuenta_Corriente.Resul());
            Cuenta_Ahorro cuenta_Ahorro = new Cuenta_Ahorro();
            cuenta_Ahorro.getPorcentaje();
            cuenta_Ahorro.setPorcentaje(0.05);
            cuenta_Ahorro.getSaldo_C();
            cuenta_Ahorro.setSaldo_C(200);
            Console.WriteLine("Su saldo en la cuenta de ahorro es de :" + cuenta_Ahorro.Calcular());
            cuenta_Ahorro.Calcular();
            Console.ReadLine();
        }
    }
}
