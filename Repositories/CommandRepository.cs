using CommandHelper.Models;

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

        public Task<IEnumerable<Command>> GetCommandsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCommandAsync()
        {
            throw new NotImplementedException();
        }
    }
}