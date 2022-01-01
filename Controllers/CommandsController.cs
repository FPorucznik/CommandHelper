using CommandHelper.Models;
using CommandHelper.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CommandHelper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandRepository _repository;

        public CommandsController(ICommandRepository repository)
        {
            _repository = repository;
        }

        //GET /commands
        [HttpGet]
        public async Task<IEnumerable<Command>> GetCommandsAsync()
        {
            var commands = await _repository.GetCommandsAsync();
            return commands;
        }

    }
}