namespace WinFormsApp1
{
    partial class Crosshelp
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
            this.helpboard = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.oprtext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.helpboard)).BeginInit();
            this.SuspendLayout();
            // 
            // helpboard
            // 
            this.helpboard.AllowUserToDeleteRows = false;
            this.helpboard.AllowUserToOrderColumns = true;
            this.helpboard.AllowUserToResizeColumns = false;
            this.helpboard.AllowUserToResizeRows = false;
            this.helpboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.helpboard.ColumnHeadersVisible = false;
            this.helpboard.Location = new System.Drawing.Point(12, 12);
            this.helpboard.Name = "helpboard";
            this.helpboard.RowHeadersVisible = false;
            this.helpboard.RowTemplate.Height = 25;
            this.helpboard.Size = new System.Drawing.Size(300, 329);
            this.helpboard.TabIndex = 0;
            this.helpboard.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.helpboard_EditingControlShowing);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "готово";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Напишите  определение";
            // 
            // oprtext
            // 
            this.oprtext.Location = new System.Drawing.Point(12, 362);
            this.oprtext.Name = "oprtext";
            this.oprtext.Size = new System.Drawing.Size(293, 23);
            this.oprtext.TabIndex = 3;
            // 
            // Crosshelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 439);
            this.ControlBox = false;
            this.Controls.Add(this.oprtext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.helpboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Crosshelp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Введите слово";
            ((System.ComponentModel.ISupportInitialize)(this.helpboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView helpboard;
        private Button button1;
        private Label label1;
        public TextBox oprtext;
    }
}