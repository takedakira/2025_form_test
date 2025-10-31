﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    internal class Test_Button : Button
    {
        private Color _onColor = Color.LightGreen;
        private Color _offColor = Color.DarkGreen;

        private bool _enable;

        

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


        public Test_Button(Point position, Size size, string text)
        {
            // ボタンの位置を設定
            Location = position;

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
            SetEnable(!_enable);
        }

    }
}
