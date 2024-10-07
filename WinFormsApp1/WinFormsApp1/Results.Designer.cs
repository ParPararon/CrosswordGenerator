namespace WinFormsApp1
{
    partial class Results
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
            this.HelpCounttxt = new System.Windows.Forms.Label();
            this.HelpCount = new System.Windows.Forms.Label();
            this.WCtxt = new System.Windows.Forms.Label();
            this.wordCount = new System.Windows.Forms.Label();
            this.Grandtxt = new System.Windows.Forms.Label();
            this.AnatherBackBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelpCounttxt
            // 
            this.HelpCounttxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpCounttxt.AutoSize = true;
            this.HelpCounttxt.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HelpCounttxt.Location = new System.Drawing.Point(90, 157);
            this.HelpCounttxt.Name = "HelpCounttxt";
            this.HelpCounttxt.Size = new System.Drawing.Size(199, 20);
            this.HelpCounttxt.TabIndex = 0;
            this.HelpCounttxt.Text = "Использованно подсказок";
            // 
            // HelpCount
            // 
            this.HelpCount.AutoSize = true;
            this.HelpCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HelpCount.Location = new System.Drawing.Point(176, 176);
            this.HelpCount.Name = "HelpCount";
            this.HelpCount.Size = new System.Drawing.Size(19, 21);
            this.HelpCount.TabIndex = 1;
            this.HelpCount.Text = "0";
            // 
            // WCtxt
            // 
            this.WCtxt.AutoSize = true;
            this.WCtxt.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WCtxt.Location = new System.Drawing.Point(135, 249);
            this.WCtxt.Name = "WCtxt";
            this.WCtxt.Size = new System.Drawing.Size(111, 20);
            this.WCtxt.TabIndex = 2;
            this.WCtxt.Text = "Слов отгадано";
            // 
            // wordCount
            // 
            this.wordCount.AutoSize = true;
            this.wordCount.Location = new System.Drawing.Point(166, 269);
            this.wordCount.Name = "wordCount";
            this.wordCount.Size = new System.Drawing.Size(0, 15);
            this.wordCount.TabIndex = 3;
            // 
            // Grandtxt
            // 
            this.Grandtxt.AutoSize = true;
            this.Grandtxt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Grandtxt.Location = new System.Drawing.Point(115, 62);
            this.Grandtxt.Name = "Grandtxt";
            this.Grandtxt.Size = new System.Drawing.Size(61, 25);
            this.Grandtxt.TabIndex = 4;
            this.Grandtxt.Text = "label1";
            // 
            // AnatherBackBut
            // 
            this.AnatherBackBut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnatherBackBut.Location = new System.Drawing.Point(150, 373);
            this.AnatherBackBut.Name = "AnatherBackBut";
            this.AnatherBackBut.Size = new System.Drawing.Size(80, 30);
            this.AnatherBackBut.TabIndex = 5;
            this.AnatherBackBut.Text = "К меню";
            this.AnatherBackBut.UseVisualStyleBackColor = true;
            this.AnatherBackBut.Click += new System.EventHandler(this.AnotherBackBut_Click);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 451);
            this.Controls.Add(this.AnatherBackBut);
            this.Controls.Add(this.Grandtxt);
            this.Controls.Add(this.wordCount);
            this.Controls.Add(this.WCtxt);
            this.Controls.Add(this.HelpCount);
            this.Controls.Add(this.HelpCounttxt);
            this.Name = "Results";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HelpCounttxt;
        private Label HelpCount;
        private Label WCtxt;
        private Label wordCount;
        private Label Grandtxt;
        private Button AnatherBackBut;
    }
}