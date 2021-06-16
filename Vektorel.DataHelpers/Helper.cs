using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Ibrahim.DataHelpers
{
    public class Helper
    {
        private static readonly string constr = 
            ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

        public static int ExecuteNonQuery(string sqlstr,CommandType type,SqlParameter[] parameters)
        {
            int numRows = 0;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            cmd.CommandType = type;

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);
            try
            {
                con.Open();
                numRows = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
                throw ex;
            }
            return numRows;
        }

        public static SqlDataReader ExecuteDataTable(string sqlstr, CommandType type, SqlParameter[] parameters)
        {
            SqlDataReader reader = null;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            cmd.CommandType = type;

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            try
            {
                con.Open();
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
                throw ex;
            }
            return reader;
        }

    }
}
