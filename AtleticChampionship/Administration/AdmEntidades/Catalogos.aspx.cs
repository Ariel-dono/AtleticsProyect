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

namespace AtleticChampionship.Administration.AdmEntidades
{
    public partial class Catalogos : System.Web.UI.Page
    {
        private static SqlCommand Command = new SqlCommand();
        public static DataTable DataPersonas = new DataTable();
        private static int tipoOperacion = -1;
        protected void Page_Load(object sender, EventArgs e)
        {
            Operaciones.Visible = false;
        }

        protected void CargarEntidades(object sender, EventArgs e)
        {
            InformacionEntidades.Items.Clear();
            if (Entidades.SelectedValue == "0")
            {
                Command.CommandText = "spObtenerDatosEstado";
            }
            else if (Entidades.SelectedValue == "1")
            {
                Command.CommandText = "spObtenerDatosTipoCompetencia";
            }
            else
            {
                Command.CommandText = "spObtenerDatosTipoSanciones";
            }
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
                    InformacionEntidades.Items.Add(new ListItem(tupla[1].ToString(), tupla[0].ToString()));
                }
                InformacionEntidades.DataBind();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            Command.Parameters.Clear();
            InformacionEntidades.SelectedIndex = 0;
            DataPersonas.Clear();
            Operaciones.Visible = true;
            OperacionPuntual.Visible = false;
        }

        protected void Actualiza(object sender, EventArgs e)
        {
            if (InformacionEntidades.SelectedValue != "")
            {
                Operaciones.Visible = true;
                OperacionPuntual.Visible = true;
                tipoOperacion = 0;
            }
        }

        protected void Inserta(object sender, EventArgs e)
        {
            Operaciones.Visible = true;
            OperacionPuntual.Visible = true;
            tipoOperacion = 1;
        }

        protected void Commit(object sender, EventArgs e)
        {
            Operaciones.Visible = true;
            OperacionPuntual.Visible = true;
            int SelectedID = Int32.Parse(InformacionEntidades.SelectedValue);
            if (tipoOperacion == 0)
            {
                if (SelectedID == 0)
                {
                    Command.CommandText = "spUpdateEstado";
                    Command.Parameters.Add("@ID", SqlDbType.Int).Value = SelectedID;
                    Command.Parameters.Add("@pDescripcion", SqlDbType.NVarChar).Value = nuevaDescripcion.Text;
                }
                else if (SelectedID == 1)
                {
                    Command.CommandText = "spUpdateTipoCompetencia";
                    Command.Parameters.Add("@ID", SqlDbType.Int).Value = SelectedID;
                    Command.Parameters.Add("@pDescripcion", SqlDbType.NVarChar).Value = nuevaDescripcion.Text;
                }
                else
                {
                    Command.CommandText = "spUpdateTipoSanciones";
                    Command.Parameters.Add("@ID", SqlDbType.Int).Value = SelectedID;
                    Command.Parameters.Add("@pDescripcion", SqlDbType.NVarChar).Value = nuevaDescripcion.Text;
                }
            }
            else
            {
                if (Entidades.SelectedValue == "0")
                {
                    Command.CommandText = "spInsertEstado";
                    Command.Parameters.Add("@pDescripcion", SqlDbType.NVarChar).Value = nuevaDescripcion.Text;
                }
                else if (Entidades.SelectedValue == "1")
                {
                    Command.CommandText = "spInsertTipoCompetencia";
                    Command.Parameters.Add("@pDescripcion", SqlDbType.NVarChar).Value = nuevaDescripcion.Text;
                }
                else
                {
                    Command.CommandText = "spInsertTipoSanciones";
                    Command.Parameters.Add("@pDescripcion", SqlDbType.NVarChar).Value = nuevaDescripcion.Text;
                }
            }
            Command.CommandType = CommandType.StoredProcedure;
            connectionDB.writeTransaction(Command);
            nuevaDescripcion.Text = "";
            Command.Parameters.Clear();
        }
    }
}