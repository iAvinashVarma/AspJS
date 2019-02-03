using System;
using System.Web.UI;

namespace AspJS
{
	public partial class Index : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			var key = "clientScript";
			var script = "document.getElementById('LblDate').textContent = new Date();";
			ClientScript.RegisterStartupScript(LblDate.GetType(), key, script, true);	
		}
	}
}