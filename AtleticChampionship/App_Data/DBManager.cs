using Microsoft.SqlServer.Server;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System;
using System.Net.Mail;
using System.Collections.Generic;



namespace AtleticChampionship
{
    static class connectionDB
    {
        private static SqlConnection connection = new SqlConnection("Server=DESKTOP-VPQIR5V; Database=AtletismoDB; Integrated Security=SSPI;");
        public static int idPersonaUseExt = 0;
        private static List<String> resultado = new List<String>();
        private static int logged  = -1;
        private static int loggedType = 1;
        public static void writeTransaction(SqlCommand sqlCommand)
        {
            sqlCommand.Connection = connection;
            try
            {
                connection.Open();
                Debug.WriteLine(sqlCommand.ExecuteNonQuery()+" Filas fueron afectadas.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            sqlCommand.Parameters.Clear();
            connection.Close();
        }
        public static void readTransaction(SqlCommand Command)
        {
            Command.Connection = connection;
            try
            {
                connection.Open();
                Command.ExecuteReader();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            connection.Close();
        }
        public static void signIn(SqlCommand Command)
        {
            SqlParameter id = new SqlParameter("@pSignInFlag", SqlDbType.Int);
            id.Value = 0;
            id.Direction = ParameterDirection.InputOutput;
            Command.Parameters.Add(id);
            SqlParameter typeUser = new SqlParameter("@pTipoUsuario", SqlDbType.Int);
            typeUser.Value = 0;
            typeUser.Direction = ParameterDirection.InputOutput;
            Command.Parameters.Add(typeUser);
            readTransaction(Command);
            logged = (int)id.Value;
            loggedType = (int)typeUser.Value;
            Command.Parameters.Clear();
        }
        public static void setLoggedState(int state)
        {
            logged = state;
        }
        public static int getLoggedState()
        {
            return logged;
        }
        
        public static int getLoggedTypeState()
        {
            return loggedType;
        }

        public static void userSpecialization(SqlCommand Command, int tipo)
        {
            Command.Parameters.Add("@pTipoUsuario", SqlDbType.NVarChar).Value = tipo;
            writeTransaction(Command);
        }
    }
}