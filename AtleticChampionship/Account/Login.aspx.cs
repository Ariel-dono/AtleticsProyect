using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using AtleticChampionship.Models;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Data;
using System.Diagnostics;

namespace AtleticChampionship.Account
{
    public partial class Login : Page
    {
        private static SqlCommand Command = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (connectionDB.getLoggedState() != -1)
            {
                Response.Redirect("~/Administration/Administration.aspx");
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            Command.CommandText = "inicioSesion";
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.Add("@pNombreUsuario", SqlDbType.NVarChar).Value = UserName.Text;
            Command.Parameters.Add("@pContrasenna", SqlDbType.NVarChar).Value = Password.Text;
            connectionDB.signIn(Command);
            if (connectionDB.getLoggedState() != -1)
            {
                Response.Redirect("~/Administration/Administration.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('Usuario y/o Contraseña invalido(a)');", true);
            }
        }
    }
}