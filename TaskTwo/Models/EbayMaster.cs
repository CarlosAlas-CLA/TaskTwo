using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTwo.Models
{
    public class EbayMaster
    {
        [Key]
        public int MasterPageID { get; set; }
        public int LastDayQtySold { get; set; }
        public int LastDayProfit { get; set; }
        public int TotalProducts { get; set; }
        //public virtual ICollection<EbayTransactions> TransactionPages { get; set; }
    }
}
