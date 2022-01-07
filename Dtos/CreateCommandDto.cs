using System.ComponentModel.DataAnnotations;

namespace CommandHelper.Dtos
{
    public class CreateCommandDto
    {
        [Required]
        public string? Action { get; set; }
        [Required]
        public string? Line { get; set; }
        [Required]
        public string? Platform { get; set; }
    }
}