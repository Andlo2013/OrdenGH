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
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using Ordenes.Modelos;
using AutomatizerSQL.Utilidades;
namespace Ordenes.Controles
{
    public partial class ctlOrden : UserControl
    {
        clsVentas objVentas = new clsVentas();

        public ctlOrden()
        {
            InitializeComponent();
        }

        private void ctlOrden_Load(object sender, EventArgs e)
        {
            _cargaCMB();
        }

        //Carga todos los combos
        private void _cargaCMB()
        {
            //GENERALES: Combo tipo trabajo
            DataTable dt_optionsCMB = objVentas._cargaCMBOPC(optionsCMB.TrabajoGEN, 0);
            objVentas._cargaCMB(dt_optionsCMB, gen_lueTrabajo);
            //TODOS LOS COMBOS TAMANO
            dt_optionsCMB = objVentas._cargaCMBOPC(optionsCMB.TipoTamano, 0);
            objVentas._cargaCMB(dt_optionsCMB, gen_lueTamano);
            objVentas._cargaCMB(dt_optionsCMB, blo_lueTamano);
            objVentas._cargaCMB(dt_optionsCMB, lib_lueTamanoENC);
            objVentas._cargaCMB(dt_optionsCMB, lib_lueTamanoPOR);
            //TODOS LOS COMBOS TROQUEL
            dt_optionsCMB = objVentas._cargaCMBOPC(optionsCMB.TipoTroquel, 0);
            objVentas._cargaCMB(dt_optionsCMB, gen_lueTroquel);
            objVentas._cargaCMB(dt_optionsCMB, blo_lueTroquel);
            objVentas._cargaCMB(dt_optionsCMB, lib_lueTroquelPOR);
            //TODOS LOS COMBOS COLOR
            dt_optionsCMB = objVentas._cargaCMBOPC(optionsCMB.Color, 0);
            objVentas._cargaCMB(dt_optionsCMB, gen_lueColorTiro);
            objVentas._cargaCMB(dt_optionsCMB, gen_lueColorRetiro);
            objVentas._cargaCMB(dt_optionsCMB, blo_lueColor);
            objVentas._cargaCMB(dt_optionsCMB, lib_lueTiroColorPOR);
            objVentas._cargaCMB(dt_optionsCMB, lib_lueRetiroColorPOR);
            objVentas._cargaCMB(dt_optionsCMB, lib_lueTiroGuardaPOR);
            objVentas._cargaCMB(dt_optionsCMB, lib_lueRetiroGuardaPOR);
            objVentas._cargaCMB(dt_optionsCMB, lib_lueTiroCubiertaPOR);
            objVentas._cargaCMB(dt_optionsCMB, lib_lueRetiroCubiertaPOR);
            objVentas._cargaCMBLUE(dt_optionsCMB, rilue_gridColorENC);
            //BLOCKS NÚMERO COPIAS
            dt_optionsCMB = objVentas._cargaCMBOPC(optionsCMB.NumeroCopia, 0);
            objVentas._cargaCMB(dt_optionsCMB, blo_lueNumCopias);
            dt_optionsCMB = objVentas._cargaCMBOPC(optionsCMB.TipoBloque, 0);
            objVentas._cargaCMB(dt_optionsCMB, blo_lueTipoEmblocado);
            dt_optionsCMB = objVentas._cargaCMBOPC(optionsCMB.BlockAcabado, 0);
            objVentas._cargaCMB(dt_optionsCMB, blo_lueAcabado);
            //LIBRO 
            dt_optionsCMB = objVentas._cargaCMBOPC(optionsCMB.LibroEncuadernado, 0);
            objVentas._cargaCMB(dt_optionsCMB, lib_TipoTrabajoENC);
            dt_optionsCMB = objVentas._cargaCMBOPC(optionsCMB.LibroTipo, 0);
            objVentas._cargaCMB(dt_optionsCMB, lib_lueTipoLibro);
            dt_optionsCMB = objVentas._cargaCMBOPC(optionsCMB.LibroForma, 0);
            objVentas._cargaCMB(dt_optionsCMB, lib_lueForma);
            //EGRESO DE MATERIALES
            dt_optionsCMB = objVentas._cargaCMBOPC(optionsCMB.EgrMat_Seccion, 0);
            objVentas._cargaCMBLUE(dt_optionsCMB, em_rilueSeccion);
            objVentas._cargaCMBLUE(dt_optionsCMB, dis_rilueSeccionARM);
            dt_optionsCMB = objVentas._cargaCMBOPC(optionsCMB.EgrMat_Maquina, 0);
            objVentas._cargaCMBLUE(dt_optionsCMB, em_rilueMaquina);

            dt_optionsCMB = objVentas._cargaCMBOPC(optionsCMB.DisenoChkGH, 0);
            objVentas._cargaCheckedList(dt_optionsCMB, dis_chklGraficasH);
            //dis_chklGraficasH.DataSource = dt_optionsCMB;

            dt_optionsCMB = objVentas._cargaCMBOPC(optionsCMB.DisenoChkORI, 0);
            objVentas._cargaCheckedList(dt_optionsCMB, dis_chklOriginales);
            //dis_chklOriginales.DataSource = dt_optionsCMB;

            dt_optionsCMB = objVentas._cargaCMBOPC(optionsCMB.DisenoChkCTP, 0);
            objVentas._cargaCheckedList(dt_optionsCMB, dis_chklCTP);
        }

