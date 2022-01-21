namespace DAL.Model
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Genre { get; set; }
        public int Publisher  { get; set; }
        public DateTime PublishDate { get; set; }

    }
}
