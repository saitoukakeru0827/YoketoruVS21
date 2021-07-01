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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ToTitle_button_Click(object sender, EventArgs e)
        {

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
                    Title_label.Visible = false;
                    Startbutton.Visible = false;
                    Copyright_label.Visible = false;
                    HighScore_label.Visible = false;
                    break;
            }
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }
    }
}
