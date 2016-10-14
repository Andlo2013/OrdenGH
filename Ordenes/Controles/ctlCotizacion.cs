using System;
using System.Data;
using System.Windows.Forms;
using Ordenes.Clases;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using Ordenes.Modelos;
using dllMensaje;
using AutomatizerSQL.Utilidades;
using DevExpress.XtraGrid.Views.Grid;

namespace Ordenes.Controles
{
    public partial class ctlCotizacion : UserControl
    {
        clsCotizacion objCotiza = new clsCotizacion();
        _Comunes objComunes = new _Comunes();
        cotizaMOD model_Cotiza = new cotizaMOD();
        blockMOD model_Block = new blockMOD();
        private string m_accion = "";

        public ctlCotizacion()
        {
            InitializeComponent();
        }

        private void ctlCotizacion_Load(object sender, EventArgs e)
        {
            _estadoControles(false);
            _inicializa();
        }

        //METODOS DEL FORMULARIO
        #region METODOS

        //carga un LookUpEdit
        #region cargaLookUpEdit
        private void _cargaLookUpEdit(LookUpEdit[] lueCombos, optionsCMB opcion)
        {
            DataTable dtCombo = objComunes._cargaDataCMB(opcion);
            foreach (LookUpEdit lueCombo in lueCombos)
            {
                objComunes._cargaCtlCMB(lueCombo, dtCombo);
            }
        }
        #endregion

        //Carga LookUpEditGrilla
        #region cargaLookUpEditGRID
        private void _cargaLookUpEditGRID(RepositoryItemLookUpEdit[] lueCombos, optionsCMB opcion)
        {
            DataTable dtCombo = objComunes._cargaDataCMB(opcion);
            foreach (RepositoryItemLookUpEdit lueCombo in lueCombos)
            {
                objComunes._cargaCtlCMBGRID(lueCombo, dtCombo);
            }
        }
        #endregion

        //Habilita o bloquea los controles
        #region estadoControles
        private void _estadoControles(bool estado)
        {
            //CABECERA
            barraStandar._OptionState(!estado, estado, !estado, estado, !estado, false);
            barraStandar._navigationToolState(false);

            beNumeroCOT.Properties.Buttons[0].Enabled = !estado;
            beNombreCLI.Properties.Buttons[0].Enabled = estado;
            beArticulo.Properties.Buttons[0].Enabled = false;
            beArticulo.Properties.ReadOnly = !estado;
            deFechaENT.Properties.ReadOnly = !estado;
            seAlto.Enabled = seAncho.Enabled = seTiraje.Enabled = estado;
            lueLineaPRD.Properties.ReadOnly = lueGrupo.Properties.ReadOnly = lueSubgrupo.Properties.ReadOnly = !estado;
            beEplVendedor.Properties.Buttons[0].Enabled = estado;
            //grilla cliente
            cli_gcColDireccion.OptionsColumn.AllowEdit = estado;
            cli_gcColCantidad.OptionsColumn.AllowEdit = estado;

            //grilla armados
            arm_gcColPliegoEXTPorcentaje.OptionsColumn.AllowEdit = estado;
            arm_gcColNumPaginas.OptionsColumn.AllowEdit = estado;
            arm_gcColAltoTrabajoF.OptionsColumn.AllowEdit = estado;
            arm_gcColAnchoTrabajoF.OptionsColumn.AllowEdit = estado;
            arm_gcColPaginasXtrabajo.OptionsColumn.AllowEdit = estado;

            //grilla color
            col_gcColLado.OptionsColumn.AllowEdit = estado;
            col_gcColTipoColor.OptionsColumn.AllowEdit = estado;
            col_gcColCobertura.OptionsColumn.AllowEdit = estado;
            col_gcColNumPaginasC.OptionsColumn.AllowEdit = estado;
            col_gcColDetallePAG.OptionsColumn.AllowEdit = estado;

            //grilla placas
            pla_gcColLadoP.OptionsColumn.AllowEdit = estado;
            pla_gcColNumColoresP.OptionsColumn.AllowEdit = estado;
            pla_gcColNumPlacasP.OptionsColumn.AllowEdit = estado;

            //grilla troquel
            tro_gcColLongitud.OptionsColumn.AllowEdit = estado;
            tro_gcColNumCortesT.OptionsColumn.AllowEdit = estado;

            //grilla accesorios
            acce_gcColCantidadS.OptionsColumn.AllowEdit = estado;
            acce_gcColTirajeS.OptionsColumn.AllowEdit = estado;

            //grilla procesos
            proc_gcColMinutos.OptionsColumn.AllowEdit = estado;

            //grilla materiales cliente
            mcli_gcColCantidadCLI.OptionsColumn.AllowEdit = estado;

            //pestana blocks
            blo_txtSerie.ReadOnly = blo_lueTipoEmblocado.ReadOnly = !estado;
            blo_seInicia.Enabled = blo_seTermina.Enabled = blo_seJuegos.Enabled = estado;
            blo_gcColColor.OptionsColumn.AllowEdit = estado;

            //Menus contextuales
            cmClienteSUC.Enabled = cmDisenoGeneralGH.Enabled = cmDisenoGeneralORI.Enabled = estado;
            cmDisenoMatARMDIS.Enabled = cmDisenoColor.Enabled = cmDisenoTroquel.Enabled = estado;
            cmDisenoAcabado.Enabled = cmDisenoAccesorios.Enabled = cmDisenoProcesos.Enabled = estado;
            cmClienteMAT.Enabled = cmBlock.Enabled = estado;

        }
        #endregion

