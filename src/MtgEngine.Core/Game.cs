namespace MtgEngine.Domain
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Battlefield Battlefield { get; set; }
        public Stack Stack { get; set; }
    }
}