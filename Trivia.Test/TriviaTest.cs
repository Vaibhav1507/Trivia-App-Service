using Microsoft.AspNetCore.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using TriviaData.Models;

namespace Trivia.Test
{
    [TestClass]
    public class TriviaTest
    {
        private Mock<IHostingEnvironment> _hostingEnvironment;
        private TriviaAppCore.TriviaAppService _triviaAppService;

        [TestInitialize]
        public void Initialise()
        {
            _hostingEnvironment = new Mock<IHostingEnvironment>();
            _hostingEnvironment.Setup(x => x.WebRootPath).Returns(@"C:\Users\CT301195\Desktop\Vaibhav\Trivia\Trivia\Trivia\wwwroot");
            _triviaAppService = new TriviaAppCore.TriviaAppService(_hostingEnvironment.Object);
        }
        [TestMethod]
        public void GetTriviaQuestions_Success()
        {
            List<Questions> questions =  _triviaAppService.GetTriviaQuestions();
            Assert.IsTrue(questions?.Count > 0);
        }
    }
}
