namespace productDB
{
    partial class Update
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
            this.txtUpdateTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateTitleBtn = new System.Windows.Forms.Button();
            this.updateCategoryBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpdateCategory = new System.Windows.Forms.TextBox();
            this.updateDescriptionBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdateDescription = new System.Windows.Forms.TextBox();
            this.updateUrlBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpdateUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUpdateTitle
            // 
            this.txtUpdateTitle.Location = new System.Drawing.Point(457, 73);
            this.txtUpdateTitle.Name = "txtUpdateTitle";
            this.txtUpdateTitle.Size = new System.Drawing.Size(160, 20);
            this.txtUpdateTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // updateTitleBtn
            // 
            this.updateTitleBtn.Location = new System.Drawing.Point(477, 99);
            this.updateTitleBtn.Name = "updateTitleBtn";
            this.updateTitleBtn.Size = new System.Drawing.Size(123, 23);
            this.updateTitleBtn.TabIndex = 2;
            this.updateTitleBtn.Text = "Atualizar nome";
            this.updateTitleBtn.UseVisualStyleBackColor = true;
            this.updateTitleBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // updateCategoryBtn
            // 
            this.updateCategoryBtn.Location = new System.Drawing.Point(477, 182);
            this.updateCategoryBtn.Name = "updateCategoryBtn";
            this.updateCategoryBtn.Size = new System.Drawing.Size(123, 23);
            this.updateCategoryBtn.TabIndex = 5;
            this.updateCategoryBtn.Text = "Atualizar categoria";
            this.updateCategoryBtn.UseVisualStyleBackColor = true;
            this.updateCategoryBtn.Click += new System.EventHandler(this.updateCategoryBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria";
            // 
            // txtUpdateCategory
            // 
            this.txtUpdateCategory.Location = new System.Drawing.Point(457, 156);
            this.txtUpdateCategory.Name = "txtUpdateCategory";
            this.txtUpdateCategory.Size = new System.Drawing.Size(160, 20);
            this.txtUpdateCategory.TabIndex = 3;
            // 
            // updateDescriptionBtn
            // 
            this.updateDescriptionBtn.Location = new System.Drawing.Point(477, 264);
            this.updateDescriptionBtn.Name = "updateDescriptionBtn";
            this.updateDescriptionBtn.Size = new System.Drawing.Size(123, 23);
            this.updateDescriptionBtn.TabIndex = 8;
            this.updateDescriptionBtn.Text = "Atualizar descrição";
            this.updateDescriptionBtn.UseVisualStyleBackColor = true;
            this.updateDescriptionBtn.Click += new System.EventHandler(this.updateDescriptionBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descrição";
            // 
            // txtUpdateDescription
            // 
            this.txtUpdateDescription.Location = new System.Drawing.Point(457, 238);
            this.txtUpdateDescription.Name = "txtUpdateDescription";
            this.txtUpdateDescription.Size = new System.Drawing.Size(160, 20);
            this.txtUpdateDescription.TabIndex = 6;
            // 
            // updateUrlBtn
            // 
            this.updateUrlBtn.Location = new System.Drawing.Point(477, 342);
            this.updateUrlBtn.Name = "updateUrlBtn";
            this.updateUrlBtn.Size = new System.Drawing.Size(123, 23);
            this.updateUrlBtn.TabIndex = 11;
            this.updateUrlBtn.Text = "Atualizar link";
            this.updateUrlBtn.UseVisualStyleBackColor = true;
            this.updateUrlBtn.Click += new System.EventHandler(this.updateUrlBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Link";
            // 
            // txtUpdateUrl
            // 
            this.txtUpdateUrl.Location = new System.Drawing.Point(457, 316);
            this.txtUpdateUrl.Name = "txtUpdateUrl";
            this.txtUpdateUrl.Size = new System.Drawing.Size(160, 20);
            this.txtUpdateUrl.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Atualizar";
            // 
            // txtProductTitle
            // 
            this.txtProductTitle.Location = new System.Drawing.Point(38, 174);
            this.txtProductTitle.Name = "txtProductTitle";
            this.txtProductTitle.Size = new System.Drawing.Size(188, 20);
            this.txtProductTitle.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nome do produto";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProductTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.updateUrlBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUpdateUrl);
            this.Controls.Add(this.updateDescriptionBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUpdateDescription);
            this.Controls.Add(this.updateCategoryBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUpdateCategory);
            this.Controls.Add(this.updateTitleBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUpdateTitle);
            this.Name = "Update";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUpdateTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateTitleBtn;
        private System.Windows.Forms.Button updateCategoryBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpdateCategory;
        private System.Windows.Forms.Button updateDescriptionBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpdateDescription;
        private System.Windows.Forms.Button updateUrlBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUpdateUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductTitle;
        private System.Windows.Forms.Label label6;
    }
}