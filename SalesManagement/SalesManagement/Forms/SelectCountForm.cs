namespace SalesManagement.Forms;
public partial class SelectCountForm : Form
{
    public long Count { get => (long)numericUpDown1.Value; }
    public SelectCountForm(long maxValue = long.MaxValue)
    {
        InitializeComponent();
        numericUpDown1.Maximum= maxValue;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }
}
