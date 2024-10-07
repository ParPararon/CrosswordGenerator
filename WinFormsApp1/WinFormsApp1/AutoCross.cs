using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AutoCross : Form
    {
        List<string> words = new List<string>();
        Random rnd = new Random();
        cell[,] gameChars = new cell[20, 20];
        List<cell> usedCells = new List<cell>();
        int wordCount;
        string CurWord;
        List<string> ReWrite = new List<string>();


        
        public AutoCross()
        {
            InitializeComponent();
            // test
            Fill();
            CrossGenerate();
            test();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        //Тестовая часть

        //Список дел БАЗА

        //Колизия Вроде Сделано
        //Будущее перераспределение слова
        //Определение лучшего выбора
        //проверка букв на лучший выбор

        //СЛОЖНАЯ ЧАСТЬ

        //Создание нескольких кроссвордов и выбор лучшего
        //Проверка нескольких дальнейших слов


        private void Fill()
        {
            words.Add("ПОВАР");
            words.Add("ПАРОМ");
            words.Add("АБАДОН");
            words.Add("ДОНЕЦК");
            words.Add("БАНК");
            words.Add("КОРСАР");
            wordCount = 6;
            for (int y = 0; y < 20; y++)
                for (int x = 0; x < 20; x++) 
                {
                    gameChars[y, x] = new cell();
                    gameChars[y, x].data = 'o';
                    gameChars[y, x].y = y;
                    gameChars[y, x].x = x;
                }
        }
        /* Плохая реализация
        private void lessssgo()
        {
            CurWord = words[rnd.Next(wordCount)];
            for(int i = 0; i < CurWord.Length; i++)
            {
                gameChars[10,7+i].data = CurWord[i];
                gameChars[10,7+i].state = cell.State.Hor;
                usedCells.Add(gameChars[10,7+i]);
            }
            wordCount--;
            words.Remove(CurWord);
            int a = wordCount;

            for(int i = 0; i < a*5; i++)
            {
                if(ReWrite.Count == 0)
                {
                    wordCount = words.Count;
                    int b = words.Count;
                    for (int j = 0; j < b; j++) AnWord();
                }
                else
                {
                    wordCount = ReWrite.Count;
                    int b = ReWrite.Count;
                    for(int j = 0; j < b; j++) ReAnWord();
                }
                
            }
            
        }
         */

        private void CrossGenerate()
        {
            //Случайно ставим первое слово
            CurWord = words[rnd.Next(wordCount)];
            for (int i = 0; i < CurWord.Length; i++)
            {
                gameChars[10, 7 + i].data = CurWord[i];
                gameChars[10, 7 + i].state = cell.State.Hor;
                usedCells.Add(gameChars[10, 7 + i]);
            }
            wordCount--;
            words.Remove(CurWord);
            int a = wordCount;

            //Подбираем слова по буквам
            for(int i = 0; i < a; i++)
            {
                List<string> PossibleWords = new List<string>();
                foreach (char elem in CurWord)
                {
                    for(int j = 0; j < wordCount; j++)
                    {
                        if (words[j].Contains(elem)) PossibleWords.Add(words[j]);
                    }
                }
                string BestWord;
                int BestSize;
                for(int j = 0; j < PossibleWords.Count; j++)
                {
                    
                }
            }
        }
        private void wordFill(cell joja, string Curword)
        { 
            if (joja.state == cell.State.Vert)
                for (int i = 0; i < Curword.Length; i++)
                {
                    gameChars[joja.y, joja.x - Curword.IndexOf(joja.data) + i].data = Curword[i];
                    gameChars[joja.y, joja.x - Curword.IndexOf(joja.data) + i].y = joja.y;
                    gameChars[joja.y, joja.x - Curword.IndexOf(joja.data) + i].x = joja.x - Curword.IndexOf(joja.data) + i;
                    gameChars[joja.y, joja.x - Curword.IndexOf(joja.data) + i].state = cell.State.Hor;
                }
            else 
                for (int i = 0; i < Curword.Length; i++)
                {
                    gameChars[joja.y - Curword.IndexOf(joja.data) + i, joja.x].data = Curword[i];
                    gameChars[joja.y - Curword.IndexOf(joja.data) + i, joja.x].y = joja.y - Curword.IndexOf(joja.data) + i;
                    gameChars[joja.y - Curword.IndexOf(joja.data) + i, joja.x].x = joja.x;
                    gameChars[joja.y, joja.x - Curword.IndexOf(joja.data) + i].state = cell.State.Vert;
                }
            joja.state = cell.State.Both;
        }
        private void test()
        {
            Label test = new Label();
            test.Location = new Point(10, 10);
            test.Size = new Size(500, 500);
            for (int i = 0; i < 20; i++) 
            {
                test.Text += "\r\n";
                for (int j = 0; j < 20; j++)
                    test.Text += gameChars[i,j].data.ToString()+"  ";
            }
            this.Controls.Add(test);
        }
        /* То же плохая реализация
        private void AnWord()
        {
            CurWord = words[rnd.Next(wordCount)];
            bool used = false;

            foreach (cell item in usedCells)
                if (CurWord.Contains(item.data) && item.state != cell.State.Both && collision(item,CurWord))
                {
                    wordFill(item, CurWord);
                    break;
                    used = true;
                }
            wordCount--;
            if (used) words.Remove(CurWord);
            else
            {
                ReWrite.Add(CurWord);
                words.Remove(CurWord);
            }
        }
        private void ReAnWord()
        {
            CurWord = ReWrite[rnd.Next(wordCount)];
            bool used = false;

            foreach (cell item in usedCells)
                if (CurWord.Contains(item.data) && item.state != cell.State.Both && collision(item,CurWord))
                {
                    wordFill(item, CurWord);
                    break;
                    used = true;
                }
            wordCount--;
            if (used) ReWrite.Remove(CurWord);
            else
            {
                words.Add(CurWord);
                ReWrite.Remove(CurWord);
            }
        }
        */
        private bool collision(cell joja, string Curword)
        {
            bool noword = true;
            if (joja.state == cell.State.Vert)
                for (int i = 0; i < Curword.Length; i++)
                {
                    if (joja.x != joja.x - Curword.IndexOf(joja.data) + i)
                    {
                        if (gameChars[joja.y, joja.x - Curword.IndexOf(joja.data) + i].data != 'o')
                        {
                            noword = false;
                            break;
                        }
                    }
                }
            else
                for (int i = 0; i < Curword.Length; i++)
                {
                    if (joja.y != joja.y - Curword.IndexOf(joja.data) + i)
                    {
                        if (gameChars[joja.y - Curword.IndexOf(joja.data) + i, joja.x].data != 'o')
                        {
                            noword = false;
                            break;
                        }
                    }
                        
                }
            return noword;
        }
        private int BestPosCheck()
        {
            int up = -1;
            int down = -1;
            int left = -1;
            int right = -1;
            bool gotcha;
            for (int y = 0; y < 10; y++)
            {
                gotcha = false;
                for (int x = 0; x < 10; x++)
                {
                    if (gameChars[y, x].data != 'o')
                    {
                        up = y;
                        gotcha = true;
                        break;
                    }
                }
                if (gotcha) break;
            }
            for (int y = 9; y > 0; y--)
            {
                gotcha = false;
                for (int x = 0; x < 10; x++)
                {
                    if (gameChars[y, x].data != 'o')
                    {
                        down = y;
                        gotcha = true;
                        break;
                    }
                }
                if (gotcha) break;
            }
            for (int x = 0; x < 10; x++)
            {
                gotcha = false;
                for (int y = 0; y < 10; y++)
                {
                    if (gameChars[y, x].data != 'o')
                    {
                        left = x;
                        gotcha = true;
                        break;
                    }
                }
                if (gotcha) break;
            }
            for (int x = 9; x > 0; x--)
            {
                gotcha = false;
                for (int y = 0; y < 10; y++)
                {
                    if (gameChars[y, x].data != 'o')
                    {
                        right = x;
                        gotcha = true;
                        break;
                    }
                }
                if (gotcha) break;
            }

            int ScoreSize = (right - left + 1) * (down - up + 1);
            return ScoreSize;
        }
        //конец тестовой части
    }
    public class cell
    {
        public enum State
        {
            None,
            Vert,
            Hor,
            Both,
        }
        public char data;
        public int x;
        public int y;
        public State state = State.None;
    }
}
