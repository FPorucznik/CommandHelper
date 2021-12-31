using CommandHelper.Models;

namespace CommandHelper.Repositories
{
    public interface ICommandRepository
    {
        Task<IEnumerable<Command>> GetCommandsAsync();
        Task<Command> GetCommandAsync();
        Task CreateCommandAsync();
        Task UpdateCommandAsync();
        Task DeleteCommandAsync();
    }
}