namespace SlnRestaurant.Core.Services.Entities;

public class Order
{
    public Guid Id { get; set; }
    public IDictionary<Guid, double> Products { get; set; }
    public DateTime StartDate { get; set; }
    public decimal TotalValue { get; set; }

}
