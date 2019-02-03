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

		protected void BtnSubmit_Click(object sender, EventArgs e)
		{
			var firstName = GetFirstName();
			var chromeScript = string.Format("var popup = window.open('Popup.html', '_blank ', 'directories=no,titlebar=no,toolbar=no,location=no,status=no,menubar=no,scrollbars=yes,resizable=yes'); popup.firstName = '{0}';", GetFirstName());
			//var internetExplorerScript = "window.showModalDialog('Popup.html', '', 'dialogHeight:100px;dialogWidth:280px;status:no');";
			ClientScript.RegisterClientScriptBlock(this.GetType(), "PopUp", chromeScript, true);
		}

		private string GetFirstName()
		{
			return "Avinash";
		}
	}
}