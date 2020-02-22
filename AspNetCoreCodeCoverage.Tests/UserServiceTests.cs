using AspNetCoreCodeCoverage.Business;
using NUnit.Framework;

namespace AspNetCoreCodeCoverage.Tests
{
	[TestFixture]
	public class UserServiceTests
	{
		[Test]
		public void CanDeleteCountry_UserIsNotCountryManagerTryToDeleteCountry_ReturnsFalse()
		{
			var user = new User
			{
				Roles = new[] { "User" },
				ManagedCountries = new[] { "Romania" }
			};
			var userService = new UserService(user);

			bool canDeleteCountry = userService.CanDeleteCountry("Romania");

			Assert.IsFalse(canDeleteCountry);
		}
	}
}
