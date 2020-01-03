using System.Linq;

using Microsoft.AspNetCore.Mvc;
using System.Collections;
using TaskTwo.Models;
using TaskTwo.Data;

namespace TaskTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterPageController : ControllerBase
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
            var s = context.transactionPages.ToList();
            return (context.transactionPages.ToList());
        }
    }
}