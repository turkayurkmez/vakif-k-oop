namespace Composite
{
    public class Category : IComparable<Category>
    {
        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(Category? other)
        {
            return this == other ? 0 : -1;
        }
    }

    public class CategoryComposite<T> where T : IComparable<T>
    {
        //Leaf: Parent olamayacak olan child nesne.
        //Non-Leaf: Parent olabilecek (child eklenebilecek) nesne.
        public T Node { get; set; }

        public List<CategoryComposite<T>> Children { get; set; } = new List<CategoryComposite<T>>();
        public CategoryComposite<T> Add(T child)
        {
            CategoryComposite<T> newCategory = new CategoryComposite<T>() { Node = child };
            Children.Add(newCategory);
            return newCategory;
        }

        public static void Show(CategoryComposite<T> composite, TreeNode rootNode)
        {
            if (composite == null)
            {
                rootNode = new TreeNode();
            }
            var treeNode = rootNode.Nodes.Add(composite.Node.ToString());
            foreach (var item in composite.Children)
            {
                Show(item, treeNode);
            }

        }
    }
}
