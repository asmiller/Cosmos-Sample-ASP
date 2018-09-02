<%@ Page Language="C#" Inherits="CosmosWebForms.register" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>register</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">

</head>
<body>
    <div class="container">
    <h3>Register</h3>
    <form id="RegisterForm" runat="server" style="max-width:500px; margin-top:24px">
        <div class="form-group">
            <label for="">First</label>
            <asp:TextBox CssClass="form-control" ID="First" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">     
            <label for="">Last</label>
            <asp:TextBox CssClass="form-control" ID="Last" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="">Email</label>
            <asp:TextBox CssClass="form-control" ID="Email" runat="server"></asp:TextBox>   
        </div>
        <button type="submit" class="btn btn-primary">Submit</button>

    </form>
    </div>
</body>
</html>
