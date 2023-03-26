using SalesManagement.Data.Entities;
using SalesManagement.Services;

namespace SalesManagement.Forms;
public partial class PurchaseForm : Form
{
    private readonly StorageService _storageService;
    public Purchase Purchase { get; private set; }
    public PurchaseForm(StorageService storageService)
    {
        _storageService = storageService;
        InitializeComponent();
        RefreshProducts();
    }

    private async Task RefreshProducts()
    {
        var storageData = await _storageService.GetStorageItems();
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
        var countForm = new SelectCountForm();
        if (countForm.ShowDialog() != DialogResult.OK || countForm.Count == 0)
            return;

        var prevItem = purchaseListView.Items.Cast<ListViewItem>().FirstOrDefault(x => (long)x.Tag == id);
        if (prevItem is not null)
        {
            prevItem.SubItems[1].Text = (countForm.Count + long.Parse(prevItem.SubItems[1].Text)).ToString();
            return;
        }

        purchaseListView.Items.Add(new ListViewItem(new string[] 
                                                   { item.SubItems[1].Text, countForm.Count.ToString() })
        {
            Tag = id
        });
    }

    private void addItemButton_Click(object sender, EventArgs e)
    {
        var productForm = new ProductForm();
        if (productForm.ShowDialog() != DialogResult.OK)
            return;

        Task.Run(async () =>
        {
            try
            {
                await _storageService.AddProduct(productForm.Product);
                MessageBox.Show($"Товар \"{productForm.Product.Name}\" добавлен", "Готово");
                await Invoke(RefreshProducts);
            }
            catch
            {
                MessageBox.Show($"Товар \"{productForm.Product.Name}\" не добавлен", "Ошибка");
            }
        });
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(numberTextBox.Text))
        {
            MessageBox.Show("Необходимо заполнить номер накладной");
            return;
        }
        if (string.IsNullOrEmpty(importerTextBox.Text))
        {
            MessageBox.Show("Необходимо заполнить имя поставщика");
            return;
        }
        if (purchaseListView.Items.Count == 0)
        {
            MessageBox.Show("Необходимо добавить товары в закупку");
            return;
        }

        var products = new List<ProductPurchase>();
        foreach (ListViewItem item in purchaseListView.Items)
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

        Purchase = new()
        {
            Date = DateTime.Now,
            Importer = importerTextBox.Text,
            Number = numberTextBox.Text,
            Products = products
        };

        DialogResult = DialogResult.OK;
        Close();
    }

    private void removePurchaseItemButton_Click(object sender, EventArgs e)
    {
        if (purchaseListView.SelectedIndices.Count == 0)
            return;

        purchaseListView.Items.RemoveAt(purchaseListView.SelectedIndices[0]);
    }
}
