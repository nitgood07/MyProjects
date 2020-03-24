using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {
       
        public Employee GetEmployee(int Id)
        {
            Employee employee = new Employee();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            //Create new sql connection and then invoke sp to get employee record
            using(SqlConnection con = new SqlConnection(cs))
            {
                //invoke sp
                SqlCommand cmd = new SqlCommand("spGetEmployee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter IdParameter = new SqlParameter("@Id",Id);
                cmd.Parameters.Add(IdParameter);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    employee.Id = Convert.ToInt32(dr["Id"]);
                    employee.Name = dr["Name"].ToString();
                    employee.Gender = dr["Gender"].ToString();
                    employee.DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
                }
                return employee;

            }
        }

        public void SaveEmployee(Employee employee)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            //Create new sql connection and then invoke sp to get employee record
            using (SqlConnection con = new SqlConnection(cs))
            {
                //invoke sp
                SqlCommand cmd = new SqlCommand("spSaveEmployee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //SqlParameter IdParameter = new SqlParameter("@Id", employee.Id);
                SqlParameter NameParameter = new SqlParameter("@Name", employee.Name);
                SqlParameter GenderParameter = new SqlParameter("@Gender", employee.Gender);
                SqlParameter DOBParameter = new SqlParameter("@DateOfBirth", employee.DateOfBirth);

                cmd.Parameters.Add(NameParameter);
                cmd.Parameters.Add(GenderParameter);
                cmd.Parameters.Add(DOBParameter);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
