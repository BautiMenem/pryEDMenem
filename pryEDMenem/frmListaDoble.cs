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
    }
}
