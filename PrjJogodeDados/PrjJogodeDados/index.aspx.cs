using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjJogodeDados
{
    public partial class index : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int image = rnd.Next(1,7);
            int image2 = rnd.Next(1,7);

            

           

            if (image == 1)
            {
                Image1.ImageUrl = "~/images/dado1.jpg";
            }
            if (image == 2)
            {
                Image1.ImageUrl = "~/images/dado2.jpg";
            }
            if (image == 3)
            {
                Image1.ImageUrl = "~/images/dado3.jpg";
            }
            if (image == 4)
            {
                Image1.ImageUrl = "~/images/dado4.jpg";
            }
            if (image == 5)
            {
                Image1.ImageUrl = "~/images/dado5.jpg";
            }
            if (image == 6)
            {
                Image1.ImageUrl = "~/images/dado6.jpg";
            }

//------------------------------------------------------------------------------

            if (image2 == 1)
            {
                Image2.ImageUrl = "~/images/dado1.jpg";
            }
            if (image2 == 2)
            {
                Image2.ImageUrl = "~/images/dado2.jpg";
            }
            if (image2 == 3)
            {
                Image2.ImageUrl = "~/images/dado3.jpg";
            }
            if (image2 == 4)
            {
                Image2.ImageUrl = "~/images/dado4.jpg";
            }
            if (image2 == 5)
            {
                Image2.ImageUrl = "~/images/dado5.jpg";
            }
            if (image2 == 6)
            {
                Image2.ImageUrl = "~/images/dado6.jpg";
            }

            int empate = int.Parse(lblEmpate.Text);

            

            if (image == image2)
            {
                // noia do tchola
                

                empate = empate + 1;
                lblEmpate.Text = empate.ToString();
            }



        }
    }
}