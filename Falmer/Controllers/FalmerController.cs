using Falmer.Model.KRA;
using Microsoft.AspNetCore.Mvc;

namespace Falmer.Controllers
{
    [ApiController]
    [Route("falmer")]
    public class FalmerController : ControllerBase
    {
        [HttpPost("kra", Name = "UpdateKRAData")]
        public IEnumerable<GameResult> UpdateKRAData()
        {
            var result = new List<GameResult>();
            result.Add(new GameResult() { });

            return result;
        }
    }
}
