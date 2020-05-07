using CoreProject03.Controllers;
using CoreProject03.Models;
using CoreProject03.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class MusicControllerTest
    {
        [TestMethod]
        public void ChechIFMusicCOntollerIsNotNull()
        {
            var repository = new RepositoryBand();
            var controler = new MusicController(repository);

            Assert.IsNotNull(controler);
        }

        [TestMethod]
        public void IfRepositoryBandReturnList()
        {
            var moq = new Mock<IRepositoryBand>();
            var list = moq.Setup(x => x.Bands()).Returns(new List<Band>());

            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void IfRepositoryBandReturBand()
        {
            var moq = new Mock<IRepositoryBand>();
          
            Assert.IsNotNull(moq.Setup(x => x.Band("The moon")).Returns(new Band()));
        }
    }
}
