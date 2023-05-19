using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjJokempoô
{
    public partial class Página_Inicial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPVE_Click(object sender, EventArgs e)
        {
            Response.Redirect("PlayerVsMaquina.aspx", true);
        }

        protected void btnEvE_Click(object sender, EventArgs e)
        {
            Response.Redirect("MaquinaVsMaquina.aspx", true);

        }
    }
}