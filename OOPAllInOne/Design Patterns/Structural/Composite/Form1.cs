namespace Composite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CategoryComposite<Category> categoryComposite = new CategoryComposite<Category>();
            var electronic = categoryComposite.Add(new Category("Elektronik"));
            categoryComposite.Node = electronic.Node;
            var computer = electronic.Add(new Category("Bilgisayar"));
            var laptop = computer.Add(new Category("Laptop"));
            var soundSystem = electronic.Add(new Category("Ses sistemi"));


            treeViewOnMemory.Nodes.Add("Test");

            CategoryComposite<Category>.Show(categoryComposite, treeViewOnMemory.Nodes[0]);


        }

        /*
         * Problem; arama işlemi yaptığınız bir koleksiyon içerisinde, bu işlevi daha da efektif hale getirmek isterseniz, bellek üzerinde nasıl bir yapı oluşturmanız gerekir?
         * Ya da bellekte sakladığınız karmaşık bir yapıyı başka bir alana taşımak isterseniz....
         * 
         * 
         * Çözüm: iç içe geçebilen yapılar oluştur.
         */


    }
}