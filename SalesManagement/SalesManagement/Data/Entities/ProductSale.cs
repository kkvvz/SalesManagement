using System.ComponentModel.DataAnnotations;

namespace SalesManagement.Data.Entities;
public class ProductSale
{
    [Key]
    public long Id { get; set; }
    public Product Product { get; set; }
    public Sale Sale { get; set; }
    public long ProductCount { get; set; }
}
