using Microsoft.EntityFrameworkCore;
using SalesManagement.Data.Contexts;
using SalesManagement.Data.Entities;

namespace SalesManagement.Services;
public class PurchasesAccountingService
{
    private readonly MainContext _context;
    public PurchasesAccountingService(MainContext context)
    {
        _context = context;
    }

    public Task<Purchase> GetPurchase(string number)
    {
        return _context.Purchases.Include(x => x.Products)
                                 .ThenInclude(x => x.Product)
                                 .FirstOrDefaultAsync(x => x.Number == number)!;
    }

    public Task<List<Purchase>> GetPurchases()
    {
        return _context.Purchases.AsNoTracking().ToListAsync();
    }
    public async Task AddPurchase(Purchase purchase)
    {
        purchase.Products = purchase.Products.Select(x => new ProductPurchase()
        {
            Product = _context.Products.FindAsync(x.Product.Id).Result!,
            ProductCount = x.ProductCount
        }).ToList();

        _context.Add(purchase);
        await _context.SaveChangesAsync();
    }
    public async Task DeletePurchase(string number)
    {
        var entity = await _context.Purchases.FindAsync(number);
        if (entity is null)
            throw new("Не найдена закупка");
        _context.Remove(entity);
        await _context.SaveChangesAsync();
    }
}
