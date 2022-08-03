using System.ComponentModel.DataAnnotations;

namespace SovTech.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}