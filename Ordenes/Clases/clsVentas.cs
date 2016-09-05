using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using dllBuscar;
using dllMensaje;
using Ordenes.Modelos;
using Ordenes.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes.Clases
{
    public class clsVentas
    {
        _SQLServer objSQLServer = Form1.getSQLServer;
        ordenMOD modelo_Orden=new ordenMOD();
        trabajoGenMOD modelo_TrabajoGEN = new trabajoGenMOD();
        blockMOD modelo_Block = new blockMOD();
        libroEncMOD modelo_LibroENC = new libroEncMOD();
        libroPorMOD modelo_LibroPOR = new libroPorMOD();
        DataTable dtAcabados = null;
        DataTable dt_disArmados = null;
        DataTable dt_disMaterialCLI = null;
        DataTable dtEgresoMAT = null;
        DataTable dtLibroColor = null;
        DataTable dtClienteDEST = null;

        private string m_servidor = "Servidor";
        private string m_database = "Indalum";
        private string m_codEmpresa = "01";
        private string m_codCliente = "3631";
        private int m_ordenID = 5428;
        private string m_ordenUUID = "64BCEF76-3ECC-4679-AA13-3E1A3EA5C9CA";
        private int m_secuencialItem = 1660;

        public clsVentas()
        {

        }

        public void _BuscarORD()
        {
            try {

                ordenMOD temp = new ordenMOD();
                temp = temp._BuscarORD();
                modelo_Orden=temp!=null?temp:modelo_Orden;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los registros", ex.Message);
            }
        }

        public DataRow _BuscarCLI()
        {
            try
            {
                frmBuscarITEM objBuscar = new frmBuscarITEM();
                Dictionary<string, string> dicFiltros = new Dictionary<string, string>();
                dicFiltros.Add("LTRIM(RTRIM(ISNULL(dbo.climae.CliApl,'')+' '+ISNULL(dbo.climae.CliNom,'')))", "Cliente");
                objBuscar.pro_Configura
                    ._set01Connection(m_servidor, m_database)
                    ._set02Find(sqlQuery.ord_CLIBuscar, new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa })
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

        public DataRow _AgregaUnMAT()
        {
            try
            {
                frmBuscarITEM objFind = _materialBuscar(false);
                objFind.ShowDialog();
                return objFind.pro_FilaSEL;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los registros", "Buscar item", ex.Message);
                return null;
            }
        }

        public DataTable _AgregaVarMAT()
        {
            try
            {
                frmBuscarITEM objFind = _materialBuscar(true);
                objFind.ShowDialog();
                return objFind.pro_dtFilasSEL;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los registros", "Buscar item", ex.Message);
                return null;
            }
        }

        private frmBuscarITEM _materialBuscar(bool isMultiple)
        {
            frmBuscarITEM objBuscar = new frmBuscarITEM();
            Dictionary<string, string> dicFiltros = new Dictionary<string, string>();
            dicFiltros.Add("ItmDsc", "Descripción");
            objBuscar.pro_Configura
                ._set01Connection(m_servidor, m_database)
                ._set02Find(sqlQuery.ord_BuscaMaterial, new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa })
                ._set03OptionsFilter(dicFiltros)
                ._setVisibleCOL(true, new string[] { "Código", "Descripción" })
                ._setSeleccionSimple(!isMultiple);
            return objBuscar;
            
        }


        #region AGREGAR-ACABADO

        public void _acabadoAgrega()
        {
            try
            {
                DataRow[] selectedRows = _acabadoBusca();
                if (selectedRows != null)
                {
                    foreach (DataRow row in selectedRows)
                    {
                        if (!_acabadoExiste(row))
                        {
                            DataRow newRow = dtAcabados.NewRow();
                            newRow["TipoAcabado"] = row["Codigo"];
                            newRow["Acabado"] = row["Descripcion"];
                            dtAcabados.Rows.Add(newRow);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar agregar los registros", "Agregar registro", ex.Message);
            }
        }

        public DataRow[] _acabadoBusca()
        {
            DataTable dtAcabado = _cargaCMBOPC(optionsCMB.Acabado, 0);
            frmBuscar objBuscar = new frmBuscar(dtAcabado);
            objBuscar._setMultiSelect(true);
            objBuscar.ShowDialog();
            return objBuscar.proFilasSEL;
        }

        public bool _acabadoExiste(DataRow rowSEL)
        {
            return dtAcabados.Select("TipoAcabado=" + rowSEL["Codigo"], "").Length > 0 ? true : false;
        }

        #endregion

        #region AGREGAR-DESTINO

        public void _destinoAgrega()
        {
            try {
                DataRow[] filasSEL = _destinoBuscar();
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
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar agregar el registro", "Agrega Destino", ex.Message);
            }
            
        }

        private DataRow[] _destinoBuscar()
        {
            DataTable dtSucursales = objSQLServer._CargaDataTable(sqlQuery.ord_CLIAgregaSUC,
                new string[] { "@CodEmpresa", "@CodigoCLI" }, new object[] { m_codEmpresa, modelo_Orden.CodigoCLI });
            frmBuscar objBuscar = new frmBuscar(dtSucursales);
            objBuscar._setVisibleCOL(new string[] { "Ciudad", "Dirección" }, true);
            objBuscar._setAnchoCOL(new string[] { "Ciudad", "Dirección" }, new int[] { 400, 600 });
            objBuscar._setMultiSelect(true);
            objBuscar.ShowDialog();
            return objBuscar.proFilasSEL;
        }

        #endregion


        #region AGREGA-MATERIALCLI
        public void _materialCLIAgrega()
        {
            try {
                DataTable dtFilasSEL = _AgregaVarMAT();
                if (dtFilasSEL != null)
                {
                    foreach (DataRow rowMaterial in dtFilasSEL.Rows)
                    {
                        if (dt_disMaterialCLI.Select("CodMaterial=" + rowMaterial["Secuencial"], "").Length == 0)
                        {
                            DataRow rowMATCLI = dt_disMaterialCLI.NewRow();
                            rowMATCLI["CodMaterial"] = rowMaterial["Secuencial"];
                            rowMATCLI["Material"] = rowMaterial["Descripción"];
                            rowMATCLI["Cantidad"] = 0;
                            dt_disMaterialCLI.Rows.Add(rowMATCLI);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar agregar los registros", "Materiales cliente", ex.Message);
            }
        }
        #endregion

        public DataTable _produccionCargaCMB()
        {
            try
            {
                DataTable dtProduccionCMB = objSQLServer._CargaDataTable("pr_ProcesoPRD_CargaCMB",
                    new string[] {"@CodEmpresa","@ItemSecuencial" }, new object[] {m_codEmpresa,m_secuencialItem });
                return dtProduccionCMB;
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los procesos de producción", "Procesos", ex.Message);
                return null;
            }
        }

        public DataTable _produccionCargaDETPROC(object codMaquina)
        {
            try
            {
                return objSQLServer._CargaDataTable("pr_ProcesoPRD_CargaDET",
                    new string[] {"@CodEmpresa","@ordenUUID","@CodMaquina" },
                    new object[] {m_codEmpresa,m_ordenUUID, codMaquina });
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar recuperar el detalle de procesos", "Procesos", ex.Message);
                return null;
            }
        }

        #region CARGA-DETALLES
        public DataTable _acabadoCarga()
        {
            try
            {
                dtAcabados = objSQLServer._CargaDataTable(sqlQuery.ord_CargaAcabado,
                                        new string[] { "@CodEmpresa", "@OrdenID" },
                                        new object[] { m_codEmpresa, pro_ordenID });
                return dtAcabados;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los acabados", "Cargar datos", ex.Message);
                return null;
            }
        }

        public void _blockCargaDET()
        {
            try
            {
                modelo_Block = new blockMOD();
                modelo_Block = modelo_Block._cargaBlock(modelo_Orden.id);
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los blocks", "Cargar datos", ex.Message);
            }
        }

        public DataTable _clienteCargaDEST()
        {
            try
            {
                dtClienteDEST = objSQLServer._CargaDataTable(sqlQuery.ord_ClienteCargaDestino,
                                                new string[] { "@CodEmpresa", "@ordenID" },
                                                new object[] { m_codEmpresa, modelo_Orden.id });
                return dtClienteDEST;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar recuperar los destinos", "Cargar datos", ex.Message);
                return null;
            }
        }

        public DataTable _clienteCargaTEL(object CodCliente)
        {
            try
            {
                DataTable dtClienteTEL = objSQLServer._CargaDataTable(sqlQuery.ord_CLICargaTelefono,
                                                new string[] { "@CodEmpresa", "@CodigoCLI" },
                                                new object[] { m_codEmpresa, CodCliente });
                return dtClienteTEL;
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar recuperar los teléfonos del cliente", "Cargar datos", ex.Message);
                return null;
            }
        }

        public DataRow _disenoCargaCAB()
        {
            try
            {
                DataTable dt_disCAB = objSQLServer._CargaDataTable(sqlQuery.ord_DisCargaCAB,
                                        new string[] { "@CodEmpresa", "@OrdenID" },
                                        new object[] { m_codEmpresa, pro_ordenID });
                return dt_disCAB != null && dt_disCAB.Rows.Count == 1 ? dt_disCAB.Rows[0] : null;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el diseño", "Cargar datos", ex.Message);
                return null;
            }
        }

        public DataTable _disenoCargaArmados()
        {
            try
            {
                dt_disArmados = objSQLServer._CargaDataTable(sqlQuery.ord_DisCargaArmados,
                                        new string[] { "@CodEmpresa", "@OrdenID" },
                                        new object[] { m_codEmpresa, pro_ordenID });
                return dt_disArmados;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el diseño", "Cargar datos", ex.Message);
                return null;
            }
        }

        public DataTable _disenoCargaCheckedList()
        {
            try
            {
                DataTable dtChecked = objSQLServer._CargaDataTable(sqlQuery.ord_DisCargaCheckedList,
                                        new string[] { "@CodEmpresa", "@OrdenID" },
                                        new object[] { m_codEmpresa, pro_ordenID });
                return dtChecked;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el diseño", "Cargar datos", ex.Message);
                return null;
            }
        }

        public DataTable _disenoCargaMaterialCLI()
        {
            try
            {
                dt_disMaterialCLI = objSQLServer._CargaDataTable(sqlQuery.ord_DisCargaMaterialCLI,
                                        new string[] { "@CodEmpresa", "@OrdenID" },
                                        new object[] { m_codEmpresa, pro_ordenID });
                return dt_disMaterialCLI;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el diseño", "Cargar datos", ex.Message);
                return null;
            }
        }

        public DataTable _egresoMatCargaDET()
        {
            try
            {
                dtEgresoMAT = objSQLServer._CargaDataTable(sqlQuery.ord_EgrMatCargaDET,
                                        new string[] { "@CodEmpresa", "@OrdenID" },
                                        new object[] { m_codEmpresa, modelo_Orden.id });
                return dtEgresoMAT;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar el diseño", "Cargar datos", ex.Message);
                return null;
            }
        }

        public void _generalCargaDET()
        {
            try
            {
                modelo_TrabajoGEN = new trabajoGenMOD();
                modelo_TrabajoGEN = modelo_TrabajoGEN._cargaDET(modelo_Orden.id);                
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los trabajos generales", "Cargar datos", ex.Message);
            }
        }

        public void _libroCargaDETENC()
        {
            try
            {
                modelo_LibroENC = new libroEncMOD();
                modelo_LibroENC = modelo_LibroENC._cargaDET(modelo_Orden.id);
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar encuadernado de libro", "Cargar datos", ex.Message);
            }
        }

        public void _libroCargaDETPOR()
        {
            try
            {
                modelo_LibroPOR = new libroPorMOD();
                modelo_LibroPOR = modelo_LibroPOR._cargaDET(modelo_Orden.id);
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar portada de libro", "Cargar datos", ex.Message);
            }
        }

        public DataTable _libroCargaColor()
        {
            try
            {
                dtLibroColor = objSQLServer._CargaDataTable(sqlQuery.ord_LibroCargaColor,
                                        new string[] { "@CodEmpresa", "@OrdenID" },
                                        new object[] { m_codEmpresa, modelo_Orden.id });
                return dtLibroColor;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los colores en libros", "Cargar datos", ex.Message);
                return null;
            }
        }

        public DataRow _srvExternoCargaDET()
        {
            try
            {
                DataTable dtSrvExterno = objSQLServer._CargaDataTable(sqlQuery.ord_ServicioEXTCaregaDET,
                                        new string[] { "@CodEmpresa", "@OrdenID" },
                                        new object[] { m_codEmpresa, pro_ordenID });
                //retorna la fila o nulo
                return dtSrvExterno != null && dtSrvExterno.Rows.Count == 1 ? dtSrvExterno.Rows[0] : null;

            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los servicios externos", "Cargar datos", ex.Message);
                return null;
            }
        }

        #endregion

        #region METODOS-COMUNES

        
        public DataTable _cargaCMBOPC(optionsCMB tipoCMB, int NodoDependiente)
        {
            try
            {
                DataTable dtCombo = null;
                if (NodoDependiente == 0)
                {
                    dtCombo = objSQLServer._CargaDataTable(sqlQuery.cmb_CargaCMB,
                        new string[] { "@Categoria" }, new object[] { tipoCMB });
                }
                else
                {
                    dtCombo = objSQLServer._CargaDataTable(sqlQuery.cmb_CargaCMBDEP,
                        new string[] { "@NodoPadre" }, new object[] { NodoDependiente });
                }
                return dtCombo;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los combos", "Cargar combos", ex.Message);
                return null;
            }
        }

        public void _cargaCMB(DataTable dtOpcionesCMB, LookUpEdit lueCombo,
            string columnaDisplay = "Descripcion", string columnaValue = "Codigo")
        {
            try
            {
                lueCombo.Properties.DataSource = dtOpcionesCMB;
                lueCombo.Properties.DisplayMember = columnaDisplay;
                lueCombo.Properties.ValueMember = columnaValue;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los combos", "Cargar combos", ex.Message);
            }
        }

        public void _cargaCMBLUE(DataTable dtOpcionesCMB, RepositoryItemLookUpEdit lueCombo,
            string columnaDisplay="Descripcion",string columnaValue="Codigo")
        {
            try
            {
                lueCombo.DataSource = dtOpcionesCMB;
                lueCombo.DisplayMember = columnaDisplay;
                lueCombo.ValueMember = columnaValue;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los combos", "Cargar combos", ex.Message);
            }
        }

        public void _cargaCheckedList(DataTable dtOpciones, CheckedListBoxControl chkl_Checked)
        {
            foreach (DataRow rowOpcion in dtOpciones.Rows)
            {
                CheckedListBoxItem item = new CheckedListBoxItem(rowOpcion["Codigo"], rowOpcion["Descripcion"].ToString());
                chkl_Checked.Items.Add(item);
            }
        }

        #endregion

        public int _codigoOrden()
        {
            try
            {
                return objSQLServer._CalculaCodigo("pr_orden", "id", "WHERE EmpCod=@CodEmpresa",
                new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa });
            }
            catch
            {
                return -1;
            }
        }


        public void _Nuevo()
        {
            int id = _codigoOrden();
            modelo_Orden = new ordenMOD();
            modelo_Orden.id = id;
            modelo_Orden.UUID = Guid.NewGuid().ToString(); 
            modelo_Orden._Estado = true;
            modelo_Orden.CodigoEPL = Form1.getSession.Usuario.Empleado.Codigo;
            
        }


        public void _guardaOrden()
        {
            objSQLServer._Open();
            objSQLServer._BeginTransacction();
            modelo_Orden._guardaOrden(modelo_Orden);
            modelo_TrabajoGEN._guardaTrabajoGEN(modelo_TrabajoGEN,modelo_Orden.id);
            modelo_Block._guardarDET(modelo_Block,modelo_Orden.id);
            modelo_LibroENC._guardaENC(modelo_LibroENC, modelo_Orden.id);
            modelo_LibroPOR._guardaPortada(modelo_LibroPOR, modelo_Orden.id);
            objSQLServer._Commit();
            objSQLServer._Close();
            /*
            @CodEmpresa,@ID,@numeroORD,@NumCotiza,@FecCotiza,@CodCliente,@FechaINI,@FechaFIN,
@CodigoEPL,@ItemSecuencial,@FechaENT,@FechaENTPP,@TipoOFFSET,@FechaFAC,@AdjuntaLIS,
@Cantidad,@PrecioUNI,@Subtotal,@IVA,@Total,@Abono,@Saldo,NULL,NULL,NULL,@UUID,@Observacion,'True'
            */
        }

        public int pro_ordenID
        {
            get { return m_ordenID; }
            set { m_ordenID = value; }
        }

        public ordenMOD pro_ModeloOrden{
            get { return modelo_Orden; }
        }

        public trabajoGenMOD pro_ModeloTrabajoGEN
        {
            get { return  modelo_TrabajoGEN; }
            set { modelo_TrabajoGEN = value; }
        }

        public blockMOD pro_ModeloBlock
        {
            get { return modelo_Block; }
            set { modelo_Block = value; }
        }

        public libroEncMOD pro_ModeloLibroENC {
            get { return modelo_LibroENC; }
            set { modelo_LibroENC = value; }
        }

        public libroPorMOD pro_ModeloLibroPOR
        {
            get { return modelo_LibroPOR; }
            set { modelo_LibroPOR = value; }
        }

    }
}
