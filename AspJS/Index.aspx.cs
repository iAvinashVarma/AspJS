using System;
using System.Web.UI;

namespace AspJS
{
	public partial class Index : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			var key = "clientScript";
			var script = "<script type=\"text/javascript\">document.getElementById('LblDate').textContent = new Date();</script>";
			ClientScript.RegisterStartupScript(LblDate.GetType(), key, script);	
		}
	}
}