using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    public class Test_Button : Button
    {

        //ランダム関数
        private static Random random = new Random();
        //論理値を格納する変数
        private bool Boolrand;




        private Color _onColor = Color.LightGreen;

        private Color _offColor = Color.DarkGreen;

        private bool _enable;

        private Form1 _form1;

        private int _x;

        private int _y;



        /// <summary>
        /// onとoffの設定
        /// </summary>
        /// <param name="on"></param>
        public void SetEnable(bool on)
        {
            _enable = on;
            if (on)
            {
                BackColor = _onColor;
            }
            else
            {
                BackColor = _offColor;
            }
        }

        public void Toggle()
        {
            SetEnable(!_enable);
        }


        public Test_Button(Form1 form1,int x,int y,  Size size, string text)
        {
            //aita様の助言あり
            //0 or 1を返す関数を作る
            //0 = true , 1 = false
            Boolrand = random.Next(0,2) == 0;

            //Formの参照を保管
            _form1 = form1;

            //横の位置を保管
            _x = x;

            //縦の位置を保管
            _y = y;

            // ボタンの位置を設定
            Location = new Point(x * size.Width, y * size.Height);

            // ボタンの大きさを設定
            Size = size;

            // ボタン内のテキストを設定
            Text = text;

            SetEnable (Boolrand);

            Click += hogehogeClick;


        }

        // 自分で作成することも可能
        /// <summary>
        /// 各ボタンがクリックされたときに呼び出される関数
        /// クリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hogehogeClick(object sender, EventArgs e)
        {
            //楽な書き方
            // _form1.GetTest_Button(_x, _y)?.Toggle();
            // _form1.GetTest_Button(_x + 1, _y)?.Toggle();
            // _form1.GetTest_Button(_x - 1, _y)?.Toggle();
            // _form1.GetTest_Button(_x, _y + 1)?.Toggle();
            // _form1.GetTest_Button(_x, _y - 1)?.Toggle();

            //かっこいい書き方
            for (int i = 0; i < _toggleDate.Length; i++)
            {
                var date = _toggleDate[i];
                var button = _form1.GetTest_Button(_x + date[0], _y + date[1]);

                if (button != null)
                {
                    button.Toggle();
                }
            }

            //クリアはこの先

            //aita様の助言あり
            //(0,0)を基準にする
            bool nandemo = _form1.GetTest_Button(0, 0)._enable;
            //全部そろっているかどうか状態を保管

            bool hantei = true;

            //全部の場所を見る
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (nandemo != _form1.GetTest_Button(i, j)._enable)
                    {
                        hantei = !hantei;
                        break;
                    }

                }

                if (!hantei)
                {
                    break;
                }

            }

            if (hantei)
            {
                MessageBox.Show("ゲームクリア");
                Application.Exit();
            }

        }

        
        //controle rr で名前変える

        private int[][] _toggleDate =
        {
            new int[]{0 ,0 },
            new int[]{1,0 },
            new int[]{-1 ,0 },
            new int[]{0 ,1 },
            new int[]{0 ,-1 },
            
            
        };






    }


}

