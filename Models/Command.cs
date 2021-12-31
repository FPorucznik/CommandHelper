using System.ComponentModel.DataAnnotations;

namespace CommandHelper.Models
{
    public class Command
    {
        [Key]
        public Guid Id { get; set; }
        public string? Action { get; set; }
        public string? Line { get; set; }
        public string? Platform { get; set; }
    }
}