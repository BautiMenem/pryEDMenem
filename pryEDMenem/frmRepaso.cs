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
    public partial class frmRepaso : Form
    {
        public frmRepaso()
        {
            InitializeComponent();
        }

        private void frmRepaso_Load(object sender, EventArgs e)
        {
            cboOperacion.SelectedIndex = 0;
        }

        clsConexionaBD objBd = new clsConexionaBD();
        private void btnListar_Click(object sender, EventArgs e)
        {
            String VarSQL = "SELECT * FROM LIBRO";
            switch (cboOperacion.SelectedIndex)
            {
                case 0:
                    txtRepaso.Text = cboOperacion.Text + ":" + "" +
                        "Paises que no tienen libros";
                    VarSQL = " select * from pais where " + "idpais not in " +
                        "(select idpais from libro)";
                    objBd.Listar(dgvDatos, VarSQL);
                    break;
            }
        }
    }
}
