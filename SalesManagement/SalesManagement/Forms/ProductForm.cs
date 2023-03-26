using SalesManagement.Data.Entities;

namespace SalesManagement.Forms;
public partial class ProductForm : Form
{
    public Product Product { get; init; }
    public ProductForm(Product? product = null)
    {
        InitializeComponent();
        if (product is not null)
            this.Text = "Редактирование товара";
        Product = product ?? new();
        InitializeProduct();
    }

    private void InitializeProduct()
    {
        nameTB.Text = Product.Name;
        descriptionTB.Text = Product.Description;
        priceNumeric.Value = Product.Price;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(nameTB.Text))
        {
            MessageBox.Show("Необходимо заполнить наименование", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        Product.Name = nameTB.Text;
        Product.Description = descriptionTB.Text;
        Product.Price = priceNumeric.Value;

        DialogResult = DialogResult.OK;
        Close();
    }
}
