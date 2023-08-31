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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola FilaDePersonas = new clsCola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
           

            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;

            FilaDePersonas.Agregar(ObjNodo);
            FilaDePersonas.Recorrer(dgvCola);
            FilaDePersonas.Recorrer(lstCola);
            FilaDePersonas.Recorrer();

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
                FilaDePersonas.Recorrer(dgvCola);
                FilaDePersonas.Recorrer(lstCola);
                FilaDePersonas.Recorrer();
            }
            else
            {
                lblCodi.Text = "";
                lblNomb.Text = "";
                lblTrami.Text = "";
            }
        }

        private void frmCola_Load(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                txtNombre.Enabled = true;
                txtTramite.Enabled = true;
                btnAgregar.Enabled = true;
            }
        }
    }
}
