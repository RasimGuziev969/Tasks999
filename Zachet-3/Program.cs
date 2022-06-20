using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards_Solitaire
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }
        private float good = 0.0f;
        private float res = 1.0f;
        private int w = 107, h = 142;
        private int OuterY = 40;
        private int step = 0;
        private int[] coordsX = new int[4]
        {
            0, 107, 214, 321
        };
        private int[] coordsY = new int[4]
        {
            66, 66, 66, 66
        };
        private Card[] card_Q = new Card[4];
        private void DoStep()
        {
            bool flag = false;
            //OuterY += 26;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i != j && card_Q[i].Suit == card_Q[j].Suit)
                    {
                        flag = true;
                        card_Q[i] = Options.CardsStack.GetRandomFromStack();
                        card_Q[j] = Options.CardsStack.GetRandomFromStack();
                        panel1.Controls.Add(Options.GetCardBox(card_Q[i], coordsX[i], coordsY[i], w, h, step));
                        panel1.Controls.Add(Options.GetCardBox(card_Q[j], coordsX[j], coordsY[j], w, h, step));

                        panel1.Controls.OfType<PictureBox>().Where(x => (int)x.Tag == step).ToList()[0].BringToFront();
                        panel1.Controls.OfType<PictureBox>().Where(x => (int)x.Tag == step).ToList()[1].BringToFront();

                        coordsY[i] += 26;
                        coordsY[j] += 26;

                        label1.Text = $"Карт: {Options.CardsStack.Cards.Count}";
                        strip.Text = $"Карт в колоде: {Options.CardsStack.Cards.Count}";
                        break;
                    }
                }
                if (flag)
                    break;
            }



            if (!flag)
            {
                timer1.Stop();
                if (numericUpDown1.Value == 1)
                    MessageBox.Show("Пасьянс не сошелся");

                OuterY = 40;
                begin_stack.Enabled = false;
                NewGame();

                if (res > 0)
                    BeginGame_Timer();
                else
                {
                    res = (int)numericUpDown1.Value;

                    if (numericUpDown1.Value != 1)
                        MessageBox.Show("K = " + (good / (int)numericUpDown1.Value).ToString());
                }
                return;
            }


        }
        private void NewGame()
        {
            Options.CardsStack.UpdateCards();
            Options.CardsStack.MixCards();
            panel1.Controls.Clear();
            card_Q[0] = Options.CardsStack.GetRandomFromStack();
            card_Q[1] = Options.CardsStack.GetRandomFromStack();
            card_Q[2] = Options.CardsStack.GetRandomFromStack();
            card_Q[3] = Options.CardsStack.GetRandomFromStack();
            panel1.Controls.Add(Options.GetCardBox(card_Q[0], coordsX[0], OuterY, w, h, -1));
            panel1.Controls.Add(Options.GetCardBox(card_Q[1], coordsX[1], OuterY, w, h, -1));
            panel1.Controls.Add(Options.GetCardBox(card_Q[2], coordsX[2], OuterY, w, h, -1));
            panel1.Controls.Add(Options.GetCardBox(card_Q[3], coordsX[3], OuterY, w, h, -1));
            coordsY[0] = 66;
            coordsY[1] = 66;
            coordsY[2] = 66;
            coordsY[3] = 66;
            begin_stack.Enabled = true;
            step = 0;
            label1.Text = $"Карт: {Options.CardsStack.Cards.Count}";
            strip.Text = $"Карт в колоде: {Options.CardsStack.Cards.Count}";
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            coloda.Image = Card.GetBack();
            NewGame();
        }

        private void new_game_Click(object sender, EventArgs e)
        {
            NewGame();

        }

        private void prob_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            this.Enabled = false;
            good = 0;
            float k = (int)numericUpDown1.Value;
            progressBar1.Value = 0;
            progressBar1.Maximum = (int)numericUpDown1.Value;
            for (int v = 0; v < k; v++)
            {
                Options.CardsStack.UpdateCards();
                Options.CardsStack.MixCards();
                card_Q[0] = Options.CardsStack.GetRandomFromStack();
                card_Q[1] = Options.CardsStack.GetRandomFromStack();
                card_Q[2] = Options.CardsStack.GetRandomFromStack();
                card_Q[3] = Options.CardsStack.GetRandomFromStack();
                bool flag = false;

                for (int S = 0; S < 16; S++)
                {
                    flag = false;
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (i != j && card_Q[i].Suit == card_Q[j].Suit)
                            {
                                flag = true;
                                card_Q[i] = Options.CardsStack.GetRandomFromStack();
                                card_Q[j] = Options.CardsStack.GetRandomFromStack();
                                break;
                            }
                        }
                        if (flag)
                            break;
                    }
                    if (!flag)
                        break;
                }
                if (Options.CardsStack.Cards.Count == 0)
                    good++;
                //else
                //  MessageBox.Show(Options.CardsStack.Cards.Count.ToString());
                progressBar1.Value++;
            }
            this.Enabled = true;
            MessageBox.Show($"Good = {good}\nAll = {k}\nK = {(good / k)}");
            progressBar1.Visible = false;
        }

        private void exit__Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (step < 16)
            {
                DoStep();
                step++;
            }
            else
            {
                timer1.Stop();
                step = 0;
                OuterY = 40;
                begin_stack.Enabled = false;
                coloda.Image = null;
                good++;
                if (numericUpDown1.Value == 1)
                    MessageBox.Show("Пасьянс сошелся");
                coloda.Image = Card.GetBack();

                NewGame();

                if (res > 0)
                    BeginGame_Timer();
                else
                {
                    if (numericUpDown1.Value != 1)
                        MessageBox.Show("K = " + (good / res).ToString());
                }


            }
        }

        private void begin_stack_Click(object sender, EventArgs e)
        {

            res = (int)numericUpDown1.Value;
            good = 0;
            BeginGame_Timer();
        }

        void BeginGame_Timer()
        {
            res--;
            step = 0;
            begin_stack.Enabled = false;
            timer1.Start();

        }
    }
}
