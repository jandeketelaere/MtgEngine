namespace MtgEngine.Domain
{
    public class Phase
    {
        public IList<Step> Steps { get; set; }

        public Phase()
        {
            Steps = new List<Step>();
        }
    }
}