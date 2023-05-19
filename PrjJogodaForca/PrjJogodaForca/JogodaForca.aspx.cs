using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjJogodaForca
{

    public partial class JogodaForca : System.Web.UI.Page
    {

        static String x = "LUA";
        int erros = 0;

        


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnJogar_Click(object sender, EventArgs e)
        {
            String texto = txtForca.Text.ToUpper();
            erros = 0;

            try
            {

                if (texto == "")
                {
                    texto = "Insira 3 Letras!!";
                }
                else
                {
                    char a = x.ElementAt(0);
                    char b = x.ElementAt(1);
                    char c = x.ElementAt(2);

                    char h = texto.ElementAt(0);
                    char i = texto.ElementAt(1);
                    char j = texto.ElementAt(2);
                    if (a != h)
                    {
                        lbl1.Text = "?";
                        erros += 1;
                    }
                    else
                    {
                        Image1.ImageUrl = "~/imagens/dado6.png";
                        lbl1.Text = "" + h;
                    }

                    if (b != i)
                    {
                        erros += 1;
                        lbl2.Text = "?";
                    }
                    else
                    {
                        Image2.ImageUrl = "~/imagens/dado6.png";
                        lbl2.Text = "" + i;

                    }

                    if (c != j)
                    {
                        erros += 1;
                        lbl3.Text = "?";

                    }
                    else
                    {
                        Image3.ImageUrl = "~/imagens/dado6.png";
                        lbl3.Text = "" + j;
                    }

                    if(erros == 1)
                    {
                        Image1.ImageUrl = "~/imagens/img1.png";


                    }
                    else if (erros == 2)
                    {
                        Image1.ImageUrl = "~/imagens/img1.png";

                        Image2.ImageUrl = "~/imagens/img2.png";

                    }
                    else if (erros == 3)
                    {
                        Image1.ImageUrl = "~/imagens/img1.png";
                        Image2.ImageUrl = "~/imagens/img2.png";
                        Image3.ImageUrl = "~/imagens/img3.png";

                    }
                }
            }
            catch
            {
               txtForca.Text = "Insira EXATAMENTE 3 Letras!!";
            }
            }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            erros = 0;
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";

            Image1.ImageUrl = "";
            Image2.ImageUrl = "";
            Image3.ImageUrl = "";

            txtForca.Text = "";
        }
    }
    }
