namespace DeckOfCardsAPI.Models
{
    public class Deck
    {
        public string success { get; set; }
        public string deck_id { get; set; }
        public string remaining { get; set; }
        public string shuffled { get; set; }
    }
    public class Images
    {
        public string svg { get; set; }
        public string png { get; set; }
    }
}