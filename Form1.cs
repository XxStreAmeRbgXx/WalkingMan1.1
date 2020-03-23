using System;
using System.Drawing;
using System.Windows.Forms;

namespace WalkingMan1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dist = 1;
        int spd = 5;
        int spd1 = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                action.Start();
                if (spd > 0)
                {
                    spd = -spd;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                action.Start();
                if (spd < 0)
                {
                    spd = -spd;
                }
            }
            if (e.KeyCode == Keys.Space)
            {
                action.Stop();
                Man.Image = Properties.Resources._1;
            }
            if (e.KeyCode == Keys.Up)
            {
                spd1 = 5;
                
            }
            if (e.KeyCode==Keys.Down)
            {
                spd1 = -5;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void action_Tick(object sender, EventArgs e)
        {
            dist++;
            Man.Left += spd;
            Man.Top -= spd1;
            if (dist == 1)
            {
                Man.Image = Properties.Resources._1;
            }
            if (dist == 2)
            {
                Man.Image = Properties.Resources._2;
            }
            if (dist == 3)
            {
                Man.Image = Properties.Resources._4;
            }
            if (dist == 4)
            {
                Man.Image = Properties.Resources._3;
            }
            if (dist == 5)
            {
                dist = 1;
            }
            if (Man.Left >= ClientSize.Width)
            {
                Man.Left = 2;
            }
            if (Man.Left <= 0)
            {
                Man.Left = ClientSize.Width - 2;
            }
            if (spd < 0)
            {
                if (spd1>0)
                {
                    Man.Image.RotateFlip(RotateFlipType.Rotate270FlipX);

                }
                else if (spd1<0)
                {
                    Man.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    Man.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
                }
                else
                {
                    Man.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                }
                
            }
            if (spd1>0 && spd>0)
            {
                Man.Image.RotateFlip(RotateFlipType.Rotate270FlipX);
                Man.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
            if (spd1 > 0 && spd > 0)
            {
                Man.Image.RotateFlip(RotateFlipType.Rotate270FlipX);
                Man.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
            }
            if (spd > 0 && spd1 < 0)
            {
                Man.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                Man.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
            }
            if (Man.Top>ClientSize.Height)
            {
                Man.Top = 8;
            }
            if (Man.Top < 0)
            {
                Man.Top = ClientSize.Height+5;
            }

        }
    }
}
