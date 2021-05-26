using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaData.Models
{
    public partial class Constants
    {
        public class TriviaService
        {
            public const string DATA_SOURCE_WEB_URL = "https://opentdb.com/api.php?amount=5&category=11&difficulty=medium&type=multiple";
            public const string TRAVIAQUESTIONSDATA_FILE_FULL_PATH = @"Trivia\wwwroot\lib\TraviaQuestionsData.json";
            public const string QUESTIONS_JSON_FILE_PATH = @"lib\TraviaQuestionsData.json";
        }
    }
}
