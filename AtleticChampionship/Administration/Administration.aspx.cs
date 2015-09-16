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
using AtleticChampionship;

namespace AtleticChampionship
{
    public partial class Administration : Page
    {
        public static Label Cedula = null;
        public static Label Nombre = null;
        public static Label Apellido = null;
        public static Label UserName = null;
        public static Label Correo = null;
        public static Image Foto = null;
        public static Button acceptRequest = null;
        public static Button cancelRequest = null;
        public static int idUserRequest = 0;
        public static int idTipoRequest = 0;
        public static SqlCommand Command = new SqlCommand();
        public static DataTable DataPersonas = new DataTable();
        public static bool editState = true;
        protected void Page_Load(object sender, EventArgs e)
        {
            Command.CommandText = "getInfoPersonas";
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.Add("@pIdPersona", SqlDbType.NVarChar).Value = connectionDB.getLoggedState();
            connectionDB.readTransaction(Command);
            SqlDataAdapter convertSQLToTable = new SqlDataAdapter(Command);
            try
            {
                convertSQLToTable.Fill(DataPersonas);
                DataRow row = DataPersonas.Rows[0];
                Object[] tupla = row.ItemArray;
                String Nombre = "" + tupla[0];
                NombreUsuario.Text = Nombre;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            Command.Parameters.Clear();
            DataPersonas.Clear();
        }
    }
}