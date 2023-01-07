using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace pat2023_lukasz_winowicz_dotnet.Dto
{
    public class AuthorDto
    {
        public int Id { get; protected set; }

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
