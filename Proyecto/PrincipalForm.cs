using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
            for(int i=0; i<9; i++)
            {
                mesas.Add(null);
            }
        }

        //Lista estatica de las mesas, se utiliza para llevar la cuenta de manera global en todo el sistema
        public static List<ClsMesa> mesas = new List<ClsMesa>();

        //Con esta variable puedo controlar que tipo de menu se vera de acuerdo a la seleccion del usuario
        public static bool menu = true;

        //Variables para saber si una mesa esta ocupada o no
        //Si el valor es cero es porque esta desocupada
        int mesa1=0, mesa2=0, mesa3=0, mesa4=0, mesa5=0, mesa6=0, mesa7=0, mesa8=0, mesa9=0;
        //Esta variable nos indica si alguna mesa esta ocupada
        public static int mesa;

        //Este método cambia el estado de la mesa
        private void CambiarEstadoDeMesa(string numeromesa ,ref int estado, ref Button mesa, ref ComboBox cmbAdd, ref ComboBox cmbCob)
        {
            if (estado == 0)
            {
                estado = 1;
                mesa.BackColor = Color.Red;
                switch (numeromesa)
                {
                    case "Mesa 1": mesas[0] = new ClsMesa("1"); break;
                    case "Mesa 2": mesas[1] = new ClsMesa("2"); break;
                    case "Mesa 3": mesas[2] = new ClsMesa("3"); break;
                    case "Mesa 4": mesas[3] = new ClsMesa("4"); break;
                    case "Mesa 5": mesas[4] = new ClsMesa("5"); break;
                    case "Mesa 6": mesas[5] = new ClsMesa("6"); break;
                    case "Mesa 7": mesas[6] = new ClsMesa("7"); break;
                    case "Mesa 8": mesas[7] = new ClsMesa("8"); break;
                    case "Mesa 9": mesas[8] = new ClsMesa("9"); break;
                    default: MessageBox.Show("Ocurrio un error"); break;
                }
                cmbAdd.Items.Add(numeromesa);
                cmbCob.Items.Add(numeromesa);
            }
            else
            {
                //Este bloque verifica si la mesa aun tiene la su cuenta abierta
                //Si es asi, no deja desactivar la mesa hasta que se pague
                string[] mesaArreglo = numeromesa.Split(' ');
                int index = Convert.ToInt32(mesaArreglo[1])-1;
                if (mesas[index] == null)
                {
                    MessageBox.Show("No puedes cambiar el estado de la mesa hasta que se cierre la cuenta");
                }
                else
                {
                    if (mesas[index].CuentaCerrada)
                    {
                        mesas[index] = null;
                        estado = 0;
                        mesa.BackColor = Color.Lime;
                        cmbAdd.Items.Remove(numeromesa);
                        cmbCob.Items.Remove(numeromesa);
                        lblEstado.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No es posible cambiar el estado de la mesa debido a que todavia tiene su cuenta abierta");
                    }
                }
            }
        }

        private bool VerificarEstado()
        {
            if (mesa1 == 1 || mesa2==1 || mesa3==1 || mesa4==1|| mesa5==1|| mesa6==1||mesa7==1||mesa8==1|mesa9==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void bttnAddMesa_Click(object sender, EventArgs e)
        {
            cmbMesa.Visible = true;
        }

        private void bttnCobrar_Click(object sender, EventArgs e)
        {
            cmbMesaCobrar.Visible = true;
        }

        private void cerrarSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VerificarEstado())
                MessageBox.Show("No es posible cerrar la aplicacion debido a que todavia hay mesas ocupadas, asegurese de " +
                    "cerrar las cuentas de esas mesas por favor", "No es posible cerrar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                Application.Exit();
        }

        private void cmbMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            menu = true;
            //Este bloque switch asigna el indice de la mesa a la variable estatica mesa
            //Con esta variable se puede identificar la mesa fue de esta forma y poder trabajar con ella
            //En este caso se pueden agregar productos a la mesa y cobrar la cuenta
            //El bloque switch de el otro comboBox tiene la misma finalidad
            switch (cmbMesa.Text)
            {
                case "Mesa 1": mesa = 0; break;
                case "Mesa 2": mesa = 1; break;
                case "Mesa 3": mesa = 2; break;
                case "Mesa 4": mesa = 3; break;
                case "Mesa 5": mesa = 4; break;
                case "Mesa 6": mesa = 5; break;
                case "Mesa 7": mesa = 6; break;
                case "Mesa 8": mesa = 7; break;
                case "Mesa 9": mesa = 8; break;
            }
            MenuForm seleccionador = new MenuForm();
            seleccionador.Show();
            cmbMesa.Visible = false;
        }

        private void cmbMesaCobrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbMesaCobrar.Text)
            {
                case "Mesa 1": mesa = 0; break;
                case "Mesa 2": mesa = 1; break;
                case "Mesa 3": mesa = 2; break;
                case "Mesa 4": mesa = 3; break;
                case "Mesa 5": mesa = 4; break;
                case "Mesa 6": mesa = 5; break;
                case "Mesa 7": mesa = 6; break;
                case "Mesa 8": mesa = 7; break;
                case "Mesa 9": mesa = 8; break;
            }
            CuentaForm cuenta = new CuentaForm();
            cuenta.Show();
            switch (cmbMesaCobrar.Text)
            {
                case "Mesa 1": lblEstado.Text = "La mesa 1 se acaba de desocupar, desactivala"; break;
                case "Mesa 2": lblEstado.Text = "La mesa 2 se acaba de desocupar, desactivala"; break;
                case "Mesa 3": lblEstado.Text = "La mesa 3 se acaba de desocupar, desactivala"; break;
                case "Mesa 4": lblEstado.Text = "La mesa 4 se acaba de desocupar, desactivala"; break;
                case "Mesa 5": lblEstado.Text = "La mesa 5 se acaba de desocupar, desactivala"; break;
                case "Mesa 6": lblEstado.Text = "La mesa 6 se acaba de desocupar, desactivala"; break;
                case "Mesa 7": lblEstado.Text = "La mesa 7 se acaba de desocupar, desactivala"; break;
                case "Mesa 8": lblEstado.Text = "La mesa 8 se acaba de desocupar, desactivala"; break;
                case "Mesa 9": lblEstado.Text = "La mesa 9 se acaba de desocupar, desactivala"; break;
            }
            cmbMesaCobrar.Visible = false;
        }

        private void verMenúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrincipalForm.menu = false;
            MenuForm menu = new MenuForm();
            menu.Show();
        }

        private void bttnMesa1_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeMesa("Mesa 1", ref mesa1, ref bttnMesa1, ref cmbMesa, ref cmbMesaCobrar);
        }

        private void bttnMesa2_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeMesa("Mesa 2", ref mesa2, ref bttnMesa2, ref cmbMesa, ref cmbMesaCobrar);
        }

        private void bttnMesa3_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeMesa("Mesa 3", ref mesa3, ref bttnMesa3, ref cmbMesa, ref cmbMesaCobrar);
        }

        private void bttnMesa4_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeMesa("Mesa 4", ref mesa4, ref bttnMesa4, ref cmbMesa, ref cmbMesaCobrar);
        }

        private void bttnMesa5_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeMesa("Mesa 5", ref mesa5, ref bttnMesa5, ref cmbMesa, ref cmbMesaCobrar);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            lblEstado.Text = "Verde significa desocupado, rojo siginifa ocupado";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            lblEstado.Text = "";
        }

        private void bttnMesa6_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeMesa("Mesa 6", ref mesa6, ref bttnMesa6, ref cmbMesa, ref cmbMesaCobrar);
        }

        private void bttnMesa7_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeMesa("Mesa 7", ref mesa7, ref bttnMesa7, ref cmbMesa, ref cmbMesaCobrar);
        }

        private void bttnMesa8_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeMesa("Mesa 8", ref mesa8, ref bttnMesa8, ref cmbMesa, ref cmbMesaCobrar);
        }

        private void bttnMesa9_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeMesa("Mesa 9", ref mesa9, ref bttnMesa9, ref cmbMesa, ref cmbMesaCobrar);
        }

        private void añadirProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProducForm add = new AddProducForm();
            add.Show();
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModProducForm mod = new ModProducForm();
            mod.Show();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelProducForm del = new DelProducForm();
            del.Show();
        }

        private void verCorteDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorteDeCajaForm corte = new CorteDeCajaForm();
            corte.Show();
        }
    }
}
