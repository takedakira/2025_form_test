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
        private Color _onColor = Color.LightGreen;
        private Color _offColor = Color.DarkGreen;

        private bool _enable;

        private Form1 _form1;

        private int _x;

        private int _y;



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
            //Formの参照を保管
            _form1 = form1;

            //
            _x = x;

            //
            _y = y;

            // ボタンの位置を設定
            Location = new Point(x * size.Width, y * size.Height);

            // ボタンの大きさを設定
            Size = size;

            // ボタン内のテキストを設定
            Text = text;

            SetEnable(false);

            Click += hogehogeClick;


        }

        // 自分で作成することも可能
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

        if
    }
}
