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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        clsPila FilaDePersonas = new clsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;

            FilaDePersonas.Agregar(ObjNodo);
            FilaDePersonas.Recorrer(dgvPila);
            FilaDePersonas.Recorrer(lstPila);
            

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (FilaDePersonas.Primero != null)
            {
                lblCodi.Text = FilaDePersonas.Primero.Codigo.ToString();
                lblNomb.Text = FilaDePersonas.Primero.Nombre;
                lblTrami.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvPila);
                FilaDePersonas.Recorrer(lstPila);
                
            }
            else
            {
                lblCodi.Text = "";
                lblNomb.Text = "";
                lblTrami.Text = "";
            }
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            validardatos();
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validardatos();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
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