        private void _CargaMaterial(ButtonEdit be_Button)
        {
            DataRow rowSEL = objVentas._AgregaUnMAT();
            if (rowSEL != null)
            {
                be_Button.Text = rowSEL["Descripción"].ToString();
                //Falta el código
            }
        }

        #region MÉTODOS: CARGA

        private void _CargaDET()
        {
            gcAcabados.DataSource = objVentas._acabadoCarga();
            lib_gcColoresENC.DataSource = objVentas._libroCargaColor();
            em_gcDetalleEGR.DataSource = objVentas._egresoMatCargaDET();

            _clienteCargaDEST();
            _clienteCargaTEL();
            _disenoCargaCAB();
            _generalCargaDET();
            _blocksCargaDET();
            _librosENCCargaDET();
            _librosPORCargaDET();
            _produccionCargaDET();
            _srvExternoCargaDET();
        }

        private void _blocksCargaDET()
        {
            objVentas._blockCargaDET();
            if (objVentas.pro_ModeloBlock != null)
            {
                blo_lueNumCopias.EditValue = objVentas.pro_ModeloBlock.NumCopias;
                blo_txtJuegos.EditValue = objVentas.pro_ModeloBlock.Juego;
                blo_lueTipoEmblocado.EditValue = objVentas.pro_ModeloBlock.TipoEmblocado;
                blo_txtSerie.EditValue = objVentas.pro_ModeloBlock.Serie;
                blo_txtInicia.EditValue = objVentas.pro_ModeloBlock.Inicia;
                blo_txtTermina.EditValue = objVentas.pro_ModeloBlock.Termina;
                blo_lueAcabado.EditValue = objVentas.pro_ModeloBlock.TipoAcabado;
                blo_lueTamano.EditValue = objVentas.pro_ModeloBlock.TipoTamano;
                blo_txtAncho.EditValue = objVentas.pro_ModeloBlock.Ancho;
                blo_txtAlto.EditValue = objVentas.pro_ModeloBlock.Alto;
                ////blo_beMaterial.EditValue = rowBlock["Material"];
                ////blo_txtGramos.EditValue = rowBlock["Gramos"];
                blo_txtTiraje.EditValue = objVentas.pro_ModeloBlock.Tiraje;
                blo_lueTroquel.EditValue = objVentas.pro_ModeloBlock.TipoTroquel;
                blo_txtOrdenTroquel.EditValue = objVentas.pro_ModeloBlock.OrdenTroquel;
                blo_lueColor.EditValue = objVentas.pro_ModeloBlock.Color;
                blo_txtPantones.EditValue = objVentas.pro_ModeloBlock.Pantones;
            }
        }

        private void _clienteCargaDEST()
        {
            cli_gcDestinos.DataSource = objVentas._clienteCargaDEST();
        }

