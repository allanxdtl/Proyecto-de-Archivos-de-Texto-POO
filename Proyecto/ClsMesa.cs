using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto
{
    public class ClsMesa
    {
        private StreamWriter writer;
        private string NumeroDeMesa;
        private double Total;

        public ClsMesa(string numero)
        {
            Total = 0;
            NumeroDeMesa = numero;
            writer = File.AppendText($"cuentaMesa{numero}.txt");

        }

        public void AñadirProducto(string nombre, double costo)
        {
            Total += costo;
            writer.WriteLine($"{nombre}, {costo}");
        }

        public void CerrarCuenta()
        {
            writer.WriteLine($"Total a pagar: {Total}");
            writer.Close();
        }
    }
}
