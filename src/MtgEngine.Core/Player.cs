namespace MtgEngine.Domain
{
    public class Player
    {
        public int Life { get; private set; }
        public IList<ManaValue> ManaPool { get; private set; } //Each player's mana pool empties at the end of each step and phase.

        public Library Library { get; private set; }
        public Hand Hand { get; private set; }
        public Graveyard Graveyard { get; private set; }

        public Player()
        {
            Life = 20;
            ManaPool = new List<ManaValue>();
        }
    }
}