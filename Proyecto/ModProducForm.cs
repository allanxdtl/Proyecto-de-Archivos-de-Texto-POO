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
    public partial class ModProducForm : Form
    {
        public ModProducForm()
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
            catch (FileNotFoundException)
            {
                MessageBox.Show("El archivo no ha sido encontrado");
            }
        }

        List<string> productos = new List<string>();

        private void bttnCerrarMod_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Primero guardo el producto modificado en la lista
                productos[dataGridView1.SelectedRows[0].Index] = $"{txtNombre.Text}, {txtPrecio.Text}";
                try
                {
                    //Aqui paso la lista modificada al archivo de texto sobreescribiendolo
                    StreamWriter writer = File.CreateText("ArchivosTexto/menu.txt");
                    for (int i = 0; i < productos.Count - 1; i++)
                    {
                        writer.WriteLine(productos[i]);
                    }
                    writer.Close();
                    MessageBox.Show("El producto ha sido modidicado con exito!", "Ya esta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Aqui se actualiza el menú modificado
                    dataGridView1.Rows.Clear();
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
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("El archivo no ha sido encontrado");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Ocurrio un error");
                }
            }
            catch
            {
                MessageBox.Show("Por favor selecciona el renglon completo", "Por favor...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Este sirve para mandar el contenido seleccionado a los textBox y que el usuario pueda modificarlo
            try
            {
                txtNombre.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtPrecio.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Por favor seleccione el renglon completo", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
