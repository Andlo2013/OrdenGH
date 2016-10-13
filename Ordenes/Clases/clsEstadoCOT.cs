﻿using AutomatizerSQL.Utilidades;
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
    public class clsEstadoCOT
    {
        _SQLServer objSQLServer = frmPrincipal.getSQLServer;
        private string m_CodEmpresa = frmPrincipal.getSession.Empresa.Codigo;
        DataTable dtEstadoCOT = null;

        private int m_codCliente = 0;

        public clsEstadoCOT() { }

        public DataTable _cargaDET(DateTime dttFechaDesde,DateTime dttFechaHasta,object codEstado,bool porCliente,bool porEstado)
        {
            try
            {
                dttFechaDesde = Convert.ToDateTime(dttFechaDesde.ToShortDateString());
                dttFechaHasta = Convert.ToDateTime(dttFechaHasta.ToShortDateString());
                dttFechaHasta = dttFechaHasta.AddSeconds(86399);
                string sqlQuery = sqlEstadoCOT.cotest_cargaDET;
                sqlQuery += porCliente == true && m_codCliente>0 ? " AND dbo.pr_Cotiza.CliSec=@CodCliente" : "";
                sqlQuery += porEstado == true && (codEstado!=null && codEstado.ToInt()>0) ? " AND dbo.pr_Cotiza.EstadoCOT=@CodEstado" : "";
                sqlQuery += " ORDER BY dbo.pr_Cotiza.FecCotiza DESC";
                dtEstadoCOT = objSQLServer._CargaDataTable(sqlQuery,
                    new string[] { "@FechaDesde", "@FechaHasta","@CodCliente","@CodEstado" }, 
                    new object[] { dttFechaDesde,dttFechaHasta,m_codCliente, codEstado });

                dtEstadoCOT.Columns.Add("Seleccionar", Type.GetType("System.Boolean"));
                return dtEstadoCOT;
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar cargar los registros", "Cotizaciones", ex.Message);
                return null;
            }
        }

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


        public int pro_CodCliente
        {
            get { return m_codCliente; }
            set { m_codCliente = value; }
        }

       

    }
}
