using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace procesoeEntregaDePasaporte
{
    public partial class entregaPasaporte : UserControl
    {
        public entregaPasaporte()
        {
            InitializeComponent();
        }

        public void getCUI(string cui)
        {
            SQL_TomarDatosPasaporte pas = new SQL_TomarDatosPasaporte();
            pas.obtenerPasaporte(cui);
            SQL_Cliente cliente = new SQL_Cliente();
            cliente.obtenerCliente(cui);
            String datos = String.Format("Datos del Pasaporte: \n" +
                "CUI:  {0} \nNOMBRE(S): {1}\nAPELLIDO(S): {2}\nFECHA NACIMEITNO: {3}\nESTADO CIVIL: {4}\nNACIONALIDAD: {5}" +
                "SEXO: {6}\nESTADO CIVIL: {7}\nFECHA DE EMISION:{8}"
                ,cui,cliente.nombres_dpi, cliente.apellidos_dpi,cliente.fecha_nacimiento_dpi.ToShortDateString(), 
                cliente.estado_civil_dpi, cliente.nacionalidad_dpi, cliente.sexo_dpi, cliente.estado_civil_dpi, 
                pas.emision);
            Lbl_Datos.Text = datos;
        }

        public void prueba()
        {
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Tlp_titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tlp_avance_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tlp_Informacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_no_paso_Click(object sender, EventArgs e)
        {

        }
    }
}