        //Forza la actualizacion
        #region forceUpdate
        private void _forceUpdate(GridView dgvToForce)
        {
            txtCIRUCCLI.Focus();
            dgvToForce.Focus();
        }
        #endregion

        //Recupera una fila de una grilla
        #region getDataRow
        private DataRow _getDataRow(GridView gvGrilla)
        {
            if (gvGrilla.IsValidRowHandle(gvGrilla.FocusedRowHandle))
            {
                DataRow row = gvGrilla.GetDataRow(gvGrilla.FocusedRowHandle);
                return row;
            }
            return null;
        }
        #endregion

        //Carga inicial de controles
        #region inicializa
        private void _inicializa()
        {
            //CARGA LÍNEAS DE PRODUCCIÓN
            _cargaLookUpEdit(new LookUpEdit[] { lueLineaPRD }, optionsCMB.Linea_Produccion);

            //CARGA EL COMBO DE COMPONENTES
            _cargaLookUpEdit(new LookUpEdit[] { dis_lueComponente }, optionsCMB.Diseno_Seccion);

            //COMBO LADO-IMPRESION
            _cargaLookUpEditGRID(new RepositoryItemLookUpEdit[] { dis_rilueLadoImpresion,
                dis_rilueLadoImpresionP }, optionsCMB.Lado_Impresion);

            //COMBO COLOR-PLANCHA
            objCotiza._disenoColorCargaPlanchas(dis_rilueTipoColor);

            //COMBO COBERTURA
            objCotiza._disenoColorCargaCobertura(dis_rilueCobertura);

            //COMBO COLOR-HOJA
            _cargaLookUpEditGRID(new RepositoryItemLookUpEdit[] { blo_rilueColorCopia }, optionsCMB.Color_Hoja);

            //COMBO TIPO DE EMBLOCADO
            _cargaLookUpEdit(new LookUpEdit[] { blo_lueTipoEmblocado, }, optionsCMB.TipoBloque);


        }
        #endregion

        //Limpia los controles y propiedades de los modelos
        #region LimpiarControles
        private void _LimpiarControles()
        {
            beNumeroCOT.Text = "";
            deFechaCOT.EditValue = DateTime.Now;
            txtCIRUCCLI.Text = beNombreCLI.Text = beArticulo.Text = "";
            seAncho.EditValue = seAlto.EditValue = 10;
            deFechaENT.EditValue = DateTime.Now.AddDays(1);
            txtEplCotizador.Text = beEplVendedor.Text = "";
            chkEstadoREG.Checked = true;

            dis_seGramosColor.Value = dis_seGramosMetalizado.Value = dis_seGramosPantone.Value = 0;
            blo_txtSerie.Text = "";
            blo_seInicia.Value = blo_seTermina.Value = blo_seJuegos.Value = 0;

            cli_gcDestinos.DataSource = cli_gcContactos.DataSource = null;
            tot_gcTotales.DataSource = null;
            gen_gcGraficasH.DataSource = gen_gcOriginales.DataSource = null;
            arm_gcArmados.DataSource = col_gcColores.DataSource = pla_gcPlacas.DataSource = null;
            tro_gcTrqouel.DataSource = aca_gcAcabados.DataSource = acce_gcAccesorios.DataSource = null;
            proc_gcProcesos.DataSource = procimp_gcProcesoIMP.DataSource = mcli_gcMaterialCLI.DataSource = null;
            blo_gcCopias.DataSource = null;

            if (model_Cotiza != null)
            {
                model_Cotiza.CodigoCLI = model_Cotiza.id = model_Cotiza.Cotizacion = -1;
                model_Cotiza.TotalCOT = 0;
            }
        }
        #endregion

