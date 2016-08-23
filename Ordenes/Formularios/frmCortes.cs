using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenes.Formularios
{
    public partial class frmCortes : Form
    {
        float m_AnchoMAT = 90;
        float m_AltoMAT = 65;
        float m_AnchoCOR = 44.50f;
        float m_AltoCOR = 32.5f;
        public frmCortes()
        {
            InitializeComponent();
        }

        private void frmCortes_Load(object sender, EventArgs e)
        {
           
        }


        private void _CalculaDesperdicio(float anchoMAT, float altoMAT, float anchoCOR, float altoCOR)
        {
            double anchoResiduo1= anchoMAT % anchoCOR;
            double altoResiduo1 = altoMAT % altoCOR;
            double areaDesperdicio1 = (anchoResiduo1 * altoMAT) + (altoResiduo1 * anchoMAT)-(anchoResiduo1*altoResiduo1);

            double anchoResiduo2 = anchoMAT % altoCOR;
            double altoResiduo2 = altoMAT % anchoCOR;
            double areaDesperdicio2 = (anchoResiduo2 * altoMAT) + (altoResiduo2 * anchoMAT) - (anchoResiduo2 * altoResiduo2);

            if (areaDesperdicio1 <= areaDesperdicio2)
            {
                m_AnchoCOR = anchoCOR;
                m_AltoCOR = altoCOR;
                seDesperdicio.EditValue = areaDesperdicio1;
            }
            else
            {
                m_AltoCOR = anchoCOR;
                m_AnchoCOR = altoCOR;
                seDesperdicio.EditValue = areaDesperdicio2;
            }
            seAnchoRES.EditValue = m_AnchoCOR;
            seAltoRES.EditValue = m_AltoCOR;
            _Dibujar();
        }

        private void _Dibujar()
        {
            float margen = 5;
            int numFilas = int.Parse(Math.Floor(m_AltoMAT / m_AltoCOR).ToString());
            int numColumnas = int.Parse(Math.Floor(m_AnchoMAT / m_AnchoCOR).ToString());
            //FACTORES DE CONVERSION PARA DIBUJAR
            float factorX = ((paSoporte.Width-(margen*2)) / m_AnchoMAT);
            float factorY = ((paSoporte.Height- (margen * 2)) / m_AltoMAT);
            //CALCULO DE LA ESCALA
            float anchoEscala = m_AnchoCOR * factorX;
            float altoEscala = m_AltoCOR * factorY;
            //INICIALIZA VALORES
            float posX = 0;
            float posY = 0;
            Pen myPen = new Pen(Color.Green);
            Graphics formGraphics = paSoporte.CreateGraphics();
            formGraphics.Clear(paSoporte.BackColor);
            //DIBUJA LAS FILAS
            for (int j = 0; j < numFilas+1; j++)
            {
                posY = (altoEscala * j)+margen;
                formGraphics.DrawLine(myPen, margen, posY, ((numColumnas* anchoEscala) +margen), posY);
            }
            //myPen = new Pen(Color.Green);
            //DIBUJA LAS COLUMNAS
            for (int i = 0; i < numColumnas + 1; i++)
            {
                posX = (anchoEscala * i)+ margen;
                formGraphics.DrawLine(myPen,posX , margen, posX, ((numFilas * altoEscala) + margen));
            }
            myPen.Dispose();
            formGraphics.Dispose();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            m_AnchoMAT = float.Parse(seAnchoMAT.Value.ToString());
            m_AltoMAT = float.Parse(seAltoMAT.Value.ToString());
            m_AnchoCOR = float.Parse(seAnchoCOR.Value.ToString());
            m_AltoCOR = float.Parse(seAltoCOR.Value.ToString());
            _CalculaDesperdicio(m_AnchoMAT,m_AltoMAT,m_AnchoCOR,m_AltoCOR);
        }
    }
}
