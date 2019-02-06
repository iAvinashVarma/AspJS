using AspJS.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace AspJS.Middle
{
	public class FileGenerator
	{
		public bool GenerateFiles(List<FileDatum> fileData)
		{
			var status = false;
			var threads = new List<Thread>();
			var files = fileData.SelectMany(x => x.PhysicalPaths).ToList();
			files.Select(f =>
			{
				var thread = new Thread(() => CreateFile(f));
				thread.Start();
				return thread;
			}).ToList().ForEach(t => t.Join());
			return status;
		}

		private void CreateFile(string filePath)
		{
			var path = Path.GetFullPath(filePath);
			var directory = Path.GetDirectoryName(filePath);
			Directory.CreateDirectory(directory);
			File.WriteAllText(filePath, string.Format("{0:yyyy,MM,dd,HH,mm,ss},{1},{2}", DateTime.Now, Guid.NewGuid(), "AVI"));
		}
	}
}