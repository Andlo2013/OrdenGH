using AutomatizerSQL.Core;
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

        public Form1()
        {
            InitializeComponent();
            IniciarSesion();
            session = this.Sesion;
            if (session.Estado)
            {
                AgregarVentana(new Controles.ctlOrden(), "Actualizar Inventario", global::Ordenes.Properties.sqlQuery.iconAPP);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (session.Estado == false)
            {
                this.Close();
            }
        }

        public static Sesion getSession
        {
            get { return session; }
        }
    }
}
