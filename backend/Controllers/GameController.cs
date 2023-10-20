using Microsoft.AspNetCore.Mvc;
using backend.Logic;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly GameLogic _gameLogic = new GameLogic();

        [HttpPost]
        public ActionResult<GameResult> Post([FromBody] GameRequest gameRequest)
        {
            if (gameRequest == null || !ModelState.IsValid)
            {
                return BadRequest("Invalid request payload");
            }

            try
            {
                var result = _gameLogic.Play(gameRequest.PlayerMove);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
