using System.ComponentModel.DataAnnotations;

namespace SalesManagement.Data.Entities;
public class Product
{
    [Key]
    public long Id { get; set; } 
    public string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public long Count { get => Purchases.Sum(x => x.ProductCount) - Sales.Sum(x => x.ProductCount); }
    public IList<ProductSale> Sales { get; set; }
    public IList<ProductPurchase> Purchases { get; set; }
    public string[] ItemArray { get => new string[] { Id.ToString(), Name, Description, Price.ToString(), Count.ToString() }; }
}
