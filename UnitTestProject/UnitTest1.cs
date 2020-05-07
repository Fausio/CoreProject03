using CoreProject03.Controllers;
using CoreProject03.Repository; 
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MusicControllerTest
    {
        [TestMethod]
        public void ChechIFMusicCOntollerIsNotNull()
        {
            var repository = new RepositoryBand();
            var controler = new  MusicController(repository);

            Assert.IsNotNull(controler);
        }
    }
}
