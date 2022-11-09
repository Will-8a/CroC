using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CroC
{
    public partial class frm_IngresarDatos : Form
    {
        public frm_IngresarDatos()
        {
            InitializeComponent();
            lbl_Rectificador.Visible = false;
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtp_FechaConteo.Value;
            String responsable = txt_Responsable.Text;
            Int32 cantidadPersonas = Convert.ToInt32(txt_CantidadPersonas.Text); ;
            

            cls_DiaConteo DiaConteo = new cls_DiaConteo(fecha, responsable, cantidadPersonas);

            txt_Prueba.Text = DiaConteo.conteo();
            lbl_Rectificador.Visible = true;

            tmr_ContadorRectificador.Enabled = true;

            txt_Responsable.Enabled = false;
            txt_CantidadPersonas.Enabled = false;
            dtp_FechaConteo.Enabled = false;
        }

        private int contador = 0;
        private void tmr_ContadorRectificador_Tick(object sender, EventArgs e)
        {
            contador = contador + 1;
            label4.Text = Convert.ToString(contador);

            if (contador > 2)
            {
                lbl_Rectificador.Visible = false;
                contador = 0;
                tmr_ContadorRectificador.Stop();
                txt_Responsable.Enabled = true;
                txt_CantidadPersonas.Enabled = true;
                dtp_FechaConteo.Enabled = true;
            }
        }
    }
}
