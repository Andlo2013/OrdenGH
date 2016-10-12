using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ordenes.Clases;

namespace Ordenes.Controles
{
    public partial class ctlEstadoCotizacion : UserControl
    {
        clsEstadoCOT objEstadoCOT = new clsEstadoCOT();

        public ctlEstadoCotizacion()
        {
            InitializeComponent();
        }

        private void ctlEstadoCotizacion_Load(object sender, EventArgs e)
        {
            _cargaDET();
        }

        private void _cargaDET()
        {
            gc_ListaCotizaciones.DataSource = objEstadoCOT._cargaDET();
        }
        
    }
}
