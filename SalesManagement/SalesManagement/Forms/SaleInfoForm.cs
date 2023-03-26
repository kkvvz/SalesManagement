using SalesManagement.Data.Entities;

namespace SalesManagement.Forms;
public partial class SaleInfoForm : Form
{
    public SaleInfoForm(Sale sale)
    {
        InitializeComponent();
        sumLabel.Text = sale.ItemArray.Last();
        dateLabel.Text = sale.SaleDate.ToString();
        salesListView.BeginUpdate();
        salesListView.Items.Clear();
        var items = sale.Products.Select(x => new ListViewItem(
                                                 new string[] { x.Product.Id.ToString(), x.Product.Name, x.ProductCount.ToString(),
                                                                x.Product.Price.ToString(), (x.ProductCount * x.Product.Price).ToString() }))
                                 .ToArray();
        salesListView.Items.AddRange(items);
        salesListView.EndUpdate();
    }
}
