using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskTwo.Data;

namespace TaskTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EbayController : ControllerBase
    {
        private Context context = new Context();
        [HttpGet("GetAll")]
        public IEnumerable GetAll()
        {
            return (context.ebayMasters.ToList());
        }
        [HttpGet("GetAllTrans")]
        public IEnumerable GetAllTrans()
        {

            return (context.ebayTransactions.ToList());
        }
    }
}