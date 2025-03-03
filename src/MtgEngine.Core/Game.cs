namespace MtgEngine.Domain
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Battlefield Battlefield { get; set; }
        public Stack Stack { get; set; }

        public Game(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        private IList<Player> GetPlayers()
            => [Player1, Player2];

        public GameResult Start()
        {
            foreach(var player in GetPlayers())
            {
                player.ShuffleLibrary();
                player.DrawCards(7);
            }

            //todo: mulligan
            return new GameResult();
        }
    }
}