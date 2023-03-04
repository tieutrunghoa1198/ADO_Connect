using ADO_Connect.Models;
using System.Data;
using System.Data.SqlClient;
namespace ADO_Connect.DAO
{
    internal class EmployeeDAO
    {
        public static List<Employee> GetEmployees()
        {
            string sql = "select * from employee";
            DataTable dt = DBContext.GetDataBySql(sql);
            List<Employee> list = new List<Employee>();
            foreach (DataRow dataRow in dt.Rows)
            {
                list.Add(
                    new Employee()
                    {
                        Id = Convert.ToInt32(dataRow["Id"]),
                        Name = dataRow["Name"].ToString() ?? "",
                        Dob = Convert.ToDateTime(dataRow["Dob"]),
                        Position = dataRow["Position"].ToString() ?? "",
                        Sex = dataRow["Sex"].ToString() ?? "",
                        Department = Convert.ToInt32(dataRow["Department"])
                    });
            }
            return list;
        }

        public static List<Employee> GetEmployeesTest()
        {
            string sql = "select e.*, d.Name as DepartmentName from Employee as e, Department as d where e.Department = d.Id";
            DataTable dt = DBContext.GetDataBySql(sql);
            List<Employee> list = new List<Employee>();
            foreach (DataRow dataRow in dt.Rows)
            {
                Console.WriteLine(dataRow["DepartmentName"].ToString());
                list.Add(
                    new Employee()
                    {
                        Id = Convert.ToInt32(dataRow["Id"]),
                        Name = dataRow["Name"].ToString() ?? "",
                        Dob = Convert.ToDateTime(dataRow["Dob"]),
                        Position = dataRow["Position"].ToString() ?? "",
                        Sex = dataRow["Sex"].ToString() ?? "",
                        Department = Convert.ToInt32(dataRow["Department"]),
                        DepartmentName = dataRow["DepartmentName"].ToString() ?? ""
                    });
            }
            return list;
        }

        public static List<Employee> GetEmployees(string sql, SqlParameter[] parameters)
        {
            string sqsl = @"select * from employee";
            DataTable dt = DBContext.GetDataBySql(sql);
            List<Employee> list = new List<Employee>();
            foreach (DataRow dataRow in dt.Rows)
            {
                list.Add(
                    new Employee()
                    {
                        Id = Convert.ToInt32(dataRow["Id"]),
                        Name = dataRow["Name"].ToString() ?? "",
                        Dob = Convert.ToDateTime(dataRow["Dob"]),
                        Position = dataRow["Position"].ToString() ?? "",
                        Sex = dataRow["Sex"].ToString() ?? "",
                        Department = Convert.ToInt32(dataRow["Department"])
                    });
            }
            return list;
        }

        public static Employee GetCustomerById(int CustomerID)
        {
            string sql = "select * from Employee where Id = @cid";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@cid", DbType.Int32);
            parameters[0].Value = CustomerID;
            DataTable dt = DBContext.GetDataBySql(sql, parameters);
            if (dt.Rows.Count == 0) return null;
            DataRow dr = dt.Rows[0];
            return new Employee()
            {
                Id = Convert.ToInt32(dr["Id"]),
                Name = dr["Name"].ToString() ?? "",
                Dob = Convert.ToDateTime(dr["Dob"]),
                Position = dr["Position"].ToString() ?? "",
                Sex = dr["Sex"].ToString() ?? "",
                Department = Convert.ToInt32(dr["Department"])
            };
        }

        public static List<Employee> GetByPosition(string position)
        {
            string sql = @"select * from Employee where Position = @position";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@position", DbType.Int32);
            parameters[0].Value = position;
            DataTable dt = DBContext.GetDataBySql(sql, parameters);
            
            if (dt.Rows.Count == 0) return null;
            List<Employee> list = new List<Employee>();
            foreach (DataRow dataRow in dt.Rows)
            {
                list.Add(
                    new Employee()
                    {
                        Id = Convert.ToInt32(dataRow["Id"]),
                        Name = dataRow["Name"].ToString() ?? "",
                        Dob = Convert.ToDateTime(dataRow["Dob"]),
                        Position = dataRow["Position"].ToString() ?? "",
                        Sex = dataRow["Sex"].ToString() ?? "",
                        Department = Convert.ToInt32(dataRow["Department"])
                    });
            }
            return list;
        }

        public static List<Employee> GetBySex(string position)
        {
            string sql = @"select * from Employee where Sex = @position";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@position", DbType.Int32);
            parameters[0].Value = position;
            DataTable dt = DBContext.GetDataBySql(sql, parameters);

            if (dt.Rows.Count == 0) return null;
            List<Employee> list = new List<Employee>();
            foreach (DataRow dataRow in dt.Rows)
            {
                list.Add(
                    new Employee()
                    {
                        Id = Convert.ToInt32(dataRow["Id"]),
                        Name = dataRow["Name"].ToString() ?? "",
                        Dob = Convert.ToDateTime(dataRow["Dob"]),
                        Position = dataRow["Position"].ToString() ?? "",
                        Sex = dataRow["Sex"].ToString() ?? "",
                        Department = Convert.ToInt32(dataRow["Department"])
                    });
            }
            return list;
        }

        public static List<Employee> GetByName(string position)
        {
            string sql = "select * from Employee where Name like @position";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@position", DbType.Int32);
            parameters[0].Value = "%" + position + "%";
            DataTable dt = DBContext.GetDataBySql(sql, parameters);

            if (dt.Rows.Count == 0) return null;
            List<Employee> list = new List<Employee>();
            foreach (DataRow dataRow in dt.Rows)
            {
                list.Add(
                    new Employee()
                    {
                        Id = Convert.ToInt32(dataRow["Id"]),
                        Name = dataRow["Name"].ToString() ?? "",
                        Dob = Convert.ToDateTime(dataRow["Dob"]),
                        Position = dataRow["Position"].ToString() ?? "",
                        Sex = dataRow["Sex"].ToString() ?? "",
                        Department = Convert.ToInt32(dataRow["Department"])
                    });
            }
            return list;
        }
    }
}
