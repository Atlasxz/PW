using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRJ___Aula_01
{
    public partial class pagina01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClicar_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "Alencar";
        }
    }
}