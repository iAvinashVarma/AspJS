<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AspJS.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="frm" runat="server">
		<div>
			<asp:ImageButton ID="btnImage" runat="server" ImageUrl="~/Images/blueButton.png" onmouseover="changeImageOnMouseOver();" onmouseout="changeImageOnMouseOut();" />
		</div>

		<script type="text/javascript">
			function changeImageOnMouseOver() {
				document.getElementById("btnImage").src = "/Images/greenButton.png";
			}

			function changeImageOnMouseOut() {
				document.getElementById("btnImage").src = "/Images/blueButton.png";
			}
		</script>
	</form>
</body>
</html>
