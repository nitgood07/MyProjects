using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeDataClient
{
    public partial class Employee : System.Web.UI.Page
    {
       
        protected void btnGetEmployee_Click(object sender, EventArgs e)
        {
            using (EmployeeServiceProxy.EmployeeServiceClient client = new EmployeeServiceProxy.EmployeeServiceClient())
            {
                EmployeeServiceProxy.Employee emp =  client.GetEmployee(Convert.ToInt32(txtId.Text));
                txtName.Text = emp.Name;
                txtGender.Text = emp.Gender;
                txtDOB.Text = emp.DateOfBirth.ToShortDateString();
                lblMessage.Text = "Employee Retrieved.";
            }

        }

        protected void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            using (EmployeeServiceProxy.EmployeeServiceClient client = new EmployeeServiceProxy.EmployeeServiceClient())
            {
                EmployeeServiceProxy.Employee emp = new EmployeeServiceProxy.Employee();
                emp.Name = txtName.Text;
                emp.Gender = txtGender.Text;
                emp.DateOfBirth = Convert.ToDateTime(txtDOB.Text);
                client.SaveEmployee(emp);
                lblMessage.Text = "New Employee added successfully.";
            }
        }
    }
}