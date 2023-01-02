using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace pat2023_lukasz_winowicz_dotnet.Dto
{
    public class CreateAuthorDto
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "datetime2(0)")]
        public DateTime BirthDate { get; set; }

        [Required]
        public bool Gender { get; set; }
    }
}