using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace pryEDMenem
{
    internal class clsConexionaBD
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataAdapter adapter = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLED.4.0;Data Source=Libreria.mdb";
        private string varCadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";


        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = varCadenaConexion;
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM LIBRO";

                DataSet DS = new DataSet();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(DS, "Resultado");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Tabla1"];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        public void Listar(DataGridView Grilla, String varInstruccionSQL)
        {
            try
            {
                conexion.ConnectionString = varCadenaConexion;
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = varInstruccionSQL;

                DataSet DS = new DataSet();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(DS, "Resultado");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Resultado"];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
    }
}
