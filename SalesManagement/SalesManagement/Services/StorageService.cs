using Microsoft.EntityFrameworkCore;
using SalesManagement.Data.Contexts;
using SalesManagement.Data.Entities;
using SalesManagement.Options;

namespace SalesManagement.Services;
public class StorageService
{
    private readonly MainContext _mainContext;
    public StorageService(MainContext context)
    {
        _mainContext = context;
    }

    public Task<List<Product>> GetStorageItems()
    {
        IQueryable<Product> q = _mainContext.Products.AsNoTracking()
                                                     .Include(x => x.Sales)
                                                     .Include(x => x.Purchases)
                                                     .OrderBy(x => x.Name);

        return q.ToListAsync();
    }

    public async Task AddProduct(Product product)
    {
        await _mainContext.Products.AddAsync(product);
        await _mainContext.SaveChangesAsync();
    }

    public ValueTask<Product?> GetProductById(long id)
    {
        return _mainContext.Products.FindAsync(id);
    }

    public async Task UpdateProduct(Product product)
    {
        _mainContext.Update(product);
        await _mainContext.SaveChangesAsync();
    }

    public async Task RemoveProductById(long id)
    {
        var product = await _mainContext.Products.FindAsync(id);
        if (product is null)
            throw new("Не найден товар с id:" + id);

        _mainContext.Remove(product);
        await _mainContext.SaveChangesAsync();
    }
}
