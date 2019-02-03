using AspJS.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace AspJS
{
	public partial class Index : Page
	{
		public string FileData
		{
			get; set;
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			string key = "clientScript";
			string script = "document.getElementById('LblDate').textContent = new Date();";
			ClientScript.RegisterStartupScript(LblDate.GetType(), key, script, true);
		}

		protected void BtnSubmit_Click(object sender, EventArgs e)
		{
			FileData = GetCurrentData();
			string commonScript = string.Format("window.open('FilePopup.html', '_blank ', 'directories=no,titlebar=no,toolbar=no,location=no,status=no,menubar=no,scrollbars=yes,resizable=yes');");
			string key = string.Format("FilePopup-{0:yyyyMMddHHmmss}", DateTime.Now);
			ClientScript.RegisterClientScriptBlock(GetType(), key, commonScript, true);
		}

		private string GetCurrentData()
		{
			List<FileData> fileDatas = new List<FileData>();
			for (int i = 0; i < 100; i++)
			{
				var dateTime = DateTime.Now;
				fileDatas.Add(GetFileData(dateTime.AddDays(i)));
			}
			string json = JsonConvert.SerializeObject(fileDatas);
			return string.Format("{0}", json);
		}

		private FileData GetFileData(DateTime dateTime)
		{
			List<string> data = new List<string>
			{
				"E:\\Practice\\ASP.NET\\AspJS\\AspJS\\Content\\bootstrap.css.map",
				"E:\\Practice\\ASP.NET\\AspJS\\AspJS\\Content\\bootstrap.min.css",
				"E:\\Practice\\ASP.NET\\AspJS\\AspJS\\Content\\bootstrap.min.css.map",
				"E:\\Practice\\ASP.NET\\AspJS\\AspJS\\Content\\bootstrap-grid.css",
				"E:\\Practice\\ASP.NET\\AspJS\\AspJS\\Content\\bootstrap-grid.css.map",
				"E:\\Practice\\ASP.NET\\AspJS\\AspJS\\Content\\bootstrap-grid.min.css",
				"E:\\Practice\\ASP.NET\\AspJS\\AspJS\\Content\\bootstrap-grid.min.css.map",
				"E:\\Practice\\ASP.NET\\AspJS\\AspJS\\Content\\bootstrap-reboot.css",
				"E:\\Practice\\ASP.NET\\AspJS\\AspJS\\Content\\bootstrap-reboot.css.map",
				"E:\\Practice\\ASP.NET\\AspJS\\AspJS\\Content\\bootstrap-reboot.min.css",
				"E:\\Practice\\ASP.NET\\AspJS\\AspJS\\Content\\bootstrap-reboot.min.css.map",
				"E:\\Practice\\ASP.NET\\AspJS\\AspJS\\Content\\bootstrap.css"
			};
			return new FileData
			{
				Date = dateTime,
				Paths = data
			};
		}
	}
}