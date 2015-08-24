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
        public void ShowDoorDoesNotReturnWinningDoor()
        {
            _game.Init();
            var shownDoor = _game.ShowDoor();

            Assert.That(_game.Doors[shownDoor], Is.Not.EqualTo('C'));
        }

        [Test]
        public void ShowDoorDoesNotReturnPickedDoor()
        {
            _game.Init();
            var shownDoor = _game.ShowDoor();
            
            Assert.That(shownDoor, Is.Not.EqualTo(_game.PickedDoor));
        }
    }
}
