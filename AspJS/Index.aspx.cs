using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace AspJS
{
	public partial class Index : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

		protected void EmployeeGridView_RowDataBound(object sender, GridViewRowEventArgs e)
		{
			if(e.Row.RowType == DataControlRowType.DataRow)
			{
				var deleteButton = e.Row.FindControl("EmployeeDeleteButton") as LinkButton;
				deleteButton.Attributes.Add("onclick", "return confirm('Are you sure to delete?')");
			}
		}
	}
}