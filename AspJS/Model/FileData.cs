using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AspJS.Model
{
	public class FileData
	{
		[JsonProperty("date")]
		public DateTime Date { get; set; }

		[JsonProperty("paths")]
		public List<string> Paths { get; set; }
	}
}