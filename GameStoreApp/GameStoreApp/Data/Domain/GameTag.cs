using System.ComponentModel.DataAnnotations;

namespace GameStoreApp.Data.Domain
{
    public class GameTag
    {
        [Key]
        public int Id { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; } = null!;

        public int TagId { get; set; }
        public Tag Tag { get; set; } = null!;
    }
}
