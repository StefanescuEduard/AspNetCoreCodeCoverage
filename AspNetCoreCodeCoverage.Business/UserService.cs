using System.Linq;

namespace AspNetCoreCodeCoverage.Business
{
	public class UserService
	{
		private readonly User user;

		public UserService(User user)
		{
			this.user = user;
		}

		public bool CanDeleteCountry(string country)
		{
			bool isCountryManager = user.Roles.Any(u => u == "CountryManager");
			bool canManageCountry = user.ManagedCountries.Any(c => c == country);

			if (isCountryManager && canManageCountry)
			{
				return true;
			}

			return false;
		}
	}
}