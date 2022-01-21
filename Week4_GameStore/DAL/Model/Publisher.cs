using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Publisher
    {
        public int Id { get; set; }
        public string PublisherName { get; set; }
        public int PublishedGameCount { get; set; }
        public float StockMoneyValue { get; set; }
    }
}