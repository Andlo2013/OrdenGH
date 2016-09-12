using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using AutomatizerSQL.Utilidades;
using dllMensaje;
using Ordenes.Clases;
using dllBuscar;
using Ordenes.Properties;

namespace Ordenes.Formularios
{
    public partial class frmCortes : Form
    {
        //INSTANCIAS-VARIABLES DE LA CLASE
        #region INSTANCIAS-VARIABLES
        clsCalculaCorte objCorte = new clsCalculaCorte();
        Graphics formGraphics;
        DataRow rowMaterial=null;

        private string m_Servidor = Form1.getSession.Servidor;
        private string m_Catalogo = Form1.getSession.Catalogo;
        private string m_codEmpresa = Form1.getSession.Empresa.Codigo;

        //AREA DE TRABAJO 1.80m X 1.20m (370px X250px)
        //5px se van en margenes de cada lado 
        private float margen = 5;
        //2px=1cm
        private float factor = 2;
        #endregion


        public frmCortes()
        {
            InitializeComponent();
        }

        private void frmCortes_Load(object sender, EventArgs e)
        {
            
        }

        //METODOS VARIOS
        #region METODOS: VARIOS
        
        //Buscar grupo
        #region BuscaGrupo
        public void _BuscarGrupo()
        {
            try
            {
                Dictionary<string, string> dicionario = new Dictionary<string, string>();
                dicionario.Add("Talla", "Grupo");
                frmBuscarITEM objBuscar = new frmBuscarITEM();
                objBuscar.pro_Configura
                    ._set01Connection(m_Servidor, m_Catalogo)
                    ._set02Find(sqlCotizacion.cot_disArmadosAgregaGrupo, new string[] { "@CodEmpresa" }, new object[] { m_codEmpresa })
                    ._set03OptionsFilter(dicionario)
                    ._setSeleccionSimple(true);
                objBuscar.ShowDialog();
                DataRow rowSEL = objBuscar.pro_FilaSEL;
                if (rowSEL != null)
                {
                    this.rowMaterial["CodGrupo"] = rowSEL["Código"];
                    this.rowMaterial["Grupo"] = rowSEL["Grupo"];
                    beGrupoMAT.EditValue = rowSEL["Grupo"];
                    //CAMBIA EL GRUPO PUEDE CAMBIAR LAS DIMENSIONES DE LOS PLIEGOS
                    _Calcular();
                }
            }
            catch (Exception ex)
            {
                clsMensaje._msjWarning("ERROR: Al intentar agregar materiales", "Agrega material", ex.Message);
            }
        }
        #endregion

        //Cargar controles
        #region CargarControles
        private void _CargaControles()
        {
            beGrupoMAT.EditValue = rowMaterial["Grupo"].ToString();
            sePliegoAncho.EditValue = rowMaterial["PliegoAncho"];
            sePliegoAlto.EditValue = rowMaterial["PliegoAlto"];
            seTamanoAncho.EditValue = rowMaterial["TamanoAncho"];
            seTamanoAlto.EditValue = rowMaterial["TamanoAlto"];
            seTrabajoAncho.EditValue = rowMaterial["TrabajoAncho"];
            seTrabajoAlto.EditValue = rowMaterial["TrabajoAlto"];
            seTrabajosXtamano.EditValue = rowMaterial["TrabajosXtamano"];
            seTamanosXpliego.EditValue = rowMaterial["TamanosXpliego"];
            seTotalPliegos.EditValue = rowMaterial["PliegoCantidad"];
        }
        #endregion

        //Calcular
        #region Calcular
        private void _Calcular()
        {
            clsCalculaCorte objCorte = new clsCalculaCorte();
            rowMaterial["TrabajoAncho"] = seAnchoUsuario.EditValue;
            rowMaterial["TrabajoAlto"] = seAltoUsuario.Value;
            objCorte._ext_disenoArmadoCalcula(rowMaterial);
            _CargaControles();
            _Dibujar();
        }
        #endregion

        #endregion

        //METODOS QUE DIBUJAN LAS AREAS Y CORTES
        #region METODOS: DIBUJAR

        //DIBUJAR METODO PRINCIPAL
        #region Dibujar
        public void _Dibujar()
        {
            try
            {
                float anchoMAT = float.Parse(sePliegoAncho.EditValue.ToString());
                float altoMAT = float.Parse(sePliegoAlto.EditValue.ToString());
                float anchoTamano = float.Parse(seTamanoAncho.EditValue.ToString());
                float altoTamano = float.Parse(seTamanoAlto.EditValue.ToString());
                float anchoTrabajo = float.Parse(seTrabajoAncho.EditValue.ToString());
                float altoTrabajo = float.Parse(seTrabajoAlto.EditValue.ToString());

                if (anchoTamano < altoTamano)
                {
                    float AUX = anchoTrabajo;
                    anchoTrabajo = altoTrabajo;
                    altoTrabajo = AUX;
                }

                _limpiarAreaTrabajo();
                //DIBUJA EL AREA DEL MATERIAL            
                _DibujarArea(margen, margen, (anchoMAT * factor), (altoMAT * factor), Brushes.Tan);

                //DIBUJA EL AREA QUE VAN A UTILIZAR LAS PLACAS
                _DibujarAreaCALC(anchoMAT, altoMAT, anchoTamano, altoTamano, Brushes.SeaGreen);

                //DIBUJA EL AREA QUE UTILIZA EL TRABAJO
                _DibujarAreaCALC(anchoTamano, altoTamano, anchoTrabajo, altoTrabajo, Brushes.CadetBlue);


                _DibujarCortes(anchoMAT, altoMAT, anchoTamano, altoTamano);

                _DibujarCortes(anchoTamano, altoTamano, anchoTrabajo, altoTrabajo);
            }
            catch(Exception ex)
            {
                _limpiarAreaTrabajo();
                clsMensaje._msjWarning("ERROR: AL intentar graficar los cortes", "Graficar", ex.Message);
            }
        }
        #endregion

