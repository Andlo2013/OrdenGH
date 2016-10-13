using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ordenes.Clases;

namespace Ordenes.Controles
{
    public partial class ctlEstadoCotizacion : UserControl
    {
        clsEstadoCOT objEstadoCOT = new clsEstadoCOT();

        public ctlEstadoCotizacion()
        {
            InitializeComponent();
        }

        private void ctlEstadoCotizacion_Load(object sender, EventArgs e)
        {
            deFechaDesde.DateTime = DateTime.Now.AddDays(-30);
            deFechaHasta.DateTime = DateTime.Now;
            _Comunes objComun = new _Comunes();
            DataTable dtEstadoCOT= objComun._cargaDataCMB(optionsCMB.Estado_Cotizacion);
            objComun._cargaCtlCMB(lueEstado, dtEstadoCOT);
            _cargaDET();
        }

        private void _cargaDET()
        {
            DataTable dtLista= objEstadoCOT._cargaDET(deFechaDesde.DateTime,deFechaHasta.DateTime,
                lueEstado.EditValue, chkPorCliente.Checked, chkPorEstado.Checked);
            gc_ListaCotizaciones.DataSource = dtLista;
            lblTotalREG.Text = "Total Registros: ";
            lblTotalREG.Text += dtLista!=null? dtLista.Rows.Count.ToString():"0";
        }

        private void btnCargaDET_Click(object sender, EventArgs e)
        {
            _cargaDET();
        }

        private void beCliente_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            beCliente.Text=objEstadoCOT._buscaCLI();
        }
    }
}
