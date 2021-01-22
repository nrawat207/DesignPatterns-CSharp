using BehavioralPatterns.Memento;
using NUnit.Framework;
using System;

namespace BehavioralPatternsTests.Memento
{
    [TestFixture]
    public class PlayerTest
    {
        private Player player;
        private PlayerHistory playerHistory;        

        [SetUp]
        public void TestSetup()
        {
            player = new Player();
            playerHistory = new PlayerHistory();

        }

        [Test]
        public void ShouldCreatePlayerSnap()
        {
            player.Level = 1;
            player.Score = 10;
            player.Timestamp = DateTime.Now;
            var snap = player.CreatePlayerSnap();
            playerHistory.AddPlayerSnap(snap);
            Assert.AreEqual(player.Level, snap.Player.Level);
            Assert.AreEqual(player.Score, snap.Player.Score);
            Assert.AreEqual(player.Timestamp, snap.Player.Timestamp);
        }

        [Test]
        public void ShoulRollbackPlayerSnap()
        {
            //set Player to level 1 stage
            player.Level = 1;
            player.Score = 10;
            player.Timestamp = DateTime.Now;
            var snap = player.CreatePlayerSnap();
            playerHistory.AddPlayerSnap(snap);

            //set Player to level 2 stage
            player.Level = 2;
            player.Score = 20;
            player.Timestamp = DateTime.Now;

            //rollback player to previous level
            player.RestorePlayerSnap(playerHistory.GetPlayerSnap());
            Assert.AreEqual(player.Level, 1);
            Assert.AreEqual(player.Score, 10);

        }
    }
}
