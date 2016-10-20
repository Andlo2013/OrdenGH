using dllBuscar;
using dllMensaje;
using Ordenes.Modelos;
using Ordenes.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AutomatizerSQL.Utilidades;
using Ordenes.Formularios;
using DevExpress.XtraEditors.Repository;

namespace Ordenes.Clases
{
    public class clsCotizacion
    {
        //INSTANCIAS/VARIABLES DE LA CLASE
        #region INSTANCIAS-VARIABLES
        _SQLServer objSQLServer = frmPrincipal.getSQLServer;
        _Comunes objComunes = new _Comunes();
        
        //DATATABLES DETALLES
        DataTable dtClienteDEST = null;
        DataTable dtBlockColor = null;
        DataTable dtDisenoArmado = null;
        DataTable dtDisenoColor = null;
        DataTable dtDisenoPlaca = null;
        DataTable dtDisenoTroquel = null;
        DataTable dtDisenoAcabado = null;
        DataTable dtDisenoMaterialCLI = null;
        DataTable dtDisenoProcesoIMP = null;
        DataTable dtDisenoAccesorios = null;
        DataTable dtDisenoProcesoDET = null;
        DataTable dtDisenoGeneralGH = null;
        DataTable dtDisenoGeneralORI = null;
        DataTable dtTotalesRES = null;
        //DATATABLES PARA OPCIONES Y COMBOS DE LAS GRILLAS
        DataTable dtComponentes = null;
        DataTable dtDisenoPorCOB = null;
        DataTable dtTipoColor= null;
        DataTable dtTipoPlacas = null;
        DataTable dtCostosProcesoIMP = null;
        DataTable dtPorcentajePliegoEXT = null;
        //LISTAS PARA GUARDAR CON OBJETOS (MODELOS)
        List<armadoMOD> lista_Armado = null;
        List<coloresMOD> lista_Colores = null;
        List<placasMOD> lista_Placas = null;
        List<troquelMOD> lista_Troquel = null;
        List<acabadoMOD> lista_Acabado = null;
        List<accesorioMOD> lista_Accesorios = null;
        List<procesoIMPMOD> lista_ProcesosIMP = null;
        List<ProcesosMOD> lista_Procesos = null;
        //VARIABLES GLOBALES
        private string m_codEmpresa = frmPrincipal.getSession.Empresa.Codigo;
        private string m_Servidor = frmPrincipal.getSession.Servidor;
        private string m_Catalogo = frmPrincipal.getSession.Catalogo;
        private string m_BodegaMP = "MP";
        //FALTA DEFINIR DE DONDE SACA EL PARAMETRO COSTO DEL CORTE (DISENO-TROQUEL)
        private decimal m_CostoCorte = 2;
        //VALOR DE PINZAS SOLICITADO POR GLADYS QUE SE SUME EN FORMA AUTOMATICA 
        //A LAS MEDIDAS DE ANCHO Y ALTO DEL TRABAJO
        private decimal m_margenPinza = 1;

        #endregion

        public clsCotizacion() { _Inicializa(); }

        //METODOS GENERALES
        #region METODOS-GENERALES

