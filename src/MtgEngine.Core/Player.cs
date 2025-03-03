namespace MtgEngine.Domain
{
    public class Player
    {
        public string Name { get; set; }
        public int Life { get; set; }
        public IList<ManaValue> ManaPool { get; set; } //Each player's mana pool empties at the end of each step and phase.

        public Library Library { get; set; }
        public Hand Hand { get; set; }
        public Graveyard Graveyard { get; set; }

        public Player(string name, Deck deck)
        {
            Name = name;
            Life = 20;

            ManaPool = [];
            Library = new Library(deck);
            Hand = new Hand();
            Graveyard = new Graveyard();
        }

        public void ShuffleLibrary()
        {
            Library.ShuffleCards();
        }

        public void DrawCards(int amount)
        {
            foreach(var _ in Enumerable.Range(1, amount))
            {
                DrawCard();
            }
        }

        public void DrawCard()
        {
            var card = Library.DrawCard();
            Hand.PutCard(card);
        }
    }
}