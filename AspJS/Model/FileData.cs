using Newtonsoft.Json;
using System.Collections.Generic;

namespace AspJS.Model
{
	public class FileData : List<FileDatum>
	{
		public override string ToString()
		{
			return JsonConvert.SerializeObject(this); 
		}
	}
}