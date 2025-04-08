namespace BlazorAppTest.Models
{
    public class Player
    {
        public Player(int id, string prenom, int score)
        {
            Id = id;
            Prenom = prenom;
            Score = score;
        }

        public int Id { get; set; }
        public string Prenom { get; set; }
        public int Score { get; set; }
    }
}
