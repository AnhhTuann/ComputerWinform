using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Storage
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Import { get; set; } = 0;
        public int Export { get; set; } = 0;
        public DateTime Date { get; set; }
    }
}
