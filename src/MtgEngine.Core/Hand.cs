namespace MtgEngine.Domain
{
    public class Hand
    {
        public IList<Card> Cards { get; set; }

        public Hand()
        {
            Cards = [];
        }

        public void PutCard(Card card)
        {
            Cards.Add(card);
        }
    }
}