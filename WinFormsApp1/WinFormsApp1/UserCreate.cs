using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class UserCreate : Form
    {
        public delegate void ShowMainAfterBack(object sender, EventArgs e);
        public event ShowMainAfterBack showback;

        public int lastrow = 0;
        public int lastcol = 0;

        int boardsize;

        public List<crossW> Crosslist = new List<crossW>();
        char[,] gamechars;
        int[,] numbers;
        int helpcount = 0;

        MainMenu menu;


        
        public UserCreate()
        {
            InitializeComponent();
        }
        public UserCreate(int boardsize, MainMenu menu)
        {
            this.boardsize = boardsize;
            InitializeComponent();
            CreateBoard();
            this.menu = menu;
        }
        //Косяки в кроссворде
        //Логика наложений выполнена процентов на 30
        //Автоизмение размера шрифта
        //тоже самое и в решаемом кроссворде
        //Модуля итогов нет следовательно сдаться и проверить кроссворд не работают как надо
        public void CreateBoard()
        {
            for(int i = 0; i < boardsize; i++) 
            { 
                board.Columns.Add("","");
            }
            for (int i = 0; i < boardsize; i++)
            {
                board.Rows.Add();
            }
            
            foreach (DataGridViewColumn c in board.Columns)
                c.Width = board.Width / board.Columns.Count;
            foreach(DataGridViewRow c in board.Rows)
                c.Height = board.Height / board.Rows.Count;
            закончитьКроссвордToolStripMenuItem.Enabled = false;
            закончитьКроссвордToolStripMenuItem.Visible = false;
            сдатьсяToolStripMenuItem.Enabled = false;
            сдатьсяToolStripMenuItem.Visible = false;
            подсказкаToolStripMenuItem.Enabled = false;
            подсказкаToolStripMenuItem.Visible = false;
        }
        public void CreateGameBoard()
        {
            CreateBoard();
            GameCharsNnumbersfill();
            board.ReadOnly = false;
            board.CellDoubleClick -= new System.Windows.Forms.DataGridViewCellEventHandler(board_CellDoubleClick);
            закончитьКроссвордToolStripMenuItem.Enabled = true;
            закончитьКроссвордToolStripMenuItem.Visible = true;
            сдатьсяToolStripMenuItem.Enabled = true;
            сдатьсяToolStripMenuItem.Visible = true;
            закончитьToolStripMenuItem.Visible = false;
            закончитьToolStripMenuItem.Enabled = false;
            зановоToolStripMenuItem.Visible = false;
            зановоToolStripMenuItem.Enabled = false;
            посмотретьСписокСловToolStripMenuItem.Enabled = false;
            посмотретьСписокСловToolStripMenuItem.Visible = false;
            подсказкаToolStripMenuItem.Enabled = true;
            подсказкаToolStripMenuItem.Visible = true;
            board.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(board_EditingControlShowing);
            //не красиво ну и ладно

            for (int i = 0; i < boardsize; i++)
            {
                for (int j = 0; j < boardsize; j++)
                {
                    if (gamechars[i, j] == '0')
                    {
                        board[j,i].ReadOnly = true;
                        board[j,i].Style.BackColor = Color.Black;
                    }
                    if (numbers[i, j] != 0)
                    {
                        board.Rows[j].Cells[i].Value = numbers[i, j];
                        board.Rows[j].Cells[i].Style.BackColor = Color.Cornsilk;
                        board.Rows[j].Cells[i].ToolTipText = numbers[i, j].ToString();
                    }
                }
            }
            DefTable deftable = new DefTable(Crosslist);
            deftable.SetDesktopLocation(this.Location.X + this.Width + 1, this.Location.Y);
            deftable.menuStrip1.Visible = false;
            deftable.menuStrip1.Enabled = false;
            deftable.Show();

        }
        private void GameCharsNnumbersfill()
        {
            gamechars = new char[boardsize, boardsize];
            numbers = new int[boardsize, boardsize];
            for (int k = 0; k < boardsize; k++)
                for (int n = 0; n < boardsize; n++) { gamechars[k, n] = '0'; numbers[k, n] = 0; }

            foreach(crossW elem in Crosslist)
            {
                numbers[elem.Xstart,elem.Ystart] = Crosslist.IndexOf(elem)+1;
                for(int i=0;i < elem.wordL+1; i++)
                {
                    if (elem.vert) gamechars[elem.Ystart + i, elem.Xstart] = elem.word[i];
                    else gamechars[elem.Ystart, elem.Xstart + i] = elem.word[i];
                }
            }
        }
        private void test()
        {
            Label test = new Label();
            test.Location = new Point(10, 10);
            test.Size = new Size(500, 500);
            String test2 = "";
            for(int i = 0; i < 21; i++)
            {
                test2 += "\n";
                for(int j = 0; j < 21; j++) test2 += gamechars[i,j].ToString()+"   ";
            }
            test.Text = test2;
            this.Controls.Add(test);
            test.BringToFront();
        }
        private void board_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex == lastrow || e.ColumnIndex == lastcol) 
                && ((board.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Cornsilk)
                && (board.Rows[lastrow].Cells[lastcol].Style.BackColor == Color.Cornsilk)) == false)
            {  
                ChooseWordZone(e.RowIndex, lastrow, e.ColumnIndex, lastcol);
                WordWriteDown(Crosslist[Crosslist.Count-1]);
                ClearCellCross(lastrow, lastcol);
                lastrow = e.RowIndex;
                lastcol = e.ColumnIndex;
            }
            else
            {
                ClearCellCross(lastrow, lastcol);
                CreateCellCross(e.RowIndex, e.ColumnIndex);
                lastrow = e.RowIndex;
                lastcol = e.ColumnIndex;
            }
        }
        private void CreateCellCross(int r, int c)
        {
            //board.Rows[r].Cells[c].Style.BackColor = Color.Black;
            int counter = r-1;
            while(counter >= 0)
            {
                if (board.Rows[counter].Cells[c].Style.BackColor != Color.Cornsilk)
                    board.Rows[counter].Cells[c].Style.BackColor = Color.Gray;
                counter--;
            }
            counter = r+1;
            while (counter < board.Rows.Count)
            {
                if (board.Rows[counter].Cells[c].Style.BackColor != Color.Cornsilk)
                    board.Rows[counter].Cells[c].Style.BackColor = Color.Gray;
                counter++;
            }
            counter = c - 1;
            while (counter >= 0)
            {
                if (board.Rows[r].Cells[counter].Style.BackColor != Color.Cornsilk)
                    board.Rows[r].Cells[counter].Style.BackColor = Color.Gray;
                counter--;
            }
            counter = c + 1;
            while (counter < board.Columns.Count)
            {
                if (board.Rows[r].Cells[counter].Style.BackColor != Color.Cornsilk)
                    board.Rows[r].Cells[counter].Style.BackColor = Color.Gray;
                counter++;
            }
        }
        private void ClearCellCross(int r,int c)
        {
            if (board.Rows[r].Cells[c].Style.BackColor != Color.Cornsilk)
                board.Rows[r].Cells[c].Style.BackColor = Color.White;
            int counter = r - 1;
            while (counter >= 0)
            {
                if (board.Rows[counter].Cells[c].Style.BackColor != Color.Cornsilk)
                    board.Rows[counter].Cells[c].Style.BackColor = Color.White;
                counter--;
            }
            counter = r + 1;
            while (counter < board.Rows.Count)
            {
                if (board.Rows[counter].Cells[c].Style.BackColor != Color.Cornsilk)
                    board.Rows[counter].Cells[c].Style.BackColor = Color.White;
                counter++;
            }
            counter = c - 1;
            while (counter >= 0)
            {
                if (board.Rows[r].Cells[counter].Style.BackColor != Color.Cornsilk)
                    board.Rows[r].Cells[counter].Style.BackColor = Color.White;
                counter--;
            }
            counter = c + 1;
            while (counter < board.Columns.Count)
            {
                if (board.Rows[r].Cells[counter].Style.BackColor != Color.Cornsilk)
                    board.Rows[r].Cells[counter].Style.BackColor = Color.White;
                counter++;
            }
        }
        private void ChooseWordZone(int rn,int rl,int cn,int cl)
        {
            if(cn == cl)
            {
                if (rn > rl)
                {
                    for (int i = rl; i < rn + 1; i++)
                    {
                        board.Rows[i].Cells[cn].Style.BackColor = Color.Aqua;
                    }
                }
                else for (int i = rn; i < rl + 1; i++)
                {
                        board.Rows[i].Cells[cn].Style.BackColor = Color.Aqua;
                }
            }
            else
            {
                if (cn > cl)
                {
                    for (int i = cl; i < cn + 1; i++)
                    {
                        board.Rows[rn].Cells[i].Style.BackColor = Color.Aqua;
                    }
                }
                else for (int i = cn; i < cl+1; i++)
                { 
                        board.Rows[rn].Cells[i].Style.BackColor = Color.Aqua;
                }
            }

            int wordlenght;
            bool vert = false;
            if (cn == cl) vert = true;
            else vert = false;
            if (vert) wordlenght = Math.Max(rn, rl) - Math.Min(rn, rl);
            else wordlenght = Math.Max(cn, cl) - Math.Min(cn, cl);
            Crosslist.Add(new crossW(Math.Min(cl,cn),Math.Min(rn,rl),wordlenght,vert));

            Crosshelp secwind = new Crosshelp(Crosslist,this.board);
            secwind.FormClosing += (sender1, e1) =>
            {
                Crosslist[Crosslist.Count -1].word = secwind.legoword;
                Crosslist[Crosslist.Count-1].wordD = secwind.oprtext.Text;
            };
            secwind.ShowDialog();

        }
        public void WordWriteDown(crossW joja)
        {
            int counter;
            if (joja.vert)
            {
                counter = joja.Ystart;
                foreach (var chr in joja.word)
                {
                    board.Rows[counter].Cells[joja.Xstart].Value = chr;
                    board.Rows[counter].Cells[joja.Xstart].Style.BackColor = Color.Cornsilk;
                    counter++;
                }
            }
            else
            {
                counter = joja.Xstart;
                foreach (var chr in joja.word)
                {
                    board.Rows[joja.Ystart].Cells[counter].Value = chr;
                    board.Rows[joja.Ystart].Cells[counter].Style.BackColor = Color.Cornsilk;
                    counter++;
                }
            }
            board.Rows[joja.Ystart].Cells[joja.Xstart].Value = (Crosslist.IndexOf(joja)+1).ToString() + "|" + board.Rows[joja.Ystart].Cells[joja.Xstart].Value;
        }
        private void посмотретьСписокСловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefTable deftable = new DefTable(Crosslist);
            deftable.SetDesktopLocation(this.Location.X+this.Width+1, this.Location.Y);
            DefTable.defboardupdate handler = new DefTable.defboardupdate(Defhelpfunc);
            deftable.update += handler;
            deftable.Show();

        }
        private void Defhelpfunc(object sender, EventArgs e)
        {
            посмотретьСписокСловToolStripMenuItem.PerformClick();
        }
        private void зановоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crosslist = new List<crossW>();
            lastrow = 0;
            lastcol = 0;
            board.Rows.Clear();
            board.Columns.Clear();
            CreateBoard();
        }
        private void закончитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            board.Rows.Clear();
            board.Columns.Clear();
            CreateGameBoard();
        }
        private void сдатьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Results newResultsWin = new Results("Вы Сдались", helpcount, GameEnd(), Crosslist.Count,menu);
            newResultsWin.Show();
            this.Close();
        }
        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showback != null)
                showback(this, EventArgs.Empty);
            this.Close();
        }
        private void board_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                (e.Control as TextBox).MaxLength = 1;
            }
        }
        private int GameEnd()
        {
            int CorCount = 0;
            foreach (crossW elem in Crosslist)
            {
                bool wordCorrect = true;
                if (elem.vert)
                {
                    for(int i = 0;i < elem.wordL; i++)
                    {
                        if (board.Rows[elem.Ystart + i].Cells[elem.Xstart].Value == null)
                        {
                            wordCorrect = false;
                            break;
                        }
                        else if (board.Rows[elem.Ystart + i].Cells[elem.Xstart].Value.ToString() != gamechars[elem.Ystart+i, elem.Xstart ].ToString())
                        {
                            wordCorrect=false;
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < elem.wordL; i++)
                    {
                        if (board.Rows[elem.Ystart].Cells[elem.Xstart+i].Value == null)
                        {
                            wordCorrect = false;
                            break;
                        }
                        else if (board.Rows[elem.Ystart].Cells[elem.Xstart+i].Value.ToString() != gamechars[elem.Ystart, elem.Xstart+i].ToString())
                        {
                            wordCorrect = false;
                            break;
                        }
                    }
                }
                if (wordCorrect) CorCount++;
            }
            return CorCount;
        }
        private void подсказкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            board.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(Gameboard_CellDoubleClick);
        }
        private void Gameboard_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gamechars[e.RowIndex, e.ColumnIndex] != '0') 
            {
                board[e.ColumnIndex,e.RowIndex].Value = gamechars[e.RowIndex, e.ColumnIndex].ToString();
                board[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
                board[e.ColumnIndex, e.RowIndex].ReadOnly = true;
                board.CellDoubleClick -= new System.Windows.Forms.DataGridViewCellEventHandler(Gameboard_CellDoubleClick);
                helpcount++;
            }
        }
        private void закончитьКроссвордToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                Results newResultsWin = new Results("Результаты кроссворда", helpcount, GameEnd(), Crosslist.Count, menu);
                newResultsWin.Show();
                this.Close();
            }
        }
        private bool Check()
        {
            return false;
        }


        /*private bool collision(int rn,int rl,int cn,int cl)
{
   bool noWord = true;
   if(cn == cl)
   {
       for(int i = 0; i < (Math.Max(rn,rl)-Math.Min(rn,rl)); i++)
       {
           if (board.Rows[Math.Min(rn,rl)].Cells[cn].Value != null)
               if (board.Rows[Math.Min(rn, rl)].Cells[cn].Value.ToString().Length >=3
                   && Crosslist[Convert.ToInt32(board.Rows[Math.Min(rn, rl)].Cells[cn].Value.ToString()[0])].vert) noWord = false;
       }
   }
   else
   {
       for(int i = 0; i < (Math.Max(cn, cl) - Math.Min(cn, cl)); i++)
       {
           if (board.Rows[rn].Cells[Math.Min(cn, cl)].Value != null)
               if (board.Rows[rn].Cells[Math.Min(cn, cl)].Value.ToString().Length >= 3
                   && Crosslist[Convert.ToInt32(board.Rows[rn].Cells[Math.Min(cn, cl)].Value.ToString()[0])-1].vert) noWord = false;
       }
   }
   return noWord;
}
*/
    }
    public class crossW
    {
        public int Xstart;
        public int Ystart;
        public int wordL;
        public bool vert;
        public string word;
        public string wordD;

        public crossW(int xstart, int ystart, int wordL, bool vert)
        {
            Xstart = xstart;
            Ystart = ystart;
            this.wordL = wordL;
            this.vert = vert;
        }
    }
}
