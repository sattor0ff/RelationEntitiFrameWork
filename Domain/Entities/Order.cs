namespace Domain.Entities;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderPlaced { get; set; }
    public DateTime OrderFulfilled { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public OrderDetail OrderDetail { get; set; }


    public Order()
    {
        
    }
    public Order(int id, DateTime orderplaced, DateTime orderfulfilled, int customerid)
    {
        Id = id;
        OrderPlaced = orderplaced;
        OrderFulfilled = orderfulfilled;
        CustomerId = customerid;
    }
}
