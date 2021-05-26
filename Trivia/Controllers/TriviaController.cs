using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using TriviaAppCore;

namespace Travia.Controllers
{
    [Route("api/Trivia")]
    public class TriviaController : BaseController
    {
        private ITriviaAppService _triviaAppService;
        private readonly ILogger<TriviaController> _logger;
        public TriviaController(ITriviaAppService triviaAppService, ILogger<TriviaController> logger)
        {
            _triviaAppService = triviaAppService;
            _logger = logger;
            _logger.LogInformation($"{nameof(TriviaController)} Loaded");
        }

        [HttpGet]
        public IActionResult GetTriviaQuestions()
        {
            try
            {
                var result = _triviaAppService.GetTriviaQuestions();
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Trivia || {nameof(TriviaController)} || {nameof(GetTriviaQuestions)} || {ex.Message}");
                throw new Exception(ex.Message);
            }
        }
    }
}
