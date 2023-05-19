using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjJokempoô
{
    public partial class MaquinaVsMaquina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int image = rnd.Next(1, 4);
            int image2 = rnd.Next(1, 4);


            if (image == 1)
            {
                Image1.ImageUrl = "~/images/papel.png";
            }
            else if (image == 2)
            {
                Image1.ImageUrl = "~/images/pedra.png";
            }
            else if (image == 3)
            {
                Image1.ImageUrl = "~/images/tesoura.png";
            }


            //------------------------------------------------------------------------------

            if (image2 == 1)
            {
                Image2.ImageUrl = "~/images/papel.png";
            }
            else if (image2 == 2)
            {
                Image2.ImageUrl = "~/images/pedra.png";
            }
            else if (image2 == 3)
            {
                Image2.ImageUrl = "~/images/tesoura.png";
            }

            Double PLC1 = Convert.ToDouble(placar1.Text);
            Double PLC2 = Convert.ToDouble(placar2.Text);


            if (image == 1 && image2 == 2)
            {

                placar1.Text = (PLC1 + 1).ToString();
            }

            if (image == 2 && image2 == 3)
            {
                placar1.Text = (PLC1 + 1).ToString();
            }

            if (image == 3 && image2 == 1)
            {
                placar1.Text = (PLC1 + 1).ToString();
            }


            if (image2 == 1 && image == 2)
            {
                placar2.Text = (PLC2 + 1).ToString();
            }

            if (image2 == 2 && image == 3)
            {
                placar2.Text = (PLC2 + 1).ToString();
            }

            if (image2 == 3 && image == 1)
            {
                placar2.Text = (PLC2 + 1).ToString();
            }



        }
    }
}