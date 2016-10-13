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
using dllMensaje;
using AutomatizerSQL.Utilidades;

namespace Ordenes.Controles
{
    public partial class ctlEstadoCotizacion : UserControl
    {
        clsEstadoCOT objEstadoCOT = new clsEstadoCOT();
        _Comunes objComun = new _Comunes();

        public ctlEstadoCotizacion()
        {
            InitializeComponent();
        }

        private void ctlEstadoCotizacion_Load(object sender, EventArgs e)
        {
            deFechaDesde.DateTime = DateTime.Now.AddDays(-30);
            deFechaHasta.DateTime = DateTime.Now;
            _inicializa();
            
            _cargaDET();
        }

        private void _inicializa()
        {
            //COMBO MOTIVOS RECHAZO
            DataTable dtMotivoRechaza = objComun._cargaDataCMB(optionsCMB.Rechaza_Cotiza);
            objComun._cargaCtlCMB(lueMotivoRechaza,dtMotivoRechaza);
            //COMBO ESTADO COTIZACION
            DataTable dtEstadoCOT = objComun._GetDataTableCOT();
            objComun._cargaCtlCMB(lueEstado, dtEstadoCOT);
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

        private void btnArpobar_Click(object sender, EventArgs e)
        {
            objEstadoCOT._actualizar(2, 0, meObservaciones.Text.Trim());
            _cargaDET();
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            if (lueMotivoRechaza.EditValue != null && lueMotivoRechaza.EditValue != DBNull.Value
                && lueMotivoRechaza.EditValue.ToString().Trim() != "" && meObservaciones.Text.Trim() != "")
            {
                objEstadoCOT._actualizar(3, lueMotivoRechaza.EditValue.ToInt(), meObservaciones.Text.Trim());
                _cargaDET();
            }
            else
            {
                clsMensaje._msjWarning("Cuando rechaza una cotización es obligatorio seleccionar una razón e ingresar una descripción en observaciones", "Rechazar");
            }
        }
    }
}
