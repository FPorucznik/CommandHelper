using AutoMapper;
using CommandHelper.Dtos;
using CommandHelper.Models;
using CommandHelper.Repositories;
using Microsoft.AspNetCore.JsonPatch;
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

        //PUT /commands/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCommandAsync(Guid id, UpdateCommandDto commandDto)
        {
            var commandToUpdate = await _repository.GetCommandAsync(id);

            if (commandToUpdate is null)
            {
                return NotFound();
            }

            _mapper.Map(commandDto, commandToUpdate);
            await _repository.UpdateCommandAsync(commandToUpdate);

            return NoContent();
        }

        //PATCH /commands/{id}
        [HttpPatch("{id}")]
        public async Task<ActionResult> PartialUpdateCommandAsync(Guid id, JsonPatchDocument<UpdateCommandDto> patchDoc)
        {
            var commandToUpdate = await _repository.GetCommandAsync(id);

            if (commandToUpdate is null)
            {
                return NotFound();
            }

            var commandToPatch = _mapper.Map<UpdateCommandDto>(commandToUpdate);

            patchDoc.ApplyTo(commandToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _mapper.Map(commandToPatch, commandToUpdate);

            await _repository.UpdateCommandAsync(commandToUpdate);

            return NoContent();
        }
    }
}