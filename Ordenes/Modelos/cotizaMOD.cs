﻿using AutomatizerSQL.Utilidades;
using dllMensaje;
using Ordenes.Clases;
using Ordenes.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;


namespace Ordenes.Modelos
{

    public class cotizaMOD:_modelo
    {
        //INSTANCIAS-VARIABLES
        #region INSTANCIAS-VARIABLES
        _SQLServer objSQLServer = frmPrincipal.getSQLServer;
        //PEDIDO ING. VELEZ DEFINIR EL NÚMERO COTIZACIÓN INICIA Y DESPUÉS SEA AUTOMÁTICO
        private int CotizaINI = 1;
        private string m_codEmpresa = frmPrincipal.getSession.Empresa.Codigo;
        private string m_servidor = frmPrincipal.getSession.Servidor;
        private string m_baseDatos = frmPrincipal.getSession.Catalogo;
        const double maxRange = 999999999;
        const double minRange = 0.00000001;
        #endregion

        //PROPIEDADES DEL MODELO
        #region PROPIEDADES

        [Required(ErrorMessage ="ID es obligatorio")]
        [Range(1,9999999,ErrorMessage ="No es un número de 'ID' válido")]
        public int id { get; set; }

        [Required(ErrorMessage = "Número de cotización es obligatorio")]
        [Range(1, 9999999, ErrorMessage = "No es un 'Número Cotización' válido")]
        public int Cotizacion { get; set; }

        [Required(ErrorMessage = "Código de cliente es obligatorio")]
        [Range(1, 9999999, ErrorMessage = "No es un 'Código de cliente' válido")]
        public int CodigoCLI { get; set; }

        [Required(ErrorMessage = "Número de CI/RUC es obligatorio")]
        [StringLength(13, ErrorMessage = "No es un número de CI/RUC válido", MinimumLength = 10)]
        public string CIRUC { get; set; }

