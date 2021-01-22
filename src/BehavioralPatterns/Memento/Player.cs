using System;

namespace BehavioralPatterns.Memento
{
    public class Player
    {
        public int Level { get; set; }
        public int Score { get; set; }
        public DateTime Timestamp { get; set; }


        public Player Clone(){

            return MemberwiseClone() as Player;
        }

        public PlayerSnap CreatePlayerSnap()
        {
            return new PlayerSnap(this);
        }

        public void RestorePlayerSnap(PlayerSnap snap)
        {            
            this.Level = snap.Player.Level;
            this.Score = snap.Player.Score;
            this.Timestamp = snap.Player.Timestamp;
        }

        public void PlayerStatistics()
        {
            Console.WriteLine("Level :{0}", Level);
            Console.WriteLine("Score :{0}", Score);
            Console.WriteLine("Timestamp :{0}", Timestamp);

        }

    }
}
