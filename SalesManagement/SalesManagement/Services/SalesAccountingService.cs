using Microsoft.EntityFrameworkCore;
using SalesManagement.Data.Contexts;
using SalesManagement.Data.Entities;

namespace SalesManagement.Services;
public class SalesAccountingService
{
    private readonly MainContext _mainContext;
    public SalesAccountingService(MainContext context)
    {
        _mainContext = context;
    }

    public Task<List<Sale>> GetSales()
    {
        return _mainContext.Sales.Include(x => x.Products)
                                 .ThenInclude(x => x.Product)
                                 .AsNoTracking()
                                 .ToListAsync();
    }

    public async Task AddSale(Sale sale)
    {
        sale.Products =  sale.Products.Select(x => new ProductSale()
        {
            Product = _mainContext.Products.FindAsync(x.Product.Id).Result!,
            ProductCount = x.ProductCount
        }).ToList();
        await _mainContext.AddAsync(sale);
        await _mainContext.SaveChangesAsync();
    }

    public async Task RemoveSale(long id)
    {
        var sale = await _mainContext.Sales.FindAsync(id);
        _mainContext.Sales.Remove(sale!);
        await _mainContext.SaveChangesAsync();
    }

    public Task<Sale> GetSale(long id)
    {
        return _mainContext.Sales.Include(x => x.Products)
                                 .ThenInclude(x => x.Product)
                                 .FirstOrDefaultAsync(x => x.Id == id)!;
    }
}
