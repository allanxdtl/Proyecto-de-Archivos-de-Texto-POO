using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto
{
    public partial class CuentaForm : Form
    {
        public CuentaForm()
        {
            InitializeComponent();
            int mesa = PrincipalForm.mesa;
            PrincipalForm.mesas[mesa].CerrarCuenta();
            StreamReader reader = File.OpenText($"ArchivosTexto/cuentaMesa{mesa+1}.txt");
            richTextBox1.Text = reader.ReadToEnd();
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            int mesa = PrincipalForm.mesa;
            MessageBox.Show($"Su cambio es de {Convert.ToInt32(txtPago.Text)- PrincipalForm.mesas[mesa].TotalAPagar}", "Cambio", MessageBoxButtons.OK);
            StreamWriter writer = File.AppendText("ArchivosTexto/CorteCaja.txt");
            writer.WriteLine($"{PrincipalForm.mesas[mesa].TotalAPagar}");
            writer.Close();
            Close();
            PrincipalForm.mesas[mesa].CuentaCerrada = true;
        }
    }
}
