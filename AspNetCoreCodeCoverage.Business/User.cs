using System.Collections.Generic;

namespace AspNetCoreCodeCoverage.Business
{
	public class User
	{
		public IEnumerable<string> Roles { get; set; }
		public IEnumerable<string> ManagedCountries { get; set; }
	}
}
