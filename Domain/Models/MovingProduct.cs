namespace Domain.Models;

public class MovingProduct
{
    public string Name { get; set; }
    public int FromStock { get; set; }
    public int ToStock { get; set; }
    public int Count { get; set; }
}