namespace MtgEngine.Domain
{
    public class Card
    {
        public string Name { get; }
        public IList<CardType> Types { get; }
        public IList<CardSubType> SubTypes { get; }
        public IList<CardSuperType> SuperTypes { get; }
        public ManaCost ManaCost { get; }

        public bool IsTapped { get; private set; }

        public Card(string name, IList<CardType> types, IList<CardSubType> subTypes, IList<CardSuperType> superTypes, ManaCost manaCost)
        {
            Name = name;
            Types = types ?? [];
            SubTypes = subTypes ?? [];
            SuperTypes = superTypes ?? [];
            ManaCost = manaCost;

            IsTapped = false;
        }

        public void Tap()
        {
            if (!IsTapped)
            {
                IsTapped = true;
            }
        }

        public void Untap()
        {
            if (IsTapped)
            {
                IsTapped = false;
            }
        }
    }
}