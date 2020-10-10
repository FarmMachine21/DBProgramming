using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_Git_Push
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//버튼 클릭시
        {
            //pictureBox1.Image = System.Drawing.Image.FromFile("Chicken_2.jpg");//이미치 출력
            label1.Text = "피자";//텍스트 출력, 충돌상황 만들기 위해 텍스트 바꿈.
        }
    }
}