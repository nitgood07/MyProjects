<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="EmployeeDataClient.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
       <table border="1">
           <tr>
               <td>ID</td>
               <td>
                   <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
           </tr>
           <tr>
               <td>Name</td>
               <td>
                   <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
           </tr>
           <tr>
               <td>Gender</td>
               <td>
                  <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
                </td>
           </tr>
           <tr>
               <td>Date Of Birth</td>
               <td>
                   <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
                </td>
           </tr>
           <tr>
               <td>
                   <asp:Button ID="btnGetEmployee" runat="server" Text="Get Employee" OnClick="btnGetEmployee_Click" />
               </td>
               <td>
                  <asp:Button ID="btnSaveEmployee" runat="server" Text="Save Employee" OnClick="btnSaveEmployee_Click" />
                </td>
           </tr>
            <tr>
               <td colspan="2">
                   <asp:Label ID="lblMessage" runat="server" Text="Placeholder"></asp:Label>
               </td>
           </tr>
       </table>
    </form>
</body>
</html>