        //CALCULA UNA AREA Y ENVIA A PINTAR
        #region DibujaAreaCalculada
        private void _DibujarAreaCALC(float anchoMAT, float altoMAT, float anchoCOR, float altoCOR,Brush ColorArea)
        {
            float x2 = _ParteEntera(anchoMAT, anchoCOR) * anchoCOR * factor;
            float y2 = _ParteEntera(altoMAT, altoCOR) * altoCOR * factor;
            _DibujarArea(margen, margen, x2, y2, ColorArea);
        }
        #endregion

        //PINTA UNA AREA
        #region DibujaArea
        private void _DibujarArea(float X1, float Y1, float X2, float Y2,Brush color)
        {
            //DIBUJA EL AREA            
            formGraphics.FillRectangle(color, X1, Y1, X2, Y2);
        }
        #endregion

        //TRAZA LAS LINEAS DE CORTE
        #region DibujaCortes
        private void _DibujarCortes(float anchoMAT, float altoMAT, float anchoCOR, float altoCOR)
        {
            
            int numColumnasCOR = _ParteEntera(anchoMAT, anchoCOR);
            int numFilasCOR = _ParteEntera(altoMAT, altoCOR);

            float anchoColumna = anchoCOR * factor;
            float altoFila = altoCOR * factor;

            Pen myPen=new Pen(Brushes.White,_anchoLapiz(altoFila,anchoColumna));

            //INICIALIZA VALORES
            float posX = 0;
            float posY = 0;
            //DIBUJA LAS FILAS
            for (int j = 0; j < numFilasCOR + 1; j++)
            {
                posY = (altoFila * j) + margen;
                formGraphics.DrawLine(myPen, margen, posY, ((numColumnasCOR * anchoColumna) + margen), posY);
            }

            //DIBUJA LAS COLUMNAS
            for (int i = 0; i < numColumnasCOR + 1; i++)
            {
                posX = (anchoColumna * i) + margen;
                formGraphics.DrawLine(myPen, posX, margen, posX, ((numFilasCOR * altoFila) + margen));
            }
        }
        #endregion

        //DEFINE EL ANCHO DEL LAPIZ EN FUNCION DE LA CANTIDAD DE LINEAS
        #region AnchoLapiz
        private float _anchoLapiz(float altoFila,float anchoColumna)
        {
            if (anchoColumna <= 5 || altoFila <= 5)
            {
                return 0.2f;
            }
            else if (anchoColumna <= 15 || altoFila <= 15)
            {
                return 1;
            }
            return 2;
        }
        #endregion

        //LIMPIA EL AREA DE TRABAJO
        #region LimpiarAreaTrabajo
        private void _limpiarAreaTrabajo()
        {
            formGraphics = paSoporte.CreateGraphics();
            formGraphics.Clear(Color.White);
        }
        #endregion

        //OBTIENE LA PARTE ENTERA DE UN NUMERO
        #region ParteEntera
        private int _ParteEntera(float Dividendo,float Divisor)
        {
            return Math.Floor((Dividendo / Divisor).ToDecimal()).ToInt();
        }
        #endregion

        #endregion

        //EVENTOS DE LOS CONTROLES
        #region CONTROLES

        //Buscar grupo click
        #region beGrupoMAT-Click
        private void beGrupoMAT_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _BuscarGrupo();
        }
        #endregion
        
        //Calcula click
        #region btnCalcular-Click
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            _Calcular();
        }
        #endregion

        //frmCortesShown
        #region frmCortes-Shown
        private void frmCortes_Shown(object sender, EventArgs e)
        {
            _Dibujar();
        }
        #endregion

        #endregion

        //METODOS PARA CLASES EXTERNAS
        #region METODOS: EXTERNOS

        //GRAFICAR METODO EXTERNO
        #region Graficar
        public void _ext_Graficar(DataRow rowSEL)
        {
            seTiraje.Value = rowSEL["Tiraje"].ToDecimal();
            rowMaterial = rowSEL;
            seAnchoUsuario.EditValue = rowMaterial["TrabajoAncho"];
            seAltoUsuario.EditValue = rowMaterial["TrabajoAlto"];
            _Calcular();
        }
        #endregion

        #endregion

        
    }
}
