using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomatizerSQL.Utilidades;
using dllMensaje;
using Ordenes.Clases;

namespace Ordenes.Formularios
{
    public partial class frmCortes : Form
    {
        clsCalculaCorte objCorte = new clsCalculaCorte();
        private float m_AnchoMAT = 0;
        private float m_AltoMAT = 0;
        private float m_AnchoCOR = 0;
        private float m_AltoCOR = 0;
        private int m_numeroFil = 0;
        private int m_numeroCol=0;

        public frmCortes()
        {
            InitializeComponent();
        }

        private void frmCortes_Load(object sender, EventArgs e)
        {
            
        }


        private void _CalculaDesperdicio() {

            objCorte._Calcular(m_AnchoMAT,m_AltoMAT,m_AnchoCOR,m_AltoCOR,
                seTiraje.Value.ToInt(), seTrabajosXCorte.Value.ToInt());

            seAnchoRES.EditValue = objCorte.pro_AnchoTamano;
            seAltoRES.EditValue = objCorte.pro_AltoTamano;
            seTamanosXpliego.EditValue = objCorte.pro_TamanoXpliego;
            seCantidadPliegos.EditValue = objCorte.pro_TotalPliego;
            seCantidadTamanos.EditValue = objCorte.pro_TotalTamano;
            seCantidadImpresiones.EditValue = objCorte.pro_TotalImpresiones;
            seCantidadPliegos.EditValue = objCorte.pro_TotalPliego;
            
            seCantidadImpresiones.EditValue = objCorte.pro_TotalImpresiones;
            sePerdida.EditValue = objCorte.pro_Desperdicio;
            m_AnchoCOR = objCorte.pro_AnchoTamano;
            m_AltoCOR = objCorte.pro_AltoTamano;
            m_numeroFil = objCorte.pro_NumFilas;
            m_numeroCol = objCorte.pro_NumColumnas;

        }
        
        private void _Dibujar()
        {
            //AREA DE TRABAJO 1.80m X 1.20m (270px X180px)
            //5px se van en margenes de cada lado 
            float margen = 5;
            //1.5px=1cm
            float factor = 1.5f;

            //CALCULO DE LA ESCALA
            float anchoColumna = m_AnchoCOR * factor;
            float altoFila = m_AltoCOR * factor;
            
            //INICIALIZA VALORES
            float posX = 0;
            float posY = 0;
            
            //POR ESTETICA SI EL CORTE ES MENOR A 5CM PINTE MENOS GRUESO PARA QUE SE VEA CLARO
            int anchoPen = m_AnchoCOR > 5 && m_AltoCOR > 5 ? 2 : 1;

            Pen myPen = new Pen(Color.SeaGreen,anchoPen);
            Graphics formGraphics = paSoporte.CreateGraphics();
            formGraphics.Clear(paSoporte.BackColor);

            //DIBUJA EL AREA DEL MATERIAL            
            formGraphics.FillRectangle(Brushes.Tan, margen, margen, (m_AnchoMAT * factor), (m_AltoMAT * factor));
            
            //DIBUJA EL AREA QUE SE VA A UTILIZAR
            formGraphics.FillRectangle(Brushes.DarkSeaGreen, margen, margen, ((m_numeroCol * m_AnchoCOR)*factor), ((m_numeroFil * m_AltoCOR)*factor));

            //DIBUJA LAS FILAS
            for (int j = 0; j < m_numeroFil + 1; j++)
            {
                posY = (altoFila * j) + margen;
                formGraphics.DrawLine(myPen, margen, posY, ((m_numeroCol * anchoColumna) + margen), posY);
            }

            //DIBUJA LAS COLUMNAS
            for (int i = 0; i < m_numeroCol + 1; i++)
            {
                posX = (anchoColumna * i) + margen;
                formGraphics.DrawLine(myPen, posX, margen, posX, ((m_numeroFil * altoFila) + margen));
            }

            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            seAnchoTotal.Value = seAnchoTAM.Value + seAnchoPinza.Value;
            seAltoTotal.Value = seAltoTAM.Value + seAltoPinza.Value;
            m_AnchoMAT = float.Parse(seAnchoMAT.Value.ToString());
            m_AltoMAT = float.Parse(seAltoMAT.Value.ToString());
            m_AnchoCOR = float.Parse(seAnchoTotal.Value.ToString());
            m_AltoCOR = float.Parse(seAltoTotal.Value.ToString());
            _CalculaDesperdicio();

            _Dibujar();
        }

    }
}
