using System;

namespace DTO
{
	public class CustomerLoginInfo
	{
		public string Token { get; set; } = Guid.NewGuid().ToString();
		public Person Person { get; set; }
	}
}