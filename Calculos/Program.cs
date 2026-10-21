using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreCliente;
            double saldo = 29090.99;
            double deposito;
            double saldoAct;

            Console.WriteLine("Ingrese su nombre");
            nombreCliente = Console.ReadLine();
            
            Console.WriteLine("Ingrese la cantidad a depositar");
            deposito = double.Parse(Console.ReadLine());

           saldoAct = (saldo + deposito);

            Console.WriteLine("================================");
            Console.WriteLine("     INFORMACIÓN DE DEPOSITO    ");
            Console.WriteLine("================================");

            Console.WriteLine($"Cliente: {nombreCliente}");
            Console.WriteLine($"Saldo anterior: {saldo}");
            Console.WriteLine($"Saldo actual: {saldoAct}");
            Console.WriteLine($"Monto depositado: {deposito}");


        }
    }
}
