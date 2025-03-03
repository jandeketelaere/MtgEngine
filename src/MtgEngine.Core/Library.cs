namespace MtgEngine.Domain
{
    public class Library
    {
        public IList<Card> Cards { get; set; }

        public Library(Deck deck)
        {
            Cards = deck.Cards;    
        }

        public void ShuffleCards()
        {
            Cards.Shuffle();
        }

        public Card DrawCard()
        {
            var card = Cards[0];

            Cards.Remove(card);

            return card;
        }
    }
}