using SalesManagement.Data.Entities;
using SalesManagement.Services;

namespace SalesManagement.Forms;
public partial class SaleForm : Form
{
    public Sale Sale { get; private set; }
    public SaleForm(StorageService storageService)
    {
        InitializeComponent();
        RefreshProducts(storageService);
    }

    private async Task RefreshProducts(StorageService storageService)
    {
        var storageData = await storageService.GetStorageItems();
        itemsListView.BeginUpdate();
        itemsListView.Items.Clear();
        foreach (var data in storageData)
        {
            itemsListView.Items.Add(new ListViewItem(data.ItemArray)
            {
                Tag = data.Id
            });
        }
        itemsListView.EndUpdate();
    }

    private void toPurchaseButton_Click(object sender, EventArgs e)
    {
        if (itemsListView.SelectedIndices.Count == 0)
            return;
        var item = itemsListView.Items[itemsListView.SelectedIndices[0]];
        var id = (long)item.Tag;
        var count = long.Parse(item.SubItems[4].Text);
        var price = decimal.Parse(item.SubItems[3].Text);
        var countForm = new SelectCountForm(count);
        if (countForm.ShowDialog() != DialogResult.OK || countForm.Count == 0)
            return;

        var prevItem = saleListView.Items.Cast<ListViewItem>().FirstOrDefault(x => (long)x.Tag == id);
        if (prevItem is not null)
        {
            var newCount = countForm.Count + long.Parse(prevItem.SubItems[1].Text);
            prevItem.SubItems[1].Text = newCount.ToString();
            prevItem.SubItems[2].Text = (newCount * price).ToString();
            return;
        }

        saleListView.Items.Add(new ListViewItem(new string[]
                                                   { item.SubItems[1].Text, countForm.Count.ToString(), (price * countForm.Count).ToString() })
        {
            Tag = id
        });

        sumLabel.Text = saleListView.Items.Cast<ListViewItem>().Sum(x => decimal.Parse(x.SubItems[2].Text)).ToString();
    }

    private void removePurchaseItemButton_Click(object sender, EventArgs e)
    {
        if (saleListView.SelectedIndices.Count == 0)
            return;

        saleListView.Items.RemoveAt(saleListView.SelectedIndices[0]);
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        var products = new List<ProductSale>();
        foreach (ListViewItem item in saleListView.Items)
        {
            products.Add(new()
            {
                Product = new()
                {
                    Id = (long)item.Tag
                },
                ProductCount = long.Parse(item.SubItems[1].Text)
            });
        }

        Sale = new()
        {
            SaleDate = DateTime.Now,
            Products = products
        };

        DialogResult = DialogResult.OK;
        Close();
    }
}
