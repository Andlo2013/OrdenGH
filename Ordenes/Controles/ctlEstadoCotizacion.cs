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

        //Inicializa el formulario
        #region inicializa
        private void _inicializa()
        {
            //COMBO MOTIVOS RECHAZO
            DataTable dtMotivoRechaza = objComun._cargaDataCMB(optionsCMB.Rechaza_Cotiza);
            objComun._cargaCtlCMB(lueMotivoRechaza,dtMotivoRechaza);
            //COMBO ESTADO COTIZACION
            DataTable dtEstadoCOT = objComun._GetDataTableCOT();
            objComun._cargaCtlCMB(lueEstado, dtEstadoCOT);
        }
        #endregion

        //Carga el detalle
        #region cargaDET
        private void _cargaDET()
        {
            DataTable dtLista= objEstadoCOT._cargaDET(deFechaDesde.DateTime,deFechaHasta.DateTime,
                lueEstado.EditValue, chkPorCliente.Checked, chkPorEstado.Checked);
            gc_ListaCotizaciones.DataSource = dtLista;
            lblTotalREG.Text = "Total Registros: ";
            lblTotalREG.Text += dtLista!=null? dtLista.Rows.Count.ToString():"0";
        }
        #endregion

        //boton cargar detalle
        #region btnCargaDET
        private void btnCargaDET_Click(object sender, EventArgs e)
        {
            _cargaDET();
        }
        #endregion

        //buscar cliente
        #region beCliente
        private void beCliente_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            beCliente.Text=objEstadoCOT._buscaCLI();
        }
        #endregion

        //boton aprobar
        #region btnAprobar
        private void btnAprobar_Click(object sender, EventArgs e)
        {
            objEstadoCOT._actualizar(2, 0, meObservaciones.Text.Trim());
            _cargaDET();
        }
        #endregion

        //boton rechazar
        #region Rechazar
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
        #endregion


    }
}
