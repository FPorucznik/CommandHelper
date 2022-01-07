namespace CommandHelper.Dtos
{
    public class GetCommandDto
    {
        public Guid Id { get; set; }
        public string? Action { get; set; }
        public string? Line { get; set; }
        public string? Platform { get; set; }
    }
}