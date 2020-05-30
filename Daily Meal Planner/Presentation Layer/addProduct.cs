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
    public partial class addProduct : Form
    {
        public addProduct()
        {
            InitializeComponent();
        }

        private void AddP_Click(object sender, EventArgs e)
        {
            Form1 prod = this.Owner as Form1;
            int grams = 0;
            double protein = 0;
            double fats = 0;
            double calories = 0;
            double carbs = 0;
            if (productName.Text == string.Empty || ProteinBox.Text == string.Empty || GramsBox.Text == string.Empty || FatsBox.Text == string.Empty || CaloriesBox.Text == string.Empty || CarbsBox.Text == string.Empty || !double.TryParse(ProteinBox.Text, out protein) || !int.TryParse(GramsBox.Text, out grams) || !double.TryParse(FatsBox.Text, out fats) || !double.TryParse(CaloriesBox.Text, out calories) || !double.TryParse(CarbsBox.Text, out carbs))
            {              
                MessageBox.Show("error", "input data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Product product = new Product();
                product.ProductName = productName.Text;
                product.Grams = int.Parse(GramsBox.Text);
                product.Proteins = double.Parse(ProteinBox.Text);
                product.Fats = double.Parse(FatsBox.Text);
                product.Carbs = double.Parse(CarbsBox.Text);
                product.Calories = double.Parse(CaloriesBox.Text);
                if (product.IsValid())
                {
                    int index = prod.treeView1.SelectedNode.Index;
                    if (prod.treeView1.SelectedNode.Parent == prod.categoryRootNode)
                    {
                        Form1.service.AddProduct(product, prod.treeView1.SelectedNode.Text);
                    }
                    else
                    {
                        Form1.service.AddProduct(product, prod.treeView1.SelectedNode.Parent.Text);
                        index = prod.treeView1.SelectedNode.Parent.Index;
                    }
                    prod.categoryRootNode.Nodes[index].Nodes.Add(product.ProductName);
                    prod.treeView1.Refresh();
                    prod.treeView1.SelectedNode.Expand();
                    Close();
                }
                else
                {
                    MessageBox.Show("error", "input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
         
    }
}
