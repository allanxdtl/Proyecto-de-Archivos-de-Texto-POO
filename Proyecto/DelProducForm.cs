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
    public partial class DelProducForm : Form
    {
        List<string> productos = new List<string>();

        public DelProducForm()
        {
            InitializeComponent();
            try
            {
                StreamReader reader = File.OpenText("ArchivosTexto/menu.txt");
                int indice = 0;
                bool noleido = true;
                string linea;
                string[] separados;
                while (noleido)
                {
                    try
                    {
                        indice = dataGridView1.Rows.Add();
                        linea = reader.ReadLine();
                        productos.Add(linea);
                        separados = linea.Split(',');
                        dataGridView1.Rows[indice].Cells[0].Value = separados[0];
                        dataGridView1.Rows[indice].Cells[1].Value = separados[1];
                    }
                    catch
                    {
                        noleido = false;
                        reader.Close();
                    }
                }
            }
            catch (FileNotFoundException f)
            {
                MessageBox.Show(f.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("JAJAJJA, Mamaste");
                Application.Exit();
            }
        }

        private void bttnCerrarMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.SelectedRows[0].Index;
                productos.RemoveAt(index);
                try
                {
                    StreamWriter writer = File.CreateText("ArchivosTexto/menu.txt");
                    for(int i=0; i<productos.Count-1; i++)
                    {
                        writer.WriteLine(productos[i]);
                    }
                    writer.Close();
                    MessageBox.Show("El producto ha sido eliminado con exito");
                    DelProducForm ventana = new DelProducForm();
                    ventana.Show();
                    Close();
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("El archivo no ha sido encontrado");
                }
            }
            catch
            {
                MessageBox.Show("Por favor selecciona el renglon completo");
            }
        }
    }
}
