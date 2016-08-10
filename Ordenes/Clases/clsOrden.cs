using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using dllBuscar;
using dllMensaje;
using Ordenes.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes.Clases
{
    public class clsOrden
    {
        _SQLServer objSQLServer = new _SQLServer();
        DataTable dtAcabados = null;
        DataTable dtEgresoMAT = null;
        DataTable dtLibroColor = null;

        private string m_servidor = "Servidor";
        private string m_database = "Indalum";
        private string m_codEmpresa = "01";
        private int m_ordenID = 5428;

        public clsOrden()
        {

        }

        public DataRow _BuscarORD()
        {
            frmBuscarITEM objBuscar = new frmBuscarITEM();
            Dictionary<string, string> dicFiltros = new Dictionary<string, string>();
            dicFiltros.Add("Orden", "Orden");
            dicFiltros.Add("LTRIM(RTRIM(ISNULL(dbo.climae.CliApl,'')+' '+ISNULL(dbo.climae.CliNom,'')))", "Cliente");
            objBuscar.pro_Configura
                ._set01Connection(m_servidor, m_database)
                ._set02Find(sqlQuery.ord_BuscaORD, new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa })
                ._set03OptionsFilter(dicFiltros)
                ._setVisibleCOL(true, new string[] { "Orden", "Cliente", "Item", "Cantidad" })
                ._setSeleccionSimple(true);
            objBuscar.ShowDialog();
            return objBuscar.pro_FilaSEL;
        }

        public DataRow _BuscarMaterial()
        {
            try
            {
                frmBuscarITEM objBuscar = new frmBuscarITEM();
                Dictionary<string, string> dicFiltros = new Dictionary<string, string>();
                dicFiltros.Add("ItmDsc", "Descripción");
                objBuscar.pro_Configura
                    ._set01Connection(m_servidor, m_database)
                    ._set02Find(sqlQuery.ord_BuscaMaterial, new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa })
                    ._set03OptionsFilter(dicFiltros)
                    ._setVisibleCOL(true, new string[] { "Código", "Descripción" });
                objBuscar.ShowDialog();
                DataTable dtREG = objBuscar.pro_dtFilasSEL;
                if (dtREG != null && dtREG.Rows.Count > 0)
                {
                    return dtREG.Rows[0];
                }
                return null;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los registros", "Buscar item", ex.Message);
                return null;
            }
        }


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

        public void _acabadoAgrega()
        {
            try
            {
                DataRow[] selectedRows=_acabadoBusca();
                if (selectedRows != null)
                {
                    foreach(DataRow row in selectedRows)
                    {
                        if (!_acabadoExiste(row))
                        {
                            DataRow newRow=dtAcabados.NewRow();
                            newRow["TipoAcabado"] = row["Codigo"];
                            newRow["Acabado"] = row["Descripcion"];
                            dtAcabados.Rows.Add(newRow);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar agregar los registros", "Agregar registro", ex.Message);
            }
        } 

        public bool _acabadoExiste(DataRow rowSEL)
        {
            return dtAcabados.Select("TipoAcabado="+rowSEL["Codigo"], "").Length > 0 ? true : false;
        }

        public DataRow[] _acabadoBusca()
        {
            DataTable dtAcabado = _cargaCMBOPC(optionsCMB.Acabado, 0);
            frmBuscar objBuscar = new frmBuscar(dtAcabado);
            objBuscar._setMultiSelect(true);
            objBuscar.ShowDialog();
            return objBuscar.proFilasSEL;
        }

        public DataTable _disenoCargaDET()
        {
            try
            {
                dtEgresoMAT = objSQLServer._CargaDataTable(sqlQuery.ord_DisenoCargaDET,
                                        new string[] { "@CodEmpresa", "@OrdenID" },
                                        new object[] { m_codEmpresa, pro_ordenID });
                return dtEgresoMAT;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los acabados", "Cargar datos", ex.Message);
                return null;
            }
        }

        public DataRow _generalCargaDET()
        {
            try
            {
                DataTable dtGeneral = objSQLServer._CargaDataTable(sqlQuery.ord_GeneralCargaDET,
                                        new string[] { "@CodEmpresa", "@OrdenID" },
                                        new object[] { m_codEmpresa, pro_ordenID });
                //retorna la fila o nulo
                return dtGeneral != null && dtGeneral.Rows.Count == 1 ? dtGeneral.Rows[0] : null;
                
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los acabados", "Cargar datos", ex.Message);
                return null;
            }
        }

        public DataTable _libroCargaColor()
        {
            try
            {
                dtLibroColor = objSQLServer._CargaDataTable(sqlQuery.ord_LibroCargaColor,
                                        new string[] { "@CodEmpresa", "@OrdenID" },
                                        new object[] { m_codEmpresa, pro_ordenID });
                return dtLibroColor;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los acabados", "Cargar datos", ex.Message);
                return null;
            }
        }


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

        public void _cargaCMB(DataTable dtOpcionesCMB, LookUpEdit lueCombo)
        {
            try
            {
                lueCombo.Properties.DataSource = dtOpcionesCMB;
                lueCombo.Properties.DisplayMember = "Descripcion";
                lueCombo.Properties.ValueMember = "Codigo";
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los combos", "Cargar combos", ex.Message);
            }
        }

        public void _cargaCMBLUE(DataTable dtOpcionesCMB, RepositoryItemLookUpEdit lueCombo)
        {
            try
            {
                lueCombo.DataSource = dtOpcionesCMB;
                lueCombo.DisplayMember = "Descripcion";
                lueCombo.ValueMember = "Codigo";
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los combos", "Cargar combos", ex.Message);
            }
        }

        



        public int pro_ordenID
        {
            get { return m_ordenID; }
            set { m_ordenID = value; }
        }

    }
}
