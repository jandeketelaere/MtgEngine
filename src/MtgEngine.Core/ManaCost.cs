namespace MtgEngine.Domain
{
    public class ManaCost
    {
        public IList<ManaValue> ManaValues { get; }

        public ManaCost(IList<ManaValue> manaValues)
        {
            ManaValues = manaValues;
        }

        private ManaCost()
        {
            ManaValues = [];
        }

        public static ManaCost Zero => new();
    }
}