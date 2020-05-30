using System;
using MakerOfMeal.Business_Layer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakerOfMeal
{
    public partial class addCategory : Form
    {
        public addCategory()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 cat = this.Owner as Form1;
            if (CatName.Text == string.Empty)
            {
                MessageBox.Show("need to write smth", "input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            else
            {
                Category category = new Category();
                category.CategoryName = CatName.Text;
                category.Description = CatDes.Text;
                if (category.IsValid())
                {
                    Form1.service.AddCategory(category);
                    cat.treeView1.Nodes[0].Nodes.Add(category.CategoryName);
                    cat.treeView1.Refresh();
                    cat.treeView1.SelectedNode.Expand();
                    Close();
                }
                else
                {
                    MessageBox.Show("error", "input error", MessageBoxButtons.OK);
                }
            }
        }
    }
}
