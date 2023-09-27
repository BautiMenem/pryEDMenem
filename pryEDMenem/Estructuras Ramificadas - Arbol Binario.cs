using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            Codigos.Recorrer(cboCodigo);
            
           
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

        public void validardatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
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
            Codigos.Recorrer(dgvArbol);
            Codigos.Recorrer(tvArbol);
            Codigos.Recorrer(cboCodigo);
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            Codigos.Equilibrar();
            Codigos.Recorrer(dgvArbol);
            Codigos.Recorrer(tvArbol);
            Codigos.Recorrer(cboCodigo);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (rbIn.Checked)
            {
                Codigos.ExportarIn(dgvArbol);
            }
            else
            {
                if (rbPre.Checked)
                {
                    Codigos.ExportarPre(dgvArbol);
                }
                else
                {
                    if (rbPost.Checked)
                    {
                        Codigos.ExportarPost(dgvArbol);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una opcion de ordenamiento", "", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void frmEstructuras_Ramificadas___Arbol_Binario_Load(object sender, EventArgs e)
        {

        }

        private void cboCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCodigo.SelectedIndex != -1 )
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            validardatos();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // No permite caracteres que no sean números
            }
        }
    }
}
