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
        private string numeroDeMesa;
        private double Total;
        private bool cuentaCerrada;

        public string NumeroDeMesa
        {
            get { return numeroDeMesa; }
            set { numeroDeMesa = value; }
        }

        public bool CuentaCerrada
        {
            get { return cuentaCerrada; }
            set { cuentaCerrada = value; }
        }

        public double TotalAPagar
        {
            get { return Total; }
        }

        public ClsMesa(string numero)
        {
            Total = 0;
            numeroDeMesa = numero;
            cuentaCerrada = false;
            writer = File.CreateText($"ArchivosTexto/cuentaMesa{numero}.txt");
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
            cuentaCerrada = true;
        }
    }
}
