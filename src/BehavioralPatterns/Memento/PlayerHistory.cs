using System.Collections.Generic;

namespace BehavioralPatterns.Memento
{
    public class PlayerHistory
    {
        private readonly List<PlayerSnap> history;

        public PlayerHistory()
        {
            history = new List<PlayerSnap>();
        }

        public void AddPlayerSnap(PlayerSnap snap)
        {
            history.Add(snap);
        }

        public PlayerSnap GetPlayerSnap()
        {
            return history[history.Count - 1];
        }
    }
}