        [Required(ErrorMessage = "Nombre de cliente es obligatorio")]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "Línea de producción es obligatorio")]
        [Range(1, 9999, ErrorMessage = "No es una 'Línea de Producción' válida")]
        public int LineaPRD { get; set; }

        [Required(ErrorMessage = "Grupo es obligatorio")]
        [Range(1, 9999, ErrorMessage = "No es un 'Grupo' válido")]
        public int Grupo { get; set; }

        [Required(ErrorMessage = "Subgrupo es obligatorio")]
        [Range(1, 9999, ErrorMessage = "No es un 'Subgrupo' válido")]
        public int Subgrupo { get; set; }

        //NO OBLIGA EL ITEM PORQUE NO SE CREA EN INVENTARIO HASTA APROBAR COTIZACION
        public int SecuencialITEM { get; set; }

        [Required(ErrorMessage = "Descripción del artículo es obligatorio")]
        public string Articulo { get; set; }

        [Required(ErrorMessage = "Tiraje es obligatorio")]
        [Range(1, 9999, ErrorMessage = "No es un 'Tiraje' válido")]
        public int Tiraje { get; set; }

        [Required(ErrorMessage = "Ancho es obligatorio")]
        [Range(1, 9999, ErrorMessage = "No es un 'Ancho' válido")]
        public decimal Ancho { get; set; }

        [Required(ErrorMessage = "Alto es obligatorio")]
        [Range(1, 9999, ErrorMessage = "No es un 'Alto' válido")]
        public decimal Alto { get; set; }

        [Required(ErrorMessage = "Fecha cotización es obligatorio")]
        public object FecCotiza { get; set; }

        [Required(ErrorMessage = "Fecha entrega es obligatorio")]
        public object FecEntrega { get; set; }

        [Required(ErrorMessage = "Cotizador es obligatorio")]
        [Range(1, 99999, ErrorMessage = "No es un 'Código de Cotizador' válido")]
        public int EplCotiza { get; set; }

        public string Cotizador { get; set; }

        [Required(ErrorMessage = "Vendedor es obligatorio")]
        [Range(1, 99999, ErrorMessage = "No es un 'Código de Vendedor' válido")]
        public int EplVendedor { get; set; }

        public string Vendedor { get; set; }

        
        [Required(ErrorMessage = "Estado cotización es obligatorio")]
        public int EstadoCOT { get; set; }

        //NO OBLIGA PORQUE SI NO ESTA EN ORDEN NO TIENE Y VA CERO
        public int NumOrden { get; set; }

        [Required(ErrorMessage = "Estado del Registro es obligatorio")]
        public bool Estado { get; set; }

        [Required(ErrorMessage = "El total de la cotización es obligatorio")]
        [Range(0.01, 999999999.99, ErrorMessage = "El total de la cotización esta fuera del rango")]
        public decimal TotalCOT { get; set; }

        #endregion

        //Buscar cotizacion
        #region buscaCOT
        public cotizaMOD _buscaCOT()
        {
            try
            {
                Dictionary<string, string> dicFiltro = new Dictionary<string, string>();
                dicFiltro.Add("NumCotiza", "Cotizacion");
                dicFiltro.Add("LTRIM(RTRIM(ISNULL(dbo.climae.CliApl,'')+' '+ISNULL(dbo.climae.CliNom,'')))", "Cliente");

                dllBuscar.frmBuscarITEM objFiltrar = new dllBuscar.frmBuscarITEM();
                objFiltrar.pro_Configura._set01Connection(m_servidor, m_baseDatos)
                    ._set02Find(sqlCotizacion.cot_buscaCOT,
                    new string[] { "@CodEmpresa" },
                    new object[] { m_codEmpresa })
                    ._set03OptionsFilter(dicFiltro)
                    ._setSeleccionSimple(true)
                    ._setVisibleCOL(true, new string[] { "Cotizacion", "Cliente", "Articulo" });
                objFiltrar.ShowDialog();
                DataRow row = objFiltrar.pro_FilaSEL;

                return row != null ? _toEntity._row2object<cotizaMOD>(row) : new cotizaMOD();
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar buscar los registros", "Buscar", ex.Message);
                return new cotizaMOD();
            }

        }
        #endregion

        //Calcula el ID
        #region calculaID
        private void _calculaID()
        {
            try
            {
                this.id = objSQLServer._CalculaCodigo("pr_Cotiza", "id", "",
                    new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa });
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar calcular el identificador", "Cotización", ex.Message);
                this.id= -1;
            }
        }
        #endregion

        //CARGA UNA COTIZACION ESPECIFICA
        #region _cargaCOT
        public cotizaMOD _cargaCOT(int idCotiza)
        {
            try
            {
                DataTable dtCotiza = objSQLServer._CargaDataTable(sqlCotizacion.cot_CargaCAB,
                    new string[] { "@CodEmpresa", "@idCotiza" }, new object[] {m_codEmpresa,idCotiza });
                
                return (dtCotiza != null && dtCotiza.Rows.Count == 1)? 
                        _toEntity._row2object<cotizaMOD>(dtCotiza.Rows[0]):new cotizaMOD();
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar recuperar el registro", "Recuperar registro", ex.InnerException.Message);
                return new cotizaMOD();
            }
        }
        #endregion

        //Nueva cotizacion
        #region nuevaCOT
        public void _nuevaCOT()
        {
            _numeroCOT();
            _calculaID();
        }
        #endregion

        //Numero de cotizacion
        #region numeroCOT
        private void _numeroCOT()
        {
            try
            {
                int secuencialCOT = objSQLServer._CalculaCodigo("pr_Cotiza", "NumCotiza", "WHERE (EmpCod=@CodEmpresa)",
                    new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa });
                secuencialCOT = secuencialCOT < CotizaINI ? CotizaINI : secuencialCOT;
                this.Cotizacion = secuencialCOT;
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar calcular el secuencial de cotización", "Cotización", ex.Message);
                this.Cotizacion = -1;
            }
        }
        #endregion

        //Guardar cotizacion
        #region guardaCOT
        public void _guardaCOT()
        {
            string[] paramsName = new string[] {"@idCotiza","@CodEmpresa","@NumCotiza",
                    "@CodCliente","@LinProduccion","@GrupoProduccion","@SubgrupoProduccion",
                    "@ItemSecuencial","@ItemDescripcion","@Tiraje","@Ancho","@Alto",
                    "@FecCotiza","@FecEntrega","@CodEplCotiza","@CodEplVendededor","@TotalCOT","@EstadoCOT" };

            object[] paramsValue = new object[] {this.id,this.m_codEmpresa,this.Cotizacion,
                    this.CodigoCLI,this.LineaPRD,this.Grupo,this.Subgrupo,this.SecuencialITEM,
                    this.Articulo,this.Tiraje,this.Ancho,this.Alto,this.FecCotiza,this.FecEntrega,
                    this.EplCotiza,this.EplVendedor,this.TotalCOT,this.EstadoCOT};

            objSQLServer._Ejecutar(sqlCotizacion.cot_guardaCAB, paramsName, paramsValue);


        }
        #endregion

        //DESPLAZAMIENTOS
        #region DESPLAZAMIENTOS

        //primero
        #region moveFirst
        public int _moveFirst()
        {
            return _moveRecord(sqlCotizacion.cot_goFirst,0);
        }
        #endregion

        //anterior
        #region movePrevious
        public int _movePrevious(int idActual)
        {
            return _moveRecord(sqlCotizacion.cot_goPrevious, idActual);
        }
        #endregion

        //siguiente
        #region moveNext
        public int _moveNext(int idActual)
        {
            return _moveRecord(sqlCotizacion.cot_goNext, idActual);
        }
        #endregion

        //ultimo
        #region moveLast
        public int _moveLast()
        {
            return _moveRecord(sqlCotizacion.Cot_goLast, 0);
        }
        #endregion

        //consulta el registro que toca cargar
        #region moveRecord
        private int _moveRecord(string sqlQuery,int idActual)
        {
            string []paramsName = new string[] { "@idActual" };
            object []paramsValue = new object[] { idActual };
            DataTable dtRecord= objSQLServer._CargaDataTable(sqlQuery, paramsName, paramsValue);
            if(dtRecord!=null && dtRecord.Rows.Count == 1)
            {
                return dtRecord.Rows[0]["idCotiza"].ToInt();
            }
            return -1;
        }
        #endregion

        #endregion

    }

}
