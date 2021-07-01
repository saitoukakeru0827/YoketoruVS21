using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace YoketoruVS21
{

    public partial class Form1 : Form
    {
        const bool isDebug = true;
        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex + PlayerMax;
        const int ItemIndex = EnemyIndex + EnemyMax;

        const string PlayerText = "(・ω・)";
        const string EnemyText = "◆";
        const string ItemText = "★";

        int zanki=ItemMax;
        static Random rand = new Random();
        enum State
        {
            None = -1, //無効
            Title, //タイトル
            Game, //ゲーム
            Gameover, //ゲームオーバー
            Clear //クリア
        }

        State currentState = State.None;
        State nextState = State.Title;

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);
        public Form1()
        {
            InitializeComponent();
            for(int i = 0; i < ChrMax; i++)
            {
                chrs[i] = new Label();
                chrs[i].AutoSize = true;
                if(i==PlayerMax)
                {
                    chrs[i].Text = PlayerText;
                }
                else if(i<ItemIndex)
                {
                    chrs[i].Text = EnemyText;
                }
                else
                {
                    chrs[i].Text = ItemText;
                }
                chrs[i].Font = temp_label.Font;
                Controls.Add(chrs[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ToTitle_button_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isDebug)
            {
                if (GetAsyncKeyState((int)Keys.O) < 0)
                {
                    nextState = State.Gameover;
                }
                else if (GetAsyncKeyState((int)Keys.C) < 0)
                {
                    nextState = State.Clear;
                }

            }
            if (nextState != State.None)
            {
                initProc();
            }
            if(currentState==State.Game)
            {
                UpdateGame();
            }
            Itme_label.Text = "★" + zanki;
        }

        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch(currentState)
            {
                case State.Title:
                    Title_label.Visible = true;
                    Startbutton.Visible = true;
                    Copyright_label.Visible = true;
                    HighScore_label.Visible = true;
                    GameOver_label.Visible = false;
                    Clear_label.Visible = false;
                    ToTitle_button.Visible = false;
                    break;

                case State.Game:
                    for (int i = 0; i < ChrMax; i++)
                    {
                        chrs[i].Visible = true;
                    }
                    Title_label.Visible = false;
                    Startbutton.Visible = false;
                    Copyright_label.Visible = false;
                    HighScore_label.Visible = false;
                    for(int i = EnemyIndex-1;i<ChrMax;i++)
                    {
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                    }
                    break;

                case State.Gameover:
                    //MessageBox.Show("Gameover");
                    GameOver_label.Visible = true;
                    ToTitle_button.Visible = true;
                    for(int i = 0; i<ChrMax;i++)
                    {
                        chrs[i].Visible = false;
                    }
                    break;

                case State.Clear:
                    //MessageBox.Show("Clear");
                    Clear_label.Visible = true;
                    ToTitle_button.Visible = true;
                    for (int i = 0; i < ChrMax; i++)
                    {
                        chrs[i].Visible = false;
                    }
                    break;
            }
        }

        void UpdateGame()
        {
            Point mp = PointToClient(MousePosition);

            //TODO:mpがプレイヤーの中心になるように設定
            chrs[1].Left = mp.X - chrs[1].Width/2;
            chrs[1].Top = mp.Y - chrs[1].Height/2;
            for (int i=0;i<ChrMax;i++)
            {
                if((mp.X>=chrs[i].Left)
                && (mp.X<chrs[i].Right)
                && (mp.Y>=chrs[i].Top)
                && (mp.Y < chrs[i].Bottom))
                {
                    if (chrs[i].Text == EnemyText)
                    {
                        nextState = State.Gameover;
                        MessageBox.Show("ゲームオーバー");
                    }
                    if (chrs[i].Text == ItemText)
                    {
                        chrs[i].Visible = false;
                        zanki--;
                    }
                }
            }
        }
        private void Startbutton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void Itme_label_Click(object sender, EventArgs e)
        {

        }
    }
}
