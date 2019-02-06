using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AspJS.Model
{
	public class FileDatum
	{
		[JsonProperty("serverUrl")]
		public string ServerUrl { get; set; }

		[JsonProperty("reportDirectory")]
		public string ReportDirectory { get; set; }

		[JsonIgnore]
		public string PhysicalPath { get; set; }

		[JsonProperty("reportDate")]
		public DateTime ReportDate { get; set; }

		[JsonIgnore]
		public List<string> PhysicalPaths { get; set; }

		[JsonProperty("files")]
		public List<string> Files { get; set; }
	}
}