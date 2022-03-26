using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consumir_ws_proto3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bSuma_Click(object sender, EventArgs e)
        {
            Referencia_ws.prototipo3SoapClient servicio = new Referencia_ws.prototipo3SoapClient();
            lResult.Text = servicio.Suma(float.Parse(tnuma.Text), float.Parse(tnumb.Text)).ToString();

        }

        protected void bResta_Click(object sender, EventArgs e)
        {
            Referencia_ws.prototipo3SoapClient servicio = new Referencia_ws.prototipo3SoapClient();
            lResult.Text = servicio.Resta(float.Parse(tnuma.Text), float.Parse(tnumb.Text)).ToString();
        }

        protected void bMultiplica_Click(object sender, EventArgs e)
        {
            Referencia_ws.prototipo3SoapClient servicio = new Referencia_ws.prototipo3SoapClient();
            lResult.Text = servicio.Multiplica(float.Parse(tnuma.Text), float.Parse(tnumb.Text)).ToString();
        }

        protected void bDivide_Click(object sender, EventArgs e)
        {
            Referencia_ws.prototipo3SoapClient servicio = new Referencia_ws.prototipo3SoapClient();
            lResult.Text = servicio.Divide(float.Parse(tnuma.Text), float.Parse(tnumb.Text)).ToString();
        }
    }
}