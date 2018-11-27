namespace DogInsuranceForm
{
    partial class DogInsuranceQuoteForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentAge = new System.Windows.Forms.MaskedTextBox();
            this.txtExpectedLife = new System.Windows.Forms.MaskedTextBox();
            this.ddlPercentCovered = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlDeductible = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlMajorClaims = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQuote = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ddlMajorClaims);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ddlDeductible);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ddlPercentCovered);
            this.groupBox1.Controls.Add(this.txtExpectedLife);
            this.groupBox1.Controls.Add(this.txtCurrentAge);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pet Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Age";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Expected Lifespan";
            // 
            // txtCurrentAge
            // 
            this.txtCurrentAge.Location = new System.Drawing.Point(150, 19);
            this.txtCurrentAge.Mask = "00000";
            this.txtCurrentAge.Name = "txtCurrentAge";
            this.txtCurrentAge.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentAge.TabIndex = 1;
            this.txtCurrentAge.TextChanged += new System.EventHandler(this.TextBoxValueChanged);
            // 
            // txtExpectedLife
            // 
            this.txtExpectedLife.Location = new System.Drawing.Point(150, 45);
            this.txtExpectedLife.Mask = "00000";
            this.txtExpectedLife.Name = "txtExpectedLife";
            this.txtExpectedLife.Size = new System.Drawing.Size(100, 20);
            this.txtExpectedLife.TabIndex = 3;
            this.txtExpectedLife.TextChanged += new System.EventHandler(this.TextBoxValueChanged);
            // 
            // ddlPercentCovered
            // 
            this.ddlPercentCovered.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPercentCovered.FormattingEnabled = true;
            this.ddlPercentCovered.Items.AddRange(new object[] {
            "60",
            "70",
            "80"});
            this.ddlPercentCovered.Location = new System.Drawing.Point(150, 71);
            this.ddlPercentCovered.Name = "ddlPercentCovered";
            this.ddlPercentCovered.Size = new System.Drawing.Size(121, 21);
            this.ddlPercentCovered.TabIndex = 5;
            this.ddlPercentCovered.SelectedIndexChanged += new System.EventHandler(this.DropDownListValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Percent Covered";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Deductible";
            // 
            // ddlDeductible
            // 
            this.ddlDeductible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDeductible.FormattingEnabled = true;
            this.ddlDeductible.Items.AddRange(new object[] {
            "250",
            "500",
            "750"});
            this.ddlDeductible.Location = new System.Drawing.Point(150, 98);
            this.ddlDeductible.Name = "ddlDeductible";
            this.ddlDeductible.Size = new System.Drawing.Size(121, 21);
            this.ddlDeductible.TabIndex = 7;
            this.ddlDeductible.SelectedIndexChanged += new System.EventHandler(this.DropDownListValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Major Claims Expected";
            // 
            // ddlMajorClaims
            // 
            this.ddlMajorClaims.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMajorClaims.FormattingEnabled = true;
            this.ddlMajorClaims.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.ddlMajorClaims.Location = new System.Drawing.Point(150, 125);
            this.ddlMajorClaims.Name = "ddlMajorClaims";
            this.ddlMajorClaims.Size = new System.Drawing.Size(121, 21);
            this.ddlMajorClaims.TabIndex = 9;
            this.ddlMajorClaims.SelectedIndexChanged += new System.EventHandler(this.DropDownListValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtQuote);
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 285);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quote";
            // 
            // txtQuote
            // 
            this.txtQuote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuote.Location = new System.Drawing.Point(6, 19);
            this.txtQuote.Multiline = true;
            this.txtQuote.Name = "txtQuote";
            this.txtQuote.ReadOnly = true;
            this.txtQuote.Size = new System.Drawing.Size(324, 260);
            this.txtQuote.TabIndex = 0;
            // 
            // DogInsuranceQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 481);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DogInsuranceQuoteForm";
            this.Text = "Dog Insurance Quote";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlPercentCovered;
        private System.Windows.Forms.MaskedTextBox txtExpectedLife;
        private System.Windows.Forms.MaskedTextBox txtCurrentAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlDeductible;
        private System.Windows.Forms.ComboBox ddlMajorClaims;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQuote;
    }
}

