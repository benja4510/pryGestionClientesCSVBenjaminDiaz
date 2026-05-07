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

        private struct RegClientes
        {
            public Int32 Codigo;
            public String Nombre;
            public Decimal Deuda;
            public Decimal Limite;
        }

        private RegClientes[] VecClientes = new RegClientes[1500];
        private Int32 IND = 0;

        private void CargarVector()
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];
            IND = 0;

            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //Leer
            DatosLeidos = AD.ReadLine();


            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                VecClientes[IND].Codigo = Convert.ToInt32(VecDatos[0]);
                VecClientes[IND].Nombre = VecDatos[1];
                VecClientes[IND].Deuda = Convert.ToDecimal(VecDatos[2]);
                VecClientes[IND].Limite = Convert.ToDecimal(VecDatos[3]);
                IND++;
                DatosLeidos = AD.ReadLine();
            }
            // Cerrar;
            AD.Close();
            AD.Dispose();

        }
        private void OrdenarVector()
        {
            RegClientes aux;

            for (Int32 c = 0; c < IND - 1; c++)


                for (Int32 i = 0; i < IND - 1; i++) //Recorre el Vector
                {
                    if (VecClientes[i].Codigo > VecClientes[i + 1].Codigo)
                    {
                        aux = VecClientes[i];
                        VecClientes[i] = VecClientes[i + 1];
                        VecClientes[i + 1] = aux;
                    }
                }
        }
        private void ReescribirArchivo()
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, false);

            for (Int32 i = 0; i < IND; i++)
            {
                AD.Write(VecClientes[i].Codigo);
                AD.Write(";");
                AD.Write(VecClientes[i].Nombre);
                AD.Write(";");
                AD.Write(VecClientes[i].Deuda);
                AD.Write(";");
                AD.WriteLine(VecClientes[i].Limite);
            }
            AD.Close();
            AD.Dispose();


        }

        public void OrdenarArchivo()
        {
            CargarVector();
            OrdenarVector();
            ReescribirArchivo();

        }


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


                if (Convert.ToUInt32(VecDatos[2]) > 0)
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
        public void GenerarReporte()
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];

            Int32 cantidad= 0;
            Decimal total = 0; 

            StreamWriter Reporte = new StreamWriter("Reporte.csv",false,Encoding.UTF8);

            Reporte.WriteLine("Listado de Clientes");
            Reporte.WriteLine("");
            Reporte.WriteLine("Codigo;Nombre;Deuda;Limite");


            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);

            //Cargar o leer
            DatosLeidos = AD.ReadLine();
          
           
            while (DatosLeidos != null)
            {
                //Separar los datos     
                VecDatos = DatosLeidos.Split(';');

                Reporte.Write(VecDatos[0]);
                Reporte.Write(";");
                Reporte.Write(VecDatos[1]);
                Reporte.Write(";");
                Reporte.Write(VecDatos[3]);
                Reporte.Write(";");
                Reporte.WriteLine(VecDatos[2]);



                // Agregar a la grilla
                DatosLeidos = AD.ReadLine();
                //contador
                cantidad++;
                //suma
                total = total + Convert.ToDecimal(VecDatos[2]);
            }

            //Cerrar
            AD.Close();
            AD.Dispose();
            Reporte.WriteLine("");
            Reporte.Write("Total Deuda:;;");
            Reporte.WriteLine(total);
            Reporte.Write("Cantidad de Clientes:;;");
            Reporte.WriteLine(cantidad);
            Reporte.Write("Promedio de Deuda:;;");
            Reporte.WriteLine(total/cantidad);

            Reporte.Close();
            Reporte.Dispose();
        }
    }
    
}