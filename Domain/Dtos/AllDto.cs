namespace Domain.Dtos;

public class AllDto
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public string ProductName { get; set; }

    public AllDto()
    {
        
    }
    public AllDto(int id, int customerId, DateTime orderDate, string fullName, string address, string productName)
    {
        Id = id;
        CustomerId = customerId;
        OrderDate = orderDate;
        FullName = fullName;
        Address = address;
        ProductName = productName;
    }
}