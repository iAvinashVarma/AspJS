using AspJS.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace AspJS.Middle
{
	public class FileProcess
	{
		public FileData FileData
		{
			get
			{
				FileData fileData = new FileData();
				Random random = new Random();
				for (int i = 0; i < random.Next(500, 1000); i++)
				{
					DateTime dateTime = DateTime.Now;
					fileData.Add(GetFileData(dateTime.AddDays(i)));
				}
				return fileData;
			}
		}

		private FileDatum GetFileData(DateTime dateTime)
		{
			string reportDirectory = AppDomain.CurrentDomain.BaseDirectory;
			List<string> data = new List<string>
			{
				Path.Combine(reportDirectory, string.Format(@"Report\FileOne-{0:yyyyMMddHHmmss}.csv", dateTime)),
				Path.Combine(reportDirectory, string.Format(@"Report\FileTwo-{0:yyyyMMddHHmmss}.csv", dateTime))
			};
			return new FileDatum
			{
				Date = dateTime,
				Paths = data
			};
		}
	}
}