<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AspJS.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>JS with ASP.NET</title>
	<link rel="stylesheet" href="Content/bootstrap.min.css" />
	<script src="Scripts/jquery-3.0.0.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
	<form id="frm" runat="server">
		<div>
		</div>
		<div class="container">
			<h2>JS with ASP.NET</h2>
			<table class="table">
				<tbody>
					<tr>
						<td>Name</td>
						<td>
							<asp:TextBox ID="TxtName" runat="server" onkeyup="countCharacters();"></asp:TextBox>
						</td>
						<td>
							<asp:Label ID="LblCount" runat="server"></asp:Label>
						</td>
					</tr>
					<tr>
						<td>Gender</td>
						<td colspan="2">
							<asp:DropDownList ID="DdlGender" runat="server">
								<asp:ListItem Text="Male" Value="Male"></asp:ListItem>
								<asp:ListItem Text="Female" Value="Female"></asp:ListItem>
							</asp:DropDownList>
						</td>
					</tr>
					<tr>
						<td>Comments</td>
						<td colspan="2">
							<asp:TextBox ID="TxtComments" TextMode="MultiLine" placeholder="Type your comments here" runat="server"></asp:TextBox>
						</td>
					</tr>
				</tbody>
			</table>
		</div>
		<script type="text/javascript">
			document.getElementById('TxtName').focus();

			function countCharacters() {
				var lblCount = document.getElementById('LblCount');
				var txtName = document.getElementById('TxtName');
				lblCount.innerHTML = txtName.value.length > 0 ? txtName.value.length + " character(s)" : "";
			}
		</script>
	</form>
</body>
</html>
