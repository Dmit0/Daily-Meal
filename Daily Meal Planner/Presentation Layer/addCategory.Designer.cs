namespace MakerOfMeal
{
    partial class addCategory
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
            this.button1 = new System.Windows.Forms.Button();
            this.CatDes = new System.Windows.Forms.TextBox();
            this.CatName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 129);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 24);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CatDes
            // 
            this.CatDes.Location = new System.Drawing.Point(185, 89);
            this.CatDes.Margin = new System.Windows.Forms.Padding(2);
            this.CatDes.Name = "CatDes";
            this.CatDes.Size = new System.Drawing.Size(226, 20);
            this.CatDes.TabIndex = 13;
            // 
            // CatName
            // 
            this.CatName.Location = new System.Drawing.Point(185, 54);
            this.CatName.Margin = new System.Windows.Forms.Padding(2);
            this.CatName.Name = "CatName";
            this.CatName.Size = new System.Drawing.Size(226, 20);
            this.CatName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Category name";
            // 
            // addCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 180);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CatDes);
            this.Controls.Add(this.CatName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addCategory";
            this.Text = "addCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox CatDes;
        public System.Windows.Forms.TextBox CatName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}