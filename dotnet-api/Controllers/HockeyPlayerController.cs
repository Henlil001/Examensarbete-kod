using dotnet_api.DTO;
using dotnet_api.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace dotnet_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HockeyPlayerController : ControllerBase
    {
        private readonly IPlayerLogic _logic;

        public HockeyPlayerController(IPlayerLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPlayers()
        {

            return Ok(await _logic.GetAllPlayersAsync());
        }
        [HttpGet("{searchVal}")]
        public async Task<IActionResult> SearchPlayerByName(string searchVal)
        {
            return Ok(await _logic.SearchPlayerAsync(searchVal));
        }
        [HttpPost]
        public async Task<IActionResult> AddPlayer([FromBody] AddPlayerDTO player)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _logic.AddPlayerAsync(player);
            return Ok("player added");

        }
        [HttpPut]
        public async Task<IActionResult> UpdatePlayer([FromBody] UpdatePlayerDTO player)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            bool check = await _logic.UpdatePlayerAsync(player);

            if (check)
                return Ok("Player Updated");
            else
                return BadRequest("Player dose not exist");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            bool check = await _logic.DeletePlayerAsync(id);

            if (check)
                return Ok($"Player with Id: {id} deleted");
            else
                return BadRequest($"Player with Id: {id} dose not exist");
        }
    }
}
