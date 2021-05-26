using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using TriviaData.Models;

namespace TriviaAppCore
{
    public class TriviaAppService : ITriviaAppService
    {
        private IHostingEnvironment _hostingEnvironment;
        public TriviaAppService(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public List<Questions> GetTriviaQuestions()
        {
            string triviaQuestionsFilePath = Path.Combine(_hostingEnvironment.WebRootPath, Constants.TriviaService.QUESTIONS_JSON_FILE_PATH);
            string jsonString = JObject.Parse(File.ReadAllText(triviaQuestionsFilePath))["results"].ToString();
            List<Questions> triviaQuestions = JsonSerializer.Deserialize<List<Questions>>(jsonString);
            return triviaQuestions;
        }
    }
}
