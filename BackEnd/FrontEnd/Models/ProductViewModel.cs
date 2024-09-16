namespace FrontEnd.Models;

public class ProductViewModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public double Price { get; set; }

    public double Rating { get; set; }

    public string Category { get; set; } = null!;

    public int Stock { get; set; }

}
