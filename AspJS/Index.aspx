<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AspJS.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>JS with ASP.NET</title>
</head>
<body>
	<form id="frm" runat="server">
		<div>
			<asp:GridView ID="EmployeeGrid" runat="server" AutoGenerateColumns="False" DataSourceID="EmployeeXmlDataSource" EnableModelValidation="True" AllowPaging="True" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
				<Columns>
					<asp:TemplateField ShowHeader="False">
						<ItemTemplate>
							<asp:LinkButton ID="BtnDelete" OnClientClick="getConfirmation(this);" runat="server" CausesValidation="false" OnClick="BtnDelete_Click" Text="Delete"></asp:LinkButton>
						</ItemTemplate>
					</asp:TemplateField>
					<asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
					<asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
					<asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
				</Columns>
				<FooterStyle BackColor="#CCCCCC" />
				<HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
				<PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
				<RowStyle BackColor="White" />
				<SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
			</asp:GridView>
			<asp:XmlDataSource ID="EmployeeXmlDataSource" runat="server" DataFile="~/Data/Employee.xml" TransformFile="~/Data/Employee.xsl"></asp:XmlDataSource>
		</div>
	</form>
	<script type="text/javascript">
		function getConfirmation(obj) {
			debugger;
			var currentObj = obj;
			var isConfirm = confirm('Are you sure to delete?');
			return isConfirm;
		}
	</script>
</body>
</html>
