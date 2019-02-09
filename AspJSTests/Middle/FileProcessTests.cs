using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace AspJS.Middle.Tests
{
	[TestClass()]
	public class FileProcessTests
	{
		[TestMethod()]
		public void FileProcessDataTest()
		{
			// Act
			var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			var fileProcess = new FileProcess(baseDirectory, "http://avi.com:8080/");
			var fileData = fileProcess.FileData;

			// Assert
			Assert.IsTrue(fileData.Any());
		}
	}
}