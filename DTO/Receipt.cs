using System;
using System.Collections.Generic;

namespace DTO
{
	public class Receipt : Entity
	{
		public Person Customer { get; set; }
		public string Recipient { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public int Status { get; set; } = 0;
		public string Date { get; set; } = new DateTime().ToShortDateString();
		public double TotalCost { get; set; } = 0;
		public List<ReceiptDetails> Details { get; set; } = new List<ReceiptDetails>();
		public List<ReceiptCombos> Combos { get; set; } = new List<ReceiptCombos>();
	}
}