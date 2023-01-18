namespace Domain.Dtos;

public class OrderDto
{
    public int Id { get; set; }
    public DateTime OrderPlaced { get; set; }
    public DateTime OrderFulfilled { get; set; }
    public int CustomerId { get; set; }

    public OrderDto()
    {
        
    }
    public OrderDto(int id, DateTime orderplaced, DateTime orderfulfilled, int customerid)
    {
        Id = id;
        OrderPlaced = orderplaced;
        OrderFulfilled = orderfulfilled;
        CustomerId = customerid;
    }
}