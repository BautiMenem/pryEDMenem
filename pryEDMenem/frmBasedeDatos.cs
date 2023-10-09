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
    public partial class frmBasedeDatos : Form
    {
        public frmBasedeDatos()
        {
            InitializeComponent();
        }

        clsConexionaBD objCon = new clsConexionaBD();
        private void btnSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO" + 
                "FROM LIBRO" + "ORDER BY 1 DESC";
            objCon.Listar(dgvBD, varSQL);
        }

        private void brnInter_Click(object sender, EventArgs e)
        {
            String varSQL = "Select * from libro" + "where idIdioma = 2 and "
                + "idlibro in" + "(Select idlibro from libro where IdPais = 3)" +
                "order by 1 asc";
            objCon.Listar(dgvBD, varSQL);
        }
    }
}
