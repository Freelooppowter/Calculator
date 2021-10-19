namespace SimpleCalculator
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
            this.txt_NumOne = new System.Windows.Forms.TextBox();
            this.txt_NumTwo = new System.Windows.Forms.TextBox();
            this.cmb_Operator = new System.Windows.Forms.ComboBox();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.cmb_languages = new System.Windows.Forms.ComboBox();
            this.lbl_lang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_NumOne
            // 
            resources.ApplyResources(this.txt_NumOne, "txt_NumOne");
            this.txt_NumOne.BackColor = System.Drawing.SystemColors.Window;
            this.txt_NumOne.Name = "txt_NumOne";
            // 
            // txt_NumTwo
            // 
            resources.ApplyResources(this.txt_NumTwo, "txt_NumTwo");
            this.txt_NumTwo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_NumTwo.Name = "txt_NumTwo";
            // 
            // cmb_Operator
            // 
            resources.ApplyResources(this.cmb_Operator, "cmb_Operator");
            this.cmb_Operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Operator.FormattingEnabled = true;
            this.cmb_Operator.Items.AddRange(new object[] {
            resources.GetString("cmb_Operator.Items"),
            resources.GetString("cmb_Operator.Items1"),
            resources.GetString("cmb_Operator.Items2"),
            resources.GetString("cmb_Operator.Items3")});
            this.cmb_Operator.Name = "cmb_Operator";
            this.cmb_Operator.Tag = "";
            // 
            // btn_Calc
            // 
            resources.ApplyResources(this.btn_Calc, "btn_Calc");
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txt_Result
            // 
            resources.ApplyResources(this.txt_Result, "txt_Result");
            this.txt_Result.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ReadOnly = true;
            // 
            // cmb_languages
            // 
            resources.ApplyResources(this.cmb_languages, "cmb_languages");
            this.cmb_languages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_languages.FormattingEnabled = true;
            this.cmb_languages.Items.AddRange(new object[] {
            resources.GetString("cmb_languages.Items"),
            resources.GetString("cmb_languages.Items1")});
            this.cmb_languages.Name = "cmb_languages";
            this.cmb_languages.Tag = "";
            this.cmb_languages.SelectedIndexChanged += new System.EventHandler(this.cmb_languages_SelectedIndexChanged);
            // 
            // lbl_lang
            // 
            resources.ApplyResources(this.lbl_lang, "lbl_lang");
            this.lbl_lang.Name = "lbl_lang";
            // 
            // CalculatorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_lang);
            this.Controls.Add(this.cmb_languages);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.cmb_Operator);
            this.Controls.Add(this.txt_NumTwo);
            this.Controls.Add(this.txt_NumOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CalculatorForm";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NumOne;
        private System.Windows.Forms.TextBox txt_NumTwo;
        private System.Windows.Forms.ComboBox cmb_Operator;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.ComboBox cmb_languages;
        private System.Windows.Forms.Label lbl_lang;
    }
}

