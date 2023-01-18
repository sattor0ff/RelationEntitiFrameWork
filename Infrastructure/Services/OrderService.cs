using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class OrderService
{
    private readonly DataContext _context;

    public OrderService(DataContext context)
    {
        _context = context;
    }
    
    public List<AllDto> GetOrders()
    {
        return _context.Orders.Select(x => new AllDto()
        {
            Address = x.Customer.Address,
            Id = x.Id,
            OrderDate = x.OrderPlaced,
            CustomerId = x.CustomerId,
            FullName = string.Concat(x.Customer.FirstName, " ", x.Customer.LastName),
            ProductName = x.OrderDetail.Product.Name
        }).ToList();
    }
    
    public List<AllDto> GetOrdersByDate(DateTime date)
    {
        
        return _context.Orders
            .Where(x=>x.OrderPlaced.Date == date.Date)
            .Select(x => new AllDto()
        {
            Address = x.Customer.Address,
            Id = x.Id,
            OrderDate = x.OrderPlaced,
            CustomerId = x.CustomerId,
            FullName = string.Concat(x.Customer.FirstName, " ", x.Customer.LastName),
            ProductName = x.OrderDetail.Product.Name
        }).ToList();
    }
    

    public List<AllDto> GetOrderById(int id)
    {
        return _context.Orders
            .Where(x=>x.Id == id)
            .Select(x => new AllDto()
        {
            Address = x.Customer.Address,
            Id = x.Id,
            OrderDate = x.OrderPlaced,
            CustomerId = x.CustomerId,
            FullName = string.Concat(x.Customer.FirstName, " ", x.Customer.LastName),
            ProductName = x.OrderDetail.Product.Name
        }).ToList();
    }
    
    public void AddOrder(OrderDto order)
    {
        var mapped = new Order(order.Id, order.OrderPlaced, order.OrderFulfilled, order.CustomerId);
        _context.Orders.Add(mapped);
        _context.SaveChanges();
    }
    public void UpdateOrder(OrderDto order)
    {
        var updated = new Order(order.Id, order.OrderPlaced, order.OrderFulfilled, order.CustomerId);
        _context.Orders.Update(updated);
        _context.SaveChanges();
    }
    public void DeleteOrder(int id)
    {
        var deleted = _context.Orders.First(x => x.Id == id);
        _context.Orders.Remove(deleted);
        _context.SaveChanges();
    }
}