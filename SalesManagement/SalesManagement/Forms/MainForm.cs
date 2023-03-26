using Microsoft.EntityFrameworkCore;
using SalesManagement.Data.Contexts;
using SalesManagement.Forms;
using SalesManagement.Services;
using System.Security.Cryptography.Xml;

namespace SalesManagement;
public partial class MainForm : Form
{
    private readonly StorageService _storageService;
    private readonly SalesAccountingService _salesService;
    private readonly PurchasesAccountingService _purchaseService;
    public MainForm(MainContext context, StorageService storageService, SalesAccountingService salesService, PurchasesAccountingService purchasesService)
    {
        context.Database.Migrate();
        _storageService = storageService;
        _salesService = salesService;
        _purchaseService = purchasesService;
        InitializeComponent();
        RefreshPurchaseData();
    }

    private async Task RefreshStorageData()
    {
        var storageData = await _storageService.GetStorageItems();
        storageListView.BeginUpdate();
        storageListView.Items.Clear();
        foreach (var data in storageData)
        {
            storageListView.Items.Add(new ListViewItem(data.ItemArray)
            {
                Tag = data.Id
            });
        }
        storageListView.EndUpdate();
    }

    private async Task RefreshSalesData()
    {
        var salesData = await _salesService.GetSales();
        salesListView.BeginUpdate();
        salesListView.Items.Clear();
        foreach (var data in salesData)
        {
            salesListView.Items.Add(new ListViewItem(data.ItemArray)
            {
                Tag = data.Id
            });
        }
        salesListView.EndUpdate();
    }

    private async Task RefreshPurchaseData()
    {
        var purchaseData = await _purchaseService.GetPurchases();
        purchasesListView.BeginUpdate();
        purchasesListView.Items.Clear();
        foreach (var data in purchaseData)
        {
            purchasesListView.Items.Add(new ListViewItem(data.ItemArray)
            {
                Tag = data.Number
            });
        }
        purchasesListView.EndUpdate();
    }

    private void storageListView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (storageListView.SelectedIndices.Count == 0)
            return;
        var id = (long)storageListView.Items[storageListView.SelectedIndices[0]].Tag;
        Task.Run(async () =>
        {
            var product = await _storageService.GetProductById(id);
            if (product is null)
                return;

            var productForm = new ProductForm(product);
            if (productForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await _storageService.UpdateProduct(productForm.Product);
                    MessageBox.Show($"Товар \"{product.Name}\" обновлен", "Готово");
                    await Invoke(RefreshStorageData);
                }
                catch
                {
                    MessageBox.Show($"Ошибка обновления \"{productForm.Product.Name}\"", "Ошибка");
                }
            }
        });
    }

    private void addPurchaseButton_Click(object sender, EventArgs e)
    {
        var purchaseForm = new PurchaseForm(_storageService);
        if (purchaseForm.ShowDialog() != DialogResult.OK)
            return;

        Task.Run(async () =>
        {
            try
            {
                await _purchaseService.AddPurchase(purchaseForm.Purchase);
                MessageBox.Show($"Закупка {purchaseForm.Purchase.Number} учтена", "Готово");
                await Invoke(RefreshPurchaseData);
            }
            catch
            {
                MessageBox.Show($"Закупка {purchaseForm.Purchase.Number} не учтена", "Ошибка");
            }
        });
    }

    private void tabControl1_Selected(object sender, TabControlEventArgs e)
    {
        Task.Run(async () =>
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    {
                        await Invoke(RefreshPurchaseData);
                        break;
                    }
                case 1:
                    {
                        await Invoke(RefreshStorageData);
                        break;
                    }
                case 2:
                    {
                        await Invoke(RefreshSalesData);
                        break;
                    }
            }
        });
    }

    private void removePurchaseButton_Click(object sender, EventArgs e)
    {
        if (purchasesListView.SelectedIndices.Count == 0)
            return;
        var id = (string)purchasesListView.Items[purchasesListView.SelectedIndices[0]].Tag;

        Task.Run(async () =>
        {
            try
            {
                await _purchaseService.DeletePurchase(id);
                MessageBox.Show("Удалено", "Готово");
                await Invoke(RefreshPurchaseData);
            }
            catch
            {
                MessageBox.Show("Ошибка удаления", "Ошибка");
            }
        });
    }

    private void purchasesListView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (purchasesListView.SelectedIndices.Count == 0)
            return;
        var id = (string)purchasesListView.Items[purchasesListView.SelectedIndices[0]].Tag;
        Task.Run(async () =>
        {
            var purchase = await _purchaseService.GetPurchase(id);
            var infoForm = new PurchaseInfoForm(purchase);
            infoForm.ShowDialog();
        });
    }

    private void addSaleButton_Click(object sender, EventArgs e)
    {
        var saleForm = new SaleForm(_storageService);
        if (saleForm.ShowDialog() != DialogResult.OK)
            return;

        Task.Run(async () =>
        {
            try
            {
                await _salesService.AddSale(saleForm.Sale);
                MessageBox.Show($"Продажа учтена", "Готово");
                await Invoke(RefreshSalesData);
            }
            catch
            {
                MessageBox.Show($"Продажа не учтена", "Ошибка");
            }
        });
    }

    private void removeSaleButton_Click(object sender, EventArgs e)
    {
        if (salesListView.SelectedIndices.Count == 0)
            return;
        var id = (long)salesListView.Items[salesListView.SelectedIndices[0]].Tag;

        Task.Run(async () =>
        {
            try
            {
                await _salesService.RemoveSale(id);
                MessageBox.Show("Удалено", "Готово");
                await Invoke(RefreshSalesData);
            }
            catch
            {
                MessageBox.Show("Ошибка удаления", "Ошибка");
            }
        });
    }

    private void salesListView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (salesListView.SelectedIndices.Count == 0)
            return;
        var id = (long)salesListView.Items[salesListView.SelectedIndices[0]].Tag;
        Task.Run(async () =>
        {
            var sale = await _salesService.GetSale(id);
            var infoForm = new SaleInfoForm(sale);
            infoForm.ShowDialog();
        });
    }
}