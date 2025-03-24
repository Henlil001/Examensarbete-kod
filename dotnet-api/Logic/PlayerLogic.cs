using AutoMapper;
using dotnet_api.DataAcces;
using dotnet_api.DTO;
using dotnet_api.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_api.Logic
{
    public class PlayerLogic : IPlayerLogic
    {
        private readonly HockeyPlayerContext _context;
        private readonly IMapper _mapper;

        public PlayerLogic(HockeyPlayerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddPlayerAsync(AddPlayerDTO playerDTO)
        {
            var player = _mapper.Map<HockeyPlayer>(playerDTO);
            await _context.HockeyPlayers.AddAsync(player);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeletePlayerAsync(int Id)
        {
            var playerToRemove = await _context.HockeyPlayers.FirstOrDefaultAsync(p => p.Id == Id);
            if (playerToRemove != null)
            {
                _context.HockeyPlayers.Remove(playerToRemove);
                await _context.SaveChangesAsync();
                return true;
            }
            else return false;
        }

        public async Task<List<HockeyPlayer>> GetAllPlayersAsync()
        {
            return await _context.HockeyPlayers.OrderBy(h => h.Club).AsNoTracking().ToListAsync();
        }

        public async Task<List<HockeyPlayer>> SearchPlayerAsync(string searchVal)
        {
            return await _context.HockeyPlayers
            .Where(h => h.FullName.Contains(searchVal))
            .OrderBy(h => h.FullName)
            .AsNoTracking()
            .ToListAsync();
        }

        public async Task<bool> UpdatePlayerAsync(UpdatePlayerDTO player)
        {
            var playerToUpdate = await _context.HockeyPlayers.FirstOrDefaultAsync(h => h.Id == player.Id);
            if (playerToUpdate != null)
            {
                _context.HockeyPlayers.Entry(playerToUpdate).CurrentValues.SetValues(player);
                await _context.SaveChangesAsync();
                return true;
            }
            else return false;
        }
    }
}
