﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AtleticChampionship.Administration
{
    public partial class AdministracionEntidades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void admCatalogos(object sender, EventArgs e)
        {
            Response.Redirect("~/Administration/AdmEntidades/Catalogos.aspx");
        }
    }
}