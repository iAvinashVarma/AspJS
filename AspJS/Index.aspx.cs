using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
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
			if (e.Row.RowType == DataControlRowType.DataRow)
			{
				LinkButton deleteButton = e.Row.FindControl("EmployeeDeleteButton") as LinkButton;
				object id = DataBinder.Eval(e.Row.DataItem, "Id");
				string onClickValue = string.Format("return confirm('Are you sure to delete record with id: \"{0}\".?')", id);
				deleteButton.Attributes.Add("onclick", onClickValue);
			}
		}

		protected void LnkDeleteSelected_Click(object sender, EventArgs e)
		{
			StringBuilder idBuilder = new StringBuilder();
			foreach (GridViewRow gridViewRow in EmployeeGridView.Rows)
			{
				if (gridViewRow.FindControl("CbSelect") is CheckBox checkBox && checkBox.Checked)
				{
					if (gridViewRow.FindControl("Label1") is Label label)
					{
						idBuilder.AppendFormat("{0},", label.Text);
					}
				}
			}
			string idBuilderValue = string.Format("{0}", idBuilder);
			if (!string.IsNullOrEmpty(idBuilderValue))
			{
				int commaLastIndex = idBuilderValue.LastIndexOf(",");
				if (commaLastIndex != -1)
				{
					idBuilder.Remove(commaLastIndex, 1);
				}
				var filteredIdBuilder = string.Format("{0}", idBuilder);
				Delete(filteredIdBuilder);
				EmployeeGridView.DataBind();
			}
		}

		private void Delete(string Ids)
		{
			string connectionString = ConfigurationManager.ConnectionStrings["AspJSDBConnectionString"].ConnectionString;
			using (SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				sqlConnection.Open();
				using (SqlCommand sqlCommand = new SqlCommand("uspDeleteEmployees", sqlConnection)
				{
					CommandType = CommandType.StoredProcedure,
				})
				{
					SqlParameter sqlParameter = new SqlParameter("@Ids", Ids);
					sqlCommand.Parameters.Add(sqlParameter);
					sqlCommand.ExecuteNonQuery();
				}
			}
		}
	}
}