using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjJokempoô
{
    public partial class PlayerVsMaquina : System.Web.UI.Page
    {

        int image = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPedra_Click(object sender, EventArgs e)
        {
            image = 1;
            Image1.ImageUrl = "~/images/pedra.png";

        }

        protected void btnPapel_Click(object sender, EventArgs e)
        {
            image = 2;
            Image1.ImageUrl = "~/images/papel.png";

        }

        protected void btnTesoura_Click(object sender, EventArgs e)
        {
            image = 3;
            Image1.ImageUrl = "~/images/tesoura.png";

        }

        protected void btnSorteio_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int image2 = rnd.Next(1, 4);



            //------------------------------------------------------------------------------


            Double PLC1 = Convert.ToDouble(placar1.Text);
            Double PLC2 = Convert.ToDouble(placar2.Text);

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

            if (image == 1 && image == 2)
            {
                placar2.Text = (PLC1 + 1).ToString();
            }

            else if (image == 2 && image == 3)
            {
                placar2.Text = (PLC1 + 1).ToString();
            }

            else if (image == 3 && image == 1)
            {
                placar2.Text = (PLC1 + 1).ToString();
            }

            if (image2 == 1 && image == 2)
            {
                placar2.Text = (PLC2 + 1).ToString();
            }

            else if (image2 == 2 && image == 3)
            {
                placar2.Text = (PLC2 + 1).ToString();
            }

            else if (image2 == 3 && image == 1)
            {
                placar2.Text = (PLC2 + 1).ToString();
            }



        }


    }
}