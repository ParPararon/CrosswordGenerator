using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DefTable : Form
    {
        public delegate void defboardupdate(object sender, EventArgs e);
        public event defboardupdate update;
        public DefTable()
        {
            InitializeComponent();
        }
        public DefTable(List<crossW> wordList)
        {
            InitializeComponent();
            ColumnsStyle();
            Defshow(wordList);
        }
        private void ColumnsStyle()
        {
            DefinTable.Columns[0].Width = 50;
            DefinTable.Columns[1].Width = 100;
            DefinTable.Columns[2].Width = 181+50;
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (update != null)
            {
                update(this, EventArgs.Empty);
            }
            this.Close();
        }
        private void Defshow(List<crossW> Wordsndefs)
        {
            DefinTable.Rows.Clear();
            for(int i = 0; i < Wordsndefs.Count; i++)
            {
                DefinTable.Rows.Add();
                DefinTable.Rows[i].Cells[0].Value = i+1;
                if (Wordsndefs[i].vert) DefinTable.Rows[i].Cells[1].Value = "Вертикальное";
                else DefinTable.Rows[i].Cells[1].Value = "Горизонтальное";
                DefinTable.Rows[i].Cells[2].Value = Wordsndefs[i].wordD;
            }
        }


    }
}
