using SalesManagement.Data.Entities;

namespace SalesManagement.Forms;
public partial class PurchaseInfoForm : Form
{
    public PurchaseInfoForm(Purchase purchase)
    {
        InitializeComponent();
        numberLabel.Text = purchase.Number;
        dateLabel.Text = purchase.Date.ToString();
        importerLabel.Text = purchase.Importer;
        productsListView.BeginUpdate();
        productsListView.Items.Clear();
        productsListView.Items.AddRange(purchase.Products
                                                .Select(x => new ListViewItem(
                                                        new string[] { x.Product.Id.ToString(), x.Product.Name, x.ProductCount.ToString() }))
                                                .ToArray());
        productsListView.EndUpdate();
    }
}
