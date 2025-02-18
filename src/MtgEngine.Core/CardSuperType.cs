using Common;

namespace MtgEngine.Domain
{
    public class CardSuperType(int id) : EnumType(id)
    {
        public static readonly CardSuperType Basic = new(1);
    }
}