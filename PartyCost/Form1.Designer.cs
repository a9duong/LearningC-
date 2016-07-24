namespace PartyCost
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.costDisplayLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.healthyOptionCheckBox = new System.Windows.Forms.CheckBox();
            this.fancyCheckBox = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numPeopleLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bActualCostLabel = new System.Windows.Forms.Label();
            this.bCostLabel = new System.Windows.Forms.Label();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.cakeWritingLabel = new System.Windows.Forms.Label();
            this.bFancyCheckbox = new System.Windows.Forms.CheckBox();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.bNumPeopleLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(162, 170);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.costDisplayLabel);
            this.tabPage1.Controls.Add(this.costLabel);
            this.tabPage1.Controls.Add(this.healthyOptionCheckBox);
            this.tabPage1.Controls.Add(this.fancyCheckBox);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.numPeopleLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(154, 144);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // costDisplayLabel
            // 
            this.costDisplayLabel.BackColor = System.Drawing.Color.White;
            this.costDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costDisplayLabel.Location = new System.Drawing.Point(46, 93);
            this.costDisplayLabel.Name = "costDisplayLabel";
            this.costDisplayLabel.Size = new System.Drawing.Size(100, 14);
            this.costDisplayLabel.TabIndex = 11;
            this.costDisplayLabel.Text = "$";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(5, 94);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(32, 13);
            this.costLabel.TabIndex = 10;
            this.costLabel.Text = "Cost";
            // 
            // healthyOptionCheckBox
            // 
            this.healthyOptionCheckBox.AutoSize = true;
            this.healthyOptionCheckBox.Location = new System.Drawing.Point(9, 69);
            this.healthyOptionCheckBox.Name = "healthyOptionCheckBox";
            this.healthyOptionCheckBox.Size = new System.Drawing.Size(96, 17);
            this.healthyOptionCheckBox.TabIndex = 9;
            this.healthyOptionCheckBox.Text = "Healthy Option";
            this.healthyOptionCheckBox.UseVisualStyleBackColor = true;
            this.healthyOptionCheckBox.CheckedChanged += new System.EventHandler(this.healthyOptionCheckBox_CheckedChanged);
            // 
            // fancyCheckBox
            // 
            this.fancyCheckBox.AutoSize = true;
            this.fancyCheckBox.Checked = true;
            this.fancyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyCheckBox.Location = new System.Drawing.Point(9, 45);
            this.fancyCheckBox.Name = "fancyCheckBox";
            this.fancyCheckBox.Size = new System.Drawing.Size(115, 17);
            this.fancyCheckBox.TabIndex = 8;
            this.fancyCheckBox.Text = "Fancy Decorations";
            this.fancyCheckBox.UseVisualStyleBackColor = true;
            this.fancyCheckBox.CheckedChanged += new System.EventHandler(this.fancyCheckBox_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(9, 19);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numPeopleLabel
            // 
            this.numPeopleLabel.AutoSize = true;
            this.numPeopleLabel.Location = new System.Drawing.Point(6, 3);
            this.numPeopleLabel.Name = "numPeopleLabel";
            this.numPeopleLabel.Size = new System.Drawing.Size(92, 13);
            this.numPeopleLabel.TabIndex = 6;
            this.numPeopleLabel.Text = "Number of People";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bActualCostLabel);
            this.tabPage2.Controls.Add(this.bCostLabel);
            this.tabPage2.Controls.Add(this.cakeWriting);
            this.tabPage2.Controls.Add(this.cakeWritingLabel);
            this.tabPage2.Controls.Add(this.bFancyCheckbox);
            this.tabPage2.Controls.Add(this.numberBirthday);
            this.tabPage2.Controls.Add(this.bNumPeopleLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(154, 144);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bActualCostLabel
            // 
            this.bActualCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bActualCostLabel.Location = new System.Drawing.Point(47, 113);
            this.bActualCostLabel.Name = "bActualCostLabel";
            this.bActualCostLabel.Size = new System.Drawing.Size(100, 13);
            this.bActualCostLabel.TabIndex = 15;
            this.bActualCostLabel.Text = "$";
            // 
            // bCostLabel
            // 
            this.bCostLabel.AutoSize = true;
            this.bCostLabel.Location = new System.Drawing.Point(12, 113);
            this.bCostLabel.Name = "bCostLabel";
            this.bCostLabel.Size = new System.Drawing.Size(28, 13);
            this.bCostLabel.TabIndex = 14;
            this.bCostLabel.Text = "Cost";
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(12, 86);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(100, 20);
            this.cakeWriting.TabIndex = 13;
            this.cakeWriting.Text = "Happy Birthday";
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
            // 
            // cakeWritingLabel
            // 
            this.cakeWritingLabel.AutoSize = true;
            this.cakeWritingLabel.Location = new System.Drawing.Point(9, 69);
            this.cakeWritingLabel.Name = "cakeWritingLabel";
            this.cakeWritingLabel.Size = new System.Drawing.Size(68, 13);
            this.cakeWritingLabel.TabIndex = 12;
            this.cakeWritingLabel.Text = "Cake Writing";
            // 
            // bFancyCheckbox
            // 
            this.bFancyCheckbox.AutoSize = true;
            this.bFancyCheckbox.Checked = true;
            this.bFancyCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bFancyCheckbox.Location = new System.Drawing.Point(9, 45);
            this.bFancyCheckbox.Name = "bFancyCheckbox";
            this.bFancyCheckbox.Size = new System.Drawing.Size(115, 17);
            this.bFancyCheckbox.TabIndex = 11;
            this.bFancyCheckbox.Text = "Fancy Decorations";
            this.bFancyCheckbox.UseVisualStyleBackColor = true;
            this.bFancyCheckbox.CheckedChanged += new System.EventHandler(this.bFancyCheckbox_CheckedChanged);
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(9, 19);
            this.numberBirthday.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(80, 20);
            this.numberBirthday.TabIndex = 10;
            this.numberBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberBirthday.ValueChanged += new System.EventHandler(this.numberBirthday_ValueChanged);
            // 
            // bNumPeopleLabel
            // 
            this.bNumPeopleLabel.AutoSize = true;
            this.bNumPeopleLabel.Location = new System.Drawing.Point(6, 3);
            this.bNumPeopleLabel.Name = "bNumPeopleLabel";
            this.bNumPeopleLabel.Size = new System.Drawing.Size(92, 13);
            this.bNumPeopleLabel.TabIndex = 9;
            this.bNumPeopleLabel.Text = "Number of People";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 190);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label costDisplayLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.CheckBox healthyOptionCheckBox;
        private System.Windows.Forms.CheckBox fancyCheckBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label numPeopleLabel;
        private System.Windows.Forms.Label bActualCostLabel;
        private System.Windows.Forms.Label bCostLabel;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label cakeWritingLabel;
        private System.Windows.Forms.CheckBox bFancyCheckbox;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.Label bNumPeopleLabel;
    }
}

