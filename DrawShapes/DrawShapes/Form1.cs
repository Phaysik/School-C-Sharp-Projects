/*Programmer: Matthew Moore
   Description: Draw Shapes
   Date: 11-8-18
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawShapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;

            MoveBall1(picBall1);
            MoveBall2(picBall2);
            MoveBall3(picBall3);
            MoveBall4(picBall4);
            MoveBall5(picBall5);
            MoveBall6(picBall6);

        }

        /// <summary>
        /// Move ball on the square image
        /// </summary>
        /// <param name="picBall1"></param>
        private void MoveBall1(PictureBox picBall1)
        {
            while(picBall1.Left < 107)
            {
                picBall1.Left++;
                System.Threading.Thread.Sleep(10);
            }

            while(picBall1.Top < 134)
            {
                picBall1.Top++;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall1.Left > 12)
            {
                picBall1.Left--;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall1.Top > 7)
            {
                picBall1.Top--;
                System.Threading.Thread.Sleep(10);
            }
        }

        /// <summary>
        /// Move ball on the pentagon image
        /// </summary>
        /// <param name="picBall2"></param>
        private void MoveBall2(PictureBox picBall2)
        {
            int i = 0;
            while (picBall2.Left < 309 && picBall2.Top < 121)
            {
                if(i == 0)
                {
                    picBall2.Top += 4;
                    i = 1;
                }
                else
                {
                    picBall2.Top--;
                    i = 0;
                }
                picBall2.Left++;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall2.Left > 285 && picBall2.Top < 292)
            {
                if(i == 0)
                {
                    picBall2.Left -= 3;
                    i = 1;
                }
                else
                {
                    picBall2.Left += 2;
                    i = 0;
                }
                picBall2.Top += 4;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall2.Left > 205)
            {
                picBall2.Left--;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall2.Left > 181 && picBall2.Top > 121)
            {
                if(i == 0)
                {
                    picBall2.Left -= 3;
                    i = 1;
                }
                else
                {
                    picBall2.Left += 2;
                    i = 0;
                }
                picBall2.Top -= 4;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall2.Left < 246 && picBall2.Top > 22)
            {
                if (i == 0)
                {
                    picBall2.Top -= 4;
                    i = 1;
                }
                else
                {
                    picBall2.Top++;
                    i = 0;
                }
                picBall2.Left++;
                System.Threading.Thread.Sleep(10);
            }
        }

        /// <summary>
        /// Move ball on the stair image
        /// </summary>
        /// <param name="picBall3"></param>
        private void MoveBall3(PictureBox picBall3)
        {
            while (picBall3.Top < 82)
            {
                picBall3.Top++;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall3.Left < 378)
            {
                picBall3.Left++;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall3.Top < 149)
            {
                picBall3.Top++;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall3.Left < 429)
            {
                picBall3.Left++;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall3.Top < 216)
            {
                picBall3.Top++;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall3.Left < 484)
            {
                picBall3.Left++;
                System.Threading.Thread.Sleep(10);
            }
        }

        /// <summary>
        /// Move ball on the right triangle
        /// </summary>
        /// <param name="picBall4"></param>
        private void MoveBall4(PictureBox picBall4)
        {
            int i = 0;

            while (picBall4.Top < 302)
            {
                picBall4.Top++;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall4.Left < 170)
            {
                picBall4.Left++;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall4.Left > 10 && picBall4.Top > 160)
            {
                if(i == 0 || i == 1 || i == 2 || i == 3)
                {
                    picBall4.Top -= 2;
                    picBall4.Left -= 2;
                    i++;
                }
                else
                {
                    picBall4.Left++;
                    picBall4.Top += 2;
                    i = 0;
                }
                System.Threading.Thread.Sleep(10);
            }
        }

        /// <summary>
        /// Move ball on the arrow
        /// </summary>
        /// <param name="picBall5"></param>
        private void MoveBall5(PictureBox picBall5)
        {
            int i = 0;

            while (picBall5.Left < 90)
            {
                picBall5.Left++;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall5.Top < 423)
            {
                picBall5.Top++;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall5.Left < 113)
            {
                picBall5.Left++;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall5.Top < 512 && picBall5.Left > 62)
            {
                picBall5.Top += 2;
                picBall5.Left--;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall5.Top > 422 && picBall5.Left > 10)
            {
                if(i == 0)
                {
                    picBall5.Top -= 2;
                    i = 1;
                }
                else
                {
                    picBall5.Top--;
                    i = 0;
                }
                picBall5.Left--;
                System.Threading.Thread.Sleep(10);
            }

            while(picBall5.Left < 36)
            {
                picBall5.Left++;
            }

            while (picBall5.Top > 327)
            {
                picBall5.Top--;
            }
        }

        /// <summary>
        /// Move ball on the star
        /// </summary>
        /// <param name="picBall6"></param>
        private void MoveBall6(PictureBox picBall6)
        {
            int i = 0;

            while (picBall6.Left < 279 && picBall5.Top < 397)
            {
                if(i == 0)
                {
                    picBall6.Top += 4;
                    i = 1;
                }
                else
                {
                    picBall6.Top += 3;
                    i = 0;
                }
                picBall6.Left++;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall6.Left < 343 && picBall5.Top < 398)
            {
                if (i == 0)
                {
                    picBall6.Left += 4;
                    picBall6.Top++;
                    i = 1;
                }
                else
                {
                    picBall6.Left += 3;
                    picBall6.Top--;
                    i = 0;
                }
                System.Threading.Thread.Sleep(10);
            }

            while (picBall6.Left > 293 && picBall5.Top < 443)
            {
                picBall6.Left--;
                picBall6.Top++;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall6.Left < 309 && picBall5.Top < 517)
            {
                if (i == 0)
                {
                    picBall6.Top += 5;
                    i = 1;
                }
                else
                {
                    picBall6.Top += 3;
                    i = 0;
                }
                picBall6.Left++;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall6.Left > 262 && picBall5.Top < 475)
            {
                picBall6.Left--;
                picBall6.Top--;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall6.Left > 208 && picBall5.Top < 523)
            {
                picBall6.Left--;
                picBall6.Top++;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall6.Left < 230 && picBall5.Top < 361)
            {
                if (i == 0)
                {
                    picBall6.Top -= 4;
                    picBall6.Left += 3;
                    i = 1;
                }
                else
                {
                    picBall6.Top -= 3;
                    picBall6.Left--;
                    i = 0;
                }
                System.Threading.Thread.Sleep(10);
            }

            while (picBall6.Left > 177 && picBall5.Top < 398)
            {
                picBall6.Left--;
                picBall6.Top--;
                System.Threading.Thread.Sleep(10);
            }

            while (picBall6.Left < 238 && picBall5.Top < 395)
            {
                if (i == 0)
                {
                    picBall6.Left += 4;
                    picBall6.Top++;
                    i = 1;
                }
                else
                {
                    picBall6.Left += 3;
                    picBall6.Top--;
                    i = 0;
                }
                System.Threading.Thread.Sleep(10);
            }

            while (picBall6.Left < 260 && picBall5.Top > 320)
            {
                if (i == 0)
                {
                    picBall6.Top -= 4;
                    picBall6.Left += 3;
                    i = 1;
                }
                else
                {
                    picBall6.Top -= 3;
                    picBall6.Left--;
                    i = 0;
                }
                System.Threading.Thread.Sleep(10);
            }

        }
    }
}
