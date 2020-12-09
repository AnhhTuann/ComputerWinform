using System;

namespace DTO
{
	public class Product : Entity
	{
		public string Name { get; set; }
		public int Amount { get; set; } = 0;
		public double Price { get; set; }
		public string Description { get; set; }
		public Category Category { get; set; }
		public string Image { get; set; }
	}
}
