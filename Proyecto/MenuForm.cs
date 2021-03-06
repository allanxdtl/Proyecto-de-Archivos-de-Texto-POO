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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            if (PrincipalForm.menu)
            {
                bttnAddProducto.Visible = true;
                label1.Text = "Favor de seleccionar el producto por favor";
                bttnCerrarMenu.Location=new Point(214,342);
            }
            else
            {
                bttnAddProducto.Visible = false;
                label1.Text = "Productos disponibles para vender";
                bttnCerrarMenu.Location = new Point(101, 342);
            }
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
            catch(FileNotFoundException f)
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
    
        private void bttnAddProducto_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.SelectedRows[0].Index;
                string producto = dataGridView1.Rows[index].Cells[0].Value.ToString();
                double costo = Convert.ToDouble(dataGridView1.Rows[index].Cells[1].Value);
                PrincipalForm.mesas[PrincipalForm.mesa].AñadirProducto(producto, costo);
            }
            catch
            {
                MessageBox.Show("Por favor selecciona el renglon completo","Por favor...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