        //Valida que ingresen solo numeros en un textedit
        #region SoloNumeros
        private void _SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false
                && e.KeyChar != 13 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        #endregion

        //Calcula los totales de la cotizacion
        #region Totales
        private void _totales()
        {
            tot_gcTotales.DataSource = objCotiza._totales();
            if (model_Cotiza != null)
            {
                model_Cotiza.TotalCOT = objCotiza._TotalGEN();
            }
        }
        #endregion

        //Validaciones
        #region Validar
        private bool _Validar()
        {
            bool isValid = true;
            if (blo_seInicia.Value > blo_seTermina.Value)
            {
                decimal aux = blo_seInicia.Value;
                blo_seInicia.Value = blo_seTermina.Value;
                blo_seTermina.Value = aux;
            }
            if (!model_Cotiza._isValid())
            {
                clsMensaje._msjWarning(model_Cotiza.pro_getErrrors, "Verificar datos");
                isValid = false;
            }

            isValid = isValid && objCotiza._clienteDESTValida(model_Cotiza.Tiraje);
            isValid = isValid && objCotiza._disenoArmadoValida();
            isValid = isValid && objCotiza._disenoColorValida();
            isValid = isValid && objCotiza._disenoPlacaValida();
            isValid = isValid && objCotiza._disenoTroquelValida();
            isValid = isValid && objCotiza._disenoAcabadoValida();
            isValid = isValid && objCotiza._disenoAccesoriosValida();
            isValid = isValid && objCotiza._disenoProcesoValida();
            isValid = isValid && objCotiza._disenoProcesoIMPValida();
            isValid = isValid && objCotiza._disenoMATCLIValida();
            return isValid;
        }
        #endregion

        //Carga los detalles
        #region Métodos-CargaDetalles

        //Método principal para cargar el detalle
        #region CargaDetalle
        private void _CargaDetalle()
        {
            _clienteCarga();
            _blockCarga();
            _disenoCarga();

        }
        #endregion

        //Pestaña blocks
        #region Block-Detalles
        private void _blockCarga()
        {
            //carga la cabecera del block
            model_Block = model_Block._cargaBlock(model_Cotiza.id);
            blo_txtSerie.EditValue = model_Block.Serie;
            blo_seInicia.EditValue = model_Block.Inicia;
            blo_seTermina.EditValue = model_Block.Termina;
            blo_seJuegos.EditValue = model_Block.Juego;
            blo_lueTipoEmblocado.EditValue = model_Block.CmbEmblocado;
            //carga los colores de las copias
            blo_gcCopias.DataSource = objCotiza._blockColorCargaDET(model_Cotiza.id);
        }
        #endregion

        //Pestaña clientes
        #region Cliente-Detalles
        private void _clienteCarga()
        {
            cli_gcDestinos.DataSource = objCotiza._clienteCargaDEST(model_Cotiza.id);
            cli_gcContactos.DataSource = objCotiza._clienteCargaTEL(model_Cotiza.CodigoCLI);
        }
        #endregion

        //Pestaña diseño
        #region Tablas-Diseno

        //carga los detalles del diseno
        private void _disenoCarga()
        {
            //dis_gcArmados.DataSource = objCotiza._disenoArmadoCargaDET(model_Cotiza.id,model_Cotiza.Tiraje);
            objCotiza._disenoArmadoCargaDET(model_Cotiza.id, model_Cotiza.Tiraje, model_Cotiza.Grupo);
            objCotiza._disenoColorCargaDET(model_Cotiza.id, model_Cotiza.Tiraje);
            objCotiza._disenoPlacaCargaDET(model_Cotiza.id);
            objCotiza._disenoTroquelCargaDET(model_Cotiza.id);
            objCotiza._disenoAcabadoCargaDET(model_Cotiza.id);
            objCotiza._disenoProcesoIMPCargaDET(model_Cotiza.id);
            objCotiza._disenoAccesoriosCargaDET(model_Cotiza.id);
            objCotiza._disenoGeneralDET(model_Cotiza.id);
            proc_gcProcesos.DataSource = objCotiza._disenoProcesoCargaDET(model_Cotiza.id);
            gen_gcGraficasH.DataSource = objCotiza.pro_disenoGeneralGH;
            gen_gcOriginales.DataSource = objCotiza.pro_disenoGeneralORI;
            mcli_gcMaterialCLI.DataSource = objCotiza._disenoMATCLICargaDET(model_Cotiza.id);
            //para que cargue solo lo del combo
            _disenoFiltrar();
            _totales();
        }

