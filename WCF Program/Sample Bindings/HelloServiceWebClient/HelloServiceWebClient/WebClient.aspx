


<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebClient.aspx.cs" Inherits="HelloServiceWebClient.WebClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Button ID="btnGetMessage" runat="server" Text="Get Message" OnClick="Unnamed1_Click" />
            
        </div>
        <p>
            
            <asp:Label id="lblMessage" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
