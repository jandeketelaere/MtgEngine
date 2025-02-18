using Common;

namespace MtgEngine.Domain
{
    public class CardSubType(int id, CardType cardType) : EnumType(id)
    {
        public static readonly CardSubType Plains = new(1, CardType.Land);
        public static readonly CardSubType Island = new(2, CardType.Land);
        public static readonly CardSubType Swamp = new(3, CardType.Land);
        public static readonly CardSubType Mountain = new(4, CardType.Land);
        public static readonly CardSubType Forest = new(5, CardType.Land);

        public CardType CardType { get; } = cardType;
    }
}