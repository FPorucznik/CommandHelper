using AutoMapper;
using CommandHelper.Dtos;
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
        private readonly IMapper _mapper;

        public CommandsController(ICommandRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET /commands
        [HttpGet]
        public async Task<IEnumerable<GetCommandDto>> GetCommandsAsync()
        {
            var commands = (await _repository.GetCommandsAsync()).Select(command => _mapper.Map<GetCommandDto>(command));
            return commands;
        }

        //GET /commands/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<GetCommandDto>> GetCommandAsync(Guid id)
        {
            var command = await _repository.GetCommandAsync(id);
            if (command is null)
            {
                return NotFound();
            }

            return _mapper.Map<GetCommandDto>(command);
        }

        //POST /commands
        [HttpPost]
        public async Task<ActionResult<GetCommandDto>> CreateCommandAsync(CreateCommandDto commandDto)
        {
            var command = _mapper.Map<Command>(commandDto);
            await _repository.CreateCommandAsync(command);

            return CreatedAtAction(nameof(GetCommandsAsync), new { id = command.Id }, command);
        }


        //DELETE /commands/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCommandAsync(Guid id)
        {
            var command = await _repository.GetCommandAsync(id);

            if (command is null)
            {
                return NotFound();
            }

            await _repository.DeleteCommandAsync(command);
            return NoContent();
        }
    }
}