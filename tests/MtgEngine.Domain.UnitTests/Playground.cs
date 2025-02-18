namespace MtgEngine.Domain.UnitTests
{
    public class Playground
    {
        [Fact]
        public void Test()
        {
            var deck = new Deck("DummyDeck",
            [
                new Card("Swamp", [CardType.Land], [CardSubType.Swamp], [CardSuperType.Basic], ManaCost.Zero)
            ]);
        }
    }
}