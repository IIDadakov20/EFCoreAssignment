namespace EFCoreAssignment.Domain.DTOs.Response;

public class ProductResponseDTO
{
    public int Id { get; set; }
    
    public string Name { get; set; } = null!;
    
    public decimal Price { get; set; }
    
    public int Stock { get; set; }
    
    public string Description { get; set; } = null!;

    public CategoryResponseDTO Category { get; set; } = null!;
}