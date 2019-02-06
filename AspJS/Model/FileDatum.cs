using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AspJS.Model
{
	public class FileDatum
	{
		[JsonProperty("date")]
		public DateTime Date { get; set; }

		[JsonProperty("paths")]
		public List<string> Paths { get; set; }
	}
}