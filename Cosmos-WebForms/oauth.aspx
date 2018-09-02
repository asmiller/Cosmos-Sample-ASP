<%@ Page Language="C#" Inherits="CosmosWebForms.oauth" %>

<!DOCTYPE html>
<html>
<head runat="server">
	<title>oauth</title>
    
</head>
<body>
	<h5>This window will close automatically...</h5>
        
    <script type="text/javascript">
        window.opener.postMessage('<%= LoginMessage %>', '*')    
    </script>
</body>
</html>
