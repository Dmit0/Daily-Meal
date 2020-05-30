namespace MakerOfMeal
{
    partial class addProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addP = new System.Windows.Forms.Button();
            this.CaloriesBox = new System.Windows.Forms.TextBox();
            this.GramsBox = new System.Windows.Forms.TextBox();
            this.CarbsBox = new System.Windows.Forms.TextBox();
            this.FatsBox = new System.Windows.Forms.TextBox();
            this.ProteinBox = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addP
            // 
            this.addP.Location = new System.Drawing.Point(81, 240);
            this.addP.Name = "addP";
            this.addP.Size = new System.Drawing.Size(75, 23);
            this.addP.TabIndex = 27;
            this.addP.Text = "Добавить";
            this.addP.UseVisualStyleBackColor = true;
            this.addP.Click += new System.EventHandler(this.AddP_Click);
            // 
            // CaloriesBox
            // 
            this.CaloriesBox.Location = new System.Drawing.Point(169, 202);
            this.CaloriesBox.Name = "CaloriesBox";
            this.CaloriesBox.Size = new System.Drawing.Size(100, 20);
            this.CaloriesBox.TabIndex = 25;
            // 
            // GramsBox
            // 
            this.GramsBox.Location = new System.Drawing.Point(169, 176);
            this.GramsBox.Name = "GramsBox";
            this.GramsBox.Size = new System.Drawing.Size(100, 20);
            this.GramsBox.TabIndex = 24;
            // 
            // CarbsBox
            // 
            this.CarbsBox.Location = new System.Drawing.Point(169, 150);
            this.CarbsBox.Name = "CarbsBox";
            this.CarbsBox.Size = new System.Drawing.Size(100, 20);
            this.CarbsBox.TabIndex = 23;
            // 
            // FatsBox
            // 
            this.FatsBox.Location = new System.Drawing.Point(169, 124);
            this.FatsBox.Name = "FatsBox";
            this.FatsBox.Size = new System.Drawing.Size(100, 20);
            this.FatsBox.TabIndex = 22;
            // 
            // ProteinBox
            // 
            this.ProteinBox.Location = new System.Drawing.Point(169, 98);
            this.ProteinBox.Name = "ProteinBox";
            this.ProteinBox.Size = new System.Drawing.Size(100, 20);
            this.ProteinBox.TabIndex = 21;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(169, 27);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(100, 20);
            this.productName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "name of product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "proteins";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "fats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "carbohydrates";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Squirrels";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "weight(g)";
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 290);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addP);
            this.Controls.Add(this.CaloriesBox);
            this.Controls.Add(this.GramsBox);
            this.Controls.Add(this.CarbsBox);
            this.Controls.Add(this.FatsBox);
            this.Controls.Add(this.ProteinBox);
            this.Controls.Add(this.productName);
            this.Name = "addProduct";
            this.Text = "addProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addP;
        private System.Windows.Forms.TextBox CaloriesBox;
        private System.Windows.Forms.TextBox GramsBox;
        private System.Windows.Forms.TextBox CarbsBox;
        private System.Windows.Forms.TextBox FatsBox;
        private System.Windows.Forms.TextBox ProteinBox;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}