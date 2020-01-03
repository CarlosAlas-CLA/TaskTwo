using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTwo.Models
{
    public class EbayTransactions
    {
        [Key]
        public int TransactionID { get; set; }
        public string ProductName { get; set; }
        public int Asin { get; set; }
        public int Price { get; set; }
        public int LastDayQtySold { get; set; }
        public int LastDayProfit { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public int? MasterPageID { get; set; }
        public virtual EbayMaster EbayMaster { get; set; }
    }
}
