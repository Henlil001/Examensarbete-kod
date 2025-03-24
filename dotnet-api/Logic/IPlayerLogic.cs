using dotnet_api.DTO;
using dotnet_api.Models;

namespace dotnet_api.Logic
{
    public interface IPlayerLogic
    {
        Task<List<HockeyPlayer>> GetAllPlayersAsync();
        Task<List<HockeyPlayer>> SearchPlayerAsync(string searchVal);
        Task AddPlayerAsync(AddPlayerDTO player);
        Task<bool> UpdatePlayerAsync(UpdatePlayerDTO player);
        Task<bool> DeletePlayerAsync(int Id);
    }
}
