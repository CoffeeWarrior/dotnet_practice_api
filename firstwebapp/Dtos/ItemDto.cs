namespace firstwebapp.Dtos
{
    public record ItemDto
    {
        public Guid Id { get; init; } //init lets you set a value during initialization and it is no longer modifiable after initialization
        public string Name { get; init; }

        public decimal Price { get; init; }

        public DateTimeOffset CreatedDate { get; init; }
    }
}
