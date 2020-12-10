using System;
using System.Collections.Generic;

namespace DTO
{
	public class Ticket : Entity
	{
		public Staff Staff { get; set; }
		public int TotalAmount { get; set; } = 0;
		public double TotalCost { get; set; } = 0;
		public bool IsImport { get; set; } = false;
		public string Date { get; set; } = new DateTime().ToShortDateString();
		public List<TicketDetails> Details { get; set; } = new List<TicketDetails>();
	}
}