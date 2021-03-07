using System;
using System.Globalization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase{
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"this", "is", "hard", "coded"};
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase{
        [HttpGet]
        public ActionResult<string> Get()
        {
            DateTime localDate = DateTime.Now;
            String cultureName = "en-US";
            var culture = new CultureInfo(cultureName);
            String rc = string.Concat("The time is now ", localDate.ToString(culture));
            return(rc);
        }
    }
}