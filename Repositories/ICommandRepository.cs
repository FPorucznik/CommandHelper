using CommandHelper.Models;

namespace CommandHelper.Repositories
{
    public interface ICommandRepository
    {
        Task<IEnumerable<Command>> GetCommandsAsync();
        Task<Command?> GetCommandAsync(Guid id);
        Task CreateCommandAsync(Command command);
        Task UpdateCommandAsync();
        Task DeleteCommandAsync(Command command);
    }
}