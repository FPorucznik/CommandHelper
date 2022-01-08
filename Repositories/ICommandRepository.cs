using CommandHelper.Models;

namespace CommandHelper.Repositories
{
    public interface ICommandRepository
    {
        Task<IEnumerable<Command>> GetCommandsAsync();
        Task<Command?> GetCommandAsync(Guid id);
        Task CreateCommandAsync(Command command);
        Task UpdateCommandAsync(Command command);
        Task DeleteCommandAsync(Command command);
    }
}