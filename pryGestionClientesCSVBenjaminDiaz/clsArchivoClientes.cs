using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryGestionClientesCSVBenjaminDiaz
{
    internal class clsArchivoClientes
    {
        public string NombreArchivo = "Clientes.csv";


        public void Grabar(string cod, string nom, string deu, string lim)
        {
            //Abrir
            StreamWriter AD = new StreamWriter(NombreArchivo, true);

            //Cargar o leer
            AD.Write(cod);
            AD.Write(";");
            AD.Write(nom);
            AD.Write(";");
            AD.Write(deu);
            AD.Write(";");
            AD.Write(lim);
            AD.WriteLine(";");

            //Cerrar
            AD.Close();
            AD.Dispose();

        }



        public void Listar(DataGridView Grilla)
        {

            string DatosLeidos;
            string[] VecDatos = new string[4];
            


            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);

            //Cargar o leer
            DatosLeidos = AD.ReadLine();
            // mientras haya datos, mostrar
            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {
                //Separar los datos     
                VecDatos = DatosLeidos.Split(';');
                // Agregar a la grilla
                Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3]);
                DatosLeidos = AD.ReadLine();
            }
                
            //Cerrar
            AD.Close();
            AD.Dispose();
        }
    }
}   