namespace GameNightWithFriends.Models
{
    public class Player
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int GameNightId { get; set; }
        // a Player attends one GameNight
        public GameNight GameNight { get; set; }

    }
}