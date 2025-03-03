namespace MtgEngine.Domain
{
    public static class CardExtensions
    {
        public static void Shuffle(this IList<Card> cards)
        {
            var random = new Random();

            for (int i = 0; i < cards.Count; i++)
            {
                int j = random.Next(cards.Count);
                (cards[j], cards[i]) = (cards[i], cards[j]);
            }
        }
    }
}