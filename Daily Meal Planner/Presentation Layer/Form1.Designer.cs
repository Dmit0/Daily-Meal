namespace MakerOfMeal
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.catecoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToDailyPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductFromGayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rationListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.gramsTrackBar = new System.Windows.Forms.TrackBar();
            this.CountRation = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gramBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.proteins_text = new System.Windows.Forms.TextBox();
            this.Fats = new System.Windows.Forms.TextBox();
            this.Carbohydrates = new System.Windows.Forms.TextBox();
            this.Calories = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.count = new System.Windows.Forms.Button();
            this.DailyNorm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gramsTrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catecoryToolStripMenuItem,
            this.productToolStripMenuItem,
            this.rationListToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(696, 24);
            this.menuStrip2.TabIndex = 40;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // catecoryToolStripMenuItem
            // 
            this.catecoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.catecoryToolStripMenuItem.Name = "catecoryToolStripMenuItem";
            this.catecoryToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.catecoryToolStripMenuItem.Text = "Catecory";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.addToolStripMenuItem.Text = "add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.deleteToolStripMenuItem.Text = "delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.deleteToolStripMenuItem1,
            this.addToDailyPlanToolStripMenuItem,
            this.deleteProductFromGayToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.addToolStripMenuItem1.Text = "add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.AddToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.deleteToolStripMenuItem1.Text = "delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.DeleteToolStripMenuItem1_Click);
            // 
            // addToDailyPlanToolStripMenuItem
            // 
            this.addToDailyPlanToolStripMenuItem.Name = "addToDailyPlanToolStripMenuItem";
            this.addToDailyPlanToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.addToDailyPlanToolStripMenuItem.Text = "add to daily plan";
            this.addToDailyPlanToolStripMenuItem.Click += new System.EventHandler(this.AddToDailyPlanToolStripMenuItem_Click);
            // 
            // deleteProductFromGayToolStripMenuItem
            // 
            this.deleteProductFromGayToolStripMenuItem.Name = "deleteProductFromGayToolStripMenuItem";
            this.deleteProductFromGayToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.deleteProductFromGayToolStripMenuItem.Text = "delete product from day";
            this.deleteProductFromGayToolStripMenuItem.Click += new System.EventHandler(this.DeleteProductFromGayToolStripMenuItem_Click);
            // 
            // rationListToolStripMenuItem
            // 
            this.rationListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2,
            this.deleteToolStripMenuItem3});
            this.rationListToolStripMenuItem.Name = "rationListToolStripMenuItem";
            this.rationListToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.rationListToolStripMenuItem.Text = "ration list";
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(106, 22);
            this.addToolStripMenuItem2.Text = "add";
            this.addToolStripMenuItem2.Click += new System.EventHandler(this.AddToolStripMenuItem2_Click);
            // 
            // deleteToolStripMenuItem3
            // 
            this.deleteToolStripMenuItem3.Name = "deleteToolStripMenuItem3";
            this.deleteToolStripMenuItem3.Size = new System.Drawing.Size(106, 22);
            this.deleteToolStripMenuItem3.Text = "delete";
            this.deleteToolStripMenuItem3.Click += new System.EventHandler(this.DeleteToolStripMenuItem3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 275);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Product panel";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.gramsTrackBar);
            this.panel2.Controls.Add(this.CountRation);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.gramBox);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.proteins_text);
            this.panel2.Controls.Add(this.Fats);
            this.panel2.Controls.Add(this.Carbohydrates);
            this.panel2.Controls.Add(this.Calories);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(12, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 286);
            this.panel2.TabIndex = 38;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Weight(gr)";
            // 
            // gramsTrackBar
            // 
            this.gramsTrackBar.Location = new System.Drawing.Point(68, 141);
            this.gramsTrackBar.Maximum = 1000;
            this.gramsTrackBar.Minimum = 1;
            this.gramsTrackBar.Name = "gramsTrackBar";
            this.gramsTrackBar.Size = new System.Drawing.Size(141, 45);
            this.gramsTrackBar.TabIndex = 51;
            this.gramsTrackBar.TabStop = false;
            this.gramsTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.gramsTrackBar.Value = 100;
            this.gramsTrackBar.Scroll += new System.EventHandler(this.GramsTrackBar_Scroll);
            // 
            // CountRation
            // 
            this.CountRation.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CountRation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountRation.Location = new System.Drawing.Point(128, 205);
            this.CountRation.Margin = new System.Windows.Forms.Padding(2);
            this.CountRation.Name = "CountRation";
            this.CountRation.ReadOnly = true;
            this.CountRation.Size = new System.Drawing.Size(69, 13);
            this.CountRation.TabIndex = 50;
            this.CountRation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "total number of calories";
            // 
            // gramBox
            // 
            this.gramBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gramBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gramBox.Location = new System.Drawing.Point(94, 101);
            this.gramBox.Margin = new System.Windows.Forms.Padding(2);
            this.gramBox.Name = "gramBox";
            this.gramBox.ReadOnly = true;
            this.gramBox.Size = new System.Drawing.Size(103, 13);
            this.gramBox.TabIndex = 48;
            this.gramBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Grams";
            // 
            // proteins_text
            // 
            this.proteins_text.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.proteins_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.proteins_text.Location = new System.Drawing.Point(94, 11);
            this.proteins_text.Margin = new System.Windows.Forms.Padding(2);
            this.proteins_text.Name = "proteins_text";
            this.proteins_text.ReadOnly = true;
            this.proteins_text.Size = new System.Drawing.Size(103, 13);
            this.proteins_text.TabIndex = 44;
            this.proteins_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Fats
            // 
            this.Fats.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Fats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Fats.Location = new System.Drawing.Point(94, 33);
            this.Fats.Margin = new System.Windows.Forms.Padding(2);
            this.Fats.Name = "Fats";
            this.Fats.ReadOnly = true;
            this.Fats.Size = new System.Drawing.Size(103, 13);
            this.Fats.TabIndex = 43;
            this.Fats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Carbohydrates
            // 
            this.Carbohydrates.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Carbohydrates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Carbohydrates.Location = new System.Drawing.Point(94, 55);
            this.Carbohydrates.Margin = new System.Windows.Forms.Padding(2);
            this.Carbohydrates.Name = "Carbohydrates";
            this.Carbohydrates.ReadOnly = true;
            this.Carbohydrates.Size = new System.Drawing.Size(103, 13);
            this.Carbohydrates.TabIndex = 42;
            this.Carbohydrates.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Calories
            // 
            this.Calories.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Calories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Calories.Location = new System.Drawing.Point(94, 78);
            this.Calories.Margin = new System.Windows.Forms.Padding(2);
            this.Calories.Name = "Calories";
            this.Calories.ReadOnly = true;
            this.Calories.Size = new System.Drawing.Size(103, 13);
            this.Calories.TabIndex = 41;
            this.Calories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 33);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Fats";
            this.label14.Click += new System.EventHandler(this.Label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 78);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Calories";
            this.label15.Click += new System.EventHandler(this.Label15_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "proteins";
            this.label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Carbohydrates";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Daily plan";
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(451, 64);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(189, 513);
            this.treeView2.TabIndex = 36;
            this.treeView2.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView2_NodeMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.count);
            this.panel1.Controls.Add(this.DailyNorm);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.WeightBox);
            this.panel1.Controls.Add(this.HeightBox);
            this.panel1.Controls.Add(this.ageBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(11, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 212);
            this.panel1.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "Fix";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "Average",
            "High"});
            this.comboBox1.Location = new System.Drawing.Point(83, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(127, 162);
            this.count.Margin = new System.Windows.Forms.Padding(2);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(44, 38);
            this.count.TabIndex = 15;
            this.count.Text = "Count";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.Count_Click);
            // 
            // DailyNorm
            // 
            this.DailyNorm.Enabled = false;
            this.DailyNorm.Location = new System.Drawing.Point(20, 172);
            this.DailyNorm.Margin = new System.Windows.Forms.Padding(2);
            this.DailyNorm.Name = "DailyNorm";
            this.DailyNorm.ReadOnly = true;
            this.DailyNorm.Size = new System.Drawing.Size(103, 20);
            this.DailyNorm.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Daily norm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Activity";
            // 
            // WeightBox
            // 
            this.WeightBox.Location = new System.Drawing.Point(83, 75);
            this.WeightBox.Margin = new System.Windows.Forms.Padding(2);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(101, 20);
            this.WeightBox.TabIndex = 15;
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(84, 47);
            this.HeightBox.Margin = new System.Windows.Forms.Padding(2);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(101, 20);
            this.HeightBox.TabIndex = 16;
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(84, 21);
            this.ageBox.Margin = new System.Windows.Forms.Padding(2);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(101, 20);
            this.ageBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Weight (kg)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Height (cm)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "User panel";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(387, 40);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 20);
            this.button5.TabIndex = 33;
            this.button5.Text = "Ок";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(256, 40);
            this.Search.Margin = new System.Windows.Forms.Padding(2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(115, 20);
            this.Search.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Searh Product";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(256, 64);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(189, 513);
            this.treeView1.TabIndex = 30;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeView1_ItemDrag);
            // 
            // ProductName
            // 
            this.ProductName.BackColor = System.Drawing.Color.MintCream;
            this.ProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductName.ForeColor = System.Drawing.Color.Transparent;
            this.ProductName.Location = new System.Drawing.Point(762, 627);
            this.ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Size = new System.Drawing.Size(103, 13);
            this.ProductName.TabIndex = 52;
            this.ProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 618);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gramsTrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem catecoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rationListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox proteins_text;
        private System.Windows.Forms.TextBox Fats;
        private System.Windows.Forms.TextBox Carbohydrates;
        private System.Windows.Forms.TextBox Calories;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.TextBox DailyNorm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.ToolStripMenuItem addToDailyPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductFromGayToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox gramBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox CountRation;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar gramsTrackBar;
        private new System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Button button2;
    }
}

