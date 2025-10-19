using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Callicode.Codility.Exercises.Tests
{
    [TestClass]
    public class TennisTournamentTests
    {
        [TestMethod]
        public void TennisTournament_Basic_1()
        {
            var exercise = new TennisTournament.Solution();

            Assert.AreEqual(2, exercise.solution(5, 3));
        }

        [TestMethod]
        public void TennisTournament_Basic_2()
        {
            var exercise = new TennisTournament.Solution();

            Assert.AreEqual(3, exercise.solution(10, 3));
        }

        [TestMethod]
        public void TennisTournament_MinValues()
        {
            var exercise = new TennisTournament.Solution();

            // Minimum case: 1 player, 1 court - no games possible (need 2 players per game)
            Assert.AreEqual(0, exercise.solution(1, 1));
        }

        [TestMethod]
        public void TennisTournament_TwoPlayers_OneCourt()
        {
            var exercise = new TennisTournament.Solution();

            // 2 players, 1 court - exactly 1 game possible
            Assert.AreEqual(1, exercise.solution(2, 1));
        }

        [TestMethod]
        public void TennisTournament_MoreCourtsThanPossibleGames()
        {
            var exercise = new TennisTournament.Solution();

            // 4 players, 10 courts - only 2 games possible (limited by players)
            Assert.AreEqual(2, exercise.solution(4, 10));
        }

        [TestMethod]
        public void TennisTournament_EvenPlayersMatchingCourts()
        {
            var exercise = new TennisTournament.Solution();

            // 8 players, 4 courts - exactly 4 games possible
            Assert.AreEqual(4, exercise.solution(8, 4));
        }

        [TestMethod]
        public void TennisTournament_OddPlayers()
        {
            var exercise = new TennisTournament.Solution();

            // 7 players, 5 courts - 3 games possible (1 player sits out)
            Assert.AreEqual(3, exercise.solution(7, 5));
        }

        [TestMethod]
        public void TennisTournament_MaxPlayers_OneCourt()
        {
            var exercise = new TennisTournament.Solution();

            // Maximum players, 1 court - only 1 game possible
            Assert.AreEqual(1, exercise.solution(30000, 1));
        }

        [TestMethod]
        public void TennisTournament_MaxCourts_TwoPlayers()
        {
            var exercise = new TennisTournament.Solution();

            // 2 players, maximum courts - only 1 game possible
            Assert.AreEqual(1, exercise.solution(2, 30000));
        }

        [TestMethod]
        public void TennisTournament_MaxRange()
        {
            var exercise = new TennisTournament.Solution();

            // Maximum players and courts - 15000 games possible (30000/2)
            Assert.AreEqual(15000, exercise.solution(30000, 30000));
        }

        [TestMethod]
        public void TennisTournament_LargeNumbers_PlayersLimited()
        {
            var exercise = new TennisTournament.Solution();

            // 1000 players, 20000 courts - 500 games possible (limited by players)
            Assert.AreEqual(500, exercise.solution(1000, 20000));
        }

        [TestMethod]
        public void TennisTournament_LargeNumbers_CourtsLimited()
        {
            var exercise = new TennisTournament.Solution();

            // 20000 players, 500 courts - 500 games possible (limited by courts)
            Assert.AreEqual(500, exercise.solution(20000, 500));
        }
    }
}
