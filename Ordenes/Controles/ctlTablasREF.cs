using System;
using System.Data;
using System.Windows.Forms;
using Ordenes.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace Ordenes.Controles
{

    public partial class ctlTablasREF : UserControl
    {
        //Instancias_variables de la clase
        #region Instancias-Variables
        clsRefAcabado objAcabadoREF = new clsRefAcabado();
        clsRefCobertura objCoberturaREF = new clsRefCobertura();
        _Comunes objComunes = new _Comunes();
        #endregion

        public ctlTablasREF()
        {
            InitializeComponent();
        }

        private void ctlTablasREF_Load(object sender, EventArgs e)
        {
            _acabadoInicia();
            _coberturaInicia();
        }

        private DataRow _getDataRow(GridView grilla)
        {
            if (grilla.IsValidRowHandle(grilla.FocusedRowHandle))
            {
                return grilla.GetDataRow(grilla.FocusedRowHandle);
            }
            return null;
        }


        //ACABADOS
        #region acabados

        //Carga los acabados
        #region acabadoInicia
        private void _acabadoInicia()
        {
            DataTable dtTallas = objAcabadoREF._acabadoCargaTalla();
            DataTable dtAreaA = objAcabadoREF._acabadoCargaArea();
            objComunes._cargaCtlCMBGRID(aca_rilueCodTalla, dtTallas,"Descripcion","CodTalla");
            objComunes._cargaCtlCMBGRID(aca_rilueAreaAplica, dtAreaA);
            aca_gcAcabados.DataSource = objAcabadoREF._acabadoCargaDET();
        }
        #endregion

        //boton guardar acabados
        #region btnGuardar
        private void aca_btnGuardar_Click(object sender, EventArgs e)
        {
            if (objAcabadoREF._acabadoValidar())
            {
                objAcabadoREF._acabadoGuardar();
            }
        }
        #endregion

        //Cambia el valor de una celda
        #region CellValueChanged
        private void aca_gvAcabados_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            objAcabadoREF._acabadoUpdate(_getDataRow(aca_gvAcabados));
        }
        #endregion

        //Elimina un registro de acabados
        #region mnuEliminaREG
        private void aca_mnuEliminaAcabado_Click(object sender, EventArgs e)
        {
            objAcabadoREF._acabadoEliminar(_getDataRow(aca_gvAcabados));
        }
        #endregion

        #endregion

        //COBERTURAS
        #region cobertura

        //Carga las coberturas
        #region coberturaInicia
        private void _coberturaInicia()
        {
            cob_gcCobertura.DataSource = objCoberturaREF._coberturaCargaDET();
        }
        #endregion

        //Guarda las coberturas
        #region btnGuardaCobertua
        private void cob_btnGuardar_Click(object sender, EventArgs e)
        {
            if (objCoberturaREF._coberturaValidar())
            {
                objCoberturaREF._coberturaGuardar();
            }
        }
        #endregion

        //Cambia valor de una celda
        #region cob_gvCobertura_CellValueChanged
        private void cob_gvCobertura_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            objCoberturaREF._coberturaUpdate(_getDataRow(cob_gvCobertura));
        }
        #endregion

        //Elimina las coberturas
        #region eliminaCobertura
        private void cob_mnuEliminaCobertura_Click(object sender, EventArgs e)
        {
            objCoberturaREF._coberturaElimina(_getDataRow(cob_gvCobertura));
        }
        #endregion

        #endregion

    }

}
