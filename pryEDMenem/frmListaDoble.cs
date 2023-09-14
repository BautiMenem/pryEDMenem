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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {

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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            validardatos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validardatos();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            validardatos();
        }

        private void cboCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCodigo.Text != "")
            {
                btnEliminar.Enabled = true;
                mrcListarD.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
                mrcListarD.Enabled = false;
            }
        }
        clsListaDoble Codigos = new clsListaDoble();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;

            Codigos.Agregar(ObjNodo);
            Codigos.Recorrer(dgvListaD);
            Codigos.Recorrer(lstListaD);
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
                Codigos.Recorrer(dgvListaD);
                Codigos.Recorrer(lstListaD);
                Codigos.Recorrer(cboCodigo);
                Codigos.Recorrer();

            }

        }

        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAscendente.Checked)
            {
                Codigos.Recorrer(dgvListaD);
                Codigos.Recorrer(lstListaD);
                Codigos.Recorrer(cboCodigo);
            }
        }

        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDescendente.Checked)
            {
                Codigos.RecorrerDes(dgvListaD);
                Codigos.RecorrerDes(lstListaD);
                Codigos.RecorrerDes(cboCodigo);
            }
        }
    }
}
