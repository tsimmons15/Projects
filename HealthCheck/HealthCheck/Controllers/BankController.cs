using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCheck.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankController : ControllerBase
    {
        protected RandomStuff.Bank TheBank { get; set; }

        public BankController(RandomStuff.Bank bank)
        {
            TheBank = bank;
        }

        [HttpGet]
        public RandomStuff.Bank Get()
        {
            return TheBank;
        }
    }
}
