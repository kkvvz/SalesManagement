using System.ComponentModel.DataAnnotations;

namespace SalesManagement.Data.Entities;
public class Purchase
{
    [Key]
    public string Number { get; set; }
    public string Importer { get; set; }
    public DateTime Date { get; set; }
    public IList<ProductPurchase> Products { get; set; }

    public string[] ItemArray => new string[] { Number, Importer, Date.ToString() };
}
