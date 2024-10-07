namespace WinFormsApp1
{
    partial class UserCreate
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
            this.board = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.закончитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зановоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьСписокСловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закончитьКроссвордToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сдатьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подсказкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.AllowUserToAddRows = false;
            this.board.AllowUserToDeleteRows = false;
            this.board.AllowUserToOrderColumns = true;
            this.board.AllowUserToResizeColumns = false;
            this.board.AllowUserToResizeRows = false;
            this.board.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.board.ColumnHeadersVisible = false;
            this.board.Location = new System.Drawing.Point(20, 27);
            this.board.Name = "board";
            this.board.ReadOnly = true;
            this.board.RowHeadersVisible = false;
            this.board.RowTemplate.Height = 25;
            this.board.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.board.Size = new System.Drawing.Size(768, 545);
            this.board.TabIndex = 0;
            this.board.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.board_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закончитьToolStripMenuItem,
            this.зановоToolStripMenuItem,
            this.посмотретьСписокСловToolStripMenuItem,
            this.закончитьКроссвордToolStripMenuItem,
            this.сдатьсяToolStripMenuItem,
            this.назадToolStripMenuItem,
            this.подсказкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // закончитьToolStripMenuItem
            // 
            this.закончитьToolStripMenuItem.Name = "закончитьToolStripMenuItem";
            this.закончитьToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.закончитьToolStripMenuItem.Text = "Закончить";
            this.закончитьToolStripMenuItem.Click += new System.EventHandler(this.закончитьToolStripMenuItem_Click);
            // 
            // зановоToolStripMenuItem
            // 
            this.зановоToolStripMenuItem.Name = "зановоToolStripMenuItem";
            this.зановоToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.зановоToolStripMenuItem.Text = "Заново";
            this.зановоToolStripMenuItem.Click += new System.EventHandler(this.зановоToolStripMenuItem_Click);
            // 
            // посмотретьСписокСловToolStripMenuItem
            // 
            this.посмотретьСписокСловToolStripMenuItem.Name = "посмотретьСписокСловToolStripMenuItem";
            this.посмотретьСписокСловToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.посмотретьСписокСловToolStripMenuItem.Text = "Посмотреть список слов";
            this.посмотретьСписокСловToolStripMenuItem.Click += new System.EventHandler(this.посмотретьСписокСловToolStripMenuItem_Click);
            // 
            // закончитьКроссвордToolStripMenuItem
            // 
            this.закончитьКроссвордToolStripMenuItem.Name = "закончитьКроссвордToolStripMenuItem";
            this.закончитьКроссвордToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.закончитьКроссвордToolStripMenuItem.Text = "Закончить кроссворд";
            this.закончитьКроссвордToolStripMenuItem.Click += new System.EventHandler(this.закончитьКроссвордToolStripMenuItem_Click);
            // 
            // сдатьсяToolStripMenuItem
            // 
            this.сдатьсяToolStripMenuItem.Name = "сдатьсяToolStripMenuItem";
            this.сдатьсяToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.сдатьсяToolStripMenuItem.Text = "Сдаться";
            this.сдатьсяToolStripMenuItem.Click += new System.EventHandler(this.сдатьсяToolStripMenuItem_Click);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // подсказкаToolStripMenuItem
            // 
            this.подсказкаToolStripMenuItem.Name = "подсказкаToolStripMenuItem";
            this.подсказкаToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.подсказкаToolStripMenuItem.Text = "Подсказка";
            this.подсказкаToolStripMenuItem.Click += new System.EventHandler(this.подсказкаToolStripMenuItem_Click);
            // 
            // UserCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.ControlBox = false;
            this.Controls.Add(this.board);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserCreate";
            this.ShowIcon = false;
            this.Text = "Создание Кроссворда";
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DataGridView board;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem закончитьToolStripMenuItem;
        private ToolStripMenuItem зановоToolStripMenuItem;
        private ToolStripMenuItem посмотретьСписокСловToolStripMenuItem;
        private ToolStripMenuItem сдатьсяToolStripMenuItem;
        private ToolStripMenuItem назадToolStripMenuItem;
        private ToolStripMenuItem подсказкаToolStripMenuItem;
        private ToolStripMenuItem закончитьКроссвордToolStripMenuItem;
    }
}