        //filtra los detalles del diseno de acuerdo a la opcion seleccionada en componente
        private void _disenoFiltrar()
        {
            arm_gcArmados.DataSource = objCotiza._disenoArmadoFiltrar(dis_lueComponente.EditValue.ToInt());
            col_gcColores.DataSource = objCotiza._disenoColorFiltrar(dis_lueComponente.EditValue.ToInt());
            pla_gcPlacas.DataSource = objCotiza._disenoPlacaFiltrar(dis_lueComponente.EditValue.ToInt());
            tro_gcTrqouel.DataSource = objCotiza._disenoTroquelFiltrar(dis_lueComponente.EditValue.ToInt());
            aca_gcAcabados.DataSource = objCotiza._disenoAcabadoFiltrar(dis_lueComponente.EditValue.ToInt());
            procimp_gcProcesoIMP.DataSource = objCotiza._disenoProcesoIMPFiltrar(dis_lueComponente.EditValue.ToInt());
            acce_gcAccesorios.DataSource = objCotiza._disenoAccesoriosFiltrar(dis_lueComponente.EditValue.ToInt());
            //calcula los totales de los detalles
            _totales();
        }

        #endregion

        #endregion

        //Carga las propiedades de los modelos con los datos de los controles
        #region METODOS-PARA_MODELOS

        //asgina valores al modelo cotizacion
        #region asignaCotizaMOD
        private void _asignaCotizaMOD()
        {
            model_Cotiza.Cotizacion = Convert.ToInt32(beNumeroCOT.EditValue);
            model_Cotiza.FecCotiza = DateTime.Now;
            model_Cotiza.LineaPRD = Convert.ToInt32(lueLineaPRD.EditValue);
            model_Cotiza.Grupo = Convert.ToInt32(lueGrupo.EditValue);
            model_Cotiza.Subgrupo = Convert.ToInt32(lueSubgrupo.EditValue);
            model_Cotiza.Articulo = beArticulo.Text.Trim();
            model_Cotiza.Tiraje = seTiraje.Value.ToInt();
            model_Cotiza.Ancho = Convert.ToDecimal(seAncho.EditValue);
            model_Cotiza.Alto = Convert.ToDecimal(seAlto.EditValue);
            model_Cotiza.FecEntrega = deFechaENT.EditValue;
            model_Cotiza.EplCotiza = frmPrincipal.getSession.Usuario.Empleado.Codigo;
            //SOLO PUEDE CREAR O MODIFICAR COTIZACIONES EN ESTADO CREADO, ACTIVO Y SIN ORDEN
            model_Cotiza.EstadoCOT = 1;
            model_Cotiza.NumOrden = 0;
            model_Cotiza.Estado = true;
        }
        #endregion

        //asigna valores al modelo block (Cabecera de blocks)
        #region asginaBlockMOD
        private void _asignaBlockMOD()
        {
            int emblocado = blo_lueTipoEmblocado.EditValue != null ? Convert.ToInt32(blo_lueTipoEmblocado.EditValue) : 0;
            model_Block.CmbEmblocado = emblocado;
            model_Block.Serie = blo_txtSerie.Text.Trim();
            model_Block.Inicia = Convert.ToInt32(blo_seInicia.Value);
            model_Block.Termina = Convert.ToInt32(blo_seInicia.Value);
            model_Block.Juego = Convert.ToInt32(blo_seJuegos.Value);
        }
        #endregion

        #endregion

        #endregion

        //Controles
        #region EVENTOS-CONTROLES

        //EVENTOS CONTROLES GENERALES
        #region EVENTOS-CONTROLES-GENERALES

        //Buscar cotizacion
        #region beNumeroCOT_ButtonClick
        private void beNumeroCOT_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            model_Cotiza = model_Cotiza._buscaCOT();
            if (model_Cotiza!=null && model_Cotiza.id > 0)
            {
                beNumeroCOT.EditValue = model_Cotiza.Cotizacion;
                deFechaCOT.EditValue = model_Cotiza.FecCotiza;
                txtCIRUCCLI.Text = model_Cotiza.CIRUC;
                beNombreCLI.Text = model_Cotiza.Cliente;
                lueLineaPRD.EditValue = model_Cotiza.LineaPRD;
                lueGrupo.EditValue = model_Cotiza.Grupo;
                lueSubgrupo.EditValue = model_Cotiza.Subgrupo;
                beArticulo.EditValue = model_Cotiza.Articulo;
                seTiraje.EditValue = model_Cotiza.Tiraje;
                seAncho.EditValue = model_Cotiza.Ancho;
                seAlto.EditValue = model_Cotiza.Alto;
                deFechaENT.EditValue = model_Cotiza.FecEntrega;
                txtEplCotizador.EditValue = model_Cotiza.Vendedor;
                beEplVendedor.EditValue = model_Cotiza.Cotizador;
                lblEstadoCOT.Text = objComunes._GetNombreCOT(model_Cotiza.EstadoCOT);
                chkEstadoREG.Checked = model_Cotiza.Estado;
                _CargaDetalle();
            }
        }
        #endregion

        //Buscar articulo
        #region beArticulo_ButtonClick
        private void beArticulo_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            ////DataRow rowItem = objComunes._agregaMATSimple();
            ////if (rowItem != null)
            ////{
            ////    model_Cotiza.SecuencialITEM = Convert.ToInt32(rowItem["Secuencial"]);
            ////    beArticulo.Text = rowItem["Descripción"].ToString().Trim();
            ////}
        }
        #endregion

        //Buscar vendedor
        #region beEplVendedor_ButtonClick
        private void beEplVendedor_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DataRow rowEmpleado = objCotiza._empleadoBuscar();
            if (rowEmpleado != null)
            {
                model_Cotiza.EplVendedor = Convert.ToInt32(rowEmpleado["Código"]);
                model_Cotiza.Vendedor = rowEmpleado["Nombre"].ToString().Trim();
                beEplVendedor.Text = rowEmpleado["Nombre"].ToString().Trim();
            }
        }
        #endregion

        //Cambia el combo componente
        #region dis_lueComponente_EditValueChanged
        private void dis_lueComponente_EditValueChanged(object sender, EventArgs e)
        {
            _disenoFiltrar();
        }
        #endregion

        //Cambia el tiraje
        #region lueLineaPRD_EditValueChanged
        private void lueLineaPRD_EditValueChanged(object sender, EventArgs e)
        {
            int valor = lueLineaPRD.EditValue != null ? Convert.ToInt32(lueLineaPRD.EditValue) : 0;
            DataTable dtOpciones = objComunes._cargaDataCMBDEP(valor);
            objComunes._cargaCtlCMB(lueGrupo, dtOpciones);
        }
        #endregion

        //Cambia el combo grupo
        #region lueGrupo_EditValueChanged
        private void lueGrupo_EditValueChanged(object sender, EventArgs e)
        {
            int valor = lueGrupo.EditValue != null ? Convert.ToInt32(lueGrupo.EditValue) : 0;
            DataTable dtOpciones = objComunes._cargaDataCMBDEP(valor);
            objComunes._cargaCtlCMB(lueSubgrupo, dtOpciones);
            objCotiza._CambiaGrupo(valor);
        }
        #endregion

        //Buscar un cliente
        #region beNombreCLI_ButtonClick
        private void beNombreCLI_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DataRow rowCliente = objCotiza._clienteBuscar();
            if (rowCliente != null)
            {
                model_Cotiza.CodigoCLI = Convert.ToInt32(rowCliente["Código"]);
                model_Cotiza.CIRUC = rowCliente["CIRUC"].ToString().Trim();
                model_Cotiza.Cliente = rowCliente["Cliente"].ToString().Trim();
                txtCIRUCCLI.Text = rowCliente["CIRUC"].ToString().Trim();
                beNombreCLI.Text = rowCliente["Cliente"].ToString().Trim();
                _clienteCarga();
            }
        }
        #endregion

        //Cambia el tiraje
        #region seTiraje_EditValueChanged
        private void seTiraje_EditValueChanged(object sender, EventArgs e)
        {
            objCotiza._updateTiraje(seTiraje.EditValue.ToInt());
            _totales();
        }
        #endregion

        //Cambia la pestana seleccionada. TAB-PRINCIPAL
        #region xtcPestanas_SelectedPageChanged
        private void xtcPestanas_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == xtpResumen)
            {
                _totales();
            }
        }
        #endregion

        #endregion

        //EVENTOS GRILLA DISENO-ARMADOS
        #region EVENTOS-DISENO-ARMADOS

        //Cambia la celda grilla armado
        #region dis_bgvArmados_CellValueChanged
        private void dis_bgvArmados_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (arm_gvArmados.IsValidRowHandle(arm_gvArmados.FocusedRowHandle))
            {
                DataRow row = arm_gvArmados.GetDataRow(arm_gvArmados.FocusedRowHandle);

                if (e.Column.FieldName == "TrabajoAncho" || e.Column.FieldName == "TrabajoAlto")
                {
                    if (!objCotiza._disenoArmadoVerificaDEP(row))
                    {
                        _disenoArmadoCMenu("CALCULA");
                    }
                    else
                    {
                        clsMensaje._msjWarning("No puede modificar esta fila porque tiene registros dependientes", "Modificar");
                        row.RejectChanges();
                    }
                }
            }
        }
        #endregion

        #endregion

        //EVENTOS GRILLA DISENO-COLOR
        #region EVENTOS-DISENO-COLOR
        
        //Buscar pantone
        #region dis_ribeBuscaPantone_ButtonClick
        private void dis_ribeBuscaPantone_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (col_gvColores.IsValidRowHandle(col_gvColores.FocusedRowHandle))
            {
                DataRow rowModifica = col_gvColores.GetDataRow(col_gvColores.FocusedRowHandle);
                objCotiza._disenoColorAgregaPantone(rowModifica);
                col_gvColores.RefreshRow(col_gvColores.FocusedRowHandle);
            }
        }
        #endregion

        //cambia el combo cobertura
        #region dis_rilueCobertura_EditValueChanged
        private void dis_rilueCobertura_EditValueChanged(object sender, EventArgs e)
        {
            if (col_gvColores.IsValidRowHandle(col_gvColores.FocusedRowHandle))
            {
                _forceUpdate(col_gvColores);
                DataRow rowColor = col_gvColores.GetDataRow(col_gvColores.FocusedRowHandle);
                objCotiza._disenoColorCambiaCobertura(rowColor);
            }
        }
        #endregion

        //cambia el combo color plancha
        #region dis_rilueColorPlancha_EditValueChanged
        private void dis_rilueColorPlancha_EditValueChanged(object sender, EventArgs e)
        {
            if (col_gvColores.IsValidRowHandle(col_gvColores.FocusedRowHandle))
            {
                _forceUpdate(col_gvColores);
                DataRow rowColor = col_gvColores.GetDataRow(col_gvColores.FocusedRowHandle);
                objCotiza._disenoColorCambiaPlancha(rowColor);
            }
        }
        #endregion

        #endregion

        //EVENTOS GRILLA DISENO - PLACAS
        #region EVENTOS-DISENO-PLACAS
        
        //CAMBIA VALOR CELDA PLACAS
        #region dis_gvPlacas_CellValueChanged
        private void dis_gvPlacas_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "NumColores")
            {
                if (pla_gvPlacas.IsValidRowHandle(pla_gvPlacas.FocusedRowHandle))
                {
                    DataRow rowPlaca = pla_gvPlacas.GetDataRow(pla_gvPlacas.FocusedRowHandle);
                    objCotiza._disenoPlacaCambiaNumColores(rowPlaca);
                }
            }
        }
        #endregion

        #endregion

        #endregion

        //Barra-Estandar
        #region BARRA-STANDAR

        private void barraStandar_onNew()
        {
            _LimpiarControles();
            model_Cotiza = new cotizaMOD();
            model_Cotiza._nuevaCOT();            
            beNumeroCOT.EditValue = model_Cotiza.Cotizacion;
            _CargaDetalle();
            _estadoControles(true);
        }

        private void barraStandar_onSave()
        {
            _forceUpdate(cli_gvDestino);
            _asignaCotizaMOD();
            _asignaBlockMOD();
            _totales();
            if (_Validar())
            {
                
                if (objCotiza._Guardar(model_Cotiza, model_Block, m_accion))
                {
                    m_accion = "";
                    _estadoControles(false);
                }
            }
        }

        private void barraStandar_onEdit()
        {
            if (model_Cotiza != null && beNumeroCOT.Text.Trim() != "" && beNombreCLI.Text.Trim() != "")
            {
                if (model_Cotiza.EstadoCOT == 1)
                {
                    m_accion = "EDITAR";
                    _estadoControles(true);
                }
                else
                {
                    clsMensaje._msjWarning("Solo se permite modificar registros en estado creado", "Editar");
                }
            }
            else
            {
                clsMensaje._msjWarning("Por favor seleccione la cotización que desea modificar", "Editar registro");
            }
        }

        private void barraStandar_onDelete()
        {
            if (model_Cotiza != null && beNumeroCOT.Text.Trim() != "" && beNombreCLI.Text.Trim() != "")
            {
                if (model_Cotiza.EstadoCOT == 1)
                {
                    //_estadoControles(true);
                }
                else
                {
                    clsMensaje._msjWarning("Solo se permite anular registros en estado creado", "Anular");
                }
            }
            else
            {
                clsMensaje._msjWarning("Por favor seleccione la cotización que desea anular", "Anular registro");
            }
        }

        private void barraStandar_onUndo()
        {
            m_accion = "";
            _estadoControles(false);
        }

        #endregion

        //Menú-Contextual
        #region MENUS-CONTEXTUALES

        //Block
        #region cmBlockElimina
        private void mnuEliminaRegBlock_Click(object sender, EventArgs e)
        {
            objCotiza._blockColorElimina(_getDataRow(blo_gvCopias));
        }
        #endregion

        //Cliente-Destino
        #region  cmClienteDestino

        private void mnuAgregarDestino_Click(object sender, EventArgs e)
        {
            objCotiza._clienteDESTAgrega(model_Cotiza.CodigoCLI);
        }

        private void mnuQuitarDestino_Click(object sender, EventArgs e)
        {
            objCotiza._clienteDESTElimina(_getDataRow(cli_gvDestino));
        }

        #endregion

        //Cliente-MaterialesCliente
        #region cmClienteMaterial

        private void mnuAgregaMATCLI_Click(object sender, EventArgs e)
        {
            objCotiza._disenoMATCLIAgregaMAT();
        }

        private void mnuQuitaMATCLI_Click(object sender, EventArgs e)
        {
            DataRow rowEliminar = mcli_gvMaterialCLI.GetDataRow(mcli_gvMaterialCLI.FocusedRowHandle);
            objCotiza._disenoMATCLIEliminaMAT(rowEliminar);
        }

        #endregion

        //Diseño-Armado
        #region cmDisenoArmado

        //AGREGA UN MATERIAL A LOS ARMADOS
        private void mnuAgregaMATARMDIS_Click(object sender, EventArgs e)
        {
            objCotiza._disenoArmadoAgregaMAT(seAlto.Value.ToInt(),
                seAncho.Value.ToInt(),seTiraje.Value.ToInt(),
                lueGrupo.EditValue, dis_lueComponente.EditValue);
        }

        //CACLULA LOS VALORES DE CORTE
        private void mnuCalculaDISARM_Click(object sender, EventArgs e)
        {
            _disenoArmadoCMenu("CALCULA");
        }

        //CALCULA LOS VALORES DE CORTE Y CARGA LA GRAFICA
        private void mnuVerGraficaDISARM_Click(object sender, EventArgs e)
        {
            _disenoArmadoCMenu("GRAFICA");
        }

        //QUITA UN MATERIAL DE LOS ARMADOS
        private void mnuQuitarMATARMDIS_Click(object sender, EventArgs e)
        {
            _disenoArmadoCMenu("ELIMINAR");
        }

        //CENTRALIZA ACCIONES DE CONTEXT MENU
        private void _disenoArmadoCMenu(string accion)
        {
            if (arm_gvArmados.IsValidRowHandle(arm_gvArmados.FocusedRowHandle))
            {
                DataRow rowSEL = _getDataRow(arm_gvArmados);
                switch (accion)
                {
                    case "CALCULA":
                        if (_disenoArmadoCMenuValida(rowSEL))
                        {
                            objCotiza._disenoArmadoCalcula(rowSEL);
                        }
                        break;
                    case "ELIMINAR":
                        objCotiza._disenoArmadoEliminaMAT(rowSEL);
                        break;
                    case "GRAFICA":
                        if (_disenoArmadoCMenuValida(rowSEL))
                        {
                            objCotiza._disenoArmadoGrafica(rowSEL);
                        }
                        break;
                }
                arm_gvArmados.RefreshRow(arm_gvArmados.FocusedRowHandle);
            }
        }

        //VALIDA ACCIONES DE CONTEXT MENU
        private bool _disenoArmadoCMenuValida(DataRow rowSEL)
        {
            if (rowSEL["TrabajoAncho"].ToDecimal() <= 0 && rowSEL["TrabajoAlto"].ToDecimal() <= 0)
            {
                clsMensaje._msjWarning("El Ancho y Alto del trabajo tiene que ser mayor a cero","Verificar datos");
                return false;
            }
            return true;
        }

        #endregion

        //Diseño-Color
        #region cmDisenoColorElimina

        private void mnuAgregaRegistro_Click(object sender, EventArgs e)
        {
            objCotiza._disenoColorAddColor(dis_lueComponente.EditValue);
        }

        private void mnuEliminaRegDisenoColor_Click(object sender, EventArgs e)
        {
            objCotiza._disenoColorElimina(_getDataRow(col_gvColores));
        }

        #endregion

        //Diseño-Troquel
        #region cmDisenoTroquel

        private void mnuAgregaRegTroquel_Click(object sender, EventArgs e)
        {
            objCotiza._disenoTroquelAddTroquel(dis_lueComponente.EditValue);
        }

        private void mnuEliminaRegTroquel_Click(object sender, EventArgs e)
        {
            objCotiza._disenoTroquelElimina(_getDataRow(tro_gvTroquel));
        }

        #endregion

        //Diseño-Acabado
        #region cmDisenoAcabado

        private void mnuAgregaAcabado_Click(object sender, EventArgs e)
        {
            if (aca_gvAcabados.IsValidRowHandle(aca_gvAcabados.FocusedRowHandle))
            {
                DataRow rowAcabado = aca_gvAcabados.GetDataRow(aca_gvAcabados.FocusedRowHandle);
                objCotiza._disenoAcabadoAddAcabado(rowAcabado);
            }
        }

        private void dis_mnuAgregaRegistro_Click(object sender, EventArgs e)
        {
            objCotiza._disenoAcabadoAddMaterial(dis_lueComponente.EditValue);
        }

        private void dis_mnuEliminaRegistro_Click(object sender, EventArgs e)
        {
            objCotiza._disenoAcabadoElimina(_getDataRow(aca_gvAcabados));
        }

        #endregion

        //Diseño-Procesos
        #region cmDisenoProcesos

        private void mnuAgregaProceso_Click(object sender, EventArgs e)
        {
            objCotiza._disenoProcesoAgregaMAQ(Convert.ToInt32(seTiraje.Value));
        }

        private void mnuQuitarProceso_Click(object sender, EventArgs e)
        {
            objCotiza._disenoProcesoElimina(_getDataRow(proc_gvProcesos));
        }

        #endregion

        //Diseño-Accesorios
        #region cmDisenoAccesorio

        private void mnuAgregaAccesorio_Click(object sender, EventArgs e)
        {
            objCotiza._disenoAccesorioAgregar(dis_lueComponente.EditValue, seTiraje.EditValue.ToInt());
        }

        private void mnuEliminaAccesorio_Click(object sender, EventArgs e)
        {
            objCotiza._disenoAccesorioEliminar(_getDataRow(acce_gvAccesorios));
        }





        #endregion

        //Diseno-General_ORI
        #region cmDisenoGENORI

        private void mnuAgregaRegistroORI_Click(object sender, EventArgs e)
        {
            objCotiza._disenoGeneralAddORI();
        }

        private void mnuEliminaRegistroORI_Click(object sender, EventArgs e)
        {
            objCotiza._disenoGeneralEliminaREG(optionsCMB.DisenoChkORI, _getDataRow(gen_gvOriginales));
        }

        #endregion

        //Diseno-General_GH
        #region DisenoGENGH
        private void mnuAgregaRegistroGH_Click(object sender, EventArgs e)
        {
            objCotiza._disenoGeneralAddGH();
        }

        private void mnuEliminaRegistroGH_Click(object sender, EventArgs e)
        {
            objCotiza._disenoGeneralEliminaREG(optionsCMB.DisenoChkGH, _getDataRow(gen_gvGraficasH));
        }

        #endregion

        #endregion

        
    }
}
