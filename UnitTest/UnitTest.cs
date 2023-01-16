using Library;

namespace UnitTest
{
    public class Tests
    {
        Team team;
        [SetUp]
        public void Setup()
        {
            team = new Team("team 1");
        }

        [Test]
        public void AddPlayers()
        {
            for(int c = 0; c <= 3; c++)
            {
                team.AddPlayer(new Player("mario", "rossi", Player.ERole.Riserva));
            }
            Assert.That(team.AddPlayer(new Player("mario", "rossi", Player.ERole.Riserva)) == false);
        }

        [Test]
        public void AddCaptain()
        {
            Assert.That(team.AddCaptain(new Player("mario", "rossi", Player.ERole.Riserva)) == false);
        }
    }
}