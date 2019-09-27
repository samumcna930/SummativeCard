using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace SummativeCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Sammy McNab 09/18/2019, greeting card


            Graphics g = this.CreateGraphics();
            g.Clear(Color.FromArgb(255, 255, 255));
            Font textFont = new Font("Futura XBlkIt BT", 22, FontStyle.Bold);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(Color.Black);
            //Title 
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100,110);
            g.DrawLine(blackPen ,95, 150, 500, 150);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //Click
            SoundPlayer start = new SoundPlayer(Properties.Resources.startup);
            start.Play();
            Graphics g = this.CreateGraphics();
            Font textFont = new Font("Futura XBlkIt BT", 22, FontStyle.Bold);
            Font textFont2 = new Font("Machine BT", 30, FontStyle.Italic);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush starBrush = new SolidBrush(Color.FromArgb(177,252,255));
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Pen star = new Pen(Color.FromArgb(251,252,24));
            SoundPlayer starSound = new SoundPlayer(Properties.Resources.starsound);
            
            Thread.Sleep(200);
            //title
            g.DrawString("The Gemeni Constellation", textFont, blackBrush, 100, 110);

            //fade frame
            int c = 255;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 250;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 245;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 240;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 235;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 230;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 225;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 220;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 215;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 210;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 205;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 200;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 195;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 190;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 185;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 180;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 175;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 170;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 165;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 160;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 155;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 150;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 145;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 140;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 135;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 130;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 125;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 120;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 115;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 110;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 105;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 100;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 95;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 90;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 85;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 80;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 75;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 70;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 65;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 60;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 55;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 45;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 40;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 30;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 20;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 10;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 5;
            g.Clear(Color.FromArgb(c, 255, 255, 255));
            g.DrawString("The Gemini Constellation", textFont, blackBrush, 100, 110);
            Thread.Sleep(10);

            c = 0;
            Thread.Sleep(1500);

            //stars on bottum of left twin
            g.FillPie(starBrush, 265, 260, 10, 10, 0, 360);
            starSound.Play();
            Thread.Sleep(200);
            g.FillPie(starBrush, 315, 213, 10, 10, 0, 360);
            starSound.Play();
            Thread.Sleep(200);
            g.FillPie(starBrush, 350, 268, 10, 10, 0, 360);
            starSound.Play();
            Thread.Sleep(200);
            g.FillPie(starBrush, 315, 370, 10, 10, 0, 360);
            starSound.Play();
            Thread.Sleep(200);
            g.FillPie(starBrush, 368, 355, 10, 10, 0, 360);
            starSound.Play();
            Thread.Sleep(200);
            //stars on top half of left twin
            g.FillPie(starBrush, 294, 132, 10, 10, 0, 360);
            starSound.Play();
            Thread.Sleep(200);
            g.FillPie(starBrush, 330, 128, 10, 10, 0, 360);
            starSound.Play();
            Thread.Sleep(200);
            g.FillPie(starBrush, 328, 90, 10, 10, 0, 360);
            starSound.Play();
            Thread.Sleep(200);
            g.FillPie(starBrush, 370, 145, 10, 10, 0, 360);
            starSound.Play();
            Thread.Sleep(200);
            //Stars on top half of right twin
            g.FillPie(starBrush, 425, 153, 10, 10, 0, 360);
            starSound.Play();
            Thread.Sleep(200);
            g.FillPie(starBrush, 412, 107, 10, 10, 0, 360);
            starSound.Play();
            Thread.Sleep(200);
            g.FillPie(starBrush, 395, 82, 10, 10, 0, 360);
            starSound.Play();
            Thread.Sleep(200);
            g.FillPie(starBrush, 500, 158, 10, 10, 0, 360);
            starSound.Play();
            Thread.Sleep(200);
            //Stars on bottum half of right twin
            g.FillPie(starBrush, 435, 257, 10, 10, 0, 360);
            starSound.Play();
            Thread.Sleep(200);
            g.FillPie(starBrush, 420, 350, 10, 10, 0, 360);
            starSound.Play();
            Thread.Sleep(200);
            g.FillPie(starBrush, 470, 338, 10, 10, 0, 360);
            starSound.Play();
            Thread.Sleep(200);
            g.FillPie(starBrush, 490, 348, 10, 10, 0, 360);
            starSound.Play();
            Thread.Sleep(200);
            g.FillPie(starBrush, 530, 358, 10, 10, 0, 360);
            starSound.Play();
            Thread.Sleep(200);
            //Lines on lower half of left twin
            g.DrawLine(star, 320, 379, 270, 268);
            starSound.Play();
            Thread.Sleep(200);
            g.DrawLine(star, 270, 268, 320, 217);
            starSound.Play();
            Thread.Sleep(200);
            g.DrawLine(star, 320, 217, 355, 273);
            starSound.Play();
            Thread.Sleep(200);
            g.DrawLine(star, 355, 273, 373, 364);
            starSound.Play();
            Thread.Sleep(200);
            //Lines on top half of left twin
            g.DrawLine(star, 320, 216, 336, 132);
            starSound.Play();
            Thread.Sleep(200);
            g.DrawLine(star, 294, 136, 336, 133);
            starSound.Play();
            Thread.Sleep(200);
            g.DrawLine(star, 336, 133, 376, 150);
            starSound.Play();
            Thread.Sleep(200);
            g.DrawLine(star, 336, 133, 332, 95);
            starSound.Play();
            Thread.Sleep(200);
            //Lines on top half of right twin
            g.DrawLine(star, 376, 150, 432, 159);
            starSound.Play();
            Thread.Sleep(200);
            g.DrawLine(star, 432, 159, 508, 161);
            starSound.Play();
            Thread.Sleep(200);
            g.DrawLine(star, 431, 159, 416, 110);
            starSound.Play();
            Thread.Sleep(200);
            g.DrawLine(star, 416, 110, 400, 85);
            starSound.Play();
            Thread.Sleep(200);
            //Lines on bottum half of right twin 
            g.DrawLine(star, 431, 159, 440, 255);
            starSound.Play();
            Thread.Sleep(200);
            g.DrawLine(star, 440, 255, 427, 356);
            starSound.Play();
            Thread.Sleep(200);
            g.DrawLine(star, 440, 255, 473, 342);
            starSound.Play();
            Thread.Sleep(200);
            g.DrawLine(star, 473, 342, 496, 354);
            starSound.Play();
            Thread.Sleep(200);
            g.DrawLine(star, 496, 354, 531, 363);
            //final title
            g.DrawString("Gemini \nConstellation",textFont2, whiteBrush, 60, 90);
        }
    }
}
