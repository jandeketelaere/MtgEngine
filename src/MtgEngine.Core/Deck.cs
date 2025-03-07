﻿namespace MtgEngine.Domain
{
    public class Deck
    {
        public string Name { get; }
        public IList<Card> Cards { get; set; }

        public Deck(string name, IList<Card> cards)
        {
            Name = name;
            Cards = cards;
        }
    }
}