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
        Decimal Total = 0;
        Int32 C = 0;


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


        public Int32 CantidadClientes()
        {
            string DatosLeidos;
            Int32 C = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                C++;

                DatosLeidos = AD.ReadLine();

            }

            AD.Close();
            AD.Dispose();
            return C;
        }
        public Decimal DeudaClientes()
        {
            string[] VecDatos = new string[4];
            string DatosLeidos;
            Decimal Total = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                Total = Total + Convert.ToDecimal(VecDatos[2]);

                DatosLeidos = AD.ReadLine();

            }

            AD.Close();
            AD.Dispose();
            return Total;


        }
        public Decimal PromedioDeudad()
        {
            string[] VecDatos = new string[4];
            string DatosLeidos;
            Decimal Total = 0;
            Int32 C = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                C++;
                VecDatos = DatosLeidos.Split(';');
                Total = Total + Convert.ToDecimal(VecDatos[2]);

                DatosLeidos = AD.ReadLine();

            }

            AD.Close();
            AD.Dispose();
            return Total / C;
        }
        public Decimal PromedioDeudad2()
        {

            Decimal Total = 0;
            Int32 C = 0;


            return Total / C;
        }
        public void ListarDeudores(DataGridView Grilla)
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

                
                if (Convert.ToUInt32(VecDatos[2])> 0) 
                {
                    Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3]);

                }

                // Agregar a la grilla
                DatosLeidos = AD.ReadLine();
            }

            //Cerrar
            AD.Close();
            AD.Dispose();
        }
    }
}