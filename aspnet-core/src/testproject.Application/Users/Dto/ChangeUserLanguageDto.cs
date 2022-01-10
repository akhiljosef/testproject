using System.ComponentModel.DataAnnotations;

namespace testproject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}