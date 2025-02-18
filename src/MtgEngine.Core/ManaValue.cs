using Common;

namespace MtgEngine.Domain
{
    public class ManaValue : ValueObject
    {
        public int Value { get; }
        public Mana Mana { get; }

        public ManaValue(int value, Mana mana)
        {
            Value = value;
            Mana = mana;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
            yield return Mana;
        }
    }
}