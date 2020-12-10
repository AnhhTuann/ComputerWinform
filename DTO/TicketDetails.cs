namespace DTO
{
	public class TicketDetails
	{
		public Ticket Ticket { private get; set; }
		public Product Product { get; set; }
		public int Amount { get; set; }
	}
}