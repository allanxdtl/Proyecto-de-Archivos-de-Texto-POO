using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        //Lista estatica de las mesas, se utiliza para llevar la cuenta de manera global en todo el sistema
        public static List<ClsMesa> mesas = new List<ClsMesa>();

        //Variables para saber si una mesa esta ocupada o no
        //Si el valor es cero es porque esta desocupada
        int mesa1=0, mesa2=0, mesa3=0, mesa4=0, mesa5=0, mesa6=0, mesa7=0, mesa8=0, mesa9=0;
        bool activo = true;

        //Este método cambia el estado de la mesa
        private void CambiarEstadoDeMesa(string numeromesa ,ref int estado, ref Button mesa, ref ComboBox cmb)
        {
            if (estado == 0)
            {

                estado = 1;
                mesa.BackColor = Color.Red;
                cmb.Items.Add(numeromesa);
            }
            else
            {
                estado = 0;
                mesa.BackColor = Color.Lime;
            }
            
        }

        private void bttnAddMesa_Click(object sender, EventArgs e)
        {
            cmbMesa.Visible = true;
        }

        private void cerrarSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bttnMesa1_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeMesa("Mesa 1", ref mesa1, ref bttnMesa1, ref cmbMesa);
        }

        private void cmbMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbMesa.Text)
            {
                case "Mesa 1": mesas.Add(new ClsMesa("1")); break;
                case "Mesa 2": mesas.Add(new ClsMesa("2")); break;
                case "Mesa 3": mesas.Add(new ClsMesa("3")); break;
                case "Mesa 4": mesas.Add(new ClsMesa("4")); break;
                case "Mesa 5": mesas.Add(new ClsMesa("5")); break;
                case "Mesa 6": mesas.Add(new ClsMesa("6")); break;
                case "Mesa 7": mesas.Add(new ClsMesa("7")); break;
                case "Mesa 8": mesas.Add(new ClsMesa("8")); break;
                case "Mesa 9": mesas.Add(new ClsMesa("9")); break;
                default: MessageBox.Show("Ocurrio un error"); break;
            }
            MenuForm seleccionador = new MenuForm();
            seleccionador.Show();
            cmbMesa.Visible = false;
        }

        private void bttnMesa2_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeMesa("Mesa 2", ref mesa2, ref bttnMesa2, ref cmbMesa);
        }

        private void bttnMesa3_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeMesa("Mesa 3", ref mesa3, ref bttnMesa3, ref cmbMesa);
        }

        private void bttnMesa4_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeMesa("Mesa 4", ref mesa4, ref bttnMesa4, ref cmbMesa);
        }

        private void bttnMesa5_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeMesa("Mesa 5", ref mesa5, ref bttnMesa5, ref cmbMesa);
        }

        private void bttnMesa6_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeMesa("Mesa 6", ref mesa6, ref bttnMesa6, ref cmbMesa);
        }

        private void bttnMesa7_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeMesa("Mesa 7", ref mesa7, ref bttnMesa7, ref cmbMesa);
        }

        private void bttnMesa8_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeMesa("Mesa 8", ref mesa8, ref bttnMesa8, ref cmbMesa);
        }

        private void bttnMesa9_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeMesa("Mesa 9", ref mesa9, ref bttnMesa9, ref cmbMesa);
        }
    }
}
