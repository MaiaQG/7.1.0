using System.ComponentModel.DataAnnotations;

namespace TrainingAngular.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}