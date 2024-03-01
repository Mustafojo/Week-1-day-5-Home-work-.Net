namespace Domain.Models;

public class Peremeshenie
{
  public int Id_Peremeshenie { get; set; }

  public int Id_Product { get; set; }

  public int IzSklada { get; set; }

  public int NaSklad { get; set; }


  public int Quantity { get; set; }

  public DateTime Data_Peremeshenie { get; set; }

}
