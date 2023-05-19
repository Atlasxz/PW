using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjCalculadora
{



    public partial class Calculadora : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSomar_Click(object sender, EventArgs e)
        {
            Double v1 = Double.Parse(txtVal1.Text);
            Double v2 = Double.Parse(txtVal2.Text);

            Double tSomar = v1 + v2;

            //Metodos de Conversão
            //txtTotal.Text = t + "";
            txtTotal.Text = tSomar.ToString();
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            Double v1 = Double.Parse(txtVal1.Text);
            Double v2 = Double.Parse(txtVal2.Text);
            Double tSub = v1 - v2;

            //Metodos de Conversão
            //txtTotal.Text = t + "";
            txtTotal.Text = tSub.ToString();
        }

        protected void btnVezes_Click(object sender, EventArgs e)
        {
            Double v1 = Double.Parse(txtVal1.Text);
            Double v2 = Double.Parse(txtVal2.Text);
            Double tVezes = v1 * v2;

            //Metodos de Conversão
            //txtTotal.Text = t + "";
            txtTotal.Text = tVezes.ToString();
        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            Double v1 = Double.Parse(txtVal1.Text);
            Double v2 = Double.Parse(txtVal2.Text);
            Double tDiv = v1 / v2;

            //Metodos de Conversão
            //txtTotal.Text = t + "";
            txtTotal.Text = tDiv.ToString();
        }

        protected void btnSeno_Click(object sender, EventArgs e)
        {
            Double v1 = Double.Parse(txtVal1.Text);
            Double rad = (v1 * Math.PI) / 180;
            Double t = Math.Sin(rad);
            txtTotal.Text = t.ToString();
        }
    }
}