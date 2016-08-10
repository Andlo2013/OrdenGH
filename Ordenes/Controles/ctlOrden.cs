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
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace Ordenes.Controles
{
    public partial class ctlOrden : UserControl
    {
        clsOrden objOrden = new clsOrden();

        public ctlOrden()
        {
            InitializeComponent();
        }

        private void ctlOrden_Load(object sender, EventArgs e)
        {
            _cargaCMB();
        }

        //Carga todos los combos
        private void _cargaCMB()
        {
            //GENERALES: Combo tipo trabajo
            DataTable dt_optionsCMB = objOrden._cargaCMBOPC(optionsCMB.TrabajoGEN,0);
            objOrden._cargaCMB(dt_optionsCMB, gen_lueTrabajo);
            //TODOS LOS COMBOS TAMANO
            dt_optionsCMB = objOrden._cargaCMBOPC(optionsCMB.TipoTamano, 0);
            objOrden._cargaCMB(dt_optionsCMB, gen_lueTamano);
            objOrden._cargaCMB(dt_optionsCMB, blo_lueTamano);
            objOrden._cargaCMB(dt_optionsCMB, lib_lueTamanoENC);
            objOrden._cargaCMB(dt_optionsCMB, lib_lueTamanoPOR);
            //TODOS LOS COMBOS TROQUEL
            dt_optionsCMB = objOrden._cargaCMBOPC(optionsCMB.TipoTroquel, 0);
            objOrden._cargaCMB(dt_optionsCMB, gen_lueTroquel);
            objOrden._cargaCMB(dt_optionsCMB, blo_lueTroquel);
            objOrden._cargaCMB(dt_optionsCMB, lib_lueTroquelPOR);
            //TODOS LOS COMBOS COLOR
            dt_optionsCMB = objOrden._cargaCMBOPC(optionsCMB.Color, 0);
            objOrden._cargaCMB(dt_optionsCMB, gen_lueColorTiro);
            objOrden._cargaCMB(dt_optionsCMB, gen_lueColorRetiro);
            objOrden._cargaCMB(dt_optionsCMB, blo_lueColor);
            objOrden._cargaCMB(dt_optionsCMB, lib_lueTiroColorPOR);
            objOrden._cargaCMB(dt_optionsCMB, lib_lueReitroColorPOR);
            objOrden._cargaCMB(dt_optionsCMB, lib_lueTiroGuardaPOR);
            objOrden._cargaCMB(dt_optionsCMB, lib_lueRetiroGuardaPOR);
            objOrden._cargaCMB(dt_optionsCMB, lib_lueTiroCubiertaPOR);
            objOrden._cargaCMB(dt_optionsCMB, lib_lueReitroCubiertaPOR);
            objOrden._cargaCMBLUE(dt_optionsCMB, rilue_gridColorENC);
            //BLOCKS NÚMERO COPIAS
            dt_optionsCMB = objOrden._cargaCMBOPC(optionsCMB.NumeroCopia, 0);
            objOrden._cargaCMB(dt_optionsCMB, blo_lueNumCopias);
            dt_optionsCMB = objOrden._cargaCMBOPC(optionsCMB.TipoBloque, 0);
            objOrden._cargaCMB(dt_optionsCMB, blo_lueTipoEmblocado);
            dt_optionsCMB = objOrden._cargaCMBOPC(optionsCMB.BlockAcabado, 0);
            objOrden._cargaCMB(dt_optionsCMB, blo_lueAcabado);
            //LIBRO 
            dt_optionsCMB = objOrden._cargaCMBOPC(optionsCMB.LibroEncuadernado, 0);
            objOrden._cargaCMB(dt_optionsCMB, lib_TipoTrabajoENC);
            dt_optionsCMB = objOrden._cargaCMBOPC(optionsCMB.TipoLibro, 0);
            objOrden._cargaCMB(dt_optionsCMB, lib_lueTipoLibro);
            dt_optionsCMB = objOrden._cargaCMBOPC(optionsCMB.LibroForma, 0);
            objOrden._cargaCMB(dt_optionsCMB, lib_lueForma);
            //EGRESO DE MATERIALES
            dt_optionsCMB = objOrden._cargaCMBOPC(optionsCMB.EgrMat_Seccion, 0);
            objOrden._cargaCMBLUE(dt_optionsCMB, dis_rilueSeccion);
            dt_optionsCMB = objOrden._cargaCMBOPC(optionsCMB.EgrMat_Maquina, 0);
            objOrden._cargaCMBLUE(dt_optionsCMB, dis_rilueMaquina);
        }

        private void _cargaMaterial(ButtonEdit be_Button)
        {
            DataRow rowSEL = objOrden._BuscarMaterial();
            if (rowSEL != null)
            {
                be_Button.Text = rowSEL["Descripción"].ToString();
                //Falta el código
            }
        }

        private void _cargaGeneral()
        {
            DataRow rowGeneral = objOrden._generalCargaDET();
            if (rowGeneral != null)
            {
                gen_lueTrabajo.EditValue = Convert.ToInt32(rowGeneral["Trabajo"]);
                gen_txtTiraje.EditValue = rowGeneral["Tiraje"];
                gen_lueTipoTrabajo.EditValue = Convert.ToInt32(rowGeneral["TipoTrabajo"]);
                gen_lueTamano.EditValue = Convert.ToInt32(rowGeneral["TipoTamano"]);
                gen_txtAncho.EditValue = rowGeneral["Ancho"];
                gen_txtAlto.EditValue = rowGeneral["Alto"];
                gen_beMaterial.EditValue = rowGeneral["Material"];
                gen_txtGramos.EditValue = rowGeneral["Gramos"];
                gen_lueTroquel.EditValue = Convert.ToInt32(rowGeneral["TipoTroquel"]);
                gen_txtOrdenTroquel.EditValue = rowGeneral["OrdenTroquel"];
                gen_lueColorTiro.EditValue = Convert.ToInt32(rowGeneral["ColorTiro"]);
                gen_lueColorRetiro.EditValue = Convert.ToInt32(rowGeneral["ColorRetiro"]);
                gen_txtPantones.EditValue = rowGeneral["Pantones"];
            }
        }
        


        #region BarraEstandar
        private void barraStandar_onNew()
        {

        }

        private void barraStandar_onSave()
        {

        }

        private void barraStandar_onEdit()
        {

        }

        private void barraStandar_onDelete()
        {

        }

        private void barraStandar_onUndo()
        {

        }

        #endregion

        #region buttonEdit

        private void beOrden_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow drFilaSEL = objOrden._BuscarORD();
            if (drFilaSEL!=null)
            {
                gcAcabados.DataSource = objOrden._acabadoCarga();
                txtCodigoORD.Text = drFilaSEL["id"].ToString();
                beOrden.Text = drFilaSEL["Orden"].ToString();
                deFechaFAC.EditValue = drFilaSEL["FechaFAC"];
                deFechaPP.EditValue = drFilaSEL["FechaENTPP"];
                deFechaENT.EditValue = drFilaSEL["FechaENT"];
                rdgTipoOFF.EditValue= drFilaSEL["TipoOFF"];
                //DATOS CLIENTE
                beBuscaCLI.Text = drFilaSEL["CodigoCLI"].ToString();
                txtNombreCLI.Text = drFilaSEL["Cliente"].ToString();
                beOrden.Text = drFilaSEL["Orden"].ToString();
                //DISEÑO
                dis_deFechaINI.EditValue= drFilaSEL["FechaINIDIS"];
                dis_deFechaFIN.EditValue = drFilaSEL["FechaFINDIS"];
                dis_txtDisenador.Text = drFilaSEL["NombreEplDisena"].ToString();
                dis_chkArchivoPerfil.Checked = Convert.ToBoolean(drFilaSEL["dis_ArchivoPerfil"]);
                dis_chkPruebaColor.Checked = Convert.ToBoolean(drFilaSEL["dis_PruebaColor"]);
                dis_chkMachote.Checked = Convert.ToBoolean(drFilaSEL["dis_Machote"]);
                //TOTALES
                seCantidad.EditValue = drFilaSEL["Cantidad"];
                sePrecioUNI.EditValue = drFilaSEL["PreUnitario"];
                seSubtotal.EditValue = drFilaSEL["Subtotal"];
                seIVA.EditValue = drFilaSEL["IVA"];
                seTotal.EditValue = drFilaSEL["Total"];
                seAbono.EditValue = drFilaSEL["Abono"];
                seSaldo.EditValue = drFilaSEL["Saldo"];

                lib_gcColoresENC.DataSource = objOrden._libroCargaColor();
                dis_gcEgreso.DataSource = objOrden._disenoCargaDET();
                _cargaGeneral();
            }
        }

        private void blo_beMaterial_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _cargaMaterial(blo_beMaterial);
        }

        private void lib_beMaterialENC_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _cargaMaterial(lib_beMaterialENC);
        }

        private void lib_beMaterialGuardaPOR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _cargaMaterial(lib_beMaterialGuardaPOR);
        }

        private void lib_beMaterialCubiertaPOR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _cargaMaterial(lib_beMaterialCubiertaPOR);
        }

        private void lib_txtMaterialPOR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _cargaMaterial(lib_txtMaterialPOR);
        }

        private void gen_beMaterial_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _cargaMaterial(gen_beMaterial);
        }

        #endregion

        private void gen_lueTrabajo_EditValueChanged(object sender, EventArgs e)
        {
            if (gen_lueTrabajo.EditValue != null)
            {
                DataTable dt_TipoTRA = objOrden._cargaCMBOPC(optionsCMB.TrabajoTipo, Convert.ToInt32(gen_lueTrabajo.EditValue));
                objOrden._cargaCMB(dt_TipoTRA, gen_lueTipoTrabajo);
            }
        }

        private void dis_ribeBuscaMAT_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (dis_gvEgreso.FocusedRowHandle >= 0)
            {
                DataRow currentRow = dis_gvEgreso.GetFocusedDataRow();
                DataRow rowSEL = objOrden._BuscarMaterial();
                if (rowSEL != null)
                {
                    currentRow["CodigoMAT"] = rowSEL["Código"].ToString();
                    currentRow["Material"] = rowSEL["Descripción"].ToString();
                    dis_gvEgreso.RefreshRow(dis_gvEgreso.FocusedRowHandle);
                }
            }
        }

        private void mnuAgregaAcabado_Click(object sender, EventArgs e)
        {
            objOrden._acabadoAgrega();
        }

        private void mnuQuitaAcabado_Click(object sender, EventArgs e)
        {

        }

        
    }
}
