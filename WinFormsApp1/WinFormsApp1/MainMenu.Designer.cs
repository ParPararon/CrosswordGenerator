namespace WinFormsApp1
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.GameStartBut = new System.Windows.Forms.Button();
            this.InfBut = new System.Windows.Forms.Button();
            this.ExitBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(95, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crossword\r\nGeneretor";
            // 
            // GameStartBut
            // 
            this.GameStartBut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameStartBut.Location = new System.Drawing.Point(64, 158);
            this.GameStartBut.Name = "GameStartBut";
            this.GameStartBut.Size = new System.Drawing.Size(212, 40);
            this.GameStartBut.TabIndex = 1;
            this.GameStartBut.Text = "Создать кроссворд";
            this.GameStartBut.UseVisualStyleBackColor = true;
            this.GameStartBut.Click += new System.EventHandler(this.GameStartBut_Click);
            // 
            // InfBut
            // 
            this.InfBut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InfBut.Location = new System.Drawing.Point(97, 228);
            this.InfBut.Name = "InfBut";
            this.InfBut.Size = new System.Drawing.Size(148, 40);
            this.InfBut.TabIndex = 2;
            this.InfBut.Text = "Инструкции";
            this.InfBut.UseVisualStyleBackColor = true;
            // 
            // ExitBut
            // 
            this.ExitBut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitBut.Location = new System.Drawing.Point(122, 301);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(98, 40);
            this.ExitBut.TabIndex = 3;
            this.ExitBut.Text = "Выход";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 441);
            this.Controls.Add(this.ExitBut);
            this.Controls.Add(this.InfBut);
            this.Controls.Add(this.GameStartBut);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crossword Generetor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button GameStartBut;
        private Button InfBut;
        private Button ExitBut;
    }
}