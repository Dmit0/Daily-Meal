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
    public partial class AddMealTimeForm : Form
    {
        public AddMealTimeForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form1 ration = this.Owner as Form1;
            if (NameBox.Text == string.Empty)
            {
                
                MessageBox.Show("error", "input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MealTime mealtime = new MealTime(NameBox.Text);
                Form1.service.AddMealtime(mealtime);
                ration.treeView2.Nodes.Add(mealtime.MealName);
                Close();
            }
        }

        private void AddMealTimeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
