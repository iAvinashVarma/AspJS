using System;
using System.Web.UI;
using System.Web.UI.WebControls;

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
				var id = DataBinder.Eval(e.Row.DataItem, "Id");
				var onClickValue = string.Format("return confirm('Are you sure to delete record with id: \"{0}\".?')", id);
				deleteButton.Attributes.Add("onclick", onClickValue);
			}
		}
	}
}