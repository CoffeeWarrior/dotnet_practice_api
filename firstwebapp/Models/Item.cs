using System.ComponentModel.DataAnnotations;

namespace firstwebapp.Models
{
    public record Item
    {
        [Required]
        public Guid Id { get; init; } //init lets you set a value during initialization and it is no longer modifiable after initialization
        [Required]
        public string Name { get; init; }
        
        public decimal Price { get; init; }

        public DateTimeOffset CreatedDate { get; init; }
    }

    
}
