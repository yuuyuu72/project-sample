using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kadai03_NoughtsCrosses
{
    public partial class Form1 : Form
    {
        Button[,] masu = new Button[3,3];
        Boolean maruflg = false;
        Boolean winflg = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            masu[0, 0] = btn11;
            masu[0, 1] = btn12;
            masu[0, 2] = btn13;
            masu[1, 0] = btn21;
            masu[1, 1] = btn22;
            masu[1, 2] = btn23;
            masu[2, 0] = btn31;
            masu[2, 1] = btn32;
            masu[2, 2] = btn33;

            Clear();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            clear.Enabled = true;
            if (maruflg)
            {
                ((Button)sender).Text = "○";
                turn.Text = "×";
            }
            else
            {
                ((Button)sender).Text = "×";
                turn.Text = "○";
            }
            ((Button)sender).Enabled = false;
            maruflg = !maruflg;

            result();
        }

        private void result()
        {

            //////勝利時
            //縦横判定
            String strYoko = "";
            String strTate = "";

            for (int i=0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    strYoko += masu[i, j].Text;
                    strTate += masu[j, i].Text;
                }
                if (strYoko.Equals("○○○") || strTate.Equals("○○○"))
                {
                    turn.Text = "End";
                    winflg = true;
                    if (MessageBox.Show("○の勝ち！", "決着", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Clear();
                    }
                }
                else if (strYoko.Equals("×××") || strTate.Equals("×××"))
                {
                    turn.Text = "End";
                    winflg = true;
                    if (MessageBox.Show("×の勝ち！", "決着", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Clear();
                    }
                }

                strYoko = "";
                strTate = "";
            }

            //斜め判定
            if(masu[0,0].Text.Equals("○")&& masu[1,1].Text.Equals("○")&& masu[2,2].Text.Equals("○")||
                masu[0,2].Text.Equals("○") && masu[1,1].Text.Equals("○") && masu[2,0].Text.Equals("○"))
            {
                turn.Text = "End";
                winflg = true;
                if (MessageBox.Show("○の勝ち！", "決着", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Clear();
                }
            }
            else if (masu[0, 0].Text.Equals("×") && masu[1,1].Text.Equals("×") && masu[2,2].Text.Equals("×") ||
                        masu[0, 2].Text.Equals("×") && masu[1, 1].Text.Equals("×") && masu[2, 0].Text.Equals("×"))
            {
                turn.Text = "End";
                winflg = true;
                if (MessageBox.Show("×の勝ち！", "決着", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Clear();
                }
            }

            //////引き分け時
            else if(!winflg)
            {
                if (!masu[0, 0].Text.Equals("") &&
                    !masu[0, 1].Text.Equals("") &&
                    !masu[0, 2].Text.Equals("") &&
                    !masu[1, 0].Text.Equals("") &&
                    !masu[1, 1].Text.Equals("") &&
                    !masu[1, 2].Text.Equals("") &&
                    !masu[2, 0].Text.Equals("") &&
                    !masu[2, 1].Text.Equals("") &&
                    !masu[2, 2].Text.Equals(""))
                {
                    turn.Text = "End";
                    if (MessageBox.Show("引き分け！", "未決着", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Clear();
                    }
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("初期化しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Clear();
            }
        }

        private void Clear()
        {
            clear.Enabled = false;
            winflg = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    masu[i,j].Text = "";
                    masu[i,j].Enabled = true;
                }
            }

            //ターン
            Random cRandom = new System.Random();
            int rResult = cRandom.Next(2);
            if (rResult ==0)
            {
                turn.Text = "○";
                maruflg = true;
            }
            else
            {
                turn.Text = "×";
                maruflg = false;
            }
        }

    }
}
