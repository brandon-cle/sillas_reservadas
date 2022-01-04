using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeSaul.Model
{
    class MSeatcs
    {
        public static DataTable ShowChairA()
        {
            DataTable DtResultado = new DataTable("ShowChairsA");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Connectivity.connection;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ShowChairsA";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                SqlCon.Close();
            }
            return DtResultado;


        }

        public static void updating_chair(string grpID, string place)
        {
            
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Connectivity.connection;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "UpdateChair2";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlCmd.Parameters.Add(new SqlParameter("@grpID", SqlDbType.VarChar) { Value = grpID });
                SqlCmd.Parameters.Add(new SqlParameter("@place", SqlDbType.Int) { Value = Int32.Parse(place)});

                SqlCon.Open();
                SqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                SqlCon.Close();
            }
           
        }
    }
}
