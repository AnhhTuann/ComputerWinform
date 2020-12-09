namespace DTO
{
	public class ComboDetails
	{
		public Combo Combo { private get; set; }
		public Product Product { get; set; }
		public int Amount { get; set; } = 1;
	}
}