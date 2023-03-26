using System.ComponentModel.DataAnnotations;

namespace SalesManagement.Data.Entities;
public class Sale
{
    [Key]
    public long Id {  get; set; }   
    public DateTime SaleDate { get; set; }
    public IList<ProductSale> Products { get; set; }
    public string[] ItemArray { get => new string[] { Id.ToString(), SaleDate.ToString(), Products.Sum(x => x.Product.Price * x.ProductCount).ToString() }; }
}
