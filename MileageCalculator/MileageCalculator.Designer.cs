namespace MileageCalculator
{
    partial class MileageCalculator
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
            this.startMileageLabel = new System.Windows.Forms.Label();
            this.endMileageLabel = new System.Windows.Forms.Label();
            this.startMileageVal = new System.Windows.Forms.NumericUpDown();
            this.endMileageVal = new System.Windows.Forms.NumericUpDown();
            this.amountOwedLabel = new System.Windows.Forms.Label();
            this.actualOwedLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.milesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startMileageVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMileageVal)).BeginInit();
            this.SuspendLayout();
            // 
            // startMileageLabel
            // 
            this.startMileageLabel.AutoSize = true;
            this.startMileageLabel.Location = new System.Drawing.Point(14, 15);
            this.startMileageLabel.Name = "startMileageLabel";
            this.startMileageLabel.Size = new System.Drawing.Size(83, 13);
            this.startMileageLabel.TabIndex = 0;
            this.startMileageLabel.Text = "Starting Mileage";
            // 
            // endMileageLabel
            // 
            this.endMileageLabel.AutoSize = true;
            this.endMileageLabel.Location = new System.Drawing.Point(17, 45);
            this.endMileageLabel.Name = "endMileageLabel";
            this.endMileageLabel.Size = new System.Drawing.Size(80, 13);
            this.endMileageLabel.TabIndex = 1;
            this.endMileageLabel.Text = "Ending Mileage";
            // 
            // startMileageVal
            // 
            this.startMileageVal.Location = new System.Drawing.Point(103, 13);
            this.startMileageVal.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.startMileageVal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startMileageVal.Name = "startMileageVal";
            this.startMileageVal.Size = new System.Drawing.Size(120, 20);
            this.startMileageVal.TabIndex = 2;
            this.startMileageVal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endMileageVal
            // 
            this.endMileageVal.Location = new System.Drawing.Point(103, 43);
            this.endMileageVal.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.endMileageVal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endMileageVal.Name = "endMileageVal";
            this.endMileageVal.Size = new System.Drawing.Size(120, 20);
            this.endMileageVal.TabIndex = 3;
            this.endMileageVal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // amountOwedLabel
            // 
            this.amountOwedLabel.AutoSize = true;
            this.amountOwedLabel.Location = new System.Drawing.Point(23, 79);
            this.amountOwedLabel.Name = "amountOwedLabel";
            this.amountOwedLabel.Size = new System.Drawing.Size(74, 13);
            this.amountOwedLabel.TabIndex = 4;
            this.amountOwedLabel.Text = "Amount Owed";
            // 
            // actualOwedLabel
            // 
            this.actualOwedLabel.AutoSize = true;
            this.actualOwedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualOwedLabel.Location = new System.Drawing.Point(103, 74);
            this.actualOwedLabel.Name = "actualOwedLabel";
            this.actualOwedLabel.Size = new System.Drawing.Size(0, 20);
            this.actualOwedLabel.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(28, 99);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // milesButton
            // 
            this.milesButton.Location = new System.Drawing.Point(156, 98);
            this.milesButton.Name = "milesButton";
            this.milesButton.Size = new System.Drawing.Size(75, 23);
            this.milesButton.TabIndex = 7;
            this.milesButton.Text = "Display Miles";
            this.milesButton.UseVisualStyleBackColor = true;
            this.milesButton.Click += new System.EventHandler(this.milesButton_Click);
            // 
            // MileageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 134);
            this.Controls.Add(this.milesButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.actualOwedLabel);
            this.Controls.Add(this.amountOwedLabel);
            this.Controls.Add(this.endMileageVal);
            this.Controls.Add(this.startMileageVal);
            this.Controls.Add(this.endMileageLabel);
            this.Controls.Add(this.startMileageLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MileageCalculator";
            this.Text = "Mileage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.startMileageVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMileageVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startMileageLabel;
        private System.Windows.Forms.Label endMileageLabel;
        private System.Windows.Forms.NumericUpDown startMileageVal;
        private System.Windows.Forms.NumericUpDown endMileageVal;
        private System.Windows.Forms.Label amountOwedLabel;
        private System.Windows.Forms.Label actualOwedLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button milesButton;
    }
}

