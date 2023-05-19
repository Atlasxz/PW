using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRJCalculadoraSimples01
{
    public partial class Calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {

            Double v1 = Double.Parse(txtVal1.Text);
            Double v2 = Double.Parse(txtVal2.Text);
            lblTotal.Text = (v1 + v2).ToString();
            }catch (Exception erro)
            {
                lblMsg.Text = "Erro = " + "\n" + erro;
            }

        }

        protected void btnSubtrair_Click(object sender, EventArgs e)
        {
            try
            {

                Double v1 = Double.Parse(txtVal1.Text);
            Double v2 = Double.Parse(txtVal2.Text);
            lblTotal.Text = (v1 - v2).ToString();
            }
            catch (Exception erro)
            {
                lblMsg.Text = "Erro = " + "\n" + erro;
            }
        }

        protected void btnVezes_Click(object sender, EventArgs e)
        {
            try
            {
                Double v1 = Double.Parse(txtVal1.Text);
                Double v2 = Double.Parse(txtVal2.Text);
                lblTotal.Text = (v1 * v2).ToString();
            }
            catch (Exception erro)
            {
                lblMsg.Text = "Erro = " + "\n" + erro;
            }
        }

        protected void btnDivisao_Click(object sender, EventArgs e)
        {
            try
            {
                Double v1 = Double.Parse(txtVal1.Text);
                Double v2 = Double.Parse(txtVal2.Text);
                lblTotal.Text = (v1 / v2).ToString();
            }
            catch (Exception erro)
            {
                lblMsg.Text = "Erro = " + "\n"+ erro;
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
           
            txtVal1.Text = "";
            txtVal2.Text = "";
            lblMsg.Text = "";
            lblTotal.Text = "";
        }

        protected void btnPi_Click(object sender, EventArgs e)
        {
            txtVal1.Text = (Math.PI).ToString();
        }

        protected void btnSeno_Click(object sender, EventArgs e)
        {
            try
            {
                Double v1 = Double.Parse(txtVal1.Text);
                Double nome = (v1 * Math.PI) / 100;
                Double seno = Math.Sin(nome);
                lblTotal.Text = seno.ToString();
            }
            catch (Exception erro)
            {
                lblMsg.Text = "Erro = " +"\n"+ erro;
            }

        }
    }
}