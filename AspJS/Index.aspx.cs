using AspJS.Middle;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace AspJS
{
	public partial class Index : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string key = "clientScript";
			string script = "document.getElementById('LblDate').textContent = new Date();";
			ClientScript.RegisterStartupScript(LblDate.GetType(), key, script, true);
		}

		protected void BtnSubmit_Click(object sender, EventArgs e)
		{
			RegisterClient registerClient = new RegisterClient();
			List<KeyValuePair<string, string>> registerDictionary = new List<KeyValuePair<string, string>>();
			var serverUrl = string.Format("{0}://{1}{2}/", Request.Url.Scheme, Request.Url.Authority, Request.ApplicationPath.TrimEnd('/'));
			FileProcess fileProcess = new FileProcess(Server.MapPath("~"), serverUrl);
			registerDictionary.Add(registerClient.ScriptBlock(ScriptBlockType.Common));
			registerDictionary.Add(registerClient.ScriptBlock(ScriptBlockType.FileType, fileProcess.FileData));
			registerDictionary.ForEach(s =>
			{
				ClientScript.RegisterClientScriptBlock(type: GetType(), key: s.Key, script: s.Value, addScriptTags: true);
			});
		}
	}
}