using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DataProvider
    {
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        private static SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=QLYNHASACH;Integrated Security=True");

        private static SqlConnection OpenConnection()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.Open();
            }
            return con;
        }

        /// <summary>
        /// Phương thức ExecuteSelectQuery() giúp thực thi câu truy vấn SELECT
        /// </summary>
        /// <param name="query">Câu truy vấn, có thể kèm theo tham số (string)</param>
        /// <param name="parameters">Danh sách tham số (SqlParatemer[])</param>
        /// <returns>Bảng kết quả truy vấn (DataTable)</returns>
        public static DataTable ExecuteSelectQuery(string query, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable result = new DataTable();
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandText = query;
                cmd.Parameters.AddRange(parameters);
                adapter.SelectCommand = cmd;
                adapter.Fill(result);
                con.Close();
            }
            catch (SqlException e)
            {
                return null;
            }
            return result;
        }

        /// <summary>
        /// Phương thức ExecuteNonQuery() giúp thực thi câu truy vấn INSERT, UPDATE, DELETE
        /// </summary>
        /// <param name="query">Câu truy vấn, có thể kèm theo tham số (string)</param>
        /// <param name="parameters">Danh sách tham số (SqlParatemer[])</param>
        /// <returns>Số dòng bị ảnh hưởng bởi câu truy vấn này (int)</returns>
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand();
            int rowsAffected;
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandText = query;
                cmd.Parameters.AddRange(parameters);
                rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                return 0;
            }
            return rowsAffected;
        }
    }
}