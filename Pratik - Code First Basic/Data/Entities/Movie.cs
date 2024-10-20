using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pratik___Code_First_Basic.Data.Entities
{
    public class Movie
    {
        [Key] // Id'yi birincil anahtar olarak belirliyoruz
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Otomatik artan olarak ayarlıyoruz
        public int Id { get; set; }

        [Required] // Title alanının boş geçilememesi için zorunlu yapıyoruz
        public string Title { get; set; }

        [Required] // Genre alanının da zorunlu olmasını sağlıyoruz
        [RegularExpression(@"^(Action|Comedy|Drama)$", ErrorMessage = "Platform yalnızca 'Action', 'Comedy' veya 'Drama' olabilir.")]
        public string Genre { get; set; }

        [Required] // ReleaseYear alanının da zorunlu olmasını sağlıyoruz
        public int ReleaseYear { get; set; }
    }
}
