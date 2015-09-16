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
        private static SqlConnection connection = new SqlConnection("Server=DESKTOP-VPQIR5V; Database=AtleticsWorldChampionship; Integrated Security=SSPI;");
        public static int idPersonaUseExt = 0;
        private static List<String> resultado = new List<String>();
        private static int logged  = -1;
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
            SqlParameter outputValue = new SqlParameter("@pSignInFlag", SqlDbType.Int);
            outputValue.Value = 0;
            outputValue.Direction = ParameterDirection.InputOutput;
            Command.Parameters.Add(outputValue);
            readTransaction(Command);
            Command.Parameters.Clear();
            logged = (int)outputValue.Value;
            Debug.WriteLine("El usuario de id: " + logged + ", ha iniciado seción exitosamente.");
        }
        public static void setLoggedState(int state)
        {
            logged = state;
        }
        public static int getLoggedState()
        {
            return logged;
        }
    }
}