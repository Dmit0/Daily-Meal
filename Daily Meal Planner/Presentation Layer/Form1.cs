using System;
using MakerOfMeal.Business_Layer;
using MakerOfMeal.Service_Layer;
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
    public partial class Form1 : Form
    {
        User user = new User();
        public static readonly IService service = new Service();
        public List<Category> categories = service.GetCategories();
        public List<MealTime> meal=service.Getmealtimess();
        public TreeNode categoryRootNode = new TreeNode("Категории");
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double count = 0;
                   //MessageBox.Show(Convert.ToString(meal[1].mealproducts.Count));
                        treeView1.Nodes.Add(categoryRootNode);
                        for (int i = 0; i < categories.Count; i++)
                        {
                            categoryRootNode.Nodes.Add(categories[i].CategoryName);
                            for (int j = 0; j < categories[i].products.Count; j++)
                            {
                                categoryRootNode.Nodes[i].Nodes.Add(categories[i].products[j].ProductName);  
                            }
                        }
           
                        for (int i = 0; i < meal.Count; i++)
                        {
                            treeView2.Nodes.Add(meal[i].MealName);
               
                            for (int j = 0; j < meal[i].mealproducts.Count; j++)
                            {
                                   
                             treeView2.Nodes[i].Nodes.Add(meal[i].mealproducts[j].ProductName);
                            count += meal[i].mealproducts[j].Calories;

                            }
                        }
            CountRation.Text = Convert.ToString(count)+" Ccal";
        }
     
        private void TreeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {

            addCategory addForm = new addCategory();
            addForm.Owner = this;
            addForm.Show();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
           
           
            string name = Convert.ToString(treeView1.SelectedNode.Text);
           // MessageBox.Show(name);
            service.DeleteCategory(name);
            treeView1.SelectedNode.Remove();
        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addProduct addForm = new addProduct();
            addForm.Owner = this;
            addForm.Show();
        }

        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string name = treeView1.SelectedNode.Text;
            treeView1.SelectedNode.Remove();
            service.DeleteProduct(name, treeView1.SelectedNode.Parent.Text);
        }
        private TreeNode SearchNode(string SearchText, TreeNode StartNode)
        {
            TreeNode node = null;
            while (StartNode != null)
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    node = StartNode;
                    break;
                }
                if (StartNode.Nodes.Count != 0)
                {
                    node = SearchNode(SearchText, StartNode.Nodes[0]);
                    if (node != null)
                    {
                        break;
                    }
                }
                StartNode = StartNode.NextNode;
            }
            return node;
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            string SearchText = Search.Text;
            if (SearchText == "")
            {
                return;
            }
            TreeNode SelectedNode = SearchNode(SearchText, treeView1.Nodes[0]);
            if (SelectedNode != null)
            {
                treeView1.SelectedNode = SelectedNode;
                treeView1.SelectedNode.Expand();
                treeView1.Select();
            }
        }

        private void Count_Click(object sender, EventArgs e)
        {
            
            try
            {
                user.Age = Convert.ToInt32(ageBox.Text);
                user.Height = Convert.ToInt32(HeightBox.Text);
                user.Weight = Convert.ToInt32(WeightBox.Text);
                user.Activitytype = comboBox1.Text;
                ageBox.Enabled = false;
                HeightBox.Enabled = false;
                WeightBox.Enabled = false;
                comboBox1.Enabled = false;
                DailyNorm.Text=Convert.ToString(service.DailyColoriesCount(user) + " Ccal");
            }
            catch
            {
              
                MessageBox.Show("error", "input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void AddToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddMealTimeForm addForm = new AddMealTimeForm();
            addForm.Owner = this;
            addForm.Show();
        }

        private void DeleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(treeView2.SelectedNode.Text);
            // MessageBox.Show(name);
            service.DeleteMealTime(name);
            treeView2.SelectedNode.Remove();
          
        }

        private void DeleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void AddToDailyPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addProducttoDaily addForm = new addProducttoDaily();
            addForm.Owner = this;
            addForm.Show();
        }

        private void DeleteProductFromGayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Productname = treeView2.SelectedNode.Text;
            string MealName = treeView2.SelectedNode.Parent.Text;
            treeView2.SelectedNode.Remove();
            service.DeleteProductFromMealTime(MealName, Productname);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

              ageBox.Enabled = true;
                HeightBox.Enabled = true;
                WeightBox.Enabled = true;
                comboBox1.Enabled = true;
                
           
        } 

        private void TreeView2_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                Product product = service.GetProductFromMeal(e.Node.Text);
               
                proteins_text.Text= Convert.ToString(product.Proteins);
                Fats.Text = Convert.ToString(product.Fats);
                Carbohydrates.Text = Convert.ToString(product.Carbs);
                Calories.Text = Convert.ToString(product.Calories);
                gramBox.Text = Convert.ToString(product.Grams);
                ProductName.Text = Convert.ToString(product.ProductName);
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GramsTrackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                double StartPositioncount = service.GetAllCalories();
                Product product = service.GetProductFromMeal(ProductName.Text);
                double bufCalories = 0;
                bufCalories = (product.Calories * gramsTrackBar.Value) / product.Grams;
                product.Grams = gramsTrackBar.Value;
                gramBox.Text = Convert.ToString(product.Grams);
                StartPositioncount = StartPositioncount - product.Calories + bufCalories;
                product.Calories = bufCalories;
                Calories.Text = Convert.ToString(product.Calories);
                CountRation.Text = Convert.ToString(StartPositioncount + " Ccal");
            }
            catch
            {
                MessageBox.Show("choose the product", "Продукт не выбран", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gramsTrackBar.Value = gramsTrackBar.Minimum;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (DailyNorm.Text == string.Empty || CountRation.Text == string.Empty)
            {
                MessageBox.Show("error check your data!", "error", MessageBoxButtons.OK);
            }
            else
            {
                service.ExportRation(DailyNorm.Text, CountRation.Text, user);
                MessageBox.Show("saved", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
