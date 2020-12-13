using System.Collections.Generic;

namespace DTO
{
	public class Ticket : Entity
	{
		public string Date { get; set; }
		public Staff Staff { get; set; }
		public int TotalAmount { get; set; } = 0;
		public double TotalCost { get; set; } = 0;
		public List<TicketDetails> Details { get; set; } = new List<TicketDetails>();
	}
}