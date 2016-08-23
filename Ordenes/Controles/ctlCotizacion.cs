using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ordenes.Formularios;

namespace Ordenes.Controles
{
    public partial class ctlCotizacion : UserControl
    {
        public ctlCotizacion()
        {
            InitializeComponent();
        }

        private void btnVistaPRV_Click(object sender, EventArgs e)
        {
            frmCortes obj = new frmCortes();
            obj.ShowDialog();
            
        }
    }
}
