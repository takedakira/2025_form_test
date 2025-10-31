using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    public partial class Form1 : Form
    {
        //constをつけると初期化時にのみ値の変更が可能になる
        const int BUTTON_SIZE_X = 100;
        const int BUTTON_SIZE_Y = 100;

        const int BOARD_SIZE_X = 3;
        const int BOARD_SIZE_Y = 3;


        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //インスタンスの生成
                    Test_Button test_Button 
                        = new Test_Button(new Point(BUTTON_SIZE_X * i, BUTTON_SIZE_Y * j)
                        , new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y),"a");




                  //コントロールにボタンを追加
                    Controls.Add(test_Button);

                }
            }

        }

        private void hogehogeCick(object sender, EventArgs e)
        {
            MessageBox.Show("クリックされてしまいました");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C#の世界へようこそ");
        }
    }
}
