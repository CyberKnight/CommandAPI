using System;
using System.Globalization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CommandAPI.Data;
using CommandAPI.Models;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase{
        private readonly ICommandAPIRepo _repository;

        public CommandsController(ICommandAPIRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var Commands = _repository.GetAllCommands();
            return Ok(Commands);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var Command = _repository.GetCommandById(id);
            if (Command == null)
            {
                return NotFound();
            }
            return Ok(Command);
        }
    }

    // [Route("api/[controller]")]
    // [ApiController]
    // public class HealthController : ControllerBase{
    //     [HttpGet]
    //     public ActionResult<string> Get()
    //     {
    //         DateTime localDate = DateTime.Now;
    //         String cultureName = "en-US";
    //         var culture = new CultureInfo(cultureName);
    //         String rc = string.Concat("The time is now ", localDate.ToString(culture));
    //         return(rc);
    //     }
    // }

}