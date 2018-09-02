<%@ Page Language="C#" Inherits="CosmosWebForms.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Cosmos Sample</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">

</head>
<body>
    <div class="container">
        <h2>Online Resources Login</h2>
        <button type="button" style="margin:24px 0;" onclick="COSMOS.login()" class="btn btn-primary">SSO Login</button>
        <h5>Don't have an account?</h5>
        <a href="/register.aspx">Register</a>
    </div>
        
    <script type="text/javascript" src="/cosmos.js"></script>
</body>
</html>
