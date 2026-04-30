using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionClientesCSVBenjaminDiaz
{
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }
        clsArchivoClientes x = new clsArchivoClientes();

        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            x.Listar(dgvDatos);
            lblCantidadClientes.Text = x.CantidadClientes().ToString();
            lblTotalDeuda.Text = x.DeudaClientes().ToString();
            lblPromedioDeuda.Text = x.PromedioDeudad().ToString();

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            x.GenerarReporte();
            MessageBox.Show("Reporte generado correctamente", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
