namespace DinnerPartyCost
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
            this.numPeopleLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.fancyCheckBox = new System.Windows.Forms.CheckBox();
            this.healthyOptionCheckBox = new System.Windows.Forms.CheckBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.costDisplayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numPeopleLabel
            // 
            this.numPeopleLabel.AutoSize = true;
            this.numPeopleLabel.Location = new System.Drawing.Point(13, 13);
            this.numPeopleLabel.Name = "numPeopleLabel";
            this.numPeopleLabel.Size = new System.Drawing.Size(92, 13);
            this.numPeopleLabel.TabIndex = 0;
            this.numPeopleLabel.Text = "Number of People";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(16, 29);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // fancyCheckBox
            // 
            this.fancyCheckBox.AutoSize = true;
            this.fancyCheckBox.Checked = true;
            this.fancyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyCheckBox.Location = new System.Drawing.Point(16, 55);
            this.fancyCheckBox.Name = "fancyCheckBox";
            this.fancyCheckBox.Size = new System.Drawing.Size(115, 17);
            this.fancyCheckBox.TabIndex = 2;
            this.fancyCheckBox.Text = "Fancy Decorations";
            this.fancyCheckBox.UseVisualStyleBackColor = true;
            this.fancyCheckBox.CheckedChanged += new System.EventHandler(this.fancyCheckBox_CheckedChanged);
            // 
            // healthyOptionCheckBox
            // 
            this.healthyOptionCheckBox.AutoSize = true;
            this.healthyOptionCheckBox.Location = new System.Drawing.Point(16, 79);
            this.healthyOptionCheckBox.Name = "healthyOptionCheckBox";
            this.healthyOptionCheckBox.Size = new System.Drawing.Size(96, 17);
            this.healthyOptionCheckBox.TabIndex = 3;
            this.healthyOptionCheckBox.Text = "Healthy Option";
            this.healthyOptionCheckBox.UseVisualStyleBackColor = true;
            this.healthyOptionCheckBox.CheckedChanged += new System.EventHandler(this.healthyOptionCheckBox_CheckedChanged);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(12, 104);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(32, 13);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "Cost";
            // 
            // costDisplayLabel
            // 
            this.costDisplayLabel.BackColor = System.Drawing.Color.White;
            this.costDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costDisplayLabel.Location = new System.Drawing.Point(53, 103);
            this.costDisplayLabel.Name = "costDisplayLabel";
            this.costDisplayLabel.Size = new System.Drawing.Size(100, 14);
            this.costDisplayLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 134);
            this.Controls.Add(this.costDisplayLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.healthyOptionCheckBox);
            this.Controls.Add(this.fancyCheckBox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.numPeopleLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numPeopleLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox fancyCheckBox;
        private System.Windows.Forms.CheckBox healthyOptionCheckBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label costDisplayLabel;
    }
}

