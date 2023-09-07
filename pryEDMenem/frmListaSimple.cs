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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple Codigos = new clsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;

            Codigos.Agregar(ObjNodo);
            Codigos.Recorrer(dgvLista);
            Codigos.Recorrer(lstLista);
            Codigos.Recorrer(cboCodigo);
            Codigos.Recorrer();


            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            

            if (Codigos.Primero != null)
            {
                Int32 Codigo = Convert.ToInt32(cboCodigo.Text);
                Codigos.Eliminar(Codigo);
                Codigos.Recorrer(dgvLista);
                Codigos.Recorrer(lstLista);
                Codigos.Recorrer(cboCodigo);
                Codigos.Recorrer();

            }
           
        }

        private void mrcElemento_Enter(object sender, EventArgs e)
        {

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

        private void cboCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCodigo.Text != "")
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }
    }
}
