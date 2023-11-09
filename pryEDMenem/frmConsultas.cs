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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (txtConsulta.Text != "")
            {
                btnListar.Enabled = true;
            }
            clsConexionaBD objBase = new clsConexionaBD();
            objBase.Listar(dgvDatos, txtConsulta.Text);
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {

        }
    }
}
