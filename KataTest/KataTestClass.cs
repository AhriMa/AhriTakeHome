using Microsoft.VisualStudio.TestTools.UnitTesting;

using Kata;

namespace KataTest
{
    [TestClass]
    public class KataTestClass
    {

        public BowlingGame bowlinggame;
        public KataTestClass()
        {
            bowlinggame = new BowlingGame();
        }

        // test all spare case
        [TestMethod]
        public void canScoreGutterGame()
        {
            int[] zeros = new int[20] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            bowlinggame.Roll(zeros);
            Assert.AreEqual(0, bowlinggame.Score());
        }

        //test all strike case 
        [TestMethod]
        public void canScoreAllStrikes()
        {
            int[] allstrike = new int[12] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            bowlinggame.Roll(allstrike);
            Assert.AreEqual(300, bowlinggame.Score());
        }

        // test 20 rolls : 10 pairs of 9 and miss =10 frames * 9points=90
        [TestMethod]
        public void canGet1Missed()
        {
            int[] get1missed = new int[20] { 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0 };
            bowlinggame.Roll(get1missed);
            Assert.AreEqual(90, bowlinggame.Score());
        }

        // test 5/5/5/5/5/5/5/5/5/5/5
        [TestMethod]
        public void TestCase4()
        {
            int[] get1missed = new int[21] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            bowlinggame.Roll(get1missed);
            Assert.AreEqual(150, bowlinggame.Score());
        }
    }
}

