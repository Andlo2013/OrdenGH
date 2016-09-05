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

namespace Ordenes.Formularios
{
    public partial class frmCortes : Form
    {
        float m_AnchoMAT = 90;
        float m_AltoMAT = 65;
        float m_AnchoCOR = 44.50f;
        float m_AltoCOR = 32.5f;
        int m_numeroFil = 0;
        int m_numeroCol = 0;

        public frmCortes()
        {
            InitializeComponent();
        }

        private void frmCortes_Load(object sender, EventArgs e)
        {
           
        }

        private double _AreaDesperdicio(float anchoMAT,float altoMAT,float anchoCOR,float altoCOR)
        {
            double anchoResiduo = anchoMAT % anchoCOR;
            double altoResiduo = altoMAT % altoCOR;
            double areaDesperdicio = (anchoResiduo * altoMAT) + (altoResiduo * anchoMAT) - (anchoResiduo * altoResiduo);
            return areaDesperdicio;
        }

        private void _CalculaDesperdicio(float anchoMAT, float altoMAT, float anchoCOR, float altoCOR,
                            int tiraje,int trabajoXcorte)
        {
            if (_Validar(anchoMAT, altoMAT,anchoCOR,altoCOR,tiraje,trabajoXcorte))
            {
                double areaDesperdicio1 = _AreaDesperdicio(anchoMAT, altoMAT, anchoCOR, altoCOR);
                double areaDesperdicio2 = _AreaDesperdicio(anchoMAT, altoMAT, altoCOR, anchoCOR);

                m_AnchoCOR = anchoCOR;
                m_AltoCOR = altoCOR;
                txtPerdida.EditValue = areaDesperdicio1;

                if (areaDesperdicio1 > areaDesperdicio2)
                {
                    m_AltoCOR = anchoCOR;
                    m_AnchoCOR = altoCOR;
                    txtPerdida.EditValue = areaDesperdicio2;
                }
               
                m_numeroFil = (Math.Floor(m_AltoMAT / m_AltoCOR)).ToInt();
                m_numeroCol = Math.Floor(m_AnchoMAT / m_AnchoCOR).ToInt();
                int cortesXpliego = m_numeroFil * m_numeroCol;
                decimal totalPliego = Math.Ceiling(tiraje / (cortesXpliego * trabajoXcorte.ToDecimal()));
                decimal totalCortes = totalPliego * cortesXpliego;
                decimal totalTrabajos = totalCortes * trabajoXcorte;

                txtAnchoRES.EditValue = m_AnchoCOR;
                txtAltoRES.EditValue = m_AltoCOR;
                txtCortesPorPliego.Text = cortesXpliego.ToString();
                txtCantidadPliegos.Text = totalPliego.ToString();
                txtCantidadCortes.Text = totalCortes.ToString();
                txtCantidadTrabajos.Text = totalTrabajos.ToString();

                _Dibujar();
            }
        }

        private void _Dibujar()
        {
            float margen = 1;
            //FACTORES DE CONVERSION PARA DIBUJAR
            float factorX = ((paSoporte.Width-(margen*2)) / m_AnchoMAT);
            float factorY = ((paSoporte.Height- (margen * 2)) / m_AltoMAT);
            //CALCULO DE LA ESCALA
            float anchoEscala = m_AnchoCOR * factorX;
            float altoEscala = m_AltoCOR * factorY;
            //INICIALIZA VALORES
            float posX = 0;
            float posY = 0;
            Pen myPen = new Pen(Color.Black,2);
            Graphics formGraphics = paSoporte.CreateGraphics();
            formGraphics.Clear(paSoporte.BackColor);
            //DIBUJA LAS FILAS
            for (int j = 0; j < m_numeroFil+1; j++)
            {
                posY = (altoEscala * j)+margen;
                formGraphics.DrawLine(myPen, margen, posY, ((m_numeroCol* anchoEscala) +margen), posY);
            }
            //myPen = new Pen(Color.Green);
            //DIBUJA LAS COLUMNAS
            for (int i = 0; i < m_numeroCol + 1; i++)
            {
                posX = (anchoEscala * i)+ margen;
                formGraphics.DrawLine(myPen,posX , margen, posX, ((m_numeroFil * altoEscala) + margen));
            }
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private bool _Validar(float anchoMAT, float altoMAT, 
            float anchoCOR, float altoCOR,int tiraje,int trabajoXcorte)
        {
            if (anchoMAT == 0)
            {
                clsMensaje._msjWarning("El ancho del material debe ser mayor a cero", "Validar");
                return false;
            }
            else if (altoMAT == 0)
            {
                clsMensaje._msjWarning("El alto del material debe ser mayor a cero", "Validar");
                return false;
            }
            else if (anchoCOR == 0)
            {
                clsMensaje._msjWarning("El ancho del corte debe ser mayor a cero", "Validar");
                return false;
            }
            else if (altoCOR == 0)
            {
                clsMensaje._msjWarning("El alto del corte debe ser mayor a cero", "Validar");
                return false;
            }
            else if (anchoCOR > altoMAT)
            {
                clsMensaje._msjWarning("El ancho del corte no puede ser mayor al ancho del material", "Validar");
                return false;
            }
            else if (altoCOR > altoMAT)
            {
                clsMensaje._msjWarning("El alto del corte no puede ser mayor al alto del material", "Validar");
                return false;
            }
            else if (tiraje <= 0)
            {
                clsMensaje._msjWarning("El tiraje debe ser mayor a cero", "Validar");
                return false;
            }
            else if (trabajoXcorte <= 0)
            {
                clsMensaje._msjWarning("Los trabajos por corte debe ser mínimo uno", "Validar");
                return false;
            }
            return true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            seAnchoTotal.Value = seAnchoCOR.Value + seAnchoPinza.Value;
            seAltoTotal.Value = seAltoCOR.Value + seAltoPinza.Value;
            m_AnchoMAT = float.Parse(seAnchoMAT.Value.ToString());
            m_AltoMAT = float.Parse(seAltoMAT.Value.ToString());
            m_AnchoCOR = float.Parse(seAnchoTotal.Value.ToString());
            m_AltoCOR = float.Parse(seAltoTotal.Value.ToString());
            _CalculaDesperdicio(m_AnchoMAT,m_AltoMAT,m_AnchoCOR,m_AltoCOR,
                seTiraje.Value.ToInt(),seTrabajosXCorte.Value.ToInt());
        }
    }
}
