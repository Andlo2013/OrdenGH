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
    public partial class Form1 : Automatizer.Core.Win32.Gui.RibbonForm
    {
        private static Sesion session;
        private static _SQLServer objSQLServer;
        public Form1()
        {
            InitializeComponent();
            IniciarSesion();
            session = this.Sesion;
            
        }

        private void Form1_Load(object sender, EventArgs e)
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

        public static _SQLServer getSQLServer {get{ return objSQLServer; }}

        public static Sesion getSession
        {
            get { return session; }
        }

        private void bbiOrden_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AgregarVentana(new Controles.ctlOrden(), "Órdenes", global::Ordenes.Properties.sqlQuery.iconAPP);
        }

        private void bbiDiseno_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AgregarVentana(new Controles.ctlDiseno(), "Diseñar órdenes", global::Ordenes.Properties.sqlQuery.iconAPP);
        }

        private void bbiCotizacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AgregarVentana(new Controles.ctlCotizacion(), "Cotizaciones", global::Ordenes.Properties.sqlQuery.iconAPP);
        }
    }
}
