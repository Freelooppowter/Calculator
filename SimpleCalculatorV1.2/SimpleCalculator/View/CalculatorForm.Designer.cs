namespace SimpleCalculator.View
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.operatorCombox = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.equalLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.firstNumberTextBox, "firstNumberTextBox");
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.secondNumberTextBox, "secondNumberTextBox");
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            // 
            // operatorCombox
            // 
            this.operatorCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operatorCombox.FormattingEnabled = true;
            this.operatorCombox.Items.AddRange(new object[] {
            resources.GetString("operatorCombox.Items"),
            resources.GetString("operatorCombox.Items1"),
            resources.GetString("operatorCombox.Items2"),
            resources.GetString("operatorCombox.Items3")});
            resources.ApplyResources(this.operatorCombox, "operatorCombox");
            this.operatorCombox.Name = "operatorCombox";
            this.operatorCombox.Tag = "";
            // 
            // calculateButton
            // 
            resources.ApplyResources(this.calculateButton, "calculateButton");
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // equalLabel
            // 
            resources.ApplyResources(this.equalLabel, "equalLabel");
            this.equalLabel.Name = "equalLabel";
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.resultTextBox, "resultTextBox");
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            // 
            // CalculatorForm
            // 
            this.AcceptButton = this.calculateButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.equalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.operatorCombox);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.HandleCreated += CalculatorForm_HandleCreated;
            this.HandleDestroyed += CalculatorForm_HandleDestroyed;
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.ComboBox operatorCombox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label equalLabel;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

