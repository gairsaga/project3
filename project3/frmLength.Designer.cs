namespace project3
{
    partial class frmLength
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
            this.txtMilliMeters = new System.Windows.Forms.TextBox();
            this.txtInches = new System.Windows.Forms.TextBox();
            this.lblMillimeters = new System.Windows.Forms.Label();
            this.lblInches = new System.Windows.Forms.Label();
            this.lblConvertedLength = new System.Windows.Forms.Label();
            this.lblConvertedLength2 = new System.Windows.Forms.Label();
            this.btnImperialLength = new System.Windows.Forms.Button();
            this.lblMetricOutput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnMetricLength = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMilliMeters
            // 
            this.txtMilliMeters.Location = new System.Drawing.Point(12, 28);
            this.txtMilliMeters.Name = "txtMilliMeters";
            this.txtMilliMeters.Size = new System.Drawing.Size(100, 20);
            this.txtMilliMeters.TabIndex = 0;
            this.txtMilliMeters.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtInches
            // 
            this.txtInches.Location = new System.Drawing.Point(15, 152);
            this.txtInches.Name = "txtInches";
            this.txtInches.Size = new System.Drawing.Size(100, 20);
            this.txtInches.TabIndex = 1;
            this.txtInches.TextChanged += new System.EventHandler(this.txtInches_TextChanged);
            // 
            // lblMillimeters
            // 
            this.lblMillimeters.AutoSize = true;
            this.lblMillimeters.ForeColor = System.Drawing.Color.Black;
            this.lblMillimeters.Location = new System.Drawing.Point(9, 9);
            this.lblMillimeters.Name = "lblMillimeters";
            this.lblMillimeters.Size = new System.Drawing.Size(134, 13);
            this.lblMillimeters.TabIndex = 2;
            this.lblMillimeters.Text = "Enter a length in millimeters";
            this.lblMillimeters.Click += new System.EventHandler(this.lblMillimeters_Click);
            // 
            // lblInches
            // 
            this.lblInches.AutoSize = true;
            this.lblInches.Location = new System.Drawing.Point(12, 136);
            this.lblInches.Name = "lblInches";
            this.lblInches.Size = new System.Drawing.Size(118, 13);
            this.lblInches.TabIndex = 3;
            this.lblInches.Text = "Enter a length in inches";
            // 
            // lblConvertedLength
            // 
            this.lblConvertedLength.AutoSize = true;
            this.lblConvertedLength.Location = new System.Drawing.Point(166, 28);
            this.lblConvertedLength.Name = "lblConvertedLength";
            this.lblConvertedLength.Size = new System.Drawing.Size(92, 13);
            this.lblConvertedLength.TabIndex = 4;
            this.lblConvertedLength.Text = "Converted Length";
            // 
            // lblConvertedLength2
            // 
            this.lblConvertedLength2.AutoSize = true;
            this.lblConvertedLength2.Location = new System.Drawing.Point(180, 136);
            this.lblConvertedLength2.Name = "lblConvertedLength2";
            this.lblConvertedLength2.Size = new System.Drawing.Size(92, 13);
            this.lblConvertedLength2.TabIndex = 5;
            this.lblConvertedLength2.Text = "Converted Length";
            // 
            // btnImperialLength
            // 
            this.btnImperialLength.Location = new System.Drawing.Point(12, 212);
            this.btnImperialLength.Name = "btnImperialLength";
            this.btnImperialLength.Size = new System.Drawing.Size(134, 23);
            this.btnImperialLength.TabIndex = 6;
            this.btnImperialLength.Text = "Find Imperial Length";
            this.btnImperialLength.UseVisualStyleBackColor = true;
            this.btnImperialLength.Click += new System.EventHandler(this.btnImperialLength_Click);
            // 
            // lblMetricOutput
            // 
            this.lblMetricOutput.AutoSize = true;
            this.lblMetricOutput.Location = new System.Drawing.Point(169, 45);
            this.lblMetricOutput.Name = "lblMetricOutput";
            this.lblMetricOutput.Size = new System.Drawing.Size(31, 13);
            this.lblMetricOutput.TabIndex = 7;
            this.lblMetricOutput.Text = "_ _ _";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(180, 175);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(31, 13);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "_ _ _";
            // 
            // btnMetricLength
            // 
            this.btnMetricLength.Location = new System.Drawing.Point(12, 69);
            this.btnMetricLength.Name = "btnMetricLength";
            this.btnMetricLength.Size = new System.Drawing.Size(128, 23);
            this.btnMetricLength.TabIndex = 9;
            this.btnMetricLength.Text = "Find Metric Length";
            this.btnMetricLength.UseVisualStyleBackColor = true;
            this.btnMetricLength.Click += new System.EventHandler(this.btnMetricLength_Click);
            // 
            // frmLength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMetricLength);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblMetricOutput);
            this.Controls.Add(this.btnImperialLength);
            this.Controls.Add(this.lblConvertedLength2);
            this.Controls.Add(this.lblConvertedLength);
            this.Controls.Add(this.lblInches);
            this.Controls.Add(this.lblMillimeters);
            this.Controls.Add(this.txtInches);
            this.Controls.Add(this.txtMilliMeters);
            this.Name = "frmLength";
            this.Text = "Length Converter";
            this.Load += new System.EventHandler(this.frmLength_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMilliMeters;
        private System.Windows.Forms.TextBox txtInches;
        private System.Windows.Forms.Label lblMillimeters;
        private System.Windows.Forms.Label lblInches;
        private System.Windows.Forms.Label lblConvertedLength;
        private System.Windows.Forms.Label lblConvertedLength2;
        private System.Windows.Forms.Button btnImperialLength;
        private System.Windows.Forms.Label lblMetricOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnMetricLength;
    }
}

