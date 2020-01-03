using System.Linq;

using Microsoft.AspNetCore.Mvc;
using System.Collections;
using TaskTwo.Models;
using TaskTwo.Data;

namespace TaskTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmazonController : ControllerBase
    {
        private Context context = new Context();
        [HttpGet("GetAll")]
        public IEnumerable GetAll()
        {
            return (context.masterPages.ToList());
        }
        [HttpGet("GetAllTrans")]
        public IEnumerable GetAllTrans()
        {

            return (context.transactionPages.ToList());
        }
        [HttpPost("Find")]
        public IEnumerable Find(object y)
        {
            var x = context.transactionPages.ToList();
            var query = from cust in x
                        where x.Contains(y)
                        select cust;



            return (query);
        }
    }
}