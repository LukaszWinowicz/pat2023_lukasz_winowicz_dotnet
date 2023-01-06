using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace pat2023_lukasz_winowicz_dotnet.Dto
{
    public class CreateBookDto
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(2,1)")]
        [Range(1, 9.9)] // 1 ... 5.5 ... 9.9
        public decimal Rating { get; set; }

        [Required]
        [MaxLength(13)]
        public string ISBN { get; set; }

        [Required]
        [Column(TypeName = "datetime2(0)")]
        public DateTime PublicationDate { get; set; }
    }
}