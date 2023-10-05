namespace Composite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Süpürge");
            TreeNode treeNode2 = new TreeNode("Fırın");
            TreeNode treeNode3 = new TreeNode("Ev Gereçleri", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Laptop");
            TreeNode treeNode5 = new TreeNode("Bilgisayar", new TreeNode[] { treeNode4 });
            TreeNode treeNode6 = new TreeNode("Elektronik", new TreeNode[] { treeNode3, treeNode5 });
            treeView1 = new TreeView();
            treeViewOnMemory = new TreeView();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(242, 68);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Süpürge";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Fırın";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Ev Gereçleri";
            treeNode4.Name = "Node5";
            treeNode4.Text = "Laptop";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Bilgisayar";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Elektronik";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode6 });
            treeView1.Size = new Size(173, 190);
            treeView1.TabIndex = 0;
            // 
            // treeViewOnMemory
            // 
            treeViewOnMemory.Location = new Point(493, 68);
            treeViewOnMemory.Name = "treeViewOnMemory";
            treeViewOnMemory.Size = new Size(197, 190);
            treeViewOnMemory.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 444);
            Controls.Add(treeViewOnMemory);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private TreeView treeViewOnMemory;
    }
}