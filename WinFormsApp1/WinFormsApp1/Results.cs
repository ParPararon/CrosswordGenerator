using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources.Extensions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Results : Form
    {
        MainMenu menu;
        public Results()
        {
            InitializeComponent();
        }

        public Results(string TextGrand, int helpCount,int wordCount,int listlen,MainMenu prevwind) 
        {
            menu = prevwind;
            InitializeComponent();
            filler(TextGrand,helpCount,wordCount,listlen);
        }
        private void filler(string TextGrand, int helpCount, int wordcount,int listlen)
        {
            Grandtxt.Text = TextGrand;
            HelpCount.Text = helpCount.ToString();
            wordCount.Text = $"{listlen}/{wordcount}";
        }
        private void AnotherBackBut_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }
    }
}
