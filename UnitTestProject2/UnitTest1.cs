using System;
using System.Media;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussianRoulette;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        //Arrange
        Form1 myForm1 = new Form1();
        Roulette myOp = new Roulette();

        [TestMethod]
        public void RndNumber()
        {
            //Act
            Random r = new Random();
            //assert
            Assert.IsNotNull(r.ToString());


        }

        [TestMethod]
        public void DoesSoundPlay()
        {
            //act
            SoundPlayer player = new SoundPlayer(Resource1._442997__suburbanwizard__8bit_sample);
            //assert
            Assert.IsNotNull(player.ToString());
        }



    }
}
