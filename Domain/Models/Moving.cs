namespace Domain.Models;

public class Moving
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int FromStock { get; set; }
    public int ToStock { get; set; }
    public int Quantity { get; set; }
    public DateTime DateofMoving { get; set; }
}