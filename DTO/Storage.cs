using System;

namespace DTO
{
	public class Storage : Entity
	{
		public Product Product { get; set; }
		public int Import { get; set; } = 0;
		public int Export { get; set; } = 0;
		public string Date { get; set; } = new DateTime().ToShortDateString();
	}
}