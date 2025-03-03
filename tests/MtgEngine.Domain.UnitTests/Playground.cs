namespace MtgEngine.Domain.UnitTests
{
    public class Playground
    {
        [Fact]
        public void Test()
        {
            var deck = new Deck("DummyDeck",
            [
                new Card("Swamp1", [CardType.Land], [CardSubType.Swamp], [CardSuperType.Basic], ManaCost.Zero),
                new Card("Swamp2", [CardType.Land], [CardSubType.Swamp], [CardSuperType.Basic], ManaCost.Zero),
                new Card("Swamp3", [CardType.Land], [CardSubType.Swamp], [CardSuperType.Basic], ManaCost.Zero),
                new Card("Swamp4", [CardType.Land], [CardSubType.Swamp], [CardSuperType.Basic], ManaCost.Zero),
                new Card("Swamp5", [CardType.Land], [CardSubType.Swamp], [CardSuperType.Basic], ManaCost.Zero),
                new Card("Swamp6", [CardType.Land], [CardSubType.Swamp], [CardSuperType.Basic], ManaCost.Zero),
                new Card("Swamp7", [CardType.Land], [CardSubType.Swamp], [CardSuperType.Basic], ManaCost.Zero)
            ]);

            var deck2 = new Deck("DummyDeck",
            [
                new Card("Swamp1", [CardType.Land], [CardSubType.Swamp], [CardSuperType.Basic], ManaCost.Zero),
                new Card("Swamp2", [CardType.Land], [CardSubType.Swamp], [CardSuperType.Basic], ManaCost.Zero),
                new Card("Swamp3", [CardType.Land], [CardSubType.Swamp], [CardSuperType.Basic], ManaCost.Zero),
                new Card("Swamp4", [CardType.Land], [CardSubType.Swamp], [CardSuperType.Basic], ManaCost.Zero),
                new Card("Swamp5", [CardType.Land], [CardSubType.Swamp], [CardSuperType.Basic], ManaCost.Zero),
                new Card("Swamp6", [CardType.Land], [CardSubType.Swamp], [CardSuperType.Basic], ManaCost.Zero),
                new Card("Swamp7", [CardType.Land], [CardSubType.Swamp], [CardSuperType.Basic], ManaCost.Zero)
            ]);

            var player = new Player("Jan", deck);
            var player2 = new Player("Jan2", deck2);

            var game = new Game(player, player2);

            var result = game.Start();
        }
    }
}