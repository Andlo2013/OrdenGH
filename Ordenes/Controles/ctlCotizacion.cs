﻿using System;
using System.Data;
using System.Windows.Forms;
using Ordenes.Formularios;
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

        public ctlCotizacion()
        {
            InitializeComponent();
        }

        private void ctlCotizacion_Load(object sender, EventArgs e)
        {
            _inicializa();
        }

        //METODOS DEL FORMULARIO
        #region METODOS

        //Métodos para iniciar el formulario
        #region Métodos-Inicializacion

        //carga CheckedList
        #region cargaCHKList
        private void _cargaCheckedList()
        {
            DataTable dt_optionsCMB = objComunes._cargaDataCMB(optionsCMB.DisenoChkGH);
            objComunes._addItemCheckedList(dt_optionsCMB, dis_chklGraficasH);

            dt_optionsCMB = objComunes._cargaDataCMB(optionsCMB.DisenoChkORI);
            objComunes._addItemCheckedList(dt_optionsCMB, dis_chklOriginales);
        }
        #endregion

        //carga un LookUpEdit
        #region cargaLookUpEdit
        private void _cargaLookUpEdit(LookUpEdit[] lueCombos,optionsCMB opcion)
        {
            DataTable dtCombo = objComunes._cargaDataCMB(opcion);
            foreach(LookUpEdit lueCombo in lueCombos)
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

        //Carga inicial de controles
        #region inicializa
        private void _inicializa()
        {
            //CARGA LÍNEAS DE PRODUCCIÓN
            _cargaLookUpEdit(new LookUpEdit[] { lueLineaPRD }, optionsCMB.Linea_Produccion);

            //CARGA EL COMBO DE COMPONENTES
            _cargaLookUpEdit(new LookUpEdit[] { dis_lueComponente }, optionsCMB.EgrMat_Seccion);

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

            //carga checkedList
            _cargaCheckedList();

        }
        #endregion

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
            _procesoCarga();
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
            objCotiza._disenoArmadoCargaDET(model_Cotiza.id, model_Cotiza.Tiraje,model_Cotiza.Grupo);
            objCotiza._disenoColorCargaDET(model_Cotiza.id,model_Cotiza.Tiraje);
            objCotiza._disenoPlacaCargaDET(model_Cotiza.id);
            objCotiza._disenoTroquelCargaDET(model_Cotiza.id);
            objCotiza._disenoAcabadoCargaDET(model_Cotiza.id);
            dis_gcMaterialCLI.DataSource = objCotiza._disenoMATCLICargaDET(model_Cotiza.id);
            //para que cargue solo lo del combo
            _disenoFiltrar();
        }

        //filtra los detalles del diseno de acuerdo a la opcion seleccionada en componente
        private void _disenoFiltrar()
        {
            dis_gcArmados.DataSource = objCotiza._disenoArmadoFiltrar(dis_lueComponente.EditValue.ToInt());
            dis_gcColores.DataSource = objCotiza._disenoColorFiltrar(dis_lueComponente.EditValue.ToInt());
            dis_gcPlacas.DataSource = objCotiza._disenoPlacaFiltrar(dis_lueComponente.EditValue.ToInt());
            dis_gcTrqouel.DataSource = objCotiza._disenoTroquelFiltrar(dis_lueComponente.EditValue.ToInt());
            dis_gcAcabados.DataSource = objCotiza._disenoAcabadoFiltrar(dis_lueComponente.EditValue.ToInt());
            //calcula los totales de los detalles
            _totales();
        }

        #endregion

        //Pestaña proceso
        #region Proceso-Detalles
        private void _procesoCarga()
        {
            gc_Procesos.DataSource = objCotiza._procesoCargaDET(model_Cotiza.id);
        }
        #endregion

        #endregion

        //Carga las propiedades de los modelos
        #region Métodos-CargaModelos(Para guardar)

        //asgina valores al modelo cotizacion
        #region asignaCotizaMOD
        private void _asignaCotizaMOD()
        {
            model_Cotiza.Cotizacion = Convert.ToInt32(beNumeroCOT.EditValue);
            model_Cotiza.FecCotiza = DateTime.Now;
            model_Cotiza.LineaPRD = Convert.ToInt32(lueLineaPRD.EditValue);
            model_Cotiza.Grupo = Convert.ToInt32(lueGrupo.EditValue);
            model_Cotiza.Subgrupo = Convert.ToInt32(lueSubgrupo.EditValue);
            model_Cotiza.Ancho = Convert.ToDecimal(seAncho.EditValue);
            model_Cotiza.Alto = Convert.ToDecimal(seAlto.EditValue);
            model_Cotiza.FecEntrega = deFechaENT.EditValue;
            model_Cotiza.EplCotiza = Form1.getSession.Usuario.Empleado.Codigo;
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
            model_Block.Juego= Convert.ToInt32(blo_seJuegos.Value);
        }
        #endregion

        #endregion

        //Métodos varios
        #region Métodos-Varios

        private void _disenoArmadosTotales()
        {
            dis_seTotalCostoPapel.Value = objCotiza._disenoArmadoTotales();
        }

        private void _disenoColorTotales()
        {
            decimal[] totales = objCotiza._disenoColorTotales();
            dis_seGramosColor.Value = totales[0];
            dis_seGramosMetalizado.Value = totales[1];
            dis_seGramosPantone.Value = totales[2];
            dis_seTotalCostoTinta.Value = totales[3];
        }

        private void _disenoPlacasTotales()
        {
            decimal[] totales = objCotiza._disenoPlacaTotales();
            dis_seNumPlacas.EditValue = totales[0];
            dis_seTotalPlacas.EditValue = totales[1];
        }

        private void _disenoTroquelTotales()
        {
            decimal[] totales = objCotiza._disenoTroquelTotales();
            dis_seCorteLONG.EditValue = totales[0];
            dis_seCortesTOT.EditValue = totales[1];
        }
        
        private void _forceUpdate(GridView dgvToForce)
        {
            txtCIRUCCLI.Focus();
            dgvToForce.Focus();
        }

        //Limpia los controles y propiedades de los modelos
        #region LimpiarControles
        private void _LimpiarControles()
        {
            beNumeroCOT.Text = "";
            deFechaCOT.EditValue = DateTime.Now;
            txtCIRUCCLI.Text = txtNombreCLI.Text = beArticulo.Text = "";
            seAncho.EditValue = seAlto.EditValue = 10;
            deFechaENT.EditValue = DateTime.Now.AddDays(1);
            txtEplCotizador.Text = beEplVendedor.Text = "";
            chkEstadoCOT.Checked = true;
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

        private void _totales()
        {
            _disenoArmadosTotales();
            _disenoColorTotales();
            _disenoPlacasTotales();
            _disenoTroquelTotales();
        }

        //Validaciones
        #region Validar
        private bool _Validar()
        {
            if (blo_seInicia.Value > blo_seTermina.Value)
            {
                decimal aux = blo_seInicia.Value;
                blo_seInicia.Value = blo_seTermina.Value;
                blo_seTermina.Value = aux;
            }

            if (blo_seInicia.Value == blo_seTermina.Value && blo_seInicia.Value != 0)
            {
                clsMensaje._msjWarning("Blocks: El campo 'INICIA' no puede tener " +
                    "el mismo valor que el campo 'TERMINA'", "Verificar datos");
                blo_seTermina.Focus();
                return false;
            }
            bool validaDET = objCotiza._disenoArmadoValida()
                            && objCotiza._disenoColorValida();
            return validaDET;
        }
        #endregion

        #endregion

        #endregion

        //Controles
        #region Controles

        #region EVENTOS-CONTROLES-GENERALES

        private void btnVistaPRV_Click(object sender, EventArgs e)
        {
            frmCortes obj = new frmCortes();
            obj.ShowDialog();
        }

        private void beNumeroCOT_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            model_Cotiza = model_Cotiza._buscaCOT();
            if (model_Cotiza!=null && model_Cotiza.id > 0)
            {
                beNumeroCOT.EditValue = model_Cotiza.Cotizacion;
                deFechaCOT.EditValue = model_Cotiza.FecCotiza;
                txtCIRUCCLI.Text = model_Cotiza.CIRUC;
                txtNombreCLI.Text = model_Cotiza.Cliente;
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
                _CargaDetalle();
            }
        }

        private void beArticulo_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DataRow rowItem = objComunes._agregaMATSimple();
            if (rowItem != null)
            {
                model_Cotiza.SecuencialITEM = Convert.ToInt32(rowItem["Secuencial"]);
                beArticulo.Text = rowItem["Descripción"].ToString().Trim();
            }
        }

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

        private void dis_lueComponente_EditValueChanged(object sender, EventArgs e)
        {
            _disenoFiltrar();
        }

        private void lueLineaPRD_EditValueChanged(object sender, EventArgs e)
        {
            int valor = lueLineaPRD.EditValue != null ? Convert.ToInt32(lueLineaPRD.EditValue) : 0;
            DataTable dtOpciones = objComunes._cargaDataCMBDEP(valor);
            objComunes._cargaCtlCMB(lueGrupo, dtOpciones);
        }

        private void lueGrupo_EditValueChanged(object sender, EventArgs e)
        {
            int valor = lueGrupo.EditValue != null ? Convert.ToInt32(lueGrupo.EditValue) : 0;
            DataTable dtOpciones = objComunes._cargaDataCMBDEP(valor);
            objComunes._cargaCtlCMB(lueSubgrupo, dtOpciones);
        }

        private void txtNombreCLI_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DataRow rowCliente = objCotiza._clienteBuscar();
            if (rowCliente != null)
            {
                model_Cotiza.CodigoCLI = Convert.ToInt32(rowCliente["Código"]);
                model_Cotiza.CIRUC = rowCliente["CIRUC"].ToString().Trim();
                model_Cotiza.Cliente = rowCliente["Cliente"].ToString().Trim();
                txtCIRUCCLI.Text = rowCliente["CIRUC"].ToString().Trim();
                txtNombreCLI.Text = rowCliente["Cliente"].ToString().Trim();
                _clienteCarga();
            }
        }

        private void seTiraje_EditValueChanged(object sender, EventArgs e)
        {
            objCotiza._updateTiraje(seTiraje.EditValue.ToInt());
            _totales();
        }

        #endregion

        #region EVENTOS-DISENO-ARMADOS

        private void dis_bgvArmados_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (dis_bgvArmados.IsValidRowHandle(dis_bgvArmados.FocusedRowHandle))
            {
                DataRow row = dis_bgvArmados.GetDataRow(dis_bgvArmados.FocusedRowHandle);
                if (!objCotiza._disenoArmadoVerificaDEP(row))
                {
                    if (e.Column.FieldName == "TrabajoAncho" || e.Column.FieldName == "TrabajoAlto")
                    {
                        _disenoArmadoCMenu("CALCULA");
                        _disenoArmadosTotales();
                    }
                    else if (e.Column.FieldName == "NumPaginas")
                    {
                        _disenoArmadosTotales();
                    }
                }
                else
                {
                    clsMensaje._msjWarning("No puede modificar esta fila porque tiene registros dependientes","Modificar");
                    row.RejectChanges();
                }
            }
        }

        #endregion

        #region EVENTOS-DISENO-COLOR

        private void dis_ribeBuscaPantone_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (dis_gvColores.IsValidRowHandle(dis_gvColores.FocusedRowHandle))
            {
                DataRow rowModifica = dis_gvColores.GetDataRow(dis_gvColores.FocusedRowHandle);
                objCotiza._disenoColorAgregaPantone(rowModifica);
                dis_gvColores.RefreshRow(dis_gvColores.FocusedRowHandle);
            }
        }

        private void dis_rilueCobertura_EditValueChanged(object sender, EventArgs e)
        {
            if (dis_gvColores.IsValidRowHandle(dis_gvColores.FocusedRowHandle))
            {
                _forceUpdate(dis_gvColores);
                DataRow rowColor = dis_gvColores.GetDataRow(dis_gvColores.FocusedRowHandle);
                objCotiza._disenoColorCambiaCobertura(rowColor);
                _disenoColorTotales();
            }
        }

        private void dis_rilueColorPlancha_EditValueChanged(object sender, EventArgs e)
        {
            if (dis_gvColores.IsValidRowHandle(dis_gvColores.FocusedRowHandle))
            {
                _forceUpdate(dis_gvColores);
                DataRow rowColor = dis_gvColores.GetDataRow(dis_gvColores.FocusedRowHandle);
                objCotiza._disenoColorCambiaPlancha(rowColor);
                _disenoColorTotales();
            }
        }

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

        }

        private void barraStandar_onSave()
        {
            if (_Validar())
            {
                _asignaCotizaMOD();
                _asignaBlockMOD();
                model_Cotiza._guardaCOT();
            }
            
        }

        private void barraStandar_onEdit()
        {

        }

        private void barraStandar_onDelete()
        {

        }

        private void barraStandar_onUndo()
        {

        }

        #endregion

        //Menú-Contextual
        #region MENUS-CONTEXTUALES

        //Block
        #region cmBlockElimina
        private void mnuEliminaRegBlock_Click(object sender, EventArgs e)
        {
            DataRow rowEliminar = blo_gvCopias.GetDataRow(blo_gvCopias.FocusedRowHandle);
            objCotiza._blockColorElimina(rowEliminar);
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
            DataRow rowEliminar = cli_gvDestino.GetDataRow(cli_gvDestino.FocusedRowHandle);
            objCotiza._clienteDESTElimina(rowEliminar);
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
            DataRow rowEliminar = dis_gvMaterialCLI.GetDataRow(dis_gvMaterialCLI.FocusedRowHandle);
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
            _disenoArmadosTotales();
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
            if (dis_bgvArmados.IsValidRowHandle(dis_bgvArmados.FocusedRowHandle))
            {
                DataRow rowSEL = dis_bgvArmados.GetDataRow(dis_bgvArmados.FocusedRowHandle);
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
                        _disenoColorTotales();
                        break;
                    case "GRAFICA":
                        if (_disenoArmadoCMenuValida(rowSEL))
                        {
                            objCotiza._disenoArmadoGrafica(rowSEL);
                        }
                        break;
                }
                dis_bgvArmados.RefreshRow(dis_bgvArmados.FocusedRowHandle);
                _disenoArmadosTotales();
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
            _disenoColorTotales();
        }

        private void mnuEliminaRegDisenoColor_Click(object sender, EventArgs e)
        {
            DataRow rowEliminar = dis_gvColores.GetDataRow(dis_gvColores.FocusedRowHandle);
            objCotiza._disenoColorElimina(rowEliminar);
            _disenoColorTotales();
        }
        #endregion

        #region cmDisenoPlaca

        private void mnuAgregaPlaca_Click(object sender, EventArgs e)
        {
            objCotiza._disenoPlacaAddPlaca(dis_lueComponente.EditValue);
            _disenoPlacasTotales();
        }

        private void mnuEliminaPlaca_Click(object sender, EventArgs e)
        {
            DataRow rowEliminar = dis_gvPlacas.GetDataRow(dis_gvPlacas.FocusedRowHandle);
            objCotiza._disenoPlacaElimina(rowEliminar);
            _disenoPlacasTotales();
        }

        #endregion

        #region cmDisenoTroquel

        private void mnuAgregaRegTroquel_Click(object sender, EventArgs e)
        {
            objCotiza._disenoTroquelAddTroquel(dis_lueComponente.EditValue);
            _disenoTroquelTotales();
        }

        private void mnuEliminaRegTroquel_Click(object sender, EventArgs e)
        {
            DataRow rowEliminar = dis_gvTroquel.GetDataRow(dis_gvTroquel.FocusedRowHandle);
            objCotiza._disenoTroquelElimina(rowEliminar);
            _disenoTroquelTotales();
        }

        #endregion

        #region cmDisenoAcabado

        private void mnuAgregaAcabado_Click(object sender, EventArgs e)
        {
            if (dis_gvAcabados.IsValidRowHandle(dis_gvAcabados.FocusedRowHandle))
            {
                DataRow rowAcabado = dis_gvAcabados.GetDataRow(dis_gvAcabados.FocusedRowHandle);
                objCotiza._disenoAcabadoAddAcabado(rowAcabado);
            }
        }

        private void dis_mnuAgregaRegistro_Click(object sender, EventArgs e)
        {
            objCotiza._disenoAcabadoAddMaterial(dis_lueComponente.EditValue);
        }

        private void dis_mnuEliminaRegistro_Click(object sender, EventArgs e)
        {

        }

        #endregion

        //Procesos
        #region cmProcesos
        private void mnuAgregaProceso_Click(object sender, EventArgs e)
        {
            objCotiza._procesoAgregaMAQ(Convert.ToInt32(seTiraje.Value));
        }

        private void mnuQuitarProceso_Click(object sender, EventArgs e)
        {
            DataRow rowEliminar = gvProcesos.GetDataRow(gvProcesos.FocusedRowHandle);
            objCotiza._procesoElimina(rowEliminar);
        }









        #endregion

        #endregion

        
    }
}