        private void _clienteCargaTEL()
        {
            object codCliente = beBuscaCLI.Text.Trim() != "" ? beBuscaCLI.Text : "-1";
            gcContactos.DataSource = objVentas._clienteCargaTEL(codCliente);
        }

        private void _disenoCargaCAB()
        {
            DataRow rowDiseno = objVentas._disenoCargaCAB();
            if (rowDiseno != null)
            {
                dis_txtDisenador.EditValue = rowDiseno["Disenador"];
                dis_deFechaINI.EditValue = rowDiseno["FecInicia"];
                dis_deFechaFIN.EditValue = rowDiseno["FecTermina"];
            }
            dis_gcArmados.DataSource = objVentas._disenoCargaArmados();
            dis_gcMaterialCLI.DataSource = objVentas._disenoCargaMaterialCLI();
            _disenoCargaCHK();
        }

        private void _disenoCargaCHK()
        {
            DataTable dtOpciones = objVentas._disenoCargaCheckedList();
            foreach (DataRow optionRow in dtOpciones.Rows)
            {
                object valor = optionRow["Opcion"];
                if (dis_chklCTP.Items.IndexOf(valor) >= 0)
                {
                    int pos = dis_chklCTP.Items.IndexOf(valor);
                    dis_chklCTP.Items[pos].CheckState = CheckState.Checked;
                }
                else if (dis_chklGraficasH.Items.IndexOf(valor) >= 0)
                {
                    int pos = dis_chklGraficasH.Items.IndexOf(valor);
                    dis_chklGraficasH.Items[pos].CheckState = CheckState.Checked;
                }
                else if (dis_chklOriginales.Items.IndexOf(valor) >= 0)
                {
                    int pos = dis_chklOriginales.Items.IndexOf(valor);
                    dis_chklOriginales.Items[pos].CheckState = CheckState.Checked;
                }
            }
        }

        private void _generalCargaDET()
        {
           objVentas._generalCargaDET();
            if (objVentas.pro_ModeloTrabajoGEN != null)
            {
                gen_lueTrabajo.EditValue = objVentas.pro_ModeloTrabajoGEN.Trabajo;
                gen_txtTiraje.EditValue = objVentas.pro_ModeloTrabajoGEN.Tiraje;
                gen_lueTipoTrabajo.EditValue = objVentas.pro_ModeloTrabajoGEN.TipoTrabajo;
                gen_lueTamano.EditValue = objVentas.pro_ModeloTrabajoGEN.TipoTamano;
                gen_txtAncho.EditValue = objVentas.pro_ModeloTrabajoGEN.Ancho;
                gen_txtAlto.EditValue = objVentas.pro_ModeloTrabajoGEN.Alto;
                ////gen_beMaterial.EditValue = rowGeneral["Material"];
                ////gen_txtGramos.EditValue = rowGeneral["Gramos"];
                gen_lueTroquel.EditValue = objVentas.pro_ModeloTrabajoGEN.TipoTroquel;
                gen_txtOrdenTroquel.EditValue = objVentas.pro_ModeloTrabajoGEN.OrdenTroquel.ToInt();
                gen_lueColorTiro.EditValue = objVentas.pro_ModeloTrabajoGEN.ColorTiro;
                gen_lueColorRetiro.EditValue = objVentas.pro_ModeloTrabajoGEN.ColorRetiro;
                gen_txtPantones.EditValue = objVentas.pro_ModeloTrabajoGEN.Pantones;
            }
        }

        private void _librosENCCargaDET()
        {
            objVentas._libroCargaDETENC();
            if (objVentas.pro_ModeloLibroENC!=null)
            {
                lib_lueTipoLibro.EditValue = objVentas.pro_ModeloLibroENC.TipoLibro;
                lib_lueForma.EditValue = objVentas.pro_ModeloLibroENC.FormaLibro;
                lib_TipoTrabajoENC.EditValue = objVentas.pro_ModeloLibroENC.TipoTrabajo;
                lib_lueTamanoENC.EditValue = objVentas.pro_ModeloLibroENC.TamanoTrabajo;
                lib_txtAnchoENC.EditValue = objVentas.pro_ModeloLibroENC.Ancho;
                lib_txtAltoENC.EditValue = objVentas.pro_ModeloLibroENC.Alto;
                //lib_beMaterialENC.EditValue = rowLibro["Material"];
                //lib_txtGramosENC.EditValue = rowLibro["Gramos"];
                lib_txtNumPaginasENC.EditValue = objVentas.pro_ModeloLibroENC.NumPaginas;
            }
        }

