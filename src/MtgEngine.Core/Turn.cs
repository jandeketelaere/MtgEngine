namespace MtgEngine.Domain
{
    public class Turn
    {
        public IList<Phase> Phases { get; set; }

        public Turn()
        {
            Phases = new List<Phase>();
        }
    }
}