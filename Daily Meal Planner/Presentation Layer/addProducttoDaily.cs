using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MakerOfMeal.Business_Layer;

namespace MakerOfMeal
{
    public partial class addProducttoDaily : Form
    {
        public addProducttoDaily()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 prod = this.Owner as Form1;
         
            if (checkProduct(prod.treeView1.SelectedNode.Text))
            {
                if (rationName.Text == string.Empty)
                {
                    MessageBox.Show("pls input the category", "input value", MessageBoxButtons.OK);
                }
                else
                {
                    
                    Product product = Form1.service.GetProduct(prod.treeView1.SelectedNode.Text);
                  
                    if (checkMeal(rationName.Text))
                    {
                       for(int i=0;i < prod.meal.Count;i++)
                        {
                            if(prod.meal[i].MealName == rationName.Text)
                            {
                                Form1.service.AddProductM(product, prod.meal[i]);
                                
                              
                                 TreeNode SelectedNode = SearchNode(rationName.Text, prod.treeView2.Nodes[0]);
                                if (SelectedNode != null)
                                {
                                    prod.treeView2.SelectedNode = SelectedNode;
                                    prod.treeView2.Select();
                                    prod.treeView2.Nodes[i].Nodes.Clear();
                                    for (int j = 0; j < prod.meal[i].mealproducts.Count; j++)
                                    {
                                        prod.treeView2.Nodes[i].Nodes.Add(prod.meal[i].mealproducts[j].ProductName);
                                       
                                        
                                    }
                                   prod.treeView2.SelectedNode.Expand();

                                    prod.CountRation.Text = Convert.ToString(Form1.service.GetAllCalories()) + " Ccal";
                                }

                            }
                        }
                        
                        Close();


                    }   
                    else MessageBox.Show("should choose right meal name", "error", MessageBoxButtons.OK);
                }
            }
            else MessageBox.Show("should select product", "error", MessageBoxButtons.OK);


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
        private bool SearchElement(string SearchText, TreeNode StartNode)
        {
            TreeNode node = null;
            while (StartNode != null)
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    return true;
                    
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
            return false;
        }
        public bool checkMeal(string name)
        {
            return Form1.service.checkMeal(name);
        }
        private bool checkProduct(string name)
        {
            return Form1.service.CheckProduct(name);
        }
    }
}
