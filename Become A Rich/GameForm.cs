using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Become_A_Rich
{
    public partial class GameForm : Form
    {
        SoundPlayer gameMusic = new SoundPlayer();
       
        List<string> hignscore = new List<string>();
        readonly string filePath = "highscore.txt";

        bool answer = false;
       
        int ansnum = 1;
        int winpoints = 0;
        int jok;

        int priceWin;
        int price;

       public GameForm()
        {
            InitializeComponent();

            gameMusic.SoundLocation = "gamesound.wav";
            gameMusic.Play();
        }

        private bool RenderQuestion(int number)
        {
            switch (number)
            {
                case 1:
                    LbQues.Text = " Кой е първият американски президент? ";
                    BtAnswer1.Text = " A: " + " Джон Адамс ";
                    BtAnswer2.Text = " B: " + " Мартин Ван Бурен ";
                    BtAnswer3.Text = " C: " + " Джордж Вашингтон ";
                    BtAnswer4.Text = " D: " + " Хари С. Труман ";
                    if (BtAnswer3.Checked)
                    {
                        answer = true;
                    
                    }
                    break;
                case 2:
                    LbQues.Text = " Кога започва строителството на Берлинската стена? ";
                    BtAnswer1.Text = " A: " + " 13.08.1961 г. ";
                    BtAnswer2.Text = " B: " + " 23.11.1965 г. ";
                    BtAnswer3.Text = " C: " + " 06.08.1957 г. ";
                    BtAnswer4.Text = " D: " + " 19.03.1986 г. ";
                    if (BtAnswer1.Checked)
                    {
                        answer = true;
                     
                    }
                    break;
                case 3:
                    LbQues.Text = " Коя е най-дългата река в България? ";
                    BtAnswer1.Text = " A: " + " Дунав ";
                    BtAnswer2.Text = " B: " + "	Искър ";
                    BtAnswer3.Text = " C: " + " Белица ";
                    BtAnswer4.Text = " D: " + " Тимок ";
                    if (BtAnswer2.Checked)
                    {
                        answer = true;
                      
                    }
                    break;
                case 4:
                    LbQues.Text = " Как се казва първият албум на легендарната група Beatles? ";
                    BtAnswer1.Text = " A: " + " Beatles ";
                    BtAnswer2.Text = " B: " + " Oxfam ";
                    BtAnswer3.Text = " C: " + " Glass Onion ";
                    BtAnswer4.Text = " D: " + " I Want to Hold Your Hand ";
                    if (BtAnswer4.Checked)
                    {
                        answer = true;
                       
                    }
                    break;
                case 5:
                    LbQues.Text = " През коя година е Съединението на България? ";
                    BtAnswer1.Text = " A: " + " 21.11.1889 г. ";
                    BtAnswer2.Text = " B: " + " 06.09.1885 г. ";
                    BtAnswer3.Text = " C: " + " 05.02.1901 г. ";
                    BtAnswer4.Text = " D: " + " 19.04.1882 г. ";
                    if (BtAnswer2.Checked)
                    {
                        answer = true;
               
                    }
                    break;
                case 6:
                    LbQues.Text = " В кой град започва да функционира първото метро в света? ";
                    BtAnswer1.Text = " A: " + " Будапеща ";
                    BtAnswer2.Text = " B: " + " Берлин ";
                    BtAnswer3.Text = " C: " + " Лондон ";
                    BtAnswer4.Text = " D: " + " Москва ";
                    if (BtAnswer1.Checked)
                    {
                        answer = true;
                   
                    }
                    break;
                case 7:
                    LbQues.Text = " Рига е столицата на? ";
                    BtAnswer1.Text = " A: " + " Естония ";
                    BtAnswer2.Text = " B: " + " Литва ";
                    BtAnswer3.Text = " C: " + " Кипър ";
                    BtAnswer4.Text = " D: " + " Латвия ";
                    if (BtAnswer4.Checked)
                    {
                        answer = true;
                  
                    }
                    break;
                case 8:
                    LbQues.Text = " При кой български владетел започват да се секат първите монети? ";
                    BtAnswer1.Text = " A: " + " Цар Симеон Велики ";
                    BtAnswer2.Text = " B: " + " Цар Иван Асен II  ";
                    BtAnswer3.Text = " C: " + " Хан Тервел ";
                    BtAnswer4.Text = " D: " + " Княз Борис I ";
                    if (BtAnswer2.Checked)
                    {
                        answer = true;
                       
                    }
                    break;
                case 9:
                    LbQues.Text = " Кой произнася известната реч “I have a dream” през 1963г.? ";
                    BtAnswer1.Text = " A: " + " Уинстън Чърчил ";
                    BtAnswer2.Text = " B: " + " Хари С. Труман ";
                    BtAnswer3.Text = " C: " + " Мартин Лутър Кинг ";
                    BtAnswer4.Text = " D: " + " Джордж VI ";
                    if (BtAnswer3.Checked)
                    {
                        answer = true;
                    
                    }
                    break;
                case 10:
                    LbQues.Text = " Коя страна е най-голяма по територия и покрива една осма от площта на Земята ? ";
                    BtAnswer1.Text = " A: " + " Русия ";
                    BtAnswer2.Text = " B: " + " Канада ";
                    BtAnswer3.Text = " C: " + " Китай ";
                    BtAnswer4.Text = " D: " + " САЩ ";
                    if (BtAnswer1.Checked)
                    {
                        answer = true;
                    
                    }
                    break;
                case 11:
                    LbQues.Text = " От какво животно произлиза името на Канарските острови? ";
                    BtAnswer1.Text = " A: " + " Заек ";
                    BtAnswer2.Text = " B: " + " Насекомо ";
                    BtAnswer3.Text = " C: " + " Риба ";
                    BtAnswer4.Text = " D: " + " Куче ";
                    if (BtAnswer4.Checked)
                    {
                        answer = true;
                      
                    }
                    break;
                case 12:
                    LbQues.Text = " Кой е най-силният мускул в човешкото тяло? ";
                    BtAnswer1.Text = " A: " + " Езикът ";
                    BtAnswer2.Text = " B: " + " Щитопирамидния мускул  ";
                    BtAnswer3.Text = " C: " + " Прешленните мускулии ";
                    BtAnswer4.Text = " D: " + " Трицепсът ";
                    if (BtAnswer1.Checked)
                    {
                        answer = true;
                    
                    }
                    break;
                case 13:
                    LbQues.Text = " Кой измисля парашутът през 1515 година? ";
                    BtAnswer1.Text = " A: " + " Алберт Айнщайн ";
                    BtAnswer2.Text = " B: " + " Петър Зукуманович ";
                    BtAnswer3.Text = " C: " + " Леонардо да Винчи ";
                    BtAnswer4.Text = " D: " + " Джеймс Кук ";
                    if (BtAnswer3.Checked)
                    {
                        answer = true;
               
                    }
                    break;
                case 14:
                    LbQues.Text = " През 1938г. Адолф Хитлер оглавява класация на списание TIME. Коя е тя ? ";
                    BtAnswer1.Text = " A: " + " Мъж на годината ";
                    BtAnswer2.Text = " B: " + " Най-великите дърважни глави ";
                    BtAnswer3.Text = " C: " + " Зъл тиранин ";
                    BtAnswer4.Text = " D: " + " Най-добри военни успехи ";
                    if (BtAnswer1.Checked)
                    {
                        answer = true;
                     
                    }
                    break;
                case 15:
                    LbQues.Text = " Кой е градът с най-много мостове в света - над 2300? ";
                    BtAnswer1.Text = " A: " + " Виена ";
                    BtAnswer2.Text = " B: " + " Хамбург ";
                    BtAnswer3.Text = " C: " + " Лион ";
                    BtAnswer4.Text = " D: " + " Париж ";
                    if (BtAnswer2.Checked)
                    {
                        answer = true;
                     
                    }
                    break;
            }

            return answer;

        }

        private int PriceWin(int number)
        {
            switch (number)
            {
                case 1:
                    priceWin = 50;
                    break;
                case 2:
                    priceWin = 100;
                    break;
                case 3:
                    priceWin = 150;
                    break;
                case 4:
                    priceWin = 200;
                    break;
                case 5:
                    priceWin = 250;
                    break;
                case 6:
                    priceWin = 500;
                    break;
                case 7:
                    priceWin = 1000;
                    break;
                case 8:
                    priceWin = 1500;
                    break;
                case 9:
                    priceWin = 2000;
                    break;
                case 10:
                    priceWin = 2500;
                    break;
                case 11:
                    priceWin = 5000;
                    break;
                case 12:
                    priceWin = 10000;
                    break;
                case 13:
                    priceWin = 25000;
                    break;
                case 14:
                    priceWin = 50000;
                    break;
                case 15:
                    priceWin = 100000;
                    break;
            }

            return priceWin;
        }

        private int RenderAnswer(int number)
        {
            switch (number)
            {
                case 1:
                    jok = 3;
                    break;
                case 2:
                    jok = 1;
                    break;
                case 3:
                    jok = 2;
                    break;
                case 4:
                    jok = 4;
                    break;
                case 5:
                    jok = 2;
                    break;
                case 6:
                    jok = 1;
                    break;
                case 7:
                    jok = 4;
                    break;
                case 8:
                    jok = 2;
                    break;
                case 9:
                    jok = 3;
                    break;
                case 10:
                    jok = 1;
                    break;
                case 11:
                    jok = 4;
                    break;
                case 12:
                    jok = 1;
                    break;
                case 13:
                    jok = 3;
                    break;
                case 14:
                    jok = 1;
                    break;
                case 15:
                    jok = 2;
                    break;
            }

            return jok;
        }

        private void SaveScore(int price)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(price);

                sw.Close();
            }
            hignscore.Add(price.ToString());
            MessageBox.Show("Поздравления, Вие спечелихте: " + price + " лева !", "Поздравления", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            gameMusic.Stop();
        }
        private void Become_a_richForm2_Load(object sender, EventArgs e)
        {
            RenderQuestion(ansnum);
            RenderAnswer(ansnum);

             FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);

            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                hignscore.Add(line);
            }
            sr.Close();

            string[] score = hignscore.ToArray();
            int max = Convert.ToInt32(score[0]);

            for (int i = 0; i < score.Length; i++)
            {
                if (Convert.ToInt32(score[i]) > max)
                {
                    max = Convert.ToInt32(score[i]);

                }

            }
            LblHighscore.Text += max.ToString();
        }

        private void Answer_button_Click(object sender, EventArgs e)
        {
            RenderQuestion(ansnum);

            if (answer == true)
            {
                winpoints += 1;
                PriceWin(winpoints);

                BtAnswer1.BackColor = Color.Black;
                BtAnswer2.BackColor = Color.Black;
                BtAnswer3.BackColor = Color.Black;
                BtAnswer4.BackColor = Color.Black;
                ((RadioButton)sender).BackColor = Color.Green;

                answer = false;
                ansnum += 1;

                RenderQuestion(ansnum);
                RenderAnswer(ansnum);

                LbPriceWin.Items.Add(priceWin);

                if (priceWin == 100000)
                {
                    SaveScore(priceWin);
                }
                
            }

            else
            {
                BtAnswer1.BackColor = Color.Black;
                BtAnswer2.BackColor = Color.Black;
                BtAnswer3.BackColor = Color.Black;
                BtAnswer4.BackColor = Color.Black;
                ((RadioButton)sender).BackColor = Color.Red;

               
                if (priceWin < 500)
                {
                    price = 0;
                }
                if (priceWin >= 500 && priceWin < 2500)
                {
                    price = 500;
                }
                if (priceWin >= 2500 && priceWin < 100000)
                {
                    price = 2500;
                }
                

                SaveScore(price);
                
            }

          }

        private void PbJoker1_Click(object sender, EventArgs e)
        {
            PbJoker1.Visible = false;
            PbJoker1Active.Visible = true;

            RenderAnswer(ansnum);

            int remove1 = jok;
            int remove2 = jok;

            if (jok == 1)
            {
                remove1 += 1;
                remove2 += 2;
            }
            if (jok == 4)
            {
                remove1 -= 1;
                remove2 -= 2;
            }
            if (jok != 1 && jok != 4)
            {
                remove1 -= 1;
                remove2 += 1;
            }

            switch (remove1)
            {
                case 1:
                    BtAnswer1.Text = string.Empty;
                    break;
                case 2:
                    BtAnswer2.Text = string.Empty;
                    break;
                case 3:
                    BtAnswer3.Text = string.Empty;
                    break;
                case 4:
                    BtAnswer4.Text = string.Empty;
                    break;
            }

            switch (remove2)
            {
                case 1:
                    BtAnswer1.Text = string.Empty;
                    break;
                case 2:
                    BtAnswer2.Text = string.Empty;
                    break;
                case 3:
                    BtAnswer3.Text = string.Empty;
                    break;
                case 4:
                    BtAnswer4.Text = string.Empty;
                    break;
            }


        }

        private void PbJoker2_Click(object sender, EventArgs e)
        {
            PbJoker2.Visible = false;
            PbJoker2Active.Visible = true;

            LbJokers3Answer1.Visible = false;
            LbJokers3Answer2.Visible = false;
            LbJokers3Answer3.Visible = false;
            LbJokers3Answer4.Visible = false;

            Random rnd = new Random();
            int jokNum = rnd.Next(1, 5);

            string jokAns;
            string name;

            switch (jokNum)
            {
                case 1:
                    jokAns = " Отговор B ";
                    name = " - Иван:";
                    LbJokers2Answer.Text = name + jokAns;
                    break;
                case 2:
                    jokAns = " Отговор D ";
                    name = " - Тошо:";
                    LbJokers2Answer.Text = name + jokAns;
                    break;
                case 3:
                    jokAns = " Отговор A ";
                    name = " - Петър:";
                    LbJokers2Answer.Text = name + jokAns;
                    break;
                case 4:
                    jokAns = " Отговор C ";
                    name = " - Жоро:";
                    LbJokers2Answer.Text = name + jokAns;
                    break;
            }

            TimerJokers.Start();
        }

        private void PbJoker3_Click(object sender, EventArgs e)
        {
            PbJoker3.Visible = false;
            PbJoker3Active.Visible = true;

            Random rnd = new Random();
            int vote1 = rnd.Next(1, 101);
            int vote2 = rnd.Next(1, (101 - vote1));
            int vote3 = rnd.Next(1, ((101 - vote1) - vote2));
            int vote4 = rnd.Next(1, (((101 - vote1) - vote2) - vote3));


            LbJokers3Answer1.Text = " Отговор A: " + vote1 + "%";
            LbJokers3Answer2.Text = " Отговор B: " + vote2 + "%";
            LbJokers3Answer3.Text = " Отговор C: " + vote3 + "%";
            LbJokers3Answer4.Text = " Отговор D: " + vote4 + "%";

            TimerJokers.Start();
        }

        private void TimerJokers_Tick(object sender, EventArgs e)
        {
            LbJokers2Answer.Text = string.Empty;
            LbJokers3Answer1.Text = string.Empty;
            LbJokers3Answer2.Text = string.Empty;
            LbJokers3Answer3.Text = string.Empty;
            LbJokers3Answer4.Text = string.Empty;
        }

        private void PbTakeMoney_Click(object sender, EventArgs e)
        {
            PriceWin(winpoints);
            SaveScore(priceWin);
        }

        private void PbMute_Click(object sender, EventArgs e)
        {
            gameMusic.Stop();
            PbMute.Visible = false;
            PbUnmute.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gameMusic.Play();
            PbUnmute.Visible = false;
            PbMute.Visible = true;
        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Играта „Стани богат“ е базирана на класическия ТВ формат: Задават се 15 въпроса с правото на 3 жокера („50/50“, „Помощ от публиката“ и „Обади се на приятел“). Голямата награда, за която участникът се бори, е 100 000 лева, а сигурните суми са 500 лв. (на 6-и въпрос) и 2 500 лв. (на 10-и въпрос). Участникът може да се откаже след всеки въпрос, и вземе спечелената до момента сума.","Правила",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void разработчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Играта е разработена на базата на телевизионната реалити игра „Стани богат“. Разработчик: Бейхан Топчиев. Специалност: СТД, I-ви курс. Фак.№1801681090","Разработчик", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
