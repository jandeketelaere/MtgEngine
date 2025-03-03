namespace MtgEngine.Domain
{
    public class Battlefield
    {
        public IList<Card> Cards { get; set; }

        public Battlefield()
        {
            Cards = [];    
        }

        public void UntapCards()
        {
            var tappedCards = Cards.Where(x => x.IsTapped).ToList();

            foreach(var tappedCard in tappedCards)
            {
                tappedCard.Untap();
            }
        }
    }
}