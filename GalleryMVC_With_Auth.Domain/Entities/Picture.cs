using System.ComponentModel.DataAnnotations;

namespace GalleryMVC_With_Auth.Domain.Entities
{
    public class Picture
    {
        public int Id { get; set; }

        [Required]
        public string Path { get; set; }

        [Required]
        public string TmbPath { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Tag { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        public decimal Price { get; set; }

        public int? AlbumId { get; set; }

        public virtual Album Album { get; set; }
    }
}