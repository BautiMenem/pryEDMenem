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
            string Sql = "SELECT Titulo FROM Libro";
            objCon.Listar(dgvBD, Sql);

        }

        private void brnInter_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT * FROM Libro WHERE idIdioma = 2 " +
                " and in " +
                "(SELECT * FROM Libro WHERE idIdioma = 7)";
            objCon.Listar(dgvBD, Sql);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {

             String varSQL = "SELECT * FROM libro WHERE IdAutor = 2 " +
                "UNION SELECT * FROM libro WHERE IdAutor = 5 " +
                "UNION SELECT * FROM libro WHERE IdAutor = 3";
            objCon.Listar(dgvBD, varSQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM libro WHERE IdIdioma " +
                "NOT IN " +
                "(SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5 ) ";
            objCon.Listar(dgvBD, varSQL);
        }

        private void btnSSimple_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT * FROM Libro WHERE idlibro > 20";
            objCon.Listar(dgvBD, Sql);
        }

        private void btnSMulti_Click(object sender, EventArgs e)
        {
            String Sql = "SELECT * FROM Libro WHERE idIdioma = 10 And idAutor = 2";
            objCon.Listar(dgvBD, Sql);
        }

        private void btnConv_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM " +
                "(SELECT * FROM Libro AS T1 WHERE T1.IdIdioma > 5 ) " +
                "AS T2 WHERE T2.IdAutor > 10";
            objCon.Listar(dgvBD, varSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM Libro, Idioma " +
                "WHERE Libro.IdIdioma = Idioma.IdIdioma";
            objCon.Listar(dgvBD, varSQL);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT * FROM Libro";
            objCon.Listar(dgvBD, Sql);
        }
    }
}
