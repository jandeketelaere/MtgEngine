using Common;

namespace MtgEngine.Domain
{
    public class Mana(int id) : EnumType(id)
    {
        public static readonly Mana Colorless = new(1);
        public static readonly Mana White = new(2);
        public static readonly Mana Blue = new(3);
        public static readonly Mana Black = new(4);
        public static readonly Mana Red = new(5);
        public static readonly Mana Green = new(6);
    }
}