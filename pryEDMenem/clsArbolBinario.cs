using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace pryEDMenem
{
    internal class clsArbolBinario
    {
        private clsNodo Inicio;
        public clsNodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }

        public void Agregar(clsNodo nvo)
        {
            nvo.Izquierda = null;
            nvo.Derecha = null;
            if (Raiz == null)
            {
                Raiz = nvo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo aux = Raiz;
                while (aux != null)
                {
                    NodoPadre = aux;
                    if (nvo.Codigo < aux.Codigo)
                    {
                        aux = aux.Izquierda;
                    }
                    else
                    {
                        aux = aux.Derecha;
                    }
                }
                if (nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierda = nvo;
                }
                else
                {
                    NodoPadre.Derecha = nvo;
                }
            }
        }

        private void InOrderAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierda != null) InOrderAsc(Dgv, R.Izquierda);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecha != null) InOrderAsc(Dgv, R.Derecha);
        }
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrderAsc(Grilla, Raiz);
        }

        private void PreOrd(DataGridView Dgv, clsNodo R)
        {
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierda != null) PreOrd(Dgv, R.Izquierda);         
            if (R.Derecha != null) PreOrd(Dgv, R.Derecha);
        }

        public void RecorrerPre(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrd(Grilla, Raiz);
        }

        private void PostOrd(DataGridView Dgv, clsNodo R)
        {          
            if (R.Izquierda != null) PostOrd(Dgv, R.Izquierda);
            if (R.Derecha != null) PostOrd(Dgv, R.Derecha);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

        public void RecorrerPost(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrd(Grilla, Raiz);
        }


        public void Recorrer()
        {  
            StreamWriter AD = new StreamWriter("ArbolBinario.csv", false, Encoding.UTF8);
            AD.WriteLine("Código;Nombre;Trámite");          
        }


    }
}
