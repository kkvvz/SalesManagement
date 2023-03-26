using System.ComponentModel.DataAnnotations;
namespace SalesManagement.Data.Entities;
public class ProductPurchase
{
    [Key]
    public long Id { get; set; }
    public Purchase Purchase { get; set; }
    public Product Product { get; set; }
    public long ProductCount { get; set; }
}