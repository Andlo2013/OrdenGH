using AutomatizerSQL.Utilidades;
using dllMensaje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes.Clases
{
    public class clsCalculaCorte
    {

        private float m_anchoTamano = 0;
        private float m_altoTamano = 0;
        private int m_numeroFIL = 0;
        private int m_numeroCOL = 0;
        private int m_tamanoXpliego = 0;
        private int m_totalPliego = 0;
        private int m_totalTamano = 0;
        private int m_totalImpresiones = 0;
        private double m_Desperdicio = 0;
        private int m_trabajoXtamano = 0;


        public float pro_AnchoTamano { get { return m_anchoTamano; } }
        public float pro_AltoTamano { get { return m_altoTamano; } }
        public int pro_NumFilas { get { return m_numeroFIL; } }
        public int pro_NumColumnas { get { return m_numeroCOL; } }
        public int pro_TamanoXpliego { get { return m_tamanoXpliego; } }
        public int pro_TotalPliego { get { return m_totalPliego; } }
        public int pro_TotalTamano { get { return m_totalTamano; } }
        public int pro_TotalImpresiones{ get { return m_totalImpresiones; } }
        public double pro_Desperdicio { get { return m_Desperdicio; } }

        public clsCalculaCorte() { }

        private double _AreaDesperdicio(float anchoMAT, float altoMAT, float anchoCOR, float altoCOR)
        {
            if (anchoMAT >= anchoCOR && altoMAT >= altoCOR)
            {
                double anchoResiduo = anchoMAT % anchoCOR;
                double altoResiduo = altoMAT % altoCOR;
                double areaDesperdicio = (anchoResiduo * altoMAT) + (altoResiduo * anchoMAT) - (anchoResiduo * altoResiduo);
                return areaDesperdicio;
            }
            return -1;
        }

        public void _Calcular(float anchoMAT, float altoMAT, float anchoCOR, float altoCOR,
                            int impresiones, int trabajoXcorte)
        {
            try
            {
                if (_Validar(anchoMAT, altoMAT, anchoCOR, altoCOR, impresiones, trabajoXcorte))
                {
                    
                    _InicializaVariables();
                    
                    m_trabajoXtamano = trabajoXcorte;

                    double areaDesperdicio1 = _AreaDesperdicio(anchoMAT, altoMAT, anchoCOR, altoCOR);
                    double areaDesperdicio2 = _AreaDesperdicio(anchoMAT, altoMAT, altoCOR, anchoCOR);

                    m_anchoTamano = anchoCOR;
                    m_altoTamano = altoCOR;
                    m_Desperdicio = areaDesperdicio1;

                    if (areaDesperdicio1 > areaDesperdicio2 && areaDesperdicio2>=0)
                    {
                        m_altoTamano = anchoCOR;
                        m_anchoTamano = altoCOR;
                        m_Desperdicio = areaDesperdicio2;
                    }

                    m_numeroFIL = (Math.Floor(altoMAT / m_altoTamano)).ToInt();
                    m_numeroCOL = Math.Floor(anchoMAT / m_anchoTamano).ToInt();
                    m_tamanoXpliego = m_numeroFIL * m_numeroCOL;
                    int residuo = 0;
                    m_totalPliego = Math.DivRem(impresiones, (m_tamanoXpliego * trabajoXcorte), out residuo);
                    m_totalPliego = residuo > 0 ? m_totalPliego + 1 : m_totalPliego;
                    m_totalTamano = m_totalPliego.ToInt() * m_tamanoXpliego;
                    m_totalImpresiones = m_totalTamano * m_trabajoXtamano;
                }
            }
            catch(Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar calcular los cortes", "Calcular corte", ex.Message);
            }
        }

        private void _InicializaVariables()
        {
            m_anchoTamano = m_altoTamano = 0;
            m_numeroFIL = m_numeroCOL = 0;
            m_tamanoXpliego = m_totalPliego = 0;
            m_totalTamano = m_totalImpresiones = 0;
            m_Desperdicio = m_trabajoXtamano = 0;
        }

        private bool _Validar(float anchoMAT, float altoMAT,
            float anchoCOR, float altoCOR, int impresiones, int trabajoXcorte)
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
            else if (anchoCOR > anchoMAT)
            {
                clsMensaje._msjWarning("El ancho del corte no puede ser mayor al ancho del material", "Validar");
                return false;
            }
            else if (altoCOR > altoMAT)
            {
                clsMensaje._msjWarning("El alto del corte no puede ser mayor al alto del material", "Validar");
                return false;
            }
            else if (impresiones <= 0)
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

    }
}