        //Inicializa la tablas
        #region Inicializa
        private void _Inicializa()
        {
            dtDisenoPorCOB = objSQLServer._CargaDataTable(sqlCotizacion.cmb_cargaPorcentajeCOB,
                new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa });
            dtTipoColor = objSQLServer._CargaDataTable(sqlCotizacion.cmb_TipoColor,
                new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa });
            dtTipoPlacas = objSQLServer._CargaDataTable(sqlCotizacion.cot_cargaPlacas,
                new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa });
            dtCostosProcesoIMP = objSQLServer._CargaDataTable(sqlCotizacion.cot_cargaCostosProcesoIMP,
                new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa });
            dtComponentes = objSQLServer._CargaDataTable(sqlCotizacion.cmb_cargaCMB, 
                new string[] { "@Categoria" }, new object[] {optionsCMB.Diseno_Seccion });
            dtPorcentajePliegoEXT = objSQLServer._CargaDataTable(sqlCotizacion.cot_cargaPorcentajePliegoEXT,
                new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa });
        }
        #endregion

        //Cuando cambia el grupo de produccion
        #region CambiaGrupo
        public void _CambiaGrupo(object objCodGrupo)
        {
            try
            {
                if (dtDisenoArmado != null)
                {
                    foreach (DataRow rowArmado in dtDisenoArmado.Rows)
                    {
                        rowArmado["CodGrupo"] = objCodGrupo;
                        _disenoArmadoGetPorcentajeEXT(rowArmado);
                    }
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar actualizar el cambio de grupo", "Cambiar grupo", ex.InnerException.Message);
            }
        }
        #endregion

        //EMPLEADOS-VENDEDORES COTIZADORES
        #region Empleados

        public DataRow _empleadoBuscar()
        {
            try
            {
                frmBuscarITEM objBuscar = new frmBuscarITEM();
                Dictionary<string, string> dicFiltros = new Dictionary<string, string>();
                dicFiltros.Add("LTRIM(RTRIM((ISNULL(EplApl,'')+' '+ISNULL(EplNom,''))))", "Nombre");
                objBuscar.pro_Configura
                    ._set01Connection(m_Servidor, m_Catalogo)
                    ._set02Find(sqlCotizacion.cot_empleadoBusca, new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa })
                    ._set03OptionsFilter(dicFiltros)
                    ._setSeleccionSimple(true);
                objBuscar.ShowDialog();
                return objBuscar.pro_FilaSEL;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los registros", "Buscar vendedor", ex.Message);
                return null;
            }
        }

        #endregion

        //ACTUALIZA UNA COLUMNA COMPLETA EN UNA TABLA
        #region updateColumna
        private void _updateColumna(DataTable dt, string columna, object valor)
        {
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    row[columna] = valor;
                }
            }
        }
        #endregion

        //ACTUALIZA EL TIRAJE
        #region updateTiraje
        public void _updateTiraje(decimal tiraje)
        {
            _updateColumna(dtDisenoArmado, "Tiraje", tiraje);
            _updateColumna(dtDisenoColor, "Tiraje", tiraje);
            _updateColumna(dtDisenoAccesorios, "Tiraje", tiraje);
        }
        #endregion

        //PESTANA - CLIENTE
        #region PESTANA - CLIENTE

        //CLIENTE BUSCAR
        #region clienteBuscar
        public DataRow _clienteBuscar()
        {
            try
            {
                frmBuscarITEM objBuscar = new frmBuscarITEM();
                Dictionary<string, string> dicFiltros = new Dictionary<string, string>();
                dicFiltros.Add("LTRIM(RTRIM(ISNULL(dbo.climae.CliApl,'')+' '+ISNULL(dbo.climae.CliNom,'')))", "Cliente");
                objBuscar.pro_Configura
                    ._set01Connection(m_Servidor, m_Catalogo)
                    ._set02Find(sqlCotizacion.cot_clienteBuscar, new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa })
                    ._set03OptionsFilter(dicFiltros)
                    ._setSeleccionSimple(true);
                objBuscar.ShowDialog();
                return objBuscar.pro_FilaSEL;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los registros", ex.Message);
                return null;
            }
        }
        #endregion

        //CLIENTE CARGA DESTINOS
        #region clienteCargaDEST
        public DataTable _clienteCargaDEST(int cotizaID)
        {
            try
            {
                dtClienteDEST = objSQLServer._CargaDataTable(sqlCotizacion.cot_clienteCargaDestino,
                                                new string[] { "@CodEmpresa", "@cotizaID" },
                                                new object[] { m_codEmpresa, cotizaID });
                return dtClienteDEST;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar recuperar los destinos", "Cargar datos", ex.Message);
                return null;
            }
        }
        #endregion

        //CLIENTE CARGA TELEFONOS
        #region clienteCargaTEL
        public DataTable _clienteCargaTEL(object CodCliente)
        {
            try
            {
                DataTable dtClienteTEL = objSQLServer._CargaDataTable(sqlCotizacion.cot_cliCargaTelefono,
                                                new string[] { "@CodEmpresa", "@CodigoCLI" },
                                                new object[] { m_codEmpresa, CodCliente });
                return dtClienteTEL;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar recuperar los teléfonos del cliente", "Cargar datos", ex.Message);
                return null;
            }
        }
        #endregion

        //CLIENTE DESTINO AGREGA
        #region clienteDestinoAgrega
        public void _clienteDESTAgrega(int CodigoCLI)
        {
            try
            {
                DataRow[] filasSEL = _clienteDESTBuscar(CodigoCLI);
                if (filasSEL != null)
                {
                    foreach (DataRow row in filasSEL)
                    {
                        DataRow rowDestino = dtClienteDEST.NewRow();
                        rowDestino["Secuencial"] = 0;
                        rowDestino["CodSucursal"] = row["CodSucursal"];
                        rowDestino["Ciudad"] = row["Ciudad"];
                        rowDestino["Direccion"] = row["Dirección"];
                        rowDestino["Cantidad"] = 0;
                        dtClienteDEST.Rows.Add(rowDestino);
                    }
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar agregar el registro", "Agrega Destino", ex.Message);
            }

        }
        #endregion

        //CLIENTE DESTINO BUSCAR
        #region clienteDestinoBuscar
        private DataRow[] _clienteDESTBuscar(int CodigoCLI)
        {
            DataTable dtSucursales = objSQLServer._CargaDataTable(sqlQuery.ord_CLIAgregaSUC,
                new string[] { "@CodEmpresa", "@CodigoCLI" }, new object[] { m_codEmpresa, CodigoCLI });
            frmBuscar objBuscar = new frmBuscar(dtSucursales);
            objBuscar._setVisibleCOL(new string[] { "Ciudad", "Dirección" }, true);
            objBuscar._setAnchoCOL(new string[] { "Ciudad", "Dirección" }, new int[] { 400, 600 });
            objBuscar._setMultiSelect(true);
            objBuscar.ShowDialog();
            return objBuscar.proFilasSEL;
        }
        #endregion

        //CLIENTE DESTINO ELIMINA
        #region clienteDestinoElimina
        public void _clienteDESTElimina(DataRow rowElimina)
        {
            try
            {
                if (rowElimina != null)
                {
                    dtClienteDEST.Rows.Remove(rowElimina);
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar eliminar el registro", "Eliminar", ex.Message);
            }
        }
        #endregion

        //VALIDA EL DETALLE DE MATERIALES DEL CLIENTE
        #region clienteDESTValida
        public bool _clienteDESTValida(int Tiraje)
        {
            try
            {
                if (dtClienteDEST != null && dtClienteDEST.Rows.Count>0)
                {
                    int fila = 0;
                    foreach (DataRow row in dtClienteDEST.Rows)
                    {
                        fila++;
                        string msj = "En CLIENTE -> SUCURSALES" +
                            "\nEl registro de la fila Nro: " + fila.ToString();
                        if (row["Direccion"].ToString().Trim() =="")
                        {
                            msj += "\nLa dirección de envío es obligatorio";
                            clsMensaje._msjWarning(msj, "Lugares de envío");
                            return false;
                        }
                        else if (row["Cantidad"].ToDecimal() <= 0)
                        {
                            msj += "\nLa cantidad debe ser mayor a cero";
                            clsMensaje._msjWarning(msj, "Lugares de envío");
                            return false;
                        }
                    }
                    return _clienteDESTValidaEXT(Tiraje);
                }
                else
                {
                    clsMensaje._msjWarning("Es obligatorio registrar al menos una dirección de entrega", "Cliente-Destino");
                    return false;
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar verificar los lugares de envío", "Lugares de envío", ex.Message);
                return false;
            }
        }
        #endregion

        //VALIDACIONES EXTRAS DEL CLIENTE
        #region clienteDESTValidaEXT
        private bool _clienteDESTValidaEXT(int Tiraje)
        {
            //El tiraje debe ser igual a la suma de las cantidades a entregar en cada direccion
            int sumaCANTENT = dtClienteDEST.Compute("SUM(Cantidad)", "").ToInt();
            if (sumaCANTENT != Tiraje)
            {
                clsMensaje._msjWarning("En la pestaña cliente."+
                    "\nLa sumatoria de cantidades de entrega debe ser igual al tiraje",
                    "Cliente - Destino");
                return false;
            }
            return true;
        }
        #endregion

        #endregion

        //PESTANA - RESUMEN
        #region PESTANA - RESUMEN

        //CREA LA TABLA CON LOS TOTALES DE CADA COMPONENTE
        #region totales
        public DataTable _totales()
        {
            dtTotalesRES = new DataTable();
            dtTotalesRES.Columns.Add("Componente", Type.GetType("System.String"));
            dtTotalesRES.Columns.Add("Armados", Type.GetType("System.Decimal"));
            dtTotalesRES.Columns.Add("Colores", Type.GetType("System.Decimal"));
            dtTotalesRES.Columns.Add("Placas", Type.GetType("System.Decimal"));
            dtTotalesRES.Columns.Add("Troquel", Type.GetType("System.Decimal"));
            dtTotalesRES.Columns.Add("Acabados", Type.GetType("System.Decimal"));
            dtTotalesRES.Columns.Add("Accesorios", Type.GetType("System.Decimal"));
            dtTotalesRES.Columns.Add("Procesos", Type.GetType("System.Decimal"));
            dtTotalesRES.Columns.Add("ProcesosIMP", Type.GetType("System.Decimal"));
            dtTotalesRES.Columns.Add("TotalLinea", Type.GetType("System.Decimal"), "Armados+Colores+Placas+Troquel+Acabados+Accesorios+ProcesosIMP");

            if (dtDisenoArmado != null && dtDisenoColor != null)
            {
                string[] componentes = new string[] { "Guarda", "Portada", "Cubierta" };
                DataTable dtComponentes = objComunes._cargaDataCMB(optionsCMB.Diseno_Seccion);
                foreach (DataRow rowCMP in dtComponentes.Rows)
                {
                    object codComponente = rowCMP["Codigo"];

                    DataRow row = dtTotalesRES.NewRow();
                    row["Componente"] = rowCMP["Descripcion"];
                    row["Armados"] = dtDisenoArmado.Compute("SUM(TotalLinea)", "Componente=" + codComponente).ToDecimal();
                    row["Colores"] = dtDisenoColor.Compute("SUM(TotalLinea)", "Componente=" + codComponente).ToDecimal();
                    row["Placas"] = dtDisenoPlaca.Compute("SUM(TotalLinea)", "Componente=" + codComponente).ToDecimal();
                    row["Troquel"] = dtDisenoTroquel.Compute("SUM(TotalLinea)", "Componente=" + codComponente).ToDecimal();
                    row["Acabados"] = dtDisenoAcabado.Compute("SUM(TotalLinea)", "Componente=" + codComponente).ToDecimal();
                    row["Accesorios"] = dtDisenoAccesorios.Compute("SUM(TotalLinea)", "Componente=" + codComponente).ToDecimal();
                    //row["Procesos"] = dtProcesoDET.Compute("SUM(TotalLinea)", "Componente=" + codComponente);
                    row["ProcesosIMP"] = dtDisenoProcesoIMP.Compute("SUM(TotalLinea)", "Componente=" + codComponente).ToDecimal();
                    dtTotalesRES.Rows.Add(row);
                }
            }
            return dtTotalesRES;
        }
        #endregion

        //TOTAL GENERAL DE LA COTIZACION
        #region TotalGEN
        public decimal _TotalGEN()
        {
            if (dtTotalesRES != null) {
                return dtTotalesRES.Compute("SUM(TotalLinea)", "").ToDecimal();
            }
            return 0;
        }
        #endregion

        #endregion

        //PESTANA - DISENO
        #region PESTANA - DISENO

        //DISEÑO GENERAL
        #region Diseno-General

        //AGREGA UNA OPCION GENERAL AL DETALLE
        #region disenoGeneralAdd
        private void _disenoGeneralAdd(DataTable dtTabla, optionsCMB opcion)
        {
            try
            {
                DataRow[] rowsOpciones = _disenoGeneralListarOPC(opcion);
                if (dtTabla != null && rowsOpciones != null)
                {
                    foreach (DataRow rowOpcion in rowsOpciones)
                    {
                        if (dtTabla.Select("Codigo=" + rowOpcion["id"]).Length == 0)
                        {
                            DataRow newRow = dtTabla.NewRow();
                            newRow["Codigo"] = rowOpcion["id"];
                            newRow["Descripcion"] = rowOpcion["Descripción"];
                            dtTabla.Rows.Add(newRow);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar agregar el registro", "Agregar", ex.Message);
            }
        }
        #endregion

        //AGREGA OPCIONES DE GRÁFICAS HERNÁNDEZ
        #region disenoGeneralAddGH
        public void _disenoGeneralAddGH()
        {
            _disenoGeneralAdd(dtDisenoGeneralGH, optionsCMB.DisenoChkGH);
        }
        #endregion

        //AGREGA OPCIONES ORIGINALES
        #region disenoGeneralAddORI
        public void _disenoGeneralAddORI()
        {
            _disenoGeneralAdd(dtDisenoGeneralORI, optionsCMB.DisenoChkORI);
        }
        #endregion

        //CARGA EL DETALLE DE GENERALES
        #region disenoGeneralDET
        public void _disenoGeneralDET(int idCotiza)
        {
            try
            {
                //CARGA LAS OPCIONES DE GRAFICAS HERNANDEZ
                dtDisenoGeneralGH = objSQLServer._CargaDataTable(sqlCotizacion.cot_disGeneralDET,
                    new string[] { "@idCotiza", "@CategoriaID" }, new object[] { idCotiza, optionsCMB.DisenoChkGH });
                //CARGA LAS OPCIONES DE ORIGINALES
                dtDisenoGeneralORI = objSQLServer._CargaDataTable(sqlCotizacion.cot_disGeneralDET,
                    new string[] { "@idCotiza", "@CategoriaID" }, new object[] { idCotiza, optionsCMB.DisenoChkORI });
            }
            catch (Exception ex)
            {
                clsMensaje._msjError("ERROR Al intentar cargar la configuracion de DISEÑO->GENERAL", "DISEÑO GENERAL", ex.Message);
            }
        }
        #endregion

        //ELIMINA UN REGISTRO DE TABLAS GENERALES
        #region disenoGeneralEliminarREG
        public void _disenoGeneralEliminaREG(optionsCMB opcion, DataRow rowEliminar)
        {
            if (opcion == optionsCMB.DisenoChkGH)
            {
                dtDisenoGeneralGH.Rows.Remove(rowEliminar);
            }
            else if (opcion == optionsCMB.DisenoChkORI)
            {
                dtDisenoGeneralORI.Rows.Remove(rowEliminar);
            }
        }
        #endregion

        //LISTA LAS OPCIONES GENERALES A AGREGAR
        #region disenoGeneralListarOPC
        private DataRow[] _disenoGeneralListarOPC(optionsCMB opcion)
        {
            try
            {
                DataTable dtOpciones = objSQLServer._CargaDataTable(sqlCotizacion.cot_disGeneralAgregaDET,
                    new string[] { "@Categoria" }, new object[] { opcion });
                frmBuscar objBuscar = new frmBuscar(dtOpciones);
                objBuscar._setVisibleCOL(new string[] { "Descripción" }, true);
                objBuscar._setMultiSelect(true);
                objBuscar.ShowDialog();
                return objBuscar.proFilasSEL;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los registros", "Agregar opciones", ex.Message);
                return null;
            }
        }
        #endregion

        #endregion

        //DISEÑO ARMADOS
        #region Diseno-Armados

        //CARGA EL DETALLE DE LOS ARMADOS
        #region disenoArmadoCargaDET
        public DataTable _disenoArmadoCargaDET(int cotizaID,int tiraje,object CodGrupo)
        {
            try
            {
                dtDisenoArmado = objSQLServer._CargaDataTable(sqlCotizacion.cot_disArmadosDET,
                    new string[] { "@CodEmpresa", "@cotizaID" }, new object[] { m_codEmpresa, cotizaID });
                
                //AGREGA COLUMNAS AUXILIARES PARA CALCULO
                dtDisenoArmado.Columns.Add("CodGrupo", Type.GetType("System.Int32"));
                dtDisenoArmado.Columns.Add("PaginasXpliego", Type.GetType("System.Decimal"));
                dtDisenoArmado.Columns.Add("Tiraje", Type.GetType("System.Decimal"));
                dtDisenoArmado.Columns.Add("TrabajoAnchoMasPinza",Type.GetType("System.Decimal"), "TrabajoAncho+" + m_margenPinza);
                dtDisenoArmado.Columns.Add("TrabajoAltoMasPinza", Type.GetType("System.Decimal"), "TrabajoAlto+" + m_margenPinza);
                dtDisenoArmado.Columns.Add("PliegoCantidadAUX",Type.GetType("System.Decimal"));
                dtDisenoArmado.Columns.Add("Extra", Type.GetType("System.Decimal"), "Convert(PliegoCantidad*(PorcentajeEXT/100),'System.Int32')");
                dtDisenoArmado.Columns["CodGrupo"].DefaultValue = CodGrupo;
                dtDisenoArmado.Columns["NumPaginas"].DefaultValue = 1;
                dtDisenoArmado.Columns["PaginasXtrabajo"].DefaultValue = 1;
                dtDisenoArmado.Columns["PorcentajeEXT"].DefaultValue = 0;
                dtDisenoArmado.Columns["Tiraje"].DefaultValue = 0;
                dtDisenoArmado.Columns["AUT"].DefaultValue = true;
                dtDisenoArmado.Columns["CodPlaca"].DefaultValue = 0;
                dtDisenoArmado.Columns["TrabajosXtamano"].DefaultValue = 0;
                dtDisenoArmado.Columns["TamanosXpliego"].DefaultValue = 0;
                
                //actualiza el tiraje para que pueda hacer el calculo
                _updateColumna(dtDisenoArmado,"Tiraje",tiraje);
                //actualiza la columna codGrupo para recuperar los porcentajes de perdida al agregar o cambiar materiales
                _updateColumna(dtDisenoArmado,"CodGrupo", CodGrupo);
                //PAGINAS QUE SE IMPRIMEN POR PLIEGO
                dtDisenoArmado.Columns["PaginasXpliego"].Expression = "PaginasXtrabajo*TrabajosXtamano*TamanosXpliego";
                //ESTO PORQUE AL HACER UNA CONVERSION A (INT) DE ACUERDO A LOS DECIMALES A VECES REDONDEA AL INFERIOR Y FALTARIA UN PLIEGO
                dtDisenoArmado.Columns["PliegoCantidadAUX"].Expression= "Convert(IIF(PaginasXpliego>0,((NumPaginas*Tiraje)/PaginasXpliego),0),'System.Int32')";
                //ESTA ES LA CANTIDAD DEFINITICVA DE PLIEGOS.
                dtDisenoArmado.Columns["PliegoCantidad"].Expression = "IIF(PliegoCantidadAUX*PaginasXpliego>=(NumPaginas*Tiraje),PliegoCantidadAUX,PliegoCantidadAUX+1)";
                dtDisenoArmado.Columns["PliegoCotizados"].Expression = "PliegoCantidad+Extra";
                dtDisenoArmado.Columns.Add("TotalLinea", Type.GetType("System.Decimal"), "PliegoCotizados*Costo");
                return dtDisenoArmado;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el detalle de armados", "Cargar datos", ex.Message);
                return null;
            }
        }
        #endregion

        //FILTRA LOS MATERIALES DEL ARMADO POR EL COMPONENTE
        #region disenoArmadoFiltrar
        public DataView _disenoArmadoFiltrar(int codComponente)
        {
            if (dtDisenoArmado != null)
            {
                DataView dvFiltrar = new DataView(dtDisenoArmado);
                dvFiltrar.RowFilter = "Componente=" + codComponente;
                return dvFiltrar;
            }
            return null;
        }
        #endregion

        //AGREGA MATERIALES A LOS ARMADOS
        #region disenoArmadoAgregaMAT
        public void _disenoArmadoAgregaMAT(int aTrabajoAlto, int aTrabajoAncho, 
            int aTiraje,object codGrupo,object codComponente)
        {
            try
            {
                Dictionary<string, string> dicionario = new Dictionary<string, string>();
                dicionario.Add("Talla", "Grupo");
                frmBuscarITEM objBuscar = new frmBuscarITEM();
                objBuscar.pro_Configura
                    ._set01Connection(m_Servidor, m_Catalogo)
                    ._set02Find(sqlCotizacion.cot_disArmadosAgregaGrupo, 
                                new string[] { "@CodEmpresa" }, 
                                new object[] { m_codEmpresa })
                    ._set03OptionsFilter(dicionario)
                    ._setSeleccionSimple(false);

                objBuscar.ShowDialog();

                _disenoArmadoAddMAT(objBuscar.pro_dtFilasSEL,aTrabajoAlto,
                    aTrabajoAncho,aTiraje,codGrupo,codComponente);    
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar agregar materiales", "Agrega material", ex.Message);
            }
        }
        #endregion

        //AGREGA UN MATERIAL AL DETALLE
        #region disenoArmadoAddMAT
        private void _disenoArmadoAddMAT(DataTable filasSEL, decimal aTrabajoAlto,
            decimal aTrabajoAncho,int aTiraje,object codGrupo,object codComponente)
        {
            if (dtDisenoArmado != null && filasSEL != null)
            {
                clsCalculaCorte objCorte = new clsCalculaCorte();
                foreach (DataRow rowMAT in filasSEL.Rows)
                {
                    //NO PUEDE DUPLICAR EL MATERIAL EN LOS COMPONENTES
                    if (dtDisenoArmado.Select("Componente="+codComponente+
                        " AND CodTalla=" + rowMAT["Código"]).Length <= 0)
                    {
                        DataRow newRow = dtDisenoArmado.NewRow();
                        newRow["CodGrupo"] = codGrupo;
                        newRow["Componente"] = codComponente;
                        newRow["CodTalla"] = rowMAT["Código"];
                        newRow["Talla"] = rowMAT["Grupo"];
                        newRow["TrabajoAlto"] = aTrabajoAlto;
                        newRow["TrabajoAncho"] = aTrabajoAncho;
                        newRow["Tiraje"] = aTiraje;
                        dtDisenoArmado.Rows.Add(newRow);
                        //selecciona el pliego
                        objCorte._ext_disenoArmadoCalcula(newRow);
                        _disenoArmadoGetPorcentajeEXT(newRow);
                        _disenoPlacaAddPlaca(codComponente, newRow);
                        _disenoProcesoIMPAddREG(newRow);
                    }
                }
            }
        }
        #endregion

        //HACE EL CALCULO DE OPTIMIZAR CORTES
        #region disenoArmadoCalcula
        public void _disenoArmadoCalcula(DataRow rowSEL)
        {
            try
            {
                if (rowSEL != null)
                {
                    clsCalculaCorte objCorte = new clsCalculaCorte();
                    objCorte._ext_disenoArmadoCalcula(rowSEL);
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar calcular los valores de la fila", "Calcular fila", ex.Message);
            }
        }
        #endregion

        //HACE EL CALCULO Y MUESTRA LA GRAFICA DE CORTES
        #region disenoArmadoGrafica
        public void _disenoArmadoGrafica(DataRow rowSEL)
        {
            if (rowSEL != null)
            {
                frmCortes objCortes = new frmCortes();
                objCortes._ext_Graficar(rowSEL);
                objCortes.ShowDialog();
            }
        }
        #endregion

        //ELIMINA MATERIALES DE LOS ARMADOS
        #region disenoArmadoEliminaMAT
        public void _disenoArmadoEliminaMAT(DataRow rowElimina)
        {
            try
            {
                if (rowElimina != null)
                {
                    //ELIMINA TODAS LAS FILAS DE COLORES 
                    //QUE USEN EL MATERIAL EN EL COMPONENTE ELIMINADO
                    _disenoArmadoEliminaDEP(dtDisenoColor, rowElimina);
                    _disenoArmadoEliminaDEP(dtDisenoPlaca, rowElimina);
                    _disenoArmadoEliminaDEP(dtDisenoProcesoIMP, rowElimina);
                    _disenoArmadoEliminaDEP(dtDisenoTroquel, rowElimina);
                    _disenoArmadoEliminaDEP(dtDisenoAcabado, rowElimina);
                    dtDisenoArmado.Rows.Remove(rowElimina);
                    dtDisenoArmado.AcceptChanges();
                    
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar eliminar el registro", "Eliminar", ex.Message);
            }
        }
        #endregion

        //VALIDA EL DETALLE DE ARMADOS
        #region disenoArmadoValida
        public bool _disenoArmadoValida()
        {
            lista_Armado = new List<armadoMOD>();
            bool isValidTable = true;
            string nombreTabla = "TABLA: DISEÑO -> PAPEL";
            string msj = nombreTabla;
            try
            {
                if (dtDisenoArmado != null && dtDisenoArmado.Rows.Count > 0)
                {
                    int fila = 0;
                    foreach (DataRow row in dtDisenoArmado.Rows)
                    {
                        fila++;
                        string msjFila = "\nEl registro de la fila Nro: " + fila.ToString();
                        if (row.RowState != DataRowState.Deleted && row.RowState != DataRowState.Detached)
                        {
                            armadoMOD objArmado = _toEntity._row2object<armadoMOD>(row);
                            if (objArmado._validar())
                            {
                                lista_Armado.Add(objArmado);
                            }
                            else
                            {
                                msj += msjFila + "\n" + objArmado.pro_getErrrors;
                                isValidTable = false;
                            }
                        }
                    }
                    if (!isValidTable)
                    {
                        clsMensaje._msjWarning(msj, nombreTabla);
                    }
                    return isValidTable;
                }
                else
                {
                    clsMensaje._msjWarning("Es obligatorio ingresar al menos un registro de armados", "DISEÑO-ARMADOS");
                    return false;
                }   
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar verificar el detalle de:\n" + nombreTabla, nombreTabla, ex.Message);
                return false;
            }
        }
        #endregion

        //CALCULA EL COSTO DE LOS MATERIALES DEL ARMADO
        #region disenoArmadoTotales
        public decimal _disenoArmadoTotales()
        {
            decimal totalCostoPliego = 0;
            try
            {
                if (dtDisenoColor != null)
                {
                    //suma costos de la materia prima
                    totalCostoPliego = dtDisenoArmado.Compute("SUM(TotalLinea)", "").ToDecimal();
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar calcular los totales", "Totales", ex.Message);
            }
            return totalCostoPliego;
        }
        #endregion

        //LISTA LOS ITEMS DEL ARMADO PARA UTILIZAR EN OTRAS PESTANAS
        #region disenoArmadoListarREG
        /// <summary>
        /// Permite listar los registros del armado para agregar en las demas pestanas
        /// </summary>
        /// <param name="CodComponente">Codigo del componente que desea listar</param>
        /// <returns>DataRow[] con registros seleccionados</returns>
        public DataRow[] _disenoArmadoListarREG(object CodComponente)
        {
            if (dtDisenoArmado != null)
            {
                DataView dvColores = new DataView(dtDisenoArmado);
                dvColores.RowFilter = "Componente=" + CodComponente;
                frmBuscar objBuscar = new frmBuscar(dvColores.ToTable());
                objBuscar._setVisibleCOL(new string[] { "Material" }, true);
                objBuscar._setMultiSelect(true);
                objBuscar.ShowDialog();
                return objBuscar.proFilasSEL;
            }
            return null;
        }
        #endregion

        //ELIMINA UN REGISTRO DE ARMADOS (ELIMINA EN CADENA)
        #region disenoArmadoEliminaDEP
        public void _disenoArmadoEliminaDEP(DataTable dtEliminar, DataRow rowArmado)
        {
            string strFiltro = "Componente=" + rowArmado["Componente"] +
                " AND SecMaterial=" + rowArmado["SecMaterial"];
            //BUSCA LOS REGISTROS QUE SE DEBEN ELIMINAR
            DataRow[] rowsEliminar = dtEliminar.Select(strFiltro);
            if (rowsEliminar != null)
            {
                foreach (DataRow rowELI in rowsEliminar)
                {
                    dtEliminar.Rows.Remove(rowELI);
                }
            }
        }
        #endregion

        //VERIFICA SI HAY REGISTROS DEPENDIENTES AL ARMADO EN LAS DEMAS PESTAÑAS
        #region disenoArmadoVerficaDEP
        public bool _disenoArmadoVerificaDEP(DataRow rowArmado)
        {
            DataTable [] tablas=new DataTable[]{dtDisenoAcabado,dtDisenoColor,dtDisenoTroquel };
            int secMaterial = rowArmado["SecMaterial"].ToInt();
            foreach (DataTable dt in tablas)
            {
                if(_disenoArmadoTieneDependencia(dt, rowArmado["Componente"], secMaterial))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        //METODO PRINCIPAL DE VALIDACION DE DEPENDENCIA
        #region disenoArmadoTieneDependencia
        private bool _disenoArmadoTieneDependencia(DataTable dt,
            object objComponente,int SecMaterial)
        {
            if (dt != null)
            {
                DataRow[] filasSEL = dt.Select("Componente=" + objComponente +
                    " AND SecMaterial=" + SecMaterial);
                return (filasSEL != null && filasSEL.Length > 0) ? true : false;
            }
            return false;
        }
        #endregion

        //RECUPERA EL PORCENTAJE DE PLIEGOS EXTRAS QUE DEBE CALCULAR EN FUNCION DE:
        //GRUPO, COMPONENTE Y MATERIAL
        #region _disenoArmadoGetPorcentajeEXT
        private void _disenoArmadoGetPorcentajeEXT(DataRow rowArmado)
        {
            try
            {
                if (rowArmado != null)
                {
                    if (dtPorcentajePliegoEXT != null)
                    {
                        string filtro = "CodGrupo=" + rowArmado["CodGrupo"] +
                            " AND Componente=" + rowArmado["Componente"] +
                            " AND SecMaterial=" + rowArmado["SecMaterial"];
                        DataRow[] rowPorcentaje = dtPorcentajePliegoEXT.Select(filtro);
                        if (rowPorcentaje != null && rowPorcentaje.Length == 1)
                        {
                            rowArmado["PorcentajeEXT"] = rowPorcentaje[0]["Porcentaje"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar recuperar el porcentajes de pliegos extras", "Porcentaje pliegos extra", ex.InnerException.Message);
            }
        }
        #endregion

        #endregion

        //DISEÑO COLOR
        #region Diseno-Color

        //Agrega un color
        #region disenoColorAddColor
        public void _disenoColorAddColor(object CodComponente)
        {
            DataRow [] drFilasSEL = _disenoArmadoListarREG(CodComponente);
            if (dtDisenoColor != null && drFilasSEL!=null)
            {
                foreach (DataRow rowFila in drFilasSEL)
                {
                    DataRow rowColor = dtDisenoColor.NewRow();
                    rowColor["Componente"] = CodComponente;
                    rowColor["SecMaterial"] = rowFila["SecMaterial"];
                    rowColor["Material"] = rowFila["Material"];
                    rowColor["TrabajoAncho"] = rowFila["TrabajoAncho"];
                    rowColor["TrabajoAlto"] = rowFila["TrabajoAlto"];
                    rowColor["NumPaginas"] = rowFila["NumPaginas"];
                    rowColor["Tiraje"] = rowFila["Tiraje"];
                    dtDisenoColor.Rows.Add(rowColor);
                }
            }
        }

        #endregion

        //agrega un pantone
        #region disenoColorAgregaPantone
        public void _disenoColorAgregaPantone(DataRow rowModifica)
        {
            try
            {
                DataRow rowSEL = objComunes._agregaMATSimple();
                if (rowSEL != null)
                {
                    rowModifica["Pantone"] = rowSEL["Descripción"];
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar agregar materiales", "Agrega material", ex.Message);
            }
        }
        #endregion

        //agrega una cobertura
        #region disenoColorCargaCobertura
        public void _disenoColorCargaCobertura(RepositoryItemLookUpEdit lueCobertura)
        {
            lueCobertura.DataSource = dtDisenoPorCOB;
            lueCobertura.ForceInitialize();
            lueCobertura.DisplayMember = "Descripcion";
            lueCobertura.ValueMember = "Codigo";
        }
        #endregion

        //carga las planchas
        #region disenoColorCargaPlanchas
        public void _disenoColorCargaPlanchas(RepositoryItemLookUpEdit lueColorPlancha)
        {
            lueColorPlancha.DataSource = dtTipoColor;
            lueColorPlancha.ForceInitialize();
            lueColorPlancha.DisplayMember = "Descripcion";
            lueColorPlancha.ValueMember = "Codigo";
        }
        #endregion

        //cambia la cobertura
        #region disenoColorCambiaCobertura
        public void _disenoColorCambiaCobertura(DataRow rowColor)
        {
            object coberturaTiro = rowColor["Cobertura"];

            DataRow [] rowCobertura=dtDisenoPorCOB.Select("Codigo="+coberturaTiro,"");
            if (rowCobertura != null && rowCobertura.Length == 1)
            {
                rowColor["GramosXcm2"] = rowCobertura[0]["Gramos"];
            }
        }
        #endregion

        //Cambia la plancha
        #region disenoColorCambiaPlancha
        public void _disenoColorCambiaPlancha(DataRow rowColor)
        {
            object tipoColor = rowColor["Color"];

            DataRow[] rowColorPlancha = dtTipoColor.Select("Codigo=" + tipoColor, "");
            if (rowColorPlancha != null && rowColorPlancha.Length == 1)
            {
                rowColor["Color"] = rowColorPlancha[0]["Codigo"];
                rowColor["CostoGramo"] = rowColorPlancha[0]["CostoGramo"];
            }
        }
        #endregion

        //carga el detalle de colores
        #region disenoColorCargaDET
        public DataTable _disenoColorCargaDET(int cotizaID,int tiraje)
        {
            try
            {
                dtDisenoColor = objSQLServer._CargaDataTable(sqlCotizacion.cot_disColoresDET,
                    new string[] { "@CodEmpresa", "@cotizaID" }, new object[] { m_codEmpresa, cotizaID });
                dtDisenoColor.Columns.Add("Area", Type.GetType("System.Decimal"), "TrabajoAncho*TrabajoAlto");
                dtDisenoColor.Columns.Add("TotalGramos", Type.GetType("System.Decimal"), "Area*NumPaginas*GramosXcm2");
                dtDisenoColor.Columns.Add("Tiraje", Type.GetType("System.Decimal"));
                dtDisenoColor.Columns.Add("TotalLinea", Type.GetType("System.Decimal"), "TotalGramos*CostoGramo*Tiraje");

                dtDisenoColor.Columns["Area"].DefaultValue = 0;
                dtDisenoColor.Columns["Color"].DefaultValue = 0;
                dtDisenoColor.Columns["GramosXcm2"].DefaultValue=0;
                dtDisenoColor.Columns["LadoImpresion"].DefaultValue = 0;
                dtDisenoColor.Columns["NumPaginas"].DefaultValue = 0;
                dtDisenoColor.Columns["CostoGramo"].DefaultValue = 0;
                dtDisenoColor.Columns["Cobertura"].DefaultValue = 0;
                dtDisenoColor.Columns["Tiraje"].DefaultValue = tiraje;

                _updateColumna(dtDisenoColor, "Tiraje", tiraje);
                return dtDisenoColor;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el detalle de colores", "Cargar datos", ex.Message);
                return null;
            }
        }
        #endregion

        //elimina un registro de colores
        #region disenoColorElimina
        public void _disenoColorElimina(DataRow rowElimina)
        {
            try
            {
                if (rowElimina != null)
                {
                    dtDisenoColor.Rows.Remove(rowElimina);
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar eliminar el registro", "Eliminar", ex.Message);
            }
        }
        #endregion

        //filtra el detalle de acuerdo al componente seleccionado
        #region disenoColorFiltrar
        public DataView _disenoColorFiltrar(int codComponente)
        {
            DataView dvFiltrar = new DataView(dtDisenoColor);
            dvFiltrar.RowFilter = "Componente=" + codComponente;
            return dvFiltrar;
        }
        #endregion

        //calcula el costo total de colores
        #region disenoColorTotales
        public decimal[] _disenoColorTotales()
        {
            decimal gramosColor = 0;
            decimal gramosMetalizado = 0;
            decimal gramosPantone = 0;
            decimal totalCostoTinta = 0;
            try
            {
                if (dtDisenoColor != null)
                {
                    //suma unColor, dosColores, fullColor
                    gramosColor = dtDisenoColor.Compute("SUM(TotalGramos)", "Color=1").ToDecimal();
                    //suma Pantones
                    gramosPantone = dtDisenoColor.Compute("SUM(TotalGramos)", "Color=2").ToDecimal();
                    //suma Metalizado
                    gramosMetalizado = dtDisenoColor.Compute("SUM(TotalGramos)", "Color=3").ToDecimal();
                    
                    //suma costos de la tinta
                    totalCostoTinta = dtDisenoColor.Compute("SUM(TotalLinea)", "").ToDecimal();
                }
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar calcular los totales", "Totales", ex.Message);
            }
            return new decimal[] {gramosColor,gramosMetalizado,gramosPantone, totalCostoTinta };
        }
        #endregion

        //validaciones de colores
        #region disenoColorValida
        
        public bool _disenoColorValida()
        {
            lista_Colores = new List<coloresMOD>();
            bool isValidTable = true;
            string nombreTabla = "TABLA: DISEÑO -> COLORES";
            string msj = nombreTabla;
            try
            {
                if (dtDisenoColor != null && dtDisenoColor.Rows.Count>0)
                {
                    int fila = 0;
                    foreach (DataRow row in dtDisenoColor.Rows)
                    {
                        fila++;
                        string msjFila = "\nEl registro de la fila Nro: " + fila.ToString();
                        if (row.RowState != DataRowState.Deleted && row.RowState != DataRowState.Detached)
                        {
                            coloresMOD objColor = _toEntity._row2object<coloresMOD>(row);
                            if (objColor._validar())
                            {
                                lista_Colores.Add(objColor);
                            }
                            else
                            {
                                msj += msjFila + "\n" + objColor.pro_getErrrors;
                                isValidTable = false;
                            }
                        }
                    }
                    if (!isValidTable)
                    {
                        clsMensaje._msjWarning(msj, nombreTabla);
                    }
                    return isValidTable;
                }
                else
                {
                    clsMensaje._msjWarning("Es obligatorio ingresar al menos un registro en colores", "DISEÑO-COLORES");
                    return false;
                }
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar verificar el detalle:\n" + nombreTabla, nombreTabla, ex.Message);
                return false;
            }
        }

        #endregion

        #endregion

        //DISEÑO PLACAS
        #region Diseno-Placas

        //RECUPERA EL COSTO DE UNA PLACA
        #region disenoPlaca_auxCostoPlaca
        private object _disenoPlaca_auxCostoPlaca(object codPlaca)
        {
            if (dtTipoPlacas != null)
            {
                DataRow[] rowPlacas = dtTipoPlacas.Select("Codigo=" + codPlaca);
                return (rowPlacas != null && rowPlacas.Length == 1) ? rowPlacas[0]["CostoPlaca"] : 0;
            }
            return 0;
        }
        #endregion

        //AGREGA UNA PLACA
        #region disenoPlacaAddPlaca

        private void _disenoPlacaAddPlaca(object CodComponente, DataRow rowFila)
        {
            DataRow rowPlaca = dtDisenoPlaca.NewRow();
            rowPlaca["Componente"] = CodComponente;
            rowPlaca["SecMaterial"] = rowFila["SecMaterial"];
            rowPlaca["Material"] = rowFila["Material"];
            rowPlaca["CodPlaca"] = rowFila["CodPlaca"];
            rowPlaca["Placa"] = rowFila["Placa"];
            rowPlaca["NumPaginas"] = rowFila["NumPaginas"];
            rowPlaca["TrabajosXplaca"] = rowFila["TrabajosXtamano"];
            rowPlaca["PaginasXtrabajo"] = rowFila["PaginasXtrabajo"];
            rowPlaca["NumPlacas"] = 0;
            rowPlaca["CostoPlaca"] = _disenoPlaca_auxCostoPlaca(rowFila["CodPlaca"]);
            dtDisenoPlaca.Rows.Add(rowPlaca);
            //despues de agregar la fila asigna el valor de NumeroPlacas como valor recomendado
            rowPlaca["NumPlacas"] = rowPlaca["NumPlacasMIN"];
        }

        #endregion

        //CAMBIA EL NÚMERO DE COLORES DE LA PLACA
        #region disenoPlacaCambiaNumColores
        public void _disenoPlacaCambiaNumColores(DataRow rowColor)
        {
            if (rowColor != null)
            {
                if (dtDisenoProcesoIMP != null)
                {
                    string filtro = "Componente=" + rowColor["Componente"] +
                        " AND SecMaterial=" + rowColor["SecMaterial"];
                    DataRow [] rowProcesoIMP = dtDisenoProcesoIMP.Select(filtro);
                    if(rowProcesoIMP!=null && rowProcesoIMP.Length > 0)
                    {
                        foreach(DataRow rowProcIMP in rowProcesoIMP)
                        {
                            rowProcIMP["NumColores"] = rowColor["NumColores"];
                            _disenoProcesoIMPCostos(rowProcIMP);
                        }
                    }
                }
            }
        }
        #endregion

        //CARGA EL DETALLE DE PLACAS
        #region disenoPlacaCargaDET
        public DataTable _disenoPlacaCargaDET(int cotizaID)
        {
            try
            {
                string numPlacasAUX = "CONVERT(IIF(PaginasXplaca>0,NumPaginas/PaginasXplaca,0),'System.Int32')";
                string numPlacasMIN = "IIF((NumPlacasAUX*PaginasXplaca)>=NumPaginas,NumPlacasAUX,(NumPlacasAUX+1))";
                dtDisenoPlaca = objSQLServer._CargaDataTable(sqlCotizacion.cot_disPlacasDET,
                    new string[] { "@CodEmpresa", "@cotizaID" }, new object[] { m_codEmpresa, cotizaID });

                dtDisenoPlaca.Columns.Add("PaginasXplaca", Type.GetType("System.Int32"), "TrabajosXplaca*PaginasXtrabajo");
                dtDisenoPlaca.Columns.Add("NumPlacasAUX", Type.GetType("System.Decimal"), numPlacasAUX);
                dtDisenoPlaca.Columns.Add("NumPlacasMIN", Type.GetType("System.Decimal"), numPlacasMIN);

                dtDisenoPlaca.Columns.Add("TotalLinea", Type.GetType("System.Decimal"), "CostoPlaca*NumPlacas*NumColores");

                dtDisenoPlaca.Columns["LadoPlaca"].DefaultValue = 0;
                dtDisenoPlaca.Columns["NumPlacas"].DefaultValue = 0;
                dtDisenoPlaca.Columns["NumColores"].DefaultValue = 1;
                dtDisenoPlaca.Columns["CostoPlaca"].DefaultValue = 0;

                return dtDisenoPlaca;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el detalle de placas", "Cargar datos", ex.Message);
                return null;
            }
        }
        #endregion

        //FILTRA EL DETALLE DE PLACAS DE ACUERDO AL COMPONENTE
        #region disenoPlacaFiltrar
        public DataView _disenoPlacaFiltrar(int codComponente)
        {
            DataView dvFiltrar = new DataView(dtDisenoPlaca);
            dvFiltrar.RowFilter = "Componente=" + codComponente;
            return dvFiltrar;
        }
        #endregion

        //calcula el costo total de placas
        #region disenoPlacaTotales
        public decimal[] _disenoPlacaTotales()
        {
            decimal numPlacas = 0;
            decimal costoPlacas = 0;
            try
            {
                if (dtDisenoPlaca != null)
                {
                    //suma el numero de placas
                    numPlacas = dtDisenoPlaca.Compute("SUM(NumPlacas)", "").ToDecimal();
                    //suma el costo de placas
                    costoPlacas = dtDisenoPlaca.Compute("SUM(TotalLinea)", "").ToDecimal();
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar calcular los totales", "Totales", ex.Message);
            }
            return new decimal[] { numPlacas,costoPlacas};
        }
        #endregion

        //VALIDA EL DETALLE DE PLACAS
        #region disenoPlacaValida
        public bool _disenoPlacaValida()
        {
            lista_Placas = new List<placasMOD>();
            bool isValidTable = true;
            string nombreTabla = "TABLA: DISEÑO -> PLACAS";
            string msj = nombreTabla;
            try
            {
                if (dtDisenoPlaca != null)
                {
                    int fila = 0;
                    foreach (DataRow row in dtDisenoPlaca.Rows)
                    {
                        fila++;
                        string msjFila = "\nEl registro de la fila Nro: " + fila.ToString();
                        if (row.RowState != DataRowState.Deleted && row.RowState != DataRowState.Detached)
                        {
                            placasMOD objPlacas = _toEntity._row2object<placasMOD>(row);
                            if (objPlacas._validar())
                            {
                                lista_Placas.Add(objPlacas);
                            }
                            else
                            {
                                msj += msjFila + "\n" + objPlacas.pro_getErrrors;
                                isValidTable = false;
                            }
                        }
                    }
                }
                if (!isValidTable)
                {
                    clsMensaje._msjWarning(msj, nombreTabla);
                }
                return isValidTable;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar verificar el detalle de:\n" + nombreTabla, nombreTabla, ex.Message);
                return false;
            }
        }
        #endregion

        #endregion

        //DISEÑO ACABADO
        #region Diseno-Acabado
        
        //CARGA EL DETALLE DE ACABADOS
        #region disenoAcabadoCargaDET
        public void _disenoAcabadoCargaDET(int cotizaID)
        {
            try
            {
                dtDisenoAcabado = objSQLServer._CargaDataTable(sqlCotizacion.cot_disAcabadosDET,
                    new string[] { "@CodEmpresa", "@cotizaID" }, new object[] { m_codEmpresa, cotizaID });
                dtDisenoAcabado.Columns.Add("Area", Type.GetType("System.Decimal"),"Ancho*Alto");
                dtDisenoAcabado.Columns["TotalLinea"].Expression = "Area*Costo";
                dtDisenoAcabado.Columns["idAcabado"].DefaultValue = 0;
                dtDisenoAcabado.Columns["idTallaAcabado"].DefaultValue = 0;
                dtDisenoAcabado.Columns["SecMaterialAcabado"].DefaultValue = 0;
                dtDisenoAcabado.Columns["Acabado"].DefaultValue = 0;
                dtDisenoAcabado.Columns["Ancho"].DefaultValue = 0;
                dtDisenoAcabado.Columns["Alto"].DefaultValue = 0;
                dtDisenoAcabado.Columns["Costo"].DefaultValue = 0;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar recuperar el detalle de acabados", "Cargar Acabados", ex.Message);
            }
        }
        #endregion

        //AGREGA EL MATERIAL
        #region disenoAcabadoAddMaterial
        public void _disenoAcabadoAddMaterial(object codComponente)
        {
            DataRow[] filasSEL = _disenoArmadoListarREG(codComponente);
            if (filasSEL != null)
            {
                foreach(DataRow rowSEL in filasSEL)
                {
                    DataRow rowAcabado = dtDisenoAcabado.NewRow();
                    rowAcabado["Componente"] = codComponente;
                    rowAcabado["SecMaterial"] = rowSEL["SecMaterial"];
                    rowAcabado["Material"] = rowSEL["Material"];
                    rowAcabado["CodTalla"] = rowSEL["CodTalla"];
                    dtDisenoAcabado.Rows.Add(rowAcabado);
                }
            }
        }
        #endregion

        //AGREGA EL ACABADO
        #region disenoAcabadoAddAcabado
        public void _disenoAcabadoAddAcabado(DataRow rowDetalle)
        {
            DataTable dtAcabadoOPC = objSQLServer._CargaDataTable(sqlCotizacion.cot_disAcabadoADD,
                new string[] { "@CodTalla" }, new object[] { rowDetalle["CodTalla"] });

            frmBuscar objBuscar = new frmBuscar(dtAcabadoOPC);
            objBuscar._setVisibleCOL(new string[] {"Descripción","Costo" },true);
            objBuscar._setAnchoCOL(new string[] { "Descripción", "Costo" }, new int[] {800,200 });
            objBuscar._setMultiSelect(false);
            objBuscar.ShowDialog();
            DataRow rowSEL = objBuscar.proFilaSEL;
            if (rowSEL != null)
            {
                rowDetalle["idAcabado"] = rowSEL["idAcabado"];
                rowDetalle["Acabado"] = rowSEL["Descripción"];
                rowDetalle["areaAplica"] = rowSEL["AplicaA"];
                rowDetalle["idTallaAcabado"] = rowSEL["idTalla"];
                rowDetalle["Costo"] = rowSEL["Costo"];
                _disenoAcabadoAreaAplica(rowDetalle);
                _disenoAcabadoOptimizaMAT(rowDetalle);
            }
        }
        #endregion

        //DEFINE EL AREA DE APLICACION
        #region disenoAcabadoAreaAplica
        private void _disenoAcabadoAreaAplica(DataRow rowDetalle)
        {
            object ancho = 0;
            object alto = 0;
            if (rowDetalle != null)
            {
                string strFiltro = "Componente=" + rowDetalle["Componente"] +
                        " AND CodTalla=" + rowDetalle["CodTalla"] +
                        " AND SecMaterial=" + rowDetalle["SecMaterial"];

                DataRow[] rowArmados = dtDisenoArmado.Select(strFiltro);
                if (rowArmados != null && rowArmados.Length == 1)
                {
                    switch (rowDetalle["areaAplica"].ToString().Trim())
                    {
                        //APLICA AREA DE TRABAJO FINAL
                        case "T-FINAL":
                            ancho = rowArmados[0]["TrabajoAncho"];
                            alto = rowArmados[0]["TrabajoAlto"];
                            break;
                        //APLICA AREA DE PLIEGO DE IMPRESION
                        case "PLIE-IMP":
                            ancho = rowArmados[0]["TamanoAncho"];
                            alto = rowArmados[0]["TamanoAlto"];
                            break;
                    }
                }
                rowDetalle["Ancho"] = ancho;
                rowDetalle["Alto"] = alto;
            }
        }
        #endregion

        //ELIMINA UN REGISTRO DE ACABADOS
        #region disenoAcabadoElimina
        public void _disenoAcabadoElimina(DataRow rowElimina)
        {
            try
            {
                if (rowElimina != null)
                {
                    dtDisenoAcabado.Rows.Remove(rowElimina);
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar eliminar el registro", "Eliminar", ex.Message);
            }
        }
        #endregion

        //SELECCIONA EL MATERIAL QUE MENOS DESPERDICIE PARA LOS ACABADOS
        #region disenoAcabadoOptimizaMAT
        private void _disenoAcabadoOptimizaMAT(DataRow rowDetalle)
        {
            //SI TALLA DE ACABADO IGUAL A CERO ENTONCES NO HAY NADA QUE OPTIMIZAR
            if (rowDetalle != null && rowDetalle["idTallaAcabado"].ToInt() > 0)
            {
                DataTable dt = objSQLServer._CargaDataTable(sqlCotizacion.cot_disAcabadoCargaMAT,
                    new string[] { "@CodEmpresa", "@CodTalla" }, new object[] { m_codEmpresa, rowDetalle["idTallaAcabado"] });

                clsCalculaCorte objCorte = new clsCalculaCorte();
                objCorte._EligeMaterialAUT(dt, rowDetalle["Ancho"].ToDecimal(), rowDetalle["Alto"].ToDecimal());
                DataRow rowMaterial = objCorte.pro_MaterialSEL;
                rowDetalle["SecMaterialAcabado"] = rowMaterial["SecMaterial"];
                rowDetalle["AcabadoMaterial"] = rowMaterial["Material"];
            }
            else
            {
                //esto para limpiar en caso previamente tenia un acabado para optimizar el material
                rowDetalle["SecMaterialAcabado"] = 0;
                rowDetalle["AcabadoMaterial"] = "";
            }
        }
        #endregion

        //VALIDA EL DETALLE DE ACABADOS
        #region disenoAcabadoValida
        public bool _disenoAcabadoValida()
        {
            lista_Acabado = new List<acabadoMOD>();
            bool isValidTable = true;
            string nombreTabla = "TABLA: DISEÑO -> ACABADOS";
            string msj = nombreTabla;
            try
            {
                if (dtDisenoAcabado != null)
                {
                    int fila = 0;
                    foreach (DataRow row in dtDisenoAcabado.Rows)
                    {
                        fila++;
                        string msjFila = "\nEl registro de la fila Nro: " + fila.ToString();
                        if (row.RowState != DataRowState.Deleted && row.RowState != DataRowState.Detached)
                        {
                            acabadoMOD objAcabado = _toEntity._row2object<acabadoMOD>(row);
                            if (objAcabado._validar())
                            {
                                lista_Acabado.Add(objAcabado);
                            }
                            else
                            {
                                msj += msjFila + "\n" + objAcabado.pro_getErrrors;
                                isValidTable = false;
                            }
                        }
                    }
                }
                if (!isValidTable)
                {
                    clsMensaje._msjWarning(msj, nombreTabla);
                }
                return isValidTable;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar verificar el detalle de:\n" + nombreTabla, nombreTabla, ex.Message);
                return false;
            }
        }
        #endregion

        //FILTRA LOS MATERIALES DEL ACABADO POR EL COMPONENTE
        #region disenoAcabadoFiltrar
        public DataView _disenoAcabadoFiltrar(int codComponente)
        {
            if (dtDisenoAcabado != null)
            {
                DataView dvFiltrar = new DataView(dtDisenoAcabado);
                dvFiltrar.RowFilter = "Componente=" + codComponente;
                return dvFiltrar;
            }
            return null;
        }
        #endregion

        #endregion

        //DISENÑO PROCESOS
        #region Diseno-Proceso
        
        //CARGA EL DETALLE DE PROCESOS
        #region disenoProcesoCargaDET
        public DataTable _disenoProcesoCargaDET(int cotizaID)
        {
            try
            {
                dtDisenoProcesoDET = objSQLServer._CargaDataTable(sqlCotizacion.cot_disProcesoDET,
                    new string[] { "@CodEmpresa", "@cotizaID" }, new object[] { m_codEmpresa, cotizaID });
                dtDisenoProcesoDET.Columns.Add("TotalLinea", Type.GetType("System.Decimal"));
                dtDisenoProcesoDET.Columns["TotalLinea"].Expression = "Costo*Minutos";
                return dtDisenoProcesoDET;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el detalle de procesos", "Cargar datos", ex.Message);
                return null;
            }
        }
        #endregion

        //AGREGA PROCESOS A LA COTIZACION
        #region disenoProcesoAgregaMAQ
        public void _disenoProcesoAgregaMAQ(int tiraje)
        {
            try
            {
                DataTable dtMaquinas = objSQLServer._CargaDataTable(sqlCotizacion.cot_procBuscaMAQ,
                    new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa });
                dllBuscar.frmBuscar objBuscar = new dllBuscar.frmBuscar(dtMaquinas);
                objBuscar._setMultiSelect(true);
                objBuscar.ShowDialog();
                _disenoProcesoAddMAQ(objBuscar.proFilasSEL, tiraje);
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar agregar el proceso", "Procesos", ex.Message);
            }
        }
        #endregion

        //AGREGA LOS REGISTROS AL DETALLE
        #region disenoProcesoAddMAQ
        private void _disenoProcesoAddMAQ(DataRow[] filasSEL, int tiraje)
        {
            if (dtDisenoProcesoDET != null && filasSEL != null)
            {
                foreach (DataRow rowMAQ in filasSEL)
                {
                    int reg = dtDisenoProcesoDET.Select("CodigoMAQ='" + rowMAQ["Código"].ToString() + "'", "").Length;
                    if (reg <= 0)
                    {
                        DataRow newRow = dtDisenoProcesoDET.NewRow();
                        newRow["CodigoMAQ"] = rowMAQ["Código"];
                        newRow["Maquina"] = rowMAQ["Máquina"];
                        newRow["Costo"] = rowMAQ["Costo"];
                        newRow["Minutos"] = 0;
                        dtDisenoProcesoDET.Rows.Add(newRow);
                    }
                }
            }
        }
        #endregion

        //ELIMINA UN REGISTRO DE PROCESOS
        #region disenoProcesoElimina
        public void _disenoProcesoElimina(DataRow rowElimina)
        {
            try
            {
                if (rowElimina != null)
                {
                    dtDisenoProcesoDET.Rows.Remove(rowElimina);
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar eliminar el registro", "Eliminar", ex.Message);
            }
        }
        #endregion

        //VALIDA LOS PROCESOS GENERALES
        #region disenoProcesoValida
        public bool _disenoProcesoValida()
        {
            lista_Procesos = new List<ProcesosMOD>();
            bool isValidTable = true;
            string nombreTabla = "TABLA: DISEÑO -> PROCESOS";
            string msj = nombreTabla;
            try
            {
                if (dtDisenoProcesoDET != null && dtDisenoProcesoDET.Rows.Count>0)
                {
                    int fila = 0;
                    foreach (DataRow row in dtDisenoProcesoDET.Rows)
                    {
                        fila++;
                        string msjFila = "\nEl registro de la fila Nro: " + fila.ToString();
                        if (row.RowState != DataRowState.Deleted && row.RowState != DataRowState.Detached)
                        {
                            ProcesosMOD objProceso = _toEntity._row2object<ProcesosMOD>(row);
                            if (objProceso._validar())
                            {
                                lista_Procesos.Add(objProceso);
                            }
                            else
                            {
                                msj += msjFila + "\n" + objProceso.pro_getErrrors;
                                isValidTable = false;
                            }
                        }
                    }
                    if (!isValidTable)
                    {
                        clsMensaje._msjWarning(msj, nombreTabla);
                    }
                    return isValidTable;
                }
                else
                {
                    clsMensaje._msjWarning("Es obligatorio ingresar al menos un registro en los procesos", "DISEÑO-PROCESOS");
                    return false;
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar verificar el detalle de:\n" + nombreTabla, nombreTabla, ex.Message);
                return false;
            }
        }
        #endregion

        #endregion

        //DISEÑO PROCESO_IMPRESION
        #region Diseno-ProcesosImpresion

        //CARGA EL DETALLE DE LOS PROCESOS DE IMPRESION
        #region disenoProcesoIMPCargaDET
        public void _disenoProcesoIMPCargaDET(int cotizaID)
        {
            try
            {
                dtDisenoProcesoIMP = objSQLServer._CargaDataTable(sqlCotizacion.cot_disProcesoIMPDET,
                    new string[] { "@CodEmpresa", "@cotizaID" }, new object[] { m_codEmpresa, cotizaID });
                dtDisenoProcesoIMP.Columns["NumMinIMP"].Expression = "IIF(NumPliegos<=PliegosXmin OR PliegosXmin=0,1,NumPliegos/PliegosXmin)";
                dtDisenoProcesoIMP.Columns["TotalLinea"].Expression = "(CostoMinIMP*NumMinIMP)+(CostoXminPP*MinutosPP)";
                dtDisenoProcesoIMP.Columns["NumColores"].DefaultValue = 1;
                dtDisenoProcesoIMP.Columns["PliegosXmin"].DefaultValue = 0;
                dtDisenoProcesoIMP.Columns["CostoMinIMP"].DefaultValue = 0;
                dtDisenoProcesoIMP.Columns["CostoXminPP"].DefaultValue = 0;
                dtDisenoProcesoIMP.Columns["MinutosPP"].DefaultValue = 0;

            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar recuperar el detalle de acabados", "Cargar Acabados", ex.Message);
            }
        }
        #endregion

        //FILTRA LOS PROCESOS DE IMPRESION POR EL COMPONENTE
        #region disenoProcesoIMPFiltrar
        public DataView _disenoProcesoIMPFiltrar(int codComponente)
        {
            if (dtDisenoProcesoIMP != null)
            {
                DataView dvFiltrar = new DataView(dtDisenoProcesoIMP);
                dvFiltrar.RowFilter = "Componente=" + codComponente;
                return dvFiltrar;
            }
            return null;
        }
        #endregion

        //AGREGA UN REGISTRO 
        #region disenoProcesoIMPAddREG
        public void _disenoProcesoIMPAddREG(DataRow rowArmado)
        {
            DataRow rowProcesoIMP = dtDisenoProcesoIMP.NewRow();
            rowProcesoIMP["Componente"] = rowArmado["Componente"];
            rowProcesoIMP["idTalla"] = rowArmado["CodTalla"];
            rowProcesoIMP["Talla"] = rowArmado["Talla"];
            rowProcesoIMP["SecMaterial"] = rowArmado["SecMaterial"];
            rowProcesoIMP["Material"] = rowArmado["Material"];
            rowProcesoIMP["PlacaID"] = rowArmado["CodPlaca"];
            rowProcesoIMP["Placa"] = rowArmado["Placa"];
            rowProcesoIMP["NumPliegos"] = rowArmado["PliegoCotizados"];

            dtDisenoProcesoIMP.Rows.Add(rowProcesoIMP);
            _disenoProcesoIMPCostos(rowProcesoIMP);
        }
        #endregion

        //RECUPERA LOS COSTOS DE LOS PROCESOS DE IMPRESION
        #region disenoProcesoIMPCostos
        private void _disenoProcesoIMPCostos(DataRow rowProcesoIMP)
        {
            if (dtCostosProcesoIMP != null)
            {
                //BUSCA LOS COSTOS DE PROCESO DE IMPRESION FILTRADO POR: TALLA(GRUPO DE MATERIAL A IMPRIMIR), PLACA, NUMERO DE COLORES
                DataRow [] rowCosto = dtCostosProcesoIMP.Select("idTalla=" + rowProcesoIMP["idTalla"] +
                    "AND idPlaca=" + rowProcesoIMP["PlacaID"]+" AND NumColores="+rowProcesoIMP["NumColores"]);

                if (rowCosto != null && rowCosto.Length == 1)
                {
                    rowProcesoIMP["PliegosXmin"] = rowCosto[0]["NumPliegosXmin"];
                    rowProcesoIMP["CostoMinIMP"] = rowCosto[0]["CostoImpMin"];
                    rowProcesoIMP["CostoXminPP"] = rowCosto[0]["CostoMinPP"];
                    rowProcesoIMP["MinutosPP"] = rowCosto[0]["NumMinPP"];
                }
            }
        }
        #endregion

        //VALIDA EL DETALLE DE PROCESOS DE IMPRESIÓN
        #region disenoProcesoIMPValida
        public bool _disenoProcesoIMPValida()
        {
            lista_ProcesosIMP = new List<procesoIMPMOD>();
            bool isValidTable = true;
            string nombreTabla = "TABLA: DISEÑO -> PROC. IMP";
            string msj = nombreTabla;
            try
            {
                if (dtDisenoProcesoIMP != null)
                {
                    int fila = 0;
                    foreach (DataRow row in dtDisenoProcesoIMP.Rows)
                    {
                        fila++;
                        string msjFila = "\nEl registro de la fila Nro: " + fila.ToString();
                        if (row.RowState != DataRowState.Deleted && row.RowState != DataRowState.Detached)
                        {
                            procesoIMPMOD objProcesoIMP = _toEntity._row2object<procesoIMPMOD>(row);
                            if (objProcesoIMP._validar())
                            {
                                lista_ProcesosIMP.Add(objProcesoIMP);
                            }
                            else
                            {
                                msj += msjFila + "\n" + objProcesoIMP.pro_getErrrors;
                                isValidTable = false;
                            }
                        }
                    }
                }
                if (!isValidTable)
                {
                    clsMensaje._msjWarning(msj, nombreTabla);
                }
                return isValidTable;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar verificar el detalle de:\n" + nombreTabla, nombreTabla, ex.Message);
                return false;
            }
        }
        #endregion

        #endregion

        //DISEÑO ACCESORIOS
        #region Diseno-Accesorios

        //AGREGAR ACCESORIO
        #region disenoAccesorioAgregar
        public void _disenoAccesorioAgregar(object CodComponente, int tiraje)
        {
            Dictionary<string, string> dic_filtro = new Dictionary<string, string>()
            { {"dbo.ItmMae.ItmDsc","Descripción" } };

            frmBuscarITEM objBuscar = new frmBuscarITEM();
            objBuscar.pro_Configura
                ._set01Connection(m_Servidor, m_Catalogo)
                ._set02Find(sqlCotizacion.cot_disAccesoriosAddAccesorio,
                new string[] { "@CodEmpresa", "@CodBodega" }, new object[] { m_codEmpresa, m_BodegaMP })
                ._set03OptionsFilter(dic_filtro)
                ._setVisibleCOL(true, new string[] { "Código", "Descripción", "Secuencial" })
                ._setSeleccionSimple(false);
            objBuscar.ShowDialog();
            _disenoAccesorioAdd(objBuscar.pro_dtFilasSEL, CodComponente, tiraje);
        }
        #endregion

        //AGREGA EL REGISTRO
        #region disenoAccesorioAdd
        private void _disenoAccesorioAdd(DataTable dtAccesorios, object CodComponente, int tiraje)
        {
            if (dtAccesorios != null)
            {
                foreach (DataRow rowAccesorio in dtAccesorios.Rows)
                {
                    if (dtDisenoAccesorios.Select("Componente=" + CodComponente
                        + " AND SecMaterial=" + rowAccesorio["Secuencial"]).Length == 0)
                    {
                        DataRow newRow = dtDisenoAccesorios.NewRow();
                        newRow["Componente"] = CodComponente;
                        newRow["SecMaterial"] = rowAccesorio["Secuencial"];
                        newRow["Material"] = rowAccesorio["Descripción"];
                        newRow["Costo"] = rowAccesorio["Costo"];
                        newRow["Tiraje"] = tiraje;
                        dtDisenoAccesorios.Rows.Add(newRow);
                    }
                }
            }
        }
        #endregion

        //CARGA EL DETALLE DE LOS ACCESORIOS
        #region disenoAccesoriosCargaDET
        public DataTable _disenoAccesoriosCargaDET(int cotizaID)
        {
            try
            {
                dtDisenoAccesorios = objSQLServer._CargaDataTable(sqlCotizacion.cot_disAccesoriosDET,
                    new string[] { "@CodEmpresa", "@cotizaID" }, new object[] { m_codEmpresa, cotizaID });

                dtDisenoAccesorios.Columns["TotalLinea"].Expression = "Tiraje*Costo*Cantidad";
                dtDisenoAccesorios.Columns["Cantidad"].DefaultValue = 1;
                dtDisenoAccesorios.Columns["Costo"].DefaultValue = 0;

                return dtDisenoAccesorios;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el detalle de accesorios", "Cargar datos", ex.Message);
                return null;
            }
        }
        #endregion

        //ELIMINA UN REGISTRO
        #region disenoAccesorioEliminar
        public void _disenoAccesorioEliminar(DataRow rowEliminar)
        {
            if (rowEliminar != null)
            {
                dtDisenoAccesorios.Rows.Remove(rowEliminar);
                dtDisenoAccesorios.AcceptChanges();
            }
        }
        #endregion

        //FILTRA LOS ACCESORIOS POR EL COMPONENTE
        #region disenoAccesoriosFiltrar
        public DataView _disenoAccesoriosFiltrar(int codComponente)
        {
            if (dtDisenoAccesorios != null)
            {
                DataView dvFiltrar = new DataView(dtDisenoAccesorios);
                dvFiltrar.RowFilter = "Componente=" + codComponente;
                return dvFiltrar;
            }
            return null;
        }
        #endregion

        //VALIDA EL DETALLE DE PROCESOS DE IMPRESIÓN
        #region disenoAccesoriosValida
        public bool _disenoAccesoriosValida()
        {
            lista_Accesorios = new List<accesorioMOD>();
            bool isValidTable = true;
            string nombreTabla = "TABLA: DISEÑO -> ACCESORIOS";
            string msj = nombreTabla;
            try
            {
                if (dtDisenoAccesorios != null)
                {
                    int fila = 0;
                    foreach (DataRow row in dtDisenoAccesorios.Rows)
                    {
                        fila++;
                        string msjFila = "\nEl registro de la fila Nro: " + fila.ToString();
                        if (row.RowState != DataRowState.Deleted && row.RowState != DataRowState.Detached)
                        {
                            accesorioMOD objAccesorio = _toEntity._row2object<accesorioMOD>(row);
                            if (objAccesorio._validar())
                            {
                                lista_Accesorios.Add(objAccesorio);
                            }
                            else
                            {
                                msj += msjFila + "\n" + objAccesorio.pro_getErrrors;
                                isValidTable = false;
                            }
                        }
                    }
                }
                if (!isValidTable)
                {
                    clsMensaje._msjWarning(msj, nombreTabla);
                }
                return isValidTable;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar verificar el detalle de:\n" + nombreTabla, nombreTabla, ex.Message);
                return false;
            }
        }
        #endregion

        #endregion

        //DISENO-TROQUEL
        #region Diseno-Troquel

        //Agrega un registro de troquel
        #region disenoTroquelAddTroquel
        public void _disenoTroquelAddTroquel(object CodComponente)
        {
            DataRow[] drFilasSEL = _disenoArmadoListarREG(CodComponente);
            if (dtDisenoTroquel != null && drFilasSEL != null)
            {
                foreach (DataRow rowFila in drFilasSEL)
                {
                    DataRow rowTroquel = dtDisenoTroquel.NewRow();
                    rowTroquel["Componente"] = CodComponente;
                    rowTroquel["SecMaterial"] = rowFila["SecMaterial"];
                    rowTroquel["Material"] = rowFila["Material"];
                    rowTroquel["Longitud"] = (rowFila["TrabajoAncho"].ToDecimal()*2)+ (rowFila["TrabajoAlto"].ToDecimal()*2);
                    rowTroquel["numCortes"] = 1;
                    rowTroquel["CostoCorte"] = m_CostoCorte;
                    dtDisenoTroquel.Rows.Add(rowTroquel);
                }
            }
        }
        #endregion

        //Carga el detalle de troqueles
        #region disenoTroquelCargaDET
        public void _disenoTroquelCargaDET(int cotizaID)
        {
            try
            {
                dtDisenoTroquel = objSQLServer._CargaDataTable(sqlCotizacion.cot_disTroquelDET,
                    new string[] { "@CodEmpresa", "@cotizaID" }, new object[] { m_codEmpresa,cotizaID  });

                dtDisenoTroquel.Columns["CostoCorte"].DefaultValue = m_CostoCorte;
                dtDisenoTroquel.Columns.Add("TotalLinea", Type.GetType("System.Decimal"), "Longitud*NumCortes*CostoCorte");
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los registros", "Cargar troquel", ex.Message);
            }
        }
        #endregion

        //Elimina un registro de troquel
        #region disenoTroquelEliminar
        public void _disenoTroquelElimina(DataRow rowElimina)
        {
            try
            {
                if (rowElimina != null)
                {
                    dtDisenoTroquel.Rows.Remove(rowElimina);
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar eliminar el registro", "Eliminar", ex.Message);
            }
        }
        #endregion

        //Filtra el detalle de los troqueles de acuerdo al componente
        #region disenoTroquelFiltrar
        public DataView _disenoTroquelFiltrar(int codComponente)
        {
            DataView dvFiltrar = new DataView(dtDisenoTroquel);
            dvFiltrar.RowFilter = "Componente=" + codComponente;
            return dvFiltrar;
        }
        #endregion

        //calcula el costo total de placas
        #region disenoTroquelTotales
        public decimal[] _disenoTroquelTotales()
        {
            decimal totalLongitud = 0;
            decimal costoTroquel = 0;
            try
            {
                if (dtDisenoTroquel != null)
                {
                    //suma el costo de placas
                    totalLongitud = dtDisenoTroquel.Compute("SUM(Longitud)", "").ToDecimal();
                    //suma el numero de placas
                    costoTroquel = dtDisenoTroquel.Compute("SUM(TotalLinea)", "").ToDecimal();
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar calcular los totales", "Totales", ex.Message);
            }
            return new decimal[] { totalLongitud, costoTroquel };
        }
        #endregion

        //VALIDA EL DETALLE DE TROQUELES
        #region disenoTroquelValida
        public bool _disenoTroquelValida()
        {
            lista_Troquel = new List<troquelMOD>();
            bool isValidTable = true;
            string nombreTabla = "TABLA: DISEÑO -> TROQUEL";
            string msj = nombreTabla;
            try
            {
                if (dtDisenoTroquel != null)
                {
                    int fila = 0;
                    foreach (DataRow row in dtDisenoTroquel.Rows)
                    {
                        fila++;
                        string msjFila = "\nEl registro de la fila Nro: " + fila.ToString();
                        if (row.RowState != DataRowState.Deleted && row.RowState != DataRowState.Detached)
                        {
                            troquelMOD objTroquel = _toEntity._row2object<troquelMOD>(row);
                            bool isValidModel = objTroquel._validar();
                            if (objTroquel._validar())
                            {
                                lista_Troquel.Add(objTroquel);
                            }
                            else
                            {
                                msj += msjFila + "\n" + objTroquel.pro_getErrrors;
                                isValidTable = false;
                            }
                        }
                    }
                }
                if (!isValidTable)
                {
                    clsMensaje._msjWarning(msj, nombreTabla);
                }
                return isValidTable;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar verificar el detalle de:\n" + nombreTabla, nombreTabla, ex.Message);
                return false;
            }
        }
        #endregion

        //MATERIALES-CLIENTE
        #region Diseno-MaterialCliente
        
        //CARGA EL DETALLE DE MATERIALES DEL CLIENTE
        #region disenoMATCLICargaDET
        public DataTable _disenoMATCLICargaDET(int cotizaID)
        {
            try
            {
                dtDisenoMaterialCLI = objSQLServer._CargaDataTable(sqlCotizacion.cot_disMATCLICargaDET,
                    new string[] {"@CodEmpresa", "@cotizaID" }, new object[] { m_codEmpresa,cotizaID });
                return dtDisenoMaterialCLI;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el detalle de materiales del cliente", "Cargar datos", ex.Message);
                return null;
            }
        }
        #endregion

        //LISTA LAS OPCIONES DE MATERIALES DEL CLIENTE PARA QUE AGREGUE EL USUARIO
        #region disenoMATCLIAgregaMAT
        public void _disenoMATCLIAgregaMAT()
        {
            try
            {
                DataTable dtFilasSEL = objComunes._agregaMATMultiple();
                _disenoMATCLIAddMAT(dtFilasSEL);
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar agregar materiales", "Agrega material", ex.Message);
            }
        }
        #endregion

        //AGREGA UN REGISTRO A MATERIALES DEL CLIENTE
        #region disenoMATCLIAddMAT
        private void _disenoMATCLIAddMAT(DataTable filasSEL)
        {
            if (dtDisenoMaterialCLI != null && filasSEL != null)
            {
                foreach (DataRow rowMAT in filasSEL.Rows)
                {
                    int reg = dtDisenoMaterialCLI.Select("SecMaterial=" + rowMAT["Secuencial"].ToString(), "").Length;
                    if (reg <= 0)
                    {
                        DataRow newRow = dtDisenoMaterialCLI.NewRow();
                        newRow["SecMaterial"] = rowMAT["Secuencial"];
                        newRow["Material"] = rowMAT["Descripción"];
                        newRow["Cantidad"] = 0;
                        dtDisenoMaterialCLI.Rows.Add(newRow);
                    }
                }
            }
        }
        #endregion

        //ELIMINA UN REGISTRO DE MATERIALES DEL CLIENTE
        #region disenoMATCLIEliminaMAT
        public void _disenoMATCLIEliminaMAT(DataRow rowElimina)
        {
            try
            {
                if (rowElimina != null)
                {
                    dtDisenoMaterialCLI.Rows.Remove(rowElimina);
                }
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar eliminar el registro", "Eliminar", ex.Message);
            }
        }
        #endregion

        //VALIDA EL DETALLE DE MATERIALES DEL CLIENTE
        #region disenoMATCLIValida
        public bool _disenoMATCLIValida()
        {
            try
            {
                if (dtDisenoMaterialCLI != null)
                {
                    int fila = 0;
                    foreach (DataRow row in dtDisenoMaterialCLI.Rows)
                    {
                        fila++;
                        string msj = "En DISEÑO -> MATERIALES CLIENTE" +
                            "\nEl registro de la fila Nro: " + fila.ToString();
                        if (row["SecMaterial"].ToInt() <= 0)
                        { 
                            msj += "\nEl secuencial de material es obligatorio";
                            clsMensaje._msjWarning(msj, "Materiales cliente");
                            return false;
                        }
                        else if (row["Cantidad"].ToDecimal() <= 0)
                        {
                            msj += "\nLa cantidad debe ser mayor a cero";
                            clsMensaje._msjWarning(msj, "Materiales cliente");
                            return false;
                        }
                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar verificar los materiales del cliente:\n", "Materiales cliente",ex.Message);
                return false;
            }
        }
        #endregion

        #endregion

        #endregion

        #endregion

        //PESTANA - BLOCKS
        #region PESTANA - BLOCK

        //Carga el detalle de colores del block
        #region blockColorCargaDET
        public DataTable _blockColorCargaDET(int cotizaID)
        {
            try
            {
                dtBlockColor = objSQLServer._CargaDataTable(sqlCotizacion.cot_blockCargaColor,
                    new string[] { "@cotizaID" }, new object[] { cotizaID });
                return dtBlockColor;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los colores del block", "Cargar datos", ex.Message);
                return null;
            }
        }
        #endregion

        //Elimina un registro de colores
        #region clockColorElimina
        public void _blockColorElimina(DataRow rowElimina)
        {
            try
            {
                if (rowElimina != null)
                {
                    dtBlockColor.Rows.Remove(rowElimina);
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar eliminar el registro", "Eliminar", ex.Message);
            }
        }
        #endregion

        #endregion

        #endregion

        //METODOS PARA GUARDAR
        #region METODOS-GUARDA

        //Guardar metodo principal
        #region Guardar
        /// <summary>
        /// Guarda cotizacion. Metodo principal
        /// </summary>
        /// <param name="modelo_Cotiza">objeto de la cotizacion a guardar</param>
        /// <param name="modelo_Block">objecto de block a guardar</param>
        /// <param name="accion">Accion a realizar (NUEVO ó EDITAR)</param>
        /// <returns>True=Completado; False=Error al guardar</returns>
        public bool _Guardar(cotizaMOD modelo_Cotiza,blockMOD modelo_Block,string accion)
        {
            try
            {
                objSQLServer._Open();
                objSQLServer._BeginTransacction();
                if (accion.ToUpper() == "NUEVO")
                {
                    //calcula el id y el numero de cotizacion 
                    modelo_Cotiza._nuevaCOT();
                }
                else
                {
                    objSQLServer._Ejecutar(sqlCotizacion.cot_EliminaG,
                        new string[] { "@idCotiza" }, new object[] { modelo_Cotiza.id });
                }
                //guarda la cabecera de la cotizacion
                modelo_Cotiza._guardaCOT();
                

                //guarda los detalles
                _guardaCLIDestino(modelo_Cotiza.id);
                _guardaGeneral(modelo_Cotiza.id);
                _guardaProceso(modelo_Cotiza.id);
                _guardaMaterialCLI(modelo_Cotiza.id);

                _guardaComponente(modelo_Cotiza.id);
                //GUARDA LOS BLOCKS
                _guardaBlock(modelo_Block, modelo_Cotiza.id);
                objSQLServer._Commit();
                objSQLServer._Close();

                return true;
            }
            catch(Exception ex)
            {
                objSQLServer._RollBack();
                objSQLServer._Close();
                clsMensaje._msjError("ERROR: Al intentar guardar el registro", "Guarda cotización", ex.InnerException.Message);
                return false;
            }
        }
        #endregion

        //Guarda los bloques
        #region guardaBlock
        private void _guardaBlock(blockMOD modelo_Block,int idCotiza)
        {
            if (modelo_Block != null)
            {
                //GUARDA LA CABECERA DE LOS BLOCKS
                modelo_Block._guardaBlock(idCotiza);
                //GUARDA EL DETALLE DE LOS BLOCKS
                _guardaBlockDET(idCotiza);
            }
        }
        #endregion

        //Guarda el detalle de bloques
        #region guardaBlockDET
        private void _guardaBlockDET(int idCotiza)
        {
            if (dtBlockColor != null)
            {
                string[] paramsName = new string[] { "@idCotiza","@SecDetalle", "@CodColor"};
                int secDetalle = 0;
                foreach (DataRow rowBlock in dtBlockColor.Rows)
                {
                    secDetalle++;
                    object[] paramsValue = new object[] { idCotiza, secDetalle, rowBlock["Color"] };
                    objSQLServer._Ejecutar(sqlCotizacion.cot_guardaBlockDET, paramsName, paramsValue);
                }
            }
        }
        #endregion

        //Guarda los destinos del cliente
        #region guardaCLIDestino
        private void _guardaCLIDestino(int idCotiza)
        {
            if (dtClienteDEST != null)
            {
                string[] paramsName = new string[] { "@idCotiza",
                    "@SecDestino", "@SucNumero", "@Direccion", "@Cantidad" };
                int secDestino = 0;
                foreach (DataRow rowDestino in dtClienteDEST.Rows)
                {
                    secDestino++;
                    object[] paramsValue = new object[] {idCotiza,secDestino,
                    rowDestino["CodSucursal"],rowDestino["Direccion"], rowDestino["Cantidad"]};

                    objSQLServer._Ejecutar(sqlCotizacion.cot_guardaDET_CliDestino, paramsName, paramsValue);
                }
            }
        }
        #endregion

        //Guarda las opciones de generales
        #region guardaGeneral
        private void _guardaGeneral(int idCotiza)
        {
            string[] paramsName = new string[] { "@idCotiza", "@idOpcion", "@CatOpcion" };
            if (dtDisenoGeneralGH != null)
            {
                foreach (DataRow rowOpcion in dtDisenoGeneralGH.Rows)
                {
                    object[] paramsValue = new object[] { idCotiza, rowOpcion["Codigo"], optionsCMB.DisenoChkGH };
                    objSQLServer._Ejecutar(sqlCotizacion.cot_guardaDET_General, paramsName, paramsValue);
                }
            }
            if (dtDisenoGeneralORI != null)
            {
                foreach (DataRow rowOpcion in dtDisenoGeneralORI.Rows)
                {
                    object[] paramsValue = new object[] { idCotiza, rowOpcion["Codigo"], optionsCMB.DisenoChkORI };
                    objSQLServer._Ejecutar(sqlCotizacion.cot_guardaDET_General, paramsName, paramsValue);
                }
            }
        }
        #endregion

        //Guarda los procesos generales
        #region guardaProceso
        private void _guardaProceso(int idCotiza)
        {
            foreach (ProcesosMOD pm in lista_Procesos)
            {
                pm._Guardar(idCotiza);
            }
        }
        #endregion

        //Guarda los materiales del cliente
        #region guardaMaterialCLI
        private void _guardaMaterialCLI(int idCotiza)
        {
            if (dtDisenoMaterialCLI != null)
            {
                string[] paramsName = new string[] { "@idCotiza", "@SecDetalle", "@CantMaterial" };
                foreach (DataRow rowMaterial in dtDisenoMaterialCLI.Rows)
                {
                    object[] paramsValue = new object[] {idCotiza,
                        rowMaterial["SecMaterial"],rowMaterial["Cantidad"]};

                    objSQLServer._Ejecutar(sqlCotizacion.cot_guardaDET_MaterialCLI, paramsName, paramsValue);
                }
            }
        }
        #endregion

        //GUARDA LOS DETALLES QUE SE CLASIFICAN POR COMPONENTE
        #region GuardaXcomponente

        //GUARDA LOS DETALLES QUE SE CLASIFICAN POR EL COMPONENTE
        #region guardaComponente
        private void _guardaComponente(int idCotiza)
        {
            foreach (DataRow rowComponente in dtComponentes.Rows)
            {
                int Componente=rowComponente["Codigo"].ToInt();
                _guardaArmados(idCotiza, Componente);
                _guardaColor(idCotiza, Componente);
                _guardaPlacas(idCotiza, Componente);
                _guardaTroquel(idCotiza, Componente);
                _guardaAcabado(idCotiza, Componente);
                _guardaAccesorio(idCotiza, Componente);
                _guardaProcesoIMP(idCotiza, Componente);
            }
        }
        #endregion

        //GUARDA LOS ARMADOS
        #region guardaArmados
        private void _guardaArmados(int idCotiza,int a_Componente)
        {
            List<armadoMOD> l = lista_Armado.Where(x => x.Componente== a_Componente).ToList();
            foreach(armadoMOD am in l)
            {
                am._Guardar(idCotiza);
            }
        }
        #endregion

        //GUARDA LOS COLORES
        #region guardaColor
        private void _guardaColor(int idCotiza, int a_Componente)
        {
            List<coloresMOD> l = lista_Colores.Where(x => x.Componente == a_Componente).ToList();
            int secDetalle = 0;
            foreach (coloresMOD cm in l)
            {
                secDetalle++;
                cm._Guardar(idCotiza,secDetalle);
            }
        }
        #endregion

        //GUARDA LAS PLACAS
        #region guardaPlacas
        private void _guardaPlacas(int idCotiza, int a_Componente)
        {
            List<placasMOD> l = lista_Placas.Where(x => x.Componente == a_Componente).ToList();
            int secDetalle = 0;
            foreach (placasMOD pm in l)
            {
                secDetalle++;
                pm._Guardar(idCotiza, secDetalle);
            }
        }
        #endregion

        //GUARDA LOS TROQUELES
        #region guardaTroquel
        private void _guardaTroquel(int idCotiza, int a_Componente)
        {
            List<troquelMOD> l = lista_Troquel.Where(x => x.Componente == a_Componente).ToList();
            int secDetalle = 0;
            foreach (troquelMOD tm in l)
            {
                secDetalle++;
                tm._Guardar(idCotiza, secDetalle);
            }
        }
        #endregion

        //GUARDA LOS ACABADOS
        #region guardaAcabado
        private void _guardaAcabado(int idCotiza, int a_Componente)
        {
            List<acabadoMOD> l = lista_Acabado.Where(x => x.Componente == a_Componente).ToList();
            int secDetalle = 0;
            foreach (acabadoMOD am in l)
            {
                secDetalle++;
                am._Guardar(idCotiza, secDetalle);
            }
        }
        #endregion

        //GUARDA LOS ACCESORIOS
        #region guardaAccesorio
        private void _guardaAccesorio(int idCotiza, int a_Componente)
        {
            List<accesorioMOD> l = lista_Accesorios.Where(x => x.Componente == a_Componente).ToList();
            int secDetalle = 0;
            foreach (accesorioMOD am in l)
            {
                secDetalle++;
                am._Guardar(idCotiza, secDetalle);
            }
        }
        #endregion

        //GUARDA LOS PROCESOS DE IMPRESION
        #region guardaProcesoIMP
        private void _guardaProcesoIMP(int idCotiza,int a_Componente)
        {
            List<procesoIMPMOD> l = lista_ProcesosIMP.Where(x => x.Componente == a_Componente).ToList();
            int secDetalle = 0;
            foreach (procesoIMPMOD pim in l)
            {
                secDetalle++;
                pim._Guardar(idCotiza, secDetalle);
            }
        }
        #endregion

        #endregion

        #endregion

        //PROPIEDADES DE LA CLASE
        #region PROPIEDADES

        //Diseno general GH
        #region pro_dtDisenoGeneralGH
        public DataTable pro_disenoGeneralGH { get { return dtDisenoGeneralGH; } }
        #endregion

        //Diseno general ORI
        #region pro_dtDisenoGeneralORI
        public DataTable pro_disenoGeneralORI { get { return dtDisenoGeneralORI; } }
        #endregion

        #endregion

    }
}