        private void _librosPORCargaDET()
        {
            objVentas._libroCargaDETPOR();
            if (objVentas.pro_ModeloLibroPOR != null)
            {
                lib_lueTamanoPOR.EditValue = objVentas.pro_ModeloLibroPOR.TipoTamano;
                lib_txtAnchoPOR.EditValue = objVentas.pro_ModeloLibroPOR.Ancho;
                lib_txtAltoPOR.EditValue = objVentas.pro_ModeloLibroPOR.Alto;
                //lib_beMaterialPOR.EditValue = rowLibro["Material"];
                //lib_txtGramosPOR.EditValue = rowLibro["Gramos"];
                lib_lueTiroColorPOR.EditValue = objVentas.pro_ModeloLibroPOR.TiroColor;
                lib_lueTiroGuardaPOR.EditValue = objVentas.pro_ModeloLibroPOR.TiroGuarda;
                lib_lueTiroCubiertaPOR.EditValue = objVentas.pro_ModeloLibroPOR.TiroCubierta;
                lib_lueRetiroColorPOR.EditValue = objVentas.pro_ModeloLibroPOR.RetiroColor;
                lib_lueRetiroGuardaPOR.EditValue = objVentas.pro_ModeloLibroPOR.RetiroGuarda;
                lib_lueRetiroCubiertaPOR.EditValue = objVentas.pro_ModeloLibroPOR.RetiroCubierta;
                lib_txtColorPantonePOR.EditValue = objVentas.pro_ModeloLibroPOR.ColorPantone;
                lib_beMaterialGuardaPOR.EditValue = objVentas.pro_ModeloLibroPOR.GuardaMAT;
                lib_beMaterialCubiertaPOR.EditValue = objVentas.pro_ModeloLibroPOR.CubiertaMAT;
                lib_lueTroquelPOR.EditValue = objVentas.pro_ModeloLibroPOR.TipoTroquel;
                lib_txtOrdenPOR.EditValue = objVentas.pro_ModeloLibroPOR.OrdenTroquel;
            }
        }

        private void _produccionCargaDET()
        {
            DataTable dtProcesos = objVentas._produccionCargaCMB();
            objVentas._cargaCMB(dtProcesos, prd_lueProceso, "DisplayText", "Value");
        }

        private void _srvExternoCargaDET()
        {
            DataRow rowSrvExt = objVentas._srvExternoCargaDET();
            if (rowSrvExt != null)
            {
                sext_txtPelicula.EditValue = rowSrvExt["Pelicula"];
                sext_sePeliculaPRE.EditValue = rowSrvExt["PeliculaCosto"];
                sext_txtTroquel.EditValue = rowSrvExt["Troquel"];
                sext_seTroquelPRE.EditValue = rowSrvExt["TroquelCosto"];
                sext_txtClishe.EditValue = rowSrvExt["Clishe"];
                sext_seClishePRE.EditValue = rowSrvExt["ClisheCosto"];
                sext_seCocidoPRE.EditValue = rowSrvExt["Cocido"];
                sext_seReservadoPRE.EditValue = rowSrvExt["Reservado"];
                sext_seTermoselladoPRE.EditValue = rowSrvExt["Termosellado"];
                sext_seTransportePRE.EditValue = rowSrvExt["Transporte"];
                sext_seSeguroPRE.EditValue = rowSrvExt["ValijaSeguro"];
                sext_sePlastificadoPRE.EditValue = rowSrvExt["Plastificado"];
                sext_chkResina.Checked = Convert.ToBoolean(rowSrvExt["Resina"]);
                sext_chkMetalico.Checked = Convert.ToBoolean(rowSrvExt["Metalico"]);
            }
        }

        #endregion

        #region MÉTODOS-ACTUALIZAR

        private void _actualizaOrdenCAB()
        {
            objVentas.pro_ModeloOrden.Abono = seAbono.EditValue;
            objVentas.pro_ModeloOrden.id= txtCodigoORD.Text.ToInt();
            objVentas.pro_ModeloOrden.Orden= beOrden.Text.ToInt();
            objVentas.pro_ModeloOrden.NumCotiza= txtNumeroCOT.Text.ToInt();
            objVentas.pro_ModeloOrden.FecCotiza= deFechaCOT.EditValue;
            objVentas.pro_ModeloOrden.Item= txtItemORD.Text;
            objVentas.pro_ModeloOrden.FechaINI= deFechaINI.EditValue;
            objVentas.pro_ModeloOrden.FechaFAC= deFechaFAC.EditValue;
            objVentas.pro_ModeloOrden.FechaENTPP= deFechaPP.EditValue;
            objVentas.pro_ModeloOrden.FechaENT= deFechaENT.EditValue;
            objVentas.pro_ModeloOrden.FechaFIN = deFechaENT.EditValue;
            objVentas.pro_ModeloOrden.TipoOFF= rdgTipoOFF.EditValue;
            //DATOS CLIENTE
            objVentas.pro_ModeloOrden.CodigoCLI= beBuscaCLI.Text.ToInt();
            objVentas.pro_ModeloOrden.Cliente= txtNombreCLI.Text;
            //TOTALES
            objVentas.pro_ModeloOrden.Cantidad= seCantidad.EditValue;
            objVentas.pro_ModeloOrden.PreUnitario= sePrecioUNI.EditValue;
            objVentas.pro_ModeloOrden.Subtotal= seSubtotal.EditValue;
            objVentas.pro_ModeloOrden.IVA= seIVA.EditValue;
            objVentas.pro_ModeloOrden.Total= seTotal.EditValue;
            objVentas.pro_ModeloOrden.Abono= seAbono.EditValue;
            objVentas.pro_ModeloOrden.Saldo= seSaldo.EditValue;
        }

        private void _actualizaTrabajoGEN()
        {
            trabajoGenMOD modelo = objVentas.pro_ModeloTrabajoGEN;
            modelo.Trabajo=gen_lueTrabajo.EditValue.ToInt();
            modelo.Tiraje= gen_txtTiraje.EditValue.ToInt();
            modelo.TipoTrabajo= gen_lueTipoTrabajo.EditValue.ToInt();
            modelo.TipoTamano= gen_lueTamano.EditValue.ToInt();
            modelo.Ancho= gen_txtAncho.EditValue.ToInt();
            modelo.Alto= gen_txtAlto.EditValue.ToInt();
            modelo.TipoTroquel= gen_lueTroquel.EditValue.ToInt();
            modelo.OrdenTroquel= gen_txtOrdenTroquel.EditValue.ToInt();
            modelo.ColorTiro= gen_lueColorTiro.EditValue.ToInt();
            modelo.ColorRetiro= gen_lueColorRetiro.EditValue.ToInt();
            modelo.Pantones=gen_txtPantones.Text.ToString();
            objVentas.pro_ModeloTrabajoGEN = modelo;
        }

        private void _actualizaBlock()
        {
            blockMOD modelo = objVentas.pro_ModeloBlock;
            modelo.NumCopias= blo_lueNumCopias.EditValue.ToInt();
            modelo.Juego= blo_txtJuegos.EditValue.ToInt();
            modelo.TipoEmblocado= blo_lueTipoEmblocado.EditValue.ToInt();
            modelo.Serie= blo_txtSerie.Text.Trim();
            modelo.Inicia= blo_txtInicia.EditValue.ToInt();
            modelo.Termina= blo_txtTermina.EditValue.ToInt();
            modelo.TipoAcabado= blo_lueAcabado.EditValue.ToInt();
            modelo.TipoTamano= blo_lueTamano.EditValue.ToInt();
            modelo.Ancho= blo_txtAncho.EditValue.ToDecimal();
            modelo.Alto= blo_txtAlto.EditValue.ToDecimal();
            ////blo_beMaterial.EditValue = rowBlock["Material"];
            ////blo_txtGramos.EditValue = rowBlock["Gramos"];
            modelo.Tiraje= blo_txtTiraje.EditValue.ToInt();
            modelo.TipoTroquel= blo_lueTroquel.EditValue.ToInt();
            modelo.OrdenTroquel= blo_txtOrdenTroquel.EditValue.ToInt();
            modelo.Color= blo_lueColor.EditValue.ToInt();
            modelo.Pantones= blo_txtPantones.Text.ToString();
            objVentas.pro_ModeloBlock = modelo;
        }

