using System.Collections.Generic;

namespace DTO
{
	public class Combo : Entity
	{
		public string Name { get; set; }
		public int Discount { get; set; } = 0;
		public double Price { get; set; } = 0;
		public double OriginPrice { get; set; } = 0;

		public int Amount { get; set; }
		public List<ComboDetails> Details { get; set; } = new List<ComboDetails>();
	}
}