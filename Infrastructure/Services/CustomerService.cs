using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class CustomerService
{
    private readonly DataContext _context;

    public CustomerService(DataContext context)
    {
        _context = context;
    }
    
    public List<CustomerDto> GetCustomers()
    {
        return _context.Customers.Select(x=>new CustomerDto(x.Id,x.FirstName,x.LastName,x.Address,x.Phone,x.Email)).ToList();
    }

    public List<CustomerDto> GetCustomerByName(string name)
    {
        return _context.Customers.
            Where(x => x.FirstName.ToLower().Contains(name.ToLower())).
            Select(x => new CustomerDto(x.Id,x.FirstName,x.LastName,x.Address,x.Phone,x.Email)).ToList();
    }
    
    public Customer GetCustomerById(int id)
    {
        return _context.Customers.FirstOrDefault(x => x.Id == id);
    }
    
    public void AddCustomer(CustomerDto customer)
    {
        var mapped = new Customer(customer.Id, customer.FirstName, customer.LastName, customer.Address, customer.Phone, customer.Email);
        _context.Customers.Add(mapped);
        _context.SaveChanges();
    }
    public void UpdateCustomer(CustomerDto customer)
    {
        var updated = new Customer(customer.Id, customer.FirstName, customer.LastName, customer.Address, customer.Phone, customer.Email);
        _context.Customers.Update(updated);
        _context.SaveChanges();
    }
    public void DeleteCustomer(int id)
    {
        var deleted = _context.Customers.First(x => x.Id == id);
        _context.Customers.Remove(deleted);
        _context.SaveChanges();
    }
}