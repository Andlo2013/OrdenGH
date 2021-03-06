﻿using AutomatizerSQL.Utilidades;
using dllMensaje;
using Ordenes.Properties;
using System;
using System.Data;

namespace Ordenes.Clases
{
    public class clsEstadoCOT
    {
        //instancias - variables de la clase
        #region INSTANCIAS-VARIABLES
        _SQLServer objSQLServer = frmPrincipal.getSQLServer;
        _Comunes objComunes = new _Comunes();
        private string m_CodEmpresa = frmPrincipal.getSession.Empresa.Codigo;
        private int m_CodEmpleado = frmPrincipal.getSession.Usuario.Empleado.Codigo;
        DataTable dtEstadoCOT = null;
        private int m_codCliente = 0;
        #endregion

        public clsEstadoCOT() { }

        //METODOS
        #region METODOS

        //Carga el detalle de cotizaciones
        #region cargaDET
        public DataTable _cargaDET(DateTime dttFechaDesde,DateTime dttFechaHasta,
            object codEstado,bool porCliente,bool porEstado)
        {
            try
            {
                dttFechaDesde = Convert.ToDateTime(dttFechaDesde.ToShortDateString());
                dttFechaHasta = Convert.ToDateTime(dttFechaHasta.ToShortDateString());
                dttFechaHasta = dttFechaHasta.AddSeconds(86399);
                string sqlQuery = sqlEstadoCOT.cotest_cargaDET;
                sqlQuery += porCliente == true && m_codCliente>0 ? " AND dbo.pr_Cotiza.CliSec=@CodCliente" : "";
                sqlQuery += porEstado == true && (codEstado!=null && codEstado.ToString()!="") ? " AND dbo.pr_Cotiza.EstadoCOT=@CodEstado" : "";
                sqlQuery += " ORDER BY dbo.pr_Cotiza.FecCotiza DESC";
                dtEstadoCOT = objSQLServer._CargaDataTable(sqlQuery,
                    new string[] { "@FechaDesde", "@FechaHasta","@CodCliente","@CodEstado" }, 
                    new object[] { dttFechaDesde,dttFechaHasta,m_codCliente, codEstado });

                dtEstadoCOT.Columns.Add("Seleccionar", Type.GetType("System.Boolean"));
                dtEstadoCOT.Columns.Add("NomEstadoCOT", Type.GetType("System.String"));
                _nombreEstadoCOT();
                return dtEstadoCOT;
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los registros", "Cotizaciones", ex.Message);
                return null;
            }
        }
        #endregion

        //recupera el nombre del estado de la cotizacion para mostrar al usuario
        #region nombreEstadoCOT
        private void _nombreEstadoCOT()
        {
            if (dtEstadoCOT != null)
            {
                foreach (DataRow row in dtEstadoCOT.Rows)
                {
                    row["NomEstadoCOT"]=objComunes._GetNombreCOT(row["EstadoCOT"].ToInt());
                }
            }
        }
        #endregion

        //busca un cliente
        #region buscaCLI
        public string _buscaCLI()
        {
            clsCotizacion objCotiza = new clsCotizacion();
            DataRow rowCliente=objCotiza._clienteBuscar();
            if (rowCliente != null)
            {
                m_codCliente = rowCliente["Código"].ToInt();
                return rowCliente["Cliente"].ToString().Trim();
            }
            m_codCliente = 0;
            return "";
        }
        #endregion

        //actualiza el estado
        #region actualizar
        public void _actualizar(int CodEstado, int CodRechaza, string Observaciones)
        {
            try
            {
                DataRow[] rowSEL = dtEstadoCOT.Select("Seleccionar=true");
                if (rowSEL != null)
                {
                    objSQLServer._Open();
                    foreach (DataRow row in rowSEL)
                    {
                        if (row["EstadoCOT"].ToInt() == 1)
                        {
                            objSQLServer._Ejecutar(sqlEstadoCOT.cotest_guardar,
                                new string[] { "@idCotiza", "@CodigoEPL", "@CodEstado", "@CodRechaza", "@Observaciones" },
                                new object[] { row["id"], m_CodEmpleado, CodEstado, CodRechaza, Observaciones });
                        }
                    }
                    objSQLServer._Close();
                }
            }
            catch (Exception ex)
            {
                objSQLServer._Close();
                clsMensaje._msjWarning("ERROR: Al intentar actualizar los registros", "Actualizar", ex.InnerException.Message);
            }
        }
        #endregion

        #endregion
        
        //PROPIEDADES
        #region PROPIEDADES

        //Codigo del cliente
        #region pro_CodCliente
        public int pro_CodCliente
        {
            get { return m_codCliente; }
            set { m_codCliente = value; }
        }
        #endregion

        #endregion


    }
}
