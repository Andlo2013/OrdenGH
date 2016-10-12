using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public class _Comunes
    {
        _SQLServer objSQLServer = frmPrincipal.getSQLServer;
        private string m_servidor = frmPrincipal.getSession.Servidor;
        private string m_database = frmPrincipal.getSession.Catalogo;
        private string m_codEmpresa = frmPrincipal.getSession.Empresa.Codigo;



        public void _addItemCheckedList(DataTable dtOpciones, CheckedListBoxControl chkLista)
        {
            foreach (DataRow rowOpcion in dtOpciones.Rows)
            {
                CheckedListBoxItem item = new CheckedListBoxItem(rowOpcion["Codigo"], rowOpcion["Descripcion"].ToString());
                chkLista.Items.Add(item);
            }
        }

        public void _unChecked_CheckedList(CheckedListBoxControl chkLista)
        {
            if (chkLista != null)
            {
                for(int i = 0; i < chkLista.Items.Count; i++)
                {
                    chkLista.Items[i].CheckState = System.Windows.Forms.CheckState.Unchecked;
                }
            }
        }

        public DataRow _agregaMATSimple()
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

        public DataTable _agregaMATMultiple()
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

        


        public void _cargaCtlCMB(LookUpEdit lueCombo,DataTable data,
            string DisplayMember="Descripcion",string ValueMember="Codigo")
        {
            lueCombo.Properties.DataSource = data;
            lueCombo.Properties.DisplayMember = DisplayMember;
            lueCombo.Properties.ValueMember = ValueMember;
            lueCombo.Properties.ForceInitialize();
            lueCombo.ItemIndex = data.Rows.Count > 0 ? 0 : lueCombo.ItemIndex;
        }

        public void _cargaCtlCMBGRID(RepositoryItemLookUpEdit rilueCombo, DataTable data,
            string DisplayMember = "Descripcion", string ValueMember = "Codigo")
        {
            rilueCombo.DataSource = data;
            rilueCombo.DisplayMember = DisplayMember;
            rilueCombo.ValueMember = ValueMember;
        }

        public DataTable _cargaDataCMB(optionsCMB categoria)
        {
            DataTable dtCargaCMB = objSQLServer._CargaDataTable(sqlCotizacion.cmb_cargaCMB,
                new string[] { "@Categoria" }, new object[] { categoria });
            return dtCargaCMB;
        }

        public DataTable _cargaDataCMBDEP(int nodoPadre)
        {
            DataTable dtCargaCMB = objSQLServer._CargaDataTable(sqlCotizacion.cmb_cargaCMBDEP,
                new string[] { "@NodoPadre" }, new object[] { nodoPadre });
            return dtCargaCMB;
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

    }
}