        private void _actualizaLibroPOR()
        {
            libroPorMOD modelo = objVentas.pro_ModeloLibroPOR;
            modelo.TipoTamano = lib_lueTamanoPOR.EditValue.ToInt();
            modelo.Ancho = lib_txtAnchoPOR.EditValue.ToInt();
            modelo.Alto = lib_txtAltoPOR.EditValue.ToInt();
            modelo.TiroColor = lib_lueTiroColorPOR.EditValue.ToInt();
            modelo.RetiroColor = lib_lueRetiroColorPOR.EditValue.ToInt();
            modelo.ColorPantone = lib_txtColorPantonePOR.Text.Trim();
            modelo.TiroGuarda = lib_lueTiroGuardaPOR.EditValue.ToInt();
            modelo.RetiroGuarda = lib_lueRetiroGuardaPOR.EditValue.ToInt();
            modelo.TiroCubierta = lib_lueTiroCubiertaPOR.EditValue.ToInt();
            modelo.RetiroCubierta = lib_lueRetiroCubiertaPOR.EditValue.ToInt();
            objVentas.pro_ModeloLibroPOR = modelo;
        }

        private void _actualizaLibroENC()
        {
            libroEncMOD modelo = objVentas.pro_ModeloLibroENC;
            modelo.TipoLibro = lib_lueTipoLibro.EditValue.ToInt();
            modelo.FormaLibro = lib_lueForma.EditValue.ToInt();
            modelo.TipoTrabajo = lib_TipoTrabajoENC.EditValue.ToInt();
            modelo.TamanoTrabajo = lib_lueTamanoENC.EditValue.ToInt();
            modelo.Ancho = lib_txtAnchoENC.EditValue.ToDecimal();
            modelo.Alto = lib_txtAltoENC.EditValue.ToDecimal();
            modelo.NumPaginas = lib_txtNumPaginasENC.EditValue.ToInt();
            objVentas.pro_ModeloLibroENC = modelo;
            
        }

        #endregion

        #region BarraEstandar
        private void barraStandar_onNew()
        {
            objVentas._Nuevo();
            txtCodigoORD.Text = objVentas.pro_ModeloOrden.id.ToString();
            _CargaDET();
        }

        private void barraStandar_onSave()
        {
            _actualizaOrdenCAB();
            _actualizaTrabajoGEN();
            _actualizaBlock();
            _actualizaLibroPOR();
            _actualizaLibroENC();
            objVentas._guardaOrden();
        }

        private void barraStandar_onEdit()
        {
            string valor = null;
            int numero = valor.ToInt();
            
        }

        private void barraStandar_onDelete()
        {

        }

        private void barraStandar_onUndo()
        {

        }

        #endregion

        #region buttonEdit

