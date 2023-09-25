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
    public partial class frmEstructuras_Ramificadas___Arbol_Binario : Form
    {
        public frmEstructuras_Ramificadas___Arbol_Binario()
        {
            InitializeComponent();
        }
        clsArbolBinario Codigos = new clsArbolBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;

            Codigos.Agregar(ObjNodo);
            Codigos.Recorrer(dgvArbol);
            Codigos.Recorrer(tvArbol);
            
           
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void rbIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIn.Checked)
            {
                Codigos.Recorrer(dgvArbol);
            }
           
        }

        private void rbPre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPre.Checked)
            {
                Codigos.RecorrerPre(dgvArbol);
            }
        }

        private void rbPost_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPost.Checked)
            {
                Codigos.RecorrerPost(dgvArbol);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32(cboCodigo.Text);
            Codigos.Eliminar(Codigo);
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            Codigos.Equilibrar();
        }
    }
}
