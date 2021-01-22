namespace BehavioralPatterns.Memento
{
    public class PlayerSnap
    {       
        public PlayerSnap(Player player)
        {
            this.Player = player.Clone();
        }
        public Player Player { get; set; }
    }
}
