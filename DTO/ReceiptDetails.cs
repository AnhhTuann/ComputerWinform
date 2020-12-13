namespace DTO
{
	public class ReceiptDetails
	{
		public Receipt Receipt { private get; set; }
		public Product Product { get; set; }
		public int Amount { get; set; }
	}
}