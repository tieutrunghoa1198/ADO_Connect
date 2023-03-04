using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Connect.DAO
{
    internal class DBContext
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(AppSetting.GetConnectionStrings()["PRN221_ASS01"]);
        }

        public static DataTable GetDataBySql(string sql)
        {
            // tao 1 doi tuong command 2 ts haoc 1 ts truyen thuoc tinh 
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(sql, GetConnection());
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            // fill du lieu vao data table
            adapter.Fill(dt);
            return dt;
            // -> co 1 cau sql select thi thuc thi cau lenh sql nay 
        }

        public static DataTable GetDataBySql(string sql, SqlParameter[] parameters = null)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
