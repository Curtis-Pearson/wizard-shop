
namespace Assignment
{
    partial class NewItem
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
            this.ItemTypeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.CleaningMagicLabel = new System.Windows.Forms.Label();
            this.ProtectiveMagicLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CleaningMagicTextBox = new System.Windows.Forms.TextBox();
            this.ProtectiveMagicTextBox = new System.Windows.Forms.TextBox();
            this.ItemTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.FormCancelButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ItemTypeLabel
            // 
            this.ItemTypeLabel.AutoSize = true;
            this.ItemTypeLabel.Location = new System.Drawing.Point(20, 30);
            this.ItemTypeLabel.Name = "ItemTypeLabel";
            this.ItemTypeLabel.Size = new System.Drawing.Size(58, 15);
            this.ItemTypeLabel.TabIndex = 0;
            this.ItemTypeLabel.Text = "Item Type";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(20, 70);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(20, 100);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "Description";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(20, 200);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(31, 15);
            this.CostLabel.TabIndex = 6;
            this.CostLabel.Text = "Cost";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(20, 230);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(45, 15);
            this.WeightLabel.TabIndex = 8;
            this.WeightLabel.Text = "Weight";
            // 
            // CleaningMagicLabel
            // 
            this.CleaningMagicLabel.AutoSize = true;
            this.CleaningMagicLabel.Location = new System.Drawing.Point(20, 260);
            this.CleaningMagicLabel.Name = "CleaningMagicLabel";
            this.CleaningMagicLabel.Size = new System.Drawing.Size(90, 15);
            this.CleaningMagicLabel.TabIndex = 10;
            this.CleaningMagicLabel.Text = "Cleaning Magic";
            // 
            // ProtectiveMagicLabel
            // 
            this.ProtectiveMagicLabel.AutoSize = true;
            this.ProtectiveMagicLabel.Location = new System.Drawing.Point(20, 290);
            this.ProtectiveMagicLabel.Name = "ProtectiveMagicLabel";
            this.ProtectiveMagicLabel.Size = new System.Drawing.Size(96, 15);
            this.ProtectiveMagicLabel.TabIndex = 10;
            this.ProtectiveMagicLabel.Text = "Protective Magic";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(120, 65);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(120, 23);
            this.NameTextBox.TabIndex = 3;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(120, 95);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(120, 90);
            this.DescriptionTextBox.TabIndex = 5;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(120, 226);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(120, 23);
            this.WeightTextBox.TabIndex = 9;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(120, 196);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(120, 23);
            this.CostTextBox.TabIndex = 7;
            // 
            // CleaningMagicTextBox
            // 
            this.CleaningMagicTextBox.Location = new System.Drawing.Point(120, 256);
            this.CleaningMagicTextBox.Name = "CleaningMagicTextBox";
            this.CleaningMagicTextBox.Size = new System.Drawing.Size(120, 23);
            this.CleaningMagicTextBox.TabIndex = 11;
            // 
            // ProtectiveMagicTextBox
            // 
            this.ProtectiveMagicTextBox.Location = new System.Drawing.Point(120, 286);
            this.ProtectiveMagicTextBox.Name = "ProtectiveMagicTextBox";
            this.ProtectiveMagicTextBox.Size = new System.Drawing.Size(120, 23);
            this.ProtectiveMagicTextBox.TabIndex = 13;
            // 
            // ItemTypeComboBox
            // 
            this.ItemTypeComboBox.AllowDrop = true;
            this.ItemTypeComboBox.FormattingEnabled = true;
            this.ItemTypeComboBox.Location = new System.Drawing.Point(120, 30);
            this.ItemTypeComboBox.Name = "ItemTypeComboBox";
            this.ItemTypeComboBox.Size = new System.Drawing.Size(120, 23);
            this.ItemTypeComboBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(40, 326);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FormCancelButton
            // 
            this.FormCancelButton.Location = new System.Drawing.Point(150, 326);
            this.FormCancelButton.Name = "FormCancelButton";
            this.FormCancelButton.Size = new System.Drawing.Size(75, 23);
            this.FormCancelButton.TabIndex = 15;
            this.FormCancelButton.Text = "Cancel";
            this.FormCancelButton.UseVisualStyleBackColor = true;
            this.FormCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 361);
            this.Controls.Add(this.FormCancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ItemTypeComboBox);
            this.Controls.Add(this.ProtectiveMagicTextBox);
            this.Controls.Add(this.CleaningMagicTextBox);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ProtectiveMagicLabel);
            this.Controls.Add(this.CleaningMagicLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ItemTypeLabel);
            this.Name = "NewItem";
            this.Text = "Create Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemTypeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label CleaningMagicLabel;
        private System.Windows.Forms.Label ProtectiveMagicLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox CleaningMagicTextBox;
        private System.Windows.Forms.TextBox ProtectiveMagicTextBox;
        private System.Windows.Forms.ComboBox ItemTypeComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button FormCancelButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}