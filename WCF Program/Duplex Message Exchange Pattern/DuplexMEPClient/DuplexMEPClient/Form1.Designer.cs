namespace DuplexMEPClient
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
            this.btnInvoke = new System.Windows.Forms.Button();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInvoke
            // 
            this.btnInvoke.Location = new System.Drawing.Point(95, 31);
            this.btnInvoke.Name = "btnInvoke";
            this.btnInvoke.Size = new System.Drawing.Size(132, 103);
            this.btnInvoke.TabIndex = 0;
            this.btnInvoke.Text = "Invoke Duplex MEP";
            this.btnInvoke.UseVisualStyleBackColor = true;
            this.btnInvoke.Click += new System.EventHandler(this.btnInvoke_Click);
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(251, 69);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(111, 26);
            this.txtPercentage.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 207);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.btnInvoke);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvoke;
        private System.Windows.Forms.TextBox txtPercentage;
    }
}

