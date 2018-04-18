using System.ComponentModel.DataAnnotations;

namespace Elecciones.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}