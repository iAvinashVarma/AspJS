<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AspJS.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frm" runat="server">
        <div>
			<asp:ImageButton ID="btnImage" runat="server" ImageUrl="~/Images/blueButton.png" onmouseover="this.src='/Images/greenButton.png'" onmouseout="'/Images/blueButton.png'" />
        </div>
    </form>
</body>
</html>
