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
						<td colspan="3">
							<asp:Label ID="LblDate" runat="server"></asp:Label>
						</td>
					</tr>
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
						<td>Card Number</td>
						<td colspan="2">
							<asp:TextBox ID="TxtCardOne" runat="server" Width="50px" MaxLength="4" onkeyup="moveCursor(this, 'TxtCardTwo')"></asp:TextBox>
							<asp:TextBox ID="TxtCardTwo" runat="server" Width="50px" MaxLength="4" onkeyup="moveCursor(this, 'TxtCardThree')"></asp:TextBox>
							<asp:TextBox ID="TxtCardThree" runat="server" Width="50px" MaxLength="4" onkeyup="moveCursor(this, 'TxtCardFour')"></asp:TextBox>
							<asp:TextBox ID="TxtCardFour" runat="server" Width="50px" MaxLength="4"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td>Comments</td>
						<td colspan="2">
							<asp:TextBox ID="TxtComments" TextMode="MultiLine" placeholder="Type your comments here" runat="server"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td colspan="3">
							<asp:Button ID="BtnSubmit" runat="server" Text="Submit" UseSubmitBehavior="false" OnClientClick="this.disabled='true'; this.value='Please wait...'" OnClick="BtnSubmit_Click" />
						</td>
					</tr>
				</tbody>
			</table>
		</div>
		<script type="text/javascript">
			function countCharacters() {
				var lblCount = document.getElementById('LblCount');
				var txtName = document.getElementById('TxtName');
				lblCount.innerHTML = txtName.value.length > 0 ? txtName.value.length + " character(s)" : "";
			}

			function moveCursor(fromTextBox, toTextBox) {
				var length = fromTextBox.value.length;
				var maxLength = fromTextBox.getAttribute('maxLength');
				if (length == maxLength) {
					document.getElementById(toTextBox).focus();
				}
			}
		</script>
	</form>
</body>
</html>
