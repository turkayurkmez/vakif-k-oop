namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * Single Responsibilty: Her nesne, sadece bir işten sorumlu olmalıdır.
         * 
         * İhlali nasıl anlarım:
         * Form1 dile gelseydi, size sorumluluğunu nasıl anlatırdı?
         * 
         * 
         * 
         */


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);
            int affectedRows = new ProductService().CreateNewProduct(name, price);
            string message = affectedRows > 0 ? "Kayıt başarılı" : "İşlem başarısız";
            MessageBox.Show(message);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BackColor = dialog.Color;
            }
        }
    }
}