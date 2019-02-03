<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AspJS.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>JS with ASP.NET</title>
</head>
<body>
	<form id="frm" runat="server">
		<div>
			<asp:GridView ID="EmployeeGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="EmployeeDataSource" EnableModelValidation="True">
				<Columns>
					<asp:TemplateField ShowHeader="False">
						<ItemTemplate>
							<asp:LinkButton ID="DeleteButton" runat="server" OnClientClick="return getConfirmation();" CausesValidation="False" CommandName="Delete" Text="Delete"></asp:LinkButton>
						</ItemTemplate>
					</asp:TemplateField>
					<asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
					<asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
					<asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
				</Columns>
			</asp:GridView>
			<asp:SqlDataSource ID="EmployeeDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:AspJSDBConnectionString %>" DeleteCommand="DELETE FROM [Employees] WHERE [Id] = @original_Id" InsertCommand="INSERT INTO [Employees] ([Name], [Gender]) VALUES (@Name, @Gender)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [Id], [Name], [Gender] FROM [Employees]" UpdateCommand="UPDATE [Employees] SET [Name] = @Name, [Gender] = @Gender WHERE [Id] = @original_Id">
				<DeleteParameters>
					<asp:Parameter Name="original_Id" Type="Int32" />
				</DeleteParameters>
				<InsertParameters>
					<asp:Parameter Name="Name" Type="String" />
					<asp:Parameter Name="Gender" Type="String" />
				</InsertParameters>
				<UpdateParameters>
					<asp:Parameter Name="Name" Type="String" />
					<asp:Parameter Name="Gender" Type="String" />
					<asp:Parameter Name="original_Id" Type="Int32" />
				</UpdateParameters>
			</asp:SqlDataSource>
		</div>
	</form>
	<script type="text/javascript">
		function getConfirmation() {
			var isConfirm = confirm('Are you sure to delete?');
			return isConfirm;
		}
	</script>
</body>
</html>
