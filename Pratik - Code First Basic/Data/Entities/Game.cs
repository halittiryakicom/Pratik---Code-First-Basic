using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pratik___Code_First_Basic.Data.Entities
{
    public class Game
    {
        [Key] // Id'yi birincil anahtar olarak belirliyoruz
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Otomatik artan olarak ayarlıyoruz
        public int Id { get; set; }

        [Required] // Name alanının boş geçilememesi için zorunlu yapıyoruz
        public string Name { get; set; }

        [Required] // Platform alanının da zorunlu olmasını sağlıyoruz
        [RegularExpression(@"^(PC|PlayStation|Xbox)$", ErrorMessage = "Platform yalnızca 'PC', 'PlayStation' veya 'Xbox' olabilir.")]
        public string Platform { get; set; }

        [Column(TypeName = "decimal(3,1)")] // Rating için ondalık veri tipi ve 0-10 arasında 1 ondalık basamak olacak şekilde ayar
        public decimal Rating { get; set; }

    }
}
