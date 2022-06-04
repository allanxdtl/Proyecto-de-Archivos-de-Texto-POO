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
    public partial class AddProducForm : Form
    {
        public AddProducForm()
        {
            InitializeComponent();
            string linea;
            string[] separados;
            bool noleido = true;
            try
            {
                reader = File.OpenText("ArchivosTexto/menu.txt");
                productos = new List<string>();
                while (noleido)
                {
                    try
                    {
                        linea = reader.ReadLine();
                        separados = linea.Split(',');
                        productos.Add(separados[0]);
                    }
                    catch
                    {
                        noleido = false;
                        reader.Close();
                    }
                }
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("El archivo no ha sido encontrado, intente de nuevo mas tarde");
            }
        }

        readonly StreamReader reader;
        StreamWriter writer;
        public static List<string> productos;

        private void bttnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                writer = File.AppendText("ArchivosTexto/menu.txt");
                string nombre = txtNombre.Text;
                bool encontrado = false;
                for (int i = 0; i < productos.Count; i++)
                {
                    if (productos[i].ToUpper() == nombre.ToUpper())
                    {
                        encontrado = true;
                    }
                }
                if (encontrado)
                {
                    MessageBox.Show("Este producto ya existe, si lo que desea es modificar su precio por " +
                        "favor vaya a la pestaña de Modificar Producto en la pestaña principal", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    writer.Close();
                    txtNombre.Text = null;
                    txtPrecio.Text = null;
                }
                else
                {
                    writer.WriteLine($"{nombre}, {txtPrecio.Text}");
                    writer.Close();
                    MessageBox.Show("El producto ha sido registrado con exito, para comprobarlo vaya a consultar el menú");
                    if (MessageBox.Show("Desea cerrar esta ventana?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Close();
                    }
                    else
                    {
                        txtNombre.Text = null;
                        txtPrecio.Text = null;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("El archivo no ha sido encontrado, favor de comunuicarse con el programador");
            }
        }
    }
}
