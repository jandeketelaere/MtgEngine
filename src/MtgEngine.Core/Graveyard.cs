namespace MtgEngine.Domain
{
    public class Graveyard
    {
        public IList<Card> Cards { get; set; }

        public Graveyard()
        {
            Cards = [];
        }
    }
}