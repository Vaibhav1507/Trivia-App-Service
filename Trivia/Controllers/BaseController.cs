using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IO;
using System.Net;
using TriviaData.Models;

namespace Travia.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            using (WebClient wc = new WebClient())
            {
                var jsonString = wc.DownloadString(Constants.TriviaService.DATA_SOURCE_WEB_URL);
                var jsonObject = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonString);
                string triviaQuestionsFilePath = Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()), Constants.TriviaService.TRAVIAQUESTIONSDATA_FILE_FULL_PATH);
                System.IO.File.WriteAllText(triviaQuestionsFilePath, jsonObject.ToString());
            }   
        }
    }
}
