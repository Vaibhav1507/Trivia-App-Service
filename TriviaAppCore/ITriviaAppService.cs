using System.Collections.Generic;
using System.Threading.Tasks;
using TriviaData.Models;

namespace TriviaAppCore
{
    public interface ITriviaAppService
    {
        List<Questions> GetTriviaQuestions();
    }
}
