using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDMenem
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void datosLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola c = new frmCola();
            c.ShowDialog();
        }

        private void informacionDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos d = new frmDatos();
            d.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila p = new frmPila();
            p.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple l = new frmListaSimple();
            l.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble ld = new frmListaDoble();
            ld.ShowDialog();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuras_Ramificadas___Arbol_Binario Ar = new frmEstructuras_Ramificadas___Arbol_Binario();
            Ar.ShowDialog();
        }
    }
}
