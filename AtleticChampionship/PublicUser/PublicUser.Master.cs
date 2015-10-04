using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AtleticChampionship.PublicUser
{
    public partial class PublicUser : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (connectionDB.getLoggedTypeState() == 0)
            {
                Response.Redirect("~/Administration/Administracion.aspx");
            }
        }
        protected void Back(object sender, EventArgs e)
        {
            connectionDB.setLoggedState(-1);
            Response.Redirect("~/Account/Login.aspx");
        }
    }
}