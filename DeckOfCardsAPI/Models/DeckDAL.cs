using Newtonsoft.Json;
using System.Net;

namespace DeckOfCardsAPI.Models
{
	public class DeckDAL
	{
		public DeckDAL()
		{
		}
		public Deck ShuffleCards()
		{
			string url = "https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";
			HttpWebRequest request = WebRequest.CreateHttp(url);
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();

			StreamReader rd = new StreamReader(response.GetResponseStream());

			string JSON = rd.ReadToEnd();

			Deck d = JsonConvert.DeserializeObject<Deck>(JSON);
			return d;
		}
		public Player DrawACard(string deckId)
		{
			Player ph = new Player();
			string url = $"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count=5";
			HttpWebRequest request = WebRequest.CreateHttp(url);
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();

			StreamReader rd = new StreamReader(response.GetResponseStream());

			string JSON = rd.ReadToEnd();

			Player p = JsonConvert.DeserializeObject<Player>(JSON);
			return p;
		}
	}
}

