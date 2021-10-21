namespace SimpleCalculator.View
{
    partial class CalculatorRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorRecordForm));
            this.calculatorRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorRecordDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // calculatorRecordDataGridView
            // 
            this.calculatorRecordDataGridView.AllowUserToAddRows = false;
            this.calculatorRecordDataGridView.AllowUserToDeleteRows = false;
            this.calculatorRecordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.calculatorRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.calculatorRecordDataGridView, "calculatorRecordDataGridView");
            this.calculatorRecordDataGridView.Name = "calculatorRecordDataGridView";
            this.calculatorRecordDataGridView.ReadOnly = true;
            this.calculatorRecordDataGridView.RowTemplate.Height = 23;
            // 
            // refreshButton
            // 
            resources.ApplyResources(this.refreshButton, "refreshButton");
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // CalculatorRecordForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.calculatorRecordDataGridView);
            this.Name = "CalculatorRecordForm";
            this.Load += new System.EventHandler(this.CalculatorRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calculatorRecordDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView calculatorRecordDataGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button deleteButton;
    }
}