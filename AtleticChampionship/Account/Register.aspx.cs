using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using AtleticChampionship.Models;
using Microsoft.SqlServer.Server;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;

namespace AtleticChampionship.Account
{
    public partial class Register : Page
    {
        private static SqlCommand SQLcommand = new SqlCommand();
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            SQLcommand.CommandText = "addUsuario";
            SQLcommand.CommandType = CommandType.StoredProcedure;
            SQLcommand.Parameters.Add("@pCorreo", SqlDbType.NVarChar).Value = Email.Text;
            SQLcommand.Parameters.Add("@pPassword", SqlDbType.NVarChar).Value = Password.Text;
            SQLcommand.Parameters.Add("@pUsername", SqlDbType.NVarChar).Value = Username.Text;
            SQLcommand.Parameters.Add("@pApellido", SqlDbType.NVarChar).Value = Apellido.Text;
            SQLcommand.Parameters.Add("@pNombre", SqlDbType.NVarChar).Value = Nombre.Text;
            SQLcommand.Parameters.Add("@pCedula", SqlDbType.Int).Value = Cedula.Text;
            SQLcommand.Parameters.Add("@pCodigo", SqlDbType.NVarChar).Value = Codigo.Text;
            SQLcommand.Parameters.Add("@pTelefono", SqlDbType.Int).Value = Telefono.Text;
            SQLcommand.Parameters.Add("@pEstado", SqlDbType.Int).Value = 0;
            SqlParameter outputValue = new SqlParameter("@pEstadoDeEjecucion", SqlDbType.Int);
            outputValue.Value = 0;
            outputValue.Direction = ParameterDirection.InputOutput;
            SQLcommand.Parameters.Add(outputValue);

            connectionDB.userSpecialization(SQLcommand, 0);
            Cedula.Text = "";
            Nombre.Text = "";
            Apellido.Text = "";
            Email.Text = "";
            Username.Text = "";
            if (((int)outputValue.Value) == 1)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('El Registro fue completado exitosamente.');", true);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('Error al crear el nuevo usuario, verifique que todos los datos sean validos.');", true);
            }
        }
    }
}