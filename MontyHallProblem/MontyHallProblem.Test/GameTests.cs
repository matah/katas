using NUnit.Framework;

namespace MontyHallProblem.Test
{
    [TestFixture]
    public class GameTests
    {
        private Game _game;
        
        [SetUp]
        public void SetUp()
        {
            _game = new Game();
        }

        [Test]
        public void InitGameReturns2GAnd1C()
        {
            char[] expectedValues = {'G', 'G', 'C'};

            _game.Init();
            var values = _game.Doors.Values;
            
            Assert.That(values, Is.EquivalentTo(expectedValues));
        }

        [Test]
        public void InitGameReturnsRandomInitialState()
        {
            
        }
    }
}
