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
    
    public partial class Crosshelp : Form
    {
        public string legoword;
        private bool vertical;
        private int worL;
        public Crosshelp()
        {
            InitializeComponent();
        }
        public Crosshelp(List<crossW> Crosslist,DataGridView main)
        {
            InitializeComponent();
            helpcreated(Crosslist[Crosslist.Count-1],main);
        }

        private void helpcreated(crossW joja, DataGridView main)
        {
            vertical = joja.vert;
            worL = joja.wordL;
            if (joja.vert)
            {
                helpboard.Columns.Add("", "");
                for (int i = 0; i < joja.wordL+1; i++) helpboard.Rows.Add();
                foreach (DataGridViewColumn c in helpboard.Columns)
                    c.Width = 30;
                for (int i = 0; i < joja.wordL+1; i++)
                {
                    if (main.Rows[joja.Ystart + i].Cells[joja.Xstart].Value != null)
                    {
                        if (main.Rows[joja.Ystart + i].Cells[joja.Xstart].Value.ToString().Length == 3)
                        {
                            helpboard.Rows[i].Cells[0].Value = main.Rows[joja.Ystart + i].Cells[joja.Xstart].Value.ToString()[2];
                            helpboard.Rows[i].Cells[0].ReadOnly = true;
                        }
                        else
                        {
                            helpboard.Rows[i].Cells[0].Value = main.Rows[joja.Ystart + i].Cells[joja.Xstart].Value;
                            helpboard.Rows[i].Cells[0].ReadOnly = true;
                        }
                    }
                }
                
            }
            else
            {

                for (int i = 0; i < joja.wordL+1; i++) helpboard.Columns.Add("", "");
                helpboard.Rows.Add();
                foreach (DataGridViewColumn c in helpboard.Columns)
                    c.Width = 30;
                for (int i = 0; i < joja.wordL + 1; i++)
                {
                    if (main.Rows[joja.Ystart].Cells[joja.Xstart+i].Value != null)
                    {
                        if (main.Rows[joja.Ystart].Cells[joja.Xstart + i].Value.ToString().Length == 3)
                        {
                            helpboard.Rows[0].Cells[i].Value = main.Rows[joja.Ystart].Cells[joja.Xstart + i].Value.ToString()[2];
                            helpboard.Rows[0].Cells[i].ReadOnly = true;
                        }
                        else
                        {
                            helpboard.Rows[0].Cells[i].Value = main.Rows[joja.Ystart].Cells[joja.Xstart + i].Value;
                            helpboard.Rows[0].Cells[i].ReadOnly = true;
                        }
                    }
                }

            }
            helpboard.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool closing = true;
            legoword = "";
            if (vertical)
            {
                for (int i = 0; i < worL + 1; i++)
                {
                    if (helpboard.Rows[i].Cells[0].Value == null) closing = false;
                    else legoword += helpboard.Rows[i].Cells[0].Value.ToString();
                }
            }
            else for (int i = 0; i < worL + 1; i++) 
                {
                    if (helpboard.Rows[0].Cells[i].Value == null) closing = false;
                    else legoword += helpboard.Rows[0].Cells[i].Value.ToString(); 
                }

            if(legoword.Length == worL+1 && closing)
                this.Close();
        }

        private void helpboard_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                (e.Control as TextBox).MaxLength = 1;
            }
        }
    }
}
