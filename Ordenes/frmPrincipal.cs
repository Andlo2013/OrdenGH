using AutomatizerSQL.Core;
using Ordenes.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenes
{
    public partial class frmPrincipal : Automatizer.Core.Win32.Gui.RibbonForm
    {
        private static Sesion session;
        private static _SQLServer objSQLServer;

        public frmPrincipal()
        {
            InitializeComponent();
            IniciarSesion();
            session = this.Sesion;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (session == null || session.Estado == false)
            {
                this.Close();
            }
            else
            {
                objSQLServer = new _SQLServer();
            }
        }

        public static _SQLServer getSQLServer { get { return objSQLServer; } }

        public static Sesion getSession
        {
            get { return session; }
        }

       

        private void bbiCotizaciones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AgregarVentana(new Controles.ctlCotizacion(), "Cotizaciones", global::Ordenes.Properties.sqlQuery.iconAPP);
        }

        private void bbiEstadoCOT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AgregarVentana(new Controles.ctlEstadoCotizacion(), "Procesar Cotizaciones", global::Ordenes.Properties.sqlQuery.iconAPP);
        }

        
    }
}
