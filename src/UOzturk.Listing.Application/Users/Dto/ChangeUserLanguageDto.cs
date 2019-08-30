using System.ComponentModel.DataAnnotations;

namespace UOzturk.Listing.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}