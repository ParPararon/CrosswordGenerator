using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void ExitBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GameStartBut_Click(object sender, EventArgs e)
        {
            GameStartBut.Enabled = false;
            GameStartBut.Visible = false;
            ExitBut.Visible = false;
            ExitBut.Enabled = false;
            InfBut.Enabled = false;
            InfBut.Visible = false;

            selfgamecreatebutton();

            autogamecreatebutton();

            Button back = new Button();
            back.Name = "back";
            back.Location = new Point(122, 380);
            back.Size = new Size(98,30);
            back.Text = "Назад";
            back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            back.Click += new System.EventHandler(back_Click);
            Controls.Add(back);
        }
        private void back_Click(object sender, EventArgs e)
        {
            GameStartBut.Enabled = true;
            GameStartBut.Visible = true;
            ExitBut.Visible = true;
            ExitBut.Enabled = true;
            InfBut.Enabled = true;
            InfBut.Visible = true;
            Controls["back"].Dispose();
            Controls["SelfGameCreate"].Dispose();
            Controls["StartUserCreate"].Dispose();
            Controls["HeightInfo"].Dispose();
            Controls["HeightBox"].Dispose();

            Controls["CompGameCreate"].Dispose();
            Controls["StartAutoCreate"].Dispose();
            Controls["WordInfo"].Dispose();
            Controls["WordBox"].Dispose();
        }
        private void selfgamecreatebutton()
        {
            Button SelfGameCreate = new Button();
            SelfGameCreate.Name = "SelfGameCreate";
            SelfGameCreate.Location = new Point(27, 160);
            SelfGameCreate.Size = new Size(121, 40);
            SelfGameCreate.Text = "Создать лично";
            SelfGameCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            SelfGameCreate.Click += new System.EventHandler(SelfGameCreate_Click);
            Controls.Add(SelfGameCreate);

            Label HeightInfo = new Label();
            HeightInfo.Name = "HeightInfo";
            HeightInfo.Location = new Point(27, 230);
            HeightInfo.AutoSize = true;
            HeightInfo.Text = "Введите размеры\r\nКроссворда";
            HeightInfo.Visible = false;
            Controls.Add(HeightInfo);

            TextBox HeightBox = new TextBox();
            HeightBox.Name = "HeightBox";
            HeightBox.MaxLength = 2;
            HeightBox.Location = new Point(27, 265);
            HeightBox.Visible = false;
            HeightBox.Enabled = false;
            Controls.Add(HeightBox);

            Button StartUserCreate = new Button();
            StartUserCreate.Name = "StartUserCreate";
            StartUserCreate.Location = new Point(27, 330);
            StartUserCreate.Size = new Size(121, 35);
            StartUserCreate.Text = "Начать";
            StartUserCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            StartUserCreate.Visible = false;
            StartUserCreate.Enabled = false;
            StartUserCreate.Click += new System.EventHandler(StartUserCreate_Click);
            Controls.Add(StartUserCreate);
        }
        private void autogamecreatebutton()
        {
            Button CompGameCreate = new Button();
            CompGameCreate.Name = "CompGameCreate";
            CompGameCreate.Location = new Point(175 + 7, 160);
            CompGameCreate.Size = new Size(121, 40);
            CompGameCreate.Text = "Сгенерировать";
            CompGameCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            CompGameCreate.Click += new System.EventHandler(AutoGameCreate_click);
            Controls.Add(CompGameCreate);

            Label WordInfo = new Label();
            WordInfo.Name = "WordInfo";
            WordInfo.Location = new Point(175+7, 230);
            WordInfo.AutoSize = true;
            WordInfo.Text = "Введите количество\r\n слов";
            WordInfo.Visible = false;
            Controls.Add(WordInfo);

            TextBox WordBox = new TextBox();
            WordBox.Name = "WordBox";
            WordBox.MaxLength = 2;
            WordBox.Location = new Point(175+7, 265);
            WordBox.Visible = false;
            WordBox.Enabled = false;
            Controls.Add(WordBox);

            Button StartAutoCreate = new Button();
            StartAutoCreate.Name = "StartAutoCreate";
            StartAutoCreate.Location = new Point(175+7, 330);
            StartAutoCreate.Size = new Size(121, 35);
            StartAutoCreate.Text = "Начать";
            StartAutoCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            StartAutoCreate.Visible = false;
            StartAutoCreate.Enabled = false;
            StartAutoCreate.Click += new System.EventHandler(AutoGameCreate_click);
            Controls.Add(StartAutoCreate);

        }
        private void SelfGameCreate_Click(object sender, EventArgs e)
        {
            Controls["StartUserCreate"].Visible = true;
            Controls["StartUserCreate"].Enabled = true;

            Controls["HeightInfo"].Visible = true;

            Controls["HeightBox"].Visible = true;
            Controls["HeightBox"].Enabled = true;

            Controls["SelfGameCreate"].Click -= new System.EventHandler(SelfGameCreate_Click);

        }
        private void AutoGameCreate_click(object sender, EventArgs e)
        {
            Controls["StartAutoCreate"].Visible = true;
            Controls["StartAutoCreate"].Enabled = true;

            Controls["WordInfo"].Visible = true;

            Controls["WordBox"].Visible = true;
            Controls["WordBox"].Enabled = true;

            Controls["CompGameCreate"].Click -= new System.EventHandler(AutoGameCreate_click);
        }
        private void StartUserCreate_Click(object sender, EventArgs e)
        {
            if ((Controls["HeightBox"].Text != "" ) &&(Regex.IsMatch(Controls["HeightBox"].Text, @"^\d+$")))
            {
                UserCreate userCreate = new UserCreate(Convert.ToInt32(Controls["HeightBox"].Text),this);
                UserCreate.ShowMainAfterBack handler = new UserCreate.ShowMainAfterBack(Mainhelpfunc);
                userCreate.showback += handler;
                userCreate.Show();
                this.Hide();
            }
        }
        private void Mainhelpfunc(object sender,EventArgs e)
        {
            this.Show();
        }
    }
}
