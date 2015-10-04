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

namespace AtleticChampionship.Administration
{
    public partial class Administracion : System.Web.UI.Page
    {
        public static DataTable DataPersonas = new DataTable();
        private static SqlCommand Command = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataPersonas.Clear();
            Command.CommandText = "getInfoPersonas";
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.Add("@pIdPersona", SqlDbType.Int).Value = connectionDB.getLoggedState();
            connectionDB.readTransaction(Command);
            SqlDataAdapter convertSQLToTable = new SqlDataAdapter(Command);
            try
            {
                convertSQLToTable.Fill(DataPersonas);
                Object[] tupla = DataPersonas.Rows[0].ItemArray;
                DatoNombre.Text = "Nombre: " + tupla[0].ToString() + " " + tupla[1].ToString();
                DatoUsername.Text = "Nombre de usuario: " + tupla[3].ToString();
                DatoCodigoIAAF.Text = "Codigo de Delegado de la IAAF: " + tupla[2].ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            Command.Parameters.Clear();
        }
    }
}