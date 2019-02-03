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
			DdlGender.Attributes.Add("class", "form-control");
		}
	}
}