<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AspJS.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>JS with ASP.NET</title>
</head>
<body>
	<form id="frm" runat="server">
		<div>
			<asp:ImageButton ID="BtnImage" runat="server" ImageUrl="~/Images/blueButton.png" OnClientClick="confirmMessage();" OnClick="BtnImage_Click" />
		</div>

		<script type="text/javascript">
			function confirmMessage() {
				var isConfirm = confirm('Are you sure you want to submit the form?');
				return isConfirm;
			}
		</script>
	</form>
</body>
</html>
