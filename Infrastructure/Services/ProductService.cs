using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class ProductService
{
    private readonly DataContext _context;

    public ProductService(DataContext context)
    {
        _context = context;
    }
    
    public List<ProductDto> GetProducts()
    {
        return _context.Products.Select(x=>new ProductDto(x.Id,x.Name,x.Price)).ToList();
    }

    public List<ProductDto> GetProductByName(string name)
    {
        return _context.Products.
            Where(x => x.Name.ToLower().Contains(name.ToLower())).
            Select(x => new ProductDto(x.Id,x.Name,x.Price)).ToList();
    }
    
    public Product GetProductById(int id)
    {
        return _context.Products.FirstOrDefault(x => x.Id == id);
    }
    
    public void AddProduct(ProductDto product)
    {
        var mapped = new Product(product.Id, product.Name, product.Price);
        _context.Products.Add(mapped);
        _context.SaveChanges();
    }
    public void UpdateProduct(ProductDto product)
    {
        var mapped = new Product(product.Id, product.Name, product.Price);
        _context.Products.Update(mapped);
        _context.SaveChanges();
    }
    public void DeleteProduct(int id)
    {
        var delete = _context.Products.First(x => x.Id == id);
        _context.Products.Remove(delete);
        _context.SaveChanges();
    }
}
    