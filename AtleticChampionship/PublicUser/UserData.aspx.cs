using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Data;
using System.Diagnostics;

namespace AtleticChampionship.PublicUser
{
    public partial class UserData : System.Web.UI.Page
    {
        private static SqlCommand Command = new SqlCommand();
        public static DataTable DataPersonas = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        protected void Consultar()
        {
            DataPersonas.Clear();
            Command.CommandText = "spObtenerInformacionPersonaCampeonato";
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.Add("@pIDPersona", SqlDbType.NVarChar).Value = connectionDB.getLoggedState();
            connectionDB.readTransaction(Command);
            SqlDataAdapter convertSQLToTable = new SqlDataAdapter(Command);
            try
            {
                convertSQLToTable.Fill(DataPersonas);
                GeneralInfo.DataSource = DataPersonas;
                GeneralInfo.Visible = true;
                GeneralInfo.DataBind();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            Command.Parameters.Clear();
        }
    }
}