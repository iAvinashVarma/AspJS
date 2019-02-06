using AspJS.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AspJS.Middle
{
	public class RegisterClient
	{
		public KeyValuePair<string, string> ScriptBlock(ScriptBlockType scriptBlockType, FileData fileData = null)
		{
			KeyValuePair<string, string> result = new KeyValuePair<string, string>();
			switch (scriptBlockType)
			{
				case ScriptBlockType.Common:
					result = CommonScriptBlock(scriptBlockType);
					break;
				case ScriptBlockType.FileType:
					result = FileTypeScriptBlock(scriptBlockType, fileData);
					break;
			}
			return result;
		}

		private KeyValuePair<string, string> CommonScriptBlock(ScriptBlockType scriptBlockType)
		{
			string script = string.Format("window.open('FilePopup.html', '_blank ', 'FilePopup-{0:yyyyMMddHHmmss},directories=no,titlebar=no,toolbar=no,location=no,status=no,menubar=no,scrollbars=yes,resizable=yes');", DateTime.Now);
			string key = string.Format("{0}", scriptBlockType);
			return new KeyValuePair<string, string>(key, script);
		}

		private KeyValuePair<string, string> FileTypeScriptBlock(ScriptBlockType scriptBlockType, FileData fileData)
		{
			var fileGenerator = new FileGenerator();
			fileGenerator.GenerateFiles(fileData);
			string script = string.Format("var fileData = {0};", fileData);
			string key = string.Format("{0}", scriptBlockType);
			return new KeyValuePair<string, string>(key, script);
		}
	}
}