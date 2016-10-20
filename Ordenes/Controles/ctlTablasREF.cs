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
        clsRefPlacas objPlacasREF = new clsRefPlacas();
        clsRefTipoColor objTipoColorREF = new clsRefTipoColor();
        clsRefPliegoEXT objPliegoEXTREF = new clsRefPliegoEXT();
        clsRefProcesoIMP objProcesoIMPREF = new clsRefProcesoIMP();
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
            _placaInicia();
            _tipocolorInicia();
            _pextraInicia();
            _pextraInicia();
            _pimpInicia();
        }

        //Recupera el datarow de una fila de una grilla
        #region getDataRow
        private DataRow _getDataRow(GridView grilla)
        {
            if (grilla.IsValidRowHandle(grilla.FocusedRowHandle))
            {
                return grilla.GetDataRow(grilla.FocusedRowHandle);
            }
            return null;
        }
        #endregion

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
                _acabadoInicia();
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
                _coberturaInicia();
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

        //PLACAS
        #region placas

        //Carga las placas
        #region placaInica
        private void _placaInicia()
        {
            pla_gcPlacas.DataSource = objPlacasREF._placaCargaDET();
        }
        #endregion

        //Guarda las placas
        #region placaGuadar
        private void pla_btnGuarda_Click(object sender, EventArgs e)
        {
            if (objPlacasREF._placaValidar())
            {
                objPlacasREF._placaGuardar();
                _placaInicia();
            }
        }
        #endregion

        //Cambia el valor de una celda
        #region pla_gvPlacas_CellValueChanged
        private void pla_gvPlacas_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            objPlacasREF._placaUpdate(_getDataRow(pla_gvPlacas));
        }
        #endregion

        //Elimina una placa
        #region placaElimina
        private void pla_mnuEliminaPlaca_Click(object sender, EventArgs e)
        {
            objPlacasREF._placaElimina(_getDataRow(pla_gvPlacas));
        }

        #endregion

        #endregion

        //TIPO COLOR
        #region tipoColor

        // carga los tipos de color
        #region tipocolorInicia
        private void _tipocolorInicia()
        {
            tipcol_gcTipoColor.DataSource = objTipoColorREF._tipocolorCargaDET();
        }
        #endregion

        //guarda los tipos de color
        #region tipoColorGuardar
        private void tipcol_btnGuardar_Click(object sender, EventArgs e)
        {
            if (objTipoColorREF._tipocolorValidar())
            {
                objTipoColorREF._tipocolorGuardar();
                _tipocolorInicia();
            }
        }
        #endregion

        //elimina los tipos de color
        #region tipocolorElimina
        private void tipcol_mnuEliminaColor_Click(object sender, EventArgs e)
        {
            objTipoColorREF._tipocolorElimina(_getDataRow(tipcol_gvTipoColor));
        }
        #endregion

        //cambia el valor de la celda de tipos de color
        #region tipcol_gvTipoColor_CellValueChanged
        private void tipcol_gvTipoColor_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            objTipoColorREF._tipocolorUpdate(_getDataRow(tipcol_gvTipoColor));
        }
        #endregion

        #endregion

        //PLIEGOS EXTRA
        #region pliegoExtra

        //Carga los combos de pliegos extra
        #region pextInicia
        private void _pextraInicia()
        {
            DataTable dtGrupos=objComunes._cargaDataCMB(optionsCMB.Grupo);
            DataTable dtComponente = objComunes._cargaDataCMB(optionsCMB.Diseno_Seccion);
            objComunes._cargaCtlCMB(pext_lueGrupo, dtGrupos);
            objComunes._cargaCtlCMB(pext_lueComponente, dtComponente);

        }
        #endregion

        //carga el detalle de pliegos extra
        #region pextCargaDET
        private void _pextraCargaDET()
        {
            pext_gcPliegoEXT.DataSource = objPliegoEXTREF._pextCargaDET(pext_lueGrupo.EditValue, pext_lueComponente.EditValue);
        }
        #endregion

        //boton agrega material
        #region pext_btnAgregaMAT
        private void pext_btnAgregaMAT_Click(object sender, EventArgs e)
        {
            objPliegoEXTREF._pextAgregaMAT();
        }
        #endregion

        //boton guarda material
        #region pext_btnGuarda
        private void pext_btnGuarda_Click(object sender, EventArgs e)
        {
            if (objPliegoEXTREF._pextValida())
            {
                objPliegoEXTREF._pextGuarda(pext_lueGrupo.EditValue, pext_lueComponente.EditValue);
            }
        }
        #endregion

        //cambia el combo grupo
        #region pext_lueGrupo_EditValueChanged
        private void pext_lueGrupo_EditValueChanged(object sender, EventArgs e)
        {
            _pextraCargaDET();
        }
        #endregion

        //cambia el combo componente
        #region pext_lueComponente_EditValueChanged
        private void pext_lueComponente_EditValueChanged(object sender, EventArgs e)
        {
            _pextraCargaDET();
        }
        #endregion

        //cmnuAgrega registro detalle
        #region pext_mnuAgregaRegistro_Click
        private void pext_mnuAgregaRegistro_Click(object sender, EventArgs e)
        {
            objPliegoEXTREF._pextAgregaMAT();
        }
        #endregion

        //cmnuElimina registro detalle
        #region pext_mnuEliminaPEXT_Click
        private void pext_mnuEliminaPEXT_Click(object sender, EventArgs e)
        {
            objPliegoEXTREF._pextElimina(_getDataRow(pext_gvPliegoEXT));
        }
        #endregion


        #endregion

        //COSTO DE LOS PROCESOS DE IMPRESION
        #region PROCESO-IMPRESION

        //INICIA LOS PROCESOS DE IMPRESION
        #region _pimpInicia
        private void _pimpInicia()
        {
            DataTable dtCMBMaquina = objProcesoIMPREF._pimpCargaPlaca();
            objComunes._cargaCtlCMB(pimp_lueMaquina, dtCMBMaquina,"Placa","Codigo");

        }
        #endregion

        //CARGA EL DETALLE DE LOS PROCESOS DE IMPRESION
        #region _pimpCargaDET
        private void _pimpCargaDET()
        {
            pimp_gcDetalle.DataSource = objProcesoIMPREF._pimpCargaDET(pimp_lueMaquina.EditValue);
        }
        #endregion

        //boton AGREGA-GRUPO-MATERIAL
        #region pimp_btnAgregaMAT_Click
        private void pimp_btnAgregaMAT_Click(object sender, EventArgs e)
        {
            objProcesoIMPREF._pimpAgregaGRP();
        }
        #endregion

        //boton Guarda
        #region pimp_btnGuardar_Click
        private void pimp_btnGuardar_Click(object sender, EventArgs e)
        {
            if (objProcesoIMPREF._pimpValidar())
            {
                objProcesoIMPREF._pimpGuardar(pimp_lueMaquina.EditValue);
            }
        }
        #endregion

        //CAMBIA EL COMBO DE PROCESOS DE IMPRESION
        #region pimp_lueMaquina_EditValueChanged
        private void pimp_lueMaquina_EditValueChanged(object sender, EventArgs e)
        {
            _pimpCargaDET();
        }
        #endregion

        //cmnu AGREGA-GRUPO-MATERIAL
        #region pimp_mnuAgregaREGPIMP_Click
        private void pimp_mnuAgregaREGPIMP_Click(object sender, EventArgs e)
        {
            objProcesoIMPREF._pimpAgregaGRP();
        }
        #endregion

        //cmenu Elimina un registro
        #region pimp_mnuEliminaREGPIMP_Click
        private void pimp_mnuEliminaREGPIMP_Click(object sender, EventArgs e)
        {
            objProcesoIMPREF._pimpEliminaREG(_getDataRow(pimp_gvDetalle));
        }
        #endregion

        #endregion

    }

}
