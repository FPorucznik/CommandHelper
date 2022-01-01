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
        public Task CreateCommandAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteCommandAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Command> GetCommandAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Command>> GetCommandsAsync()
        {
            return await _context.Commands.ToListAsync();
        }

        public Task UpdateCommandAsync()
        {
            throw new NotImplementedException();
        }
    }
}