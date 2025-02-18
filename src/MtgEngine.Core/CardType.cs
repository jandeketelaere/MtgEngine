using Common;

namespace MtgEngine.Domain
{
    public class CardType(int id) : EnumType(id)
    {
        public static readonly CardType Land = new(1);
        public static readonly CardType Creature = new(2);
        public static readonly CardType Artifact = new(3);
        public static readonly CardType Enchantment = new(4);
        public static readonly CardType Instant = new(5);
        public static readonly CardType Sorcery = new(6);
    }
}