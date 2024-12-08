using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pJGestionEventos.Presentacion.Reportes
{
    public partial class rfmReporte : Form
    {
        public rfmReporte()
        {
            InitializeComponent();
        }

        private void rfmReporte_Load(object sender, EventArgs e)
        {
            this.sP_LISTAR_VISITANTESTableAdapter.Fill(this.dataSet1.SP_LISTAR_VISITANTES, cBuscar:txtFiltrar.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