        private void beOrden_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            objVentas._BuscarORD();
            if (objVentas.pro_ModeloOrden != null)
            {
                txtCodigoORD.Text = objVentas.pro_ModeloOrden.id.ToString();
                beOrden.Text = objVentas.pro_ModeloOrden.Orden.ToString();
                txtNumeroCOT.Text = objVentas.pro_ModeloOrden.NumCotiza.ToString();
                deFechaCOT.EditValue = objVentas.pro_ModeloOrden.FecCotiza;
                txtItemORD.Text = objVentas.pro_ModeloOrden.Item;
                deFechaINI.EditValue = objVentas.pro_ModeloOrden.FechaINI;
                deFechaFAC.EditValue = objVentas.pro_ModeloOrden.FechaFAC;
                deFechaPP.EditValue = objVentas.pro_ModeloOrden.FechaENTPP;
                deFechaENT.EditValue = objVentas.pro_ModeloOrden.FechaENT;
                rdgTipoOFF.EditValue = objVentas.pro_ModeloOrden.TipoOFF;
                //DATOS CLIENTE
                beBuscaCLI.Text = objVentas.pro_ModeloOrden.CodigoCLI.ToString();
                txtNombreCLI.Text = objVentas.pro_ModeloOrden.Cliente;
                //TOTALES
                seCantidad.EditValue = objVentas.pro_ModeloOrden.Cantidad;
                sePrecioUNI.EditValue = objVentas.pro_ModeloOrden.PreUnitario;
                seSubtotal.EditValue = objVentas.pro_ModeloOrden.Subtotal;
                seIVA.EditValue = objVentas.pro_ModeloOrden.IVA;
                seTotal.EditValue = objVentas.pro_ModeloOrden.Total;
                seAbono.EditValue = objVentas.pro_ModeloOrden.Abono;
                seSaldo.EditValue = objVentas.pro_ModeloOrden.Saldo;


                _CargaDET();
            }
        }

        private void beBuscaCLI_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow rowCliente = objVentas._BuscarCLI();
            if (rowCliente != null)
            {
                objVentas.pro_ModeloOrden.CodigoCLI = rowCliente["Código"].ToInt();
                beBuscaCLI.Text= rowCliente["Código"].ToString() ;
                txtNombreCLI.Text = rowCliente["Cliente"].ToString();
                _clienteCargaTEL();
            }
        }

        private void blo_beMaterial_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //_cargaMaterial(blo_beMaterial);
        }

        private void lib_beMaterialENC_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ////_cargaMaterial(lib_beMaterialENC);
        }

        private void lib_beMaterialGuardaPOR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _CargaMaterial(lib_beMaterialGuardaPOR);
        }

        private void lib_beMaterialCubiertaPOR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _CargaMaterial(lib_beMaterialCubiertaPOR);
        }

        private void lib_txtMaterialPOR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ////_cargaMaterial(lib_beMaterialPOR);
        }

        private void gen_beMaterial_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ////_cargaMaterial(gen_beMaterial);
        }

        #endregion

        private void gen_lueTrabajo_EditValueChanged(object sender, EventArgs e)
        {
            if (gen_lueTrabajo.EditValue != null)
            {
                DataTable dt_TipoTRA = objVentas._cargaCMBOPC(optionsCMB.TrabajoTipo, Convert.ToInt32(gen_lueTrabajo.EditValue));
                objVentas._cargaCMB(dt_TipoTRA, gen_lueTipoTrabajo);
            }
        }

        private void dis_ribeBuscaMAT_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (em_gvDetalleEGR.IsValidRowHandle(em_gvDetalleEGR.FocusedRowHandle))
            {
                DataRow currentRow = em_gvDetalleEGR.GetFocusedDataRow();
                DataRow rowSEL = objVentas._AgregaUnMAT();
                if (rowSEL != null)
                {
                    currentRow["CodMaterial"] = rowSEL["Secuencial"].ToString();
                    currentRow["Material"] = rowSEL["Descripción"].ToString();
                    em_gvDetalleEGR.RefreshRow(em_gvDetalleEGR.FocusedRowHandle);
                }
            }
        }

        #region MENU-CONTEXTUAL


        #region CMNU-ACABADO

        private void mnuAgregaAcabado_Click(object sender, EventArgs e)
        {
            objVentas._acabadoAgrega();
        }

        private void mnuQuitaAcabado_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region  CMNU-SUCURSALCLI
        private void mnuAgregarDestino_Click(object sender, EventArgs e)
        {
            objVentas._destinoAgrega();
        }

        private void mnuQuitarDestino_Click(object sender, EventArgs e)
        {

        }


        #endregion

        #region CMNU-AGREGAMATCLI

        private void mnuAgregaMaterialCLI_Click(object sender, EventArgs e)
        {
            objVentas._materialCLIAgrega();
        }

        private void mnuQuitaMaterialCLI_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion


        private void prd_lueProceso_EditValueChanged(object sender, EventArgs e)
        {
            prd_gcDetalle.DataSource = objVentas._produccionCargaDETPROC(prd_lueProceso.EditValue);
        }
    }
}
