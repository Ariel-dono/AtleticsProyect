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
    public partial class GeneralData : System.Web.UI.Page
    {
        private static SqlCommand Command = new SqlCommand();
        public static DataTable DataPersonas = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DropCampeonatos.Items.Count == 0)
            {
                CargarList();
            }
        }

        private void CargarList()
        {
            DataPersonas = new DataTable();
            Command.CommandText = "spObtenerCampeonatos";
            Command.CommandType = CommandType.StoredProcedure;
            connectionDB.readTransaction(Command);
            SqlDataAdapter convertSQLToTable = new SqlDataAdapter(Command);
            Object[] tupla = new Object[0];
            try
            {
                convertSQLToTable.Fill(DataPersonas);
                foreach (DataRow row in DataPersonas.Rows)
                {
                    tupla = row.ItemArray;
                    DropCampeonatos.Items.Add(new ListItem(tupla[1].ToString(), tupla[0].ToString()));
                }
                DropCampeonatos.DataBind();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            Command.Parameters.Clear();
            DropCampeonatos.SelectedIndex = 0;
            DataPersonas.Clear();
        }

        protected void Consultar(object sender, EventArgs e)
        {
            Command.Parameters.Clear();
            DataPersonas = new DataTable();
            Command.CommandText = "spObtenerDatosGeneralesCampeonato";
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.Add("@pIDCampeonato", SqlDbType.NVarChar).Value = DropCampeonatos.SelectedValue;
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
        }
    }
}