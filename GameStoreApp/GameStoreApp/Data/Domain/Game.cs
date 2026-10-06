using System.ComponentModel.DataAnnotations;

namespace GameStoreApp.Data.Domain
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Range(0, 1000)]
        public decimal Price { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public int DeveloperId { get; set; }
        public Developer Developer { get; set; } = null!;

        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; } = null!;

        public ICollection<GameTag> GameTags { get; set; } = new List<GameTag>();
        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
