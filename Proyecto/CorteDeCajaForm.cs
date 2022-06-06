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
    public partial class CorteDeCajaForm : Form
    {
        public CorteDeCajaForm()
        {
            InitializeComponent();
            StreamReader reader = File.OpenText("ArchivosTexto/CorteCaja.txt");
            List<int> vendido=new List<int>();
            string linea=reader.ReadLine();
            richTextBox1.Text += linea+Environment.NewLine;
            bool noleido = true;
            while (noleido)
            {    
                if (linea != null)
                {
                    linea = reader.ReadLine();
                    richTextBox1.Text += linea + Environment.NewLine;
                    vendido.Add(Convert.ToInt32(linea));
                }
                else 
                {
                    reader.Close();
                    noleido = false;
                }
            }
            richTextBox1.Text += $"Se ha vendido hoy: {vendido.Sum().ToString()}";
        }

        private void bttnCerrarVentana_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Escriba el nombre del archivo y seleccione donde desea que se guarde";
            try
            {
                saveFileDialog1.ShowDialog();
                if (File.Exists(saveFileDialog1.FileName))
                {
                    string nombre = saveFileDialog1.FileName;
                    StreamWriter saveArchivo = File.CreateText(nombre);
                    saveArchivo.Write(richTextBox1.Text);
                    saveArchivo.Flush();
                    saveArchivo.Close();
                    MessageBox.Show("El archivo ha sido guardado con exito","El archivo se guardo");
                }
                else
                {
                    string nombre = saveFileDialog1.FileName;
                    StreamWriter saveArchivo = File.CreateText(nombre);
                    saveArchivo.Write(richTextBox1.Text);
                    saveArchivo.Flush();
                    saveArchivo.Close();
                    MessageBox.Show("El archivo ha sido guardado con exito", "El archivo se guardo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al intentar guardar, intente de nuevo al guardar");
            }
        }

        private void verOtroCorteDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Busque el archivo que desea abrir";
            try
            {
                openFileDialog1.ShowDialog();
                if (File.Exists(openFileDialog1.FileName))
                {
                    string archivo = openFileDialog1.FileName;
                    TextReader read = new StreamReader(archivo);
                    richTextBox1.Text = read.ReadToEnd();
                    read.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al intentar abrir el archivo, vuelve a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
