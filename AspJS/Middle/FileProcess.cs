using AspJS.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace AspJS.Middle
{
	public class FileProcess
	{
		private readonly string _serverPath;

		private readonly string _serverUrl;
		private const string ReportDirectory = "Report/";

		public FileProcess(string serverPath, string serverUrl)
		{
			_serverPath = serverPath;
			_serverUrl = serverUrl;
		}

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
			string fileOne = string.Format("FileOne-{0:yyyyMMddHHmmss}.csv", dateTime);
			string fileTwo = string.Format("FileTwo-{0:yyyyMMddHHmmss}.csv", dateTime);
			List<string> physicalPaths = new List<string>
			{
				Path.Combine(_serverPath, string.Format("{0}{1}", ReportDirectory, fileOne)),
				Path.Combine(_serverPath, string.Format("{0}{1}", ReportDirectory, fileTwo))
			};
			List<string> files = new List<string>
			{
				fileOne,
				fileTwo
			};
			return new FileDatum
			{
				ReportDirectory = ReportDirectory,
				ServerUrl = _serverUrl,
				ReportDate = dateTime,
				PhysicalPaths = physicalPaths,
				Files = files
			};
		}
	}
}