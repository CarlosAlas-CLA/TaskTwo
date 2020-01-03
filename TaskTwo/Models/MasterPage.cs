using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TaskTwo.Models
{
    public class MasterPage
    {
        [Key]
        public int MasterPageID { get; set; }
        public int LastDayQtySold { get; set; }
        public int LastDayProfit { get; set; }
        public int TotalProducts { get; set; }
        public virtual ICollection<TransactionPage> TransactionPages { get; set; }
    }
}
