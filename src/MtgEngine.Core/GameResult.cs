namespace MtgEngine.Domain
{
    public class GameResult
    {
        public string Player { get; set; }
        public IList<IGameAction> Actions { get; set; }

    }
}