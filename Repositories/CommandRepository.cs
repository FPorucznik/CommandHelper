using CommandHelper.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandHelper.Repositories
{
    public class CommandRepository : ICommandRepository
    {
        private readonly ApplicationDbContext _context;

        public CommandRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateCommandAsync(Command command)
        {
            _context.Add(command);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCommandAsync(Command command)
        {
            _context.Remove(command);
            await _context.SaveChangesAsync();
        }

        public async Task<Command?> GetCommandAsync(Guid id)
        {
            var command = await _context.Commands.SingleOrDefaultAsync(command => command.Id == id);
            return command;
        }

        public async Task<IEnumerable<Command>> GetCommandsAsync()
        {
            return await _context.Commands.ToListAsync();
        }

        public async Task UpdateCommandAsync(Command command)
        {
            _context.Update(command);
            await _context.SaveChangesAsync();
        }
    }
}