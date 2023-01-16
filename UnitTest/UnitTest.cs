using Library;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddPlayers()
        {
            Team team = new Team("team 1");
            for(int c = 0; c <= 3; c++)
            {
                team.AddPlayer(new Player("mario", "rossi", Player.ERole.Riserva));
            }
            Assert.That(team.AddPlayer(new Player("mario", "rossi", Player.ERole.Riserva)) == false);
        }

        [Test]
        public void AddCaptain()
        {
            // TODO U.2
        }
    }
}