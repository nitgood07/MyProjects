namespace Windows_Client
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
            this.btnGetEvenNumber = new System.Windows.Forms.Button();
            this.btnGetOddNumber = new System.Windows.Forms.Button();
            this.btnClearResults = new System.Windows.Forms.Button();
            this.ListBoxEvenNumbers = new System.Windows.Forms.ListBox();
            this.ListBoxOddNumbers = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnGetEvenNumber
            // 
            this.btnGetEvenNumber.Location = new System.Drawing.Point(21, 24);
            this.btnGetEvenNumber.Name = "btnGetEvenNumber";
            this.btnGetEvenNumber.Size = new System.Drawing.Size(201, 33);
            this.btnGetEvenNumber.TabIndex = 0;
            this.btnGetEvenNumber.Text = "Get Even Numbers";
            this.btnGetEvenNumber.UseVisualStyleBackColor = true;
            this.btnGetEvenNumber.Click += new System.EventHandler(this.btnGetEvenNumber_Click);
            // 
            // btnGetOddNumber
            // 
            this.btnGetOddNumber.Location = new System.Drawing.Point(241, 24);
            this.btnGetOddNumber.Name = "btnGetOddNumber";
            this.btnGetOddNumber.Size = new System.Drawing.Size(205, 33);
            this.btnGetOddNumber.TabIndex = 1;
            this.btnGetOddNumber.Text = "Get Odd Numbers";
            this.btnGetOddNumber.UseVisualStyleBackColor = true;
            this.btnGetOddNumber.Click += new System.EventHandler(this.btnGetOddNumber_Click);
            // 
            // btnClearResults
            // 
            this.btnClearResults.Location = new System.Drawing.Point(21, 359);
            this.btnClearResults.Name = "btnClearResults";
            this.btnClearResults.Size = new System.Drawing.Size(425, 37);
            this.btnClearResults.TabIndex = 2;
            this.btnClearResults.Text = "Clear Results";
            this.btnClearResults.UseVisualStyleBackColor = true;
            this.btnClearResults.Click += new System.EventHandler(this.btnClearResults_Click);
            // 
            // ListBoxEvenNumbers
            // 
            this.ListBoxEvenNumbers.FormattingEnabled = true;
            this.ListBoxEvenNumbers.ItemHeight = 20;
            this.ListBoxEvenNumbers.Location = new System.Drawing.Point(21, 78);
            this.ListBoxEvenNumbers.Name = "ListBoxEvenNumbers";
            this.ListBoxEvenNumbers.Size = new System.Drawing.Size(201, 264);
            this.ListBoxEvenNumbers.TabIndex = 3;
            // 
            // ListBoxOddNumbers
            // 
            this.ListBoxOddNumbers.FormattingEnabled = true;
            this.ListBoxOddNumbers.ItemHeight = 20;
            this.ListBoxOddNumbers.Location = new System.Drawing.Point(241, 78);
            this.ListBoxOddNumbers.Name = "ListBoxOddNumbers";
            this.ListBoxOddNumbers.Size = new System.Drawing.Size(205, 264);
            this.ListBoxOddNumbers.TabIndex = 4;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 418);
            this.Controls.Add(this.ListBoxOddNumbers);
            this.Controls.Add(this.ListBoxEvenNumbers);
            this.Controls.Add(this.btnClearResults);
            this.Controls.Add(this.btnGetOddNumber);
            this.Controls.Add(this.btnGetEvenNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetEvenNumber;
        private System.Windows.Forms.Button btnGetOddNumber;
        private System.Windows.Forms.Button btnClearResults;
        private System.Windows.Forms.ListBox ListBoxEvenNumbers;
        private System.Windows.Forms.ListBox ListBoxOddNumbers;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

