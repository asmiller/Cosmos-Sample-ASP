<%@ Page Language="C#" Inherits="CosmosWebForms.register" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>register</title>
</head>
<body>
    <form id="RegisterForm" runat="server">
        <label for="">First</label>
        <asp:TextBox ID="First" runat="server"></asp:TextBox>
            
        <label for="">Last</label>
        <asp:TextBox ID="Last" runat="server"></asp:TextBox> 
            
        <label for="">Email</label>
        <asp:TextBox ID="Email" runat="server"></asp:TextBox>   
    </form>
</body>
</html>
