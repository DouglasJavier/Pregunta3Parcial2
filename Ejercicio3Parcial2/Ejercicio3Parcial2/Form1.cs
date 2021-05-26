using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3Parcial2
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Bitmap bmp = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            int cRto, cGto, cBto;
            Color c = new Color();
            for (int i = 0; i < bmp.Width -3; i = i + 3)
                for (int j = 0; j < bmp.Height - 3; j = j + 3)
                {

                    cRto = 0; cGto = 0; cBto = 0;
                    for (int k = i; k < i + 3; k++)
                        for (int l = j; l < j + 3; l++)
                        {
                            c = bmp.GetPixel(k, l);
                            cRto = c.R + cRto; cGto = c.G + cGto; cBto = c.B + cBto;
                        }
                    cRto = cRto / 9;
                    cGto = cGto / 9;
                    cBto = cBto / 9;
                    c = bmp.GetPixel(i, j);
                   // if (((0 <= cRto) && (cRto <= 35)) && ((cGto<= 74) && (6 <= cGto)) && ((cBto<= 255) && (24 <= cBto))&&(cGto<cBto))
                   if((cRto<=cGto)&&(cGto<=cBto))
                        for (int k = i; k < i + 3; k++)
                            for (int l = j; l < j + 3; l++)
                            {
                                bmp2.SetPixel(k, l, Color.Black);
                            }
                    else
                        for (int k = i; k < i + 3; k++)
                            for (int l = j; l < j + 3; l++)
                            {
                                c = bmp.GetPixel(k, l);
                                bmp2.SetPixel(k, l, c);
                            }
                }
            pictureBox1.Image = bmp2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
             bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            int cRto, cGto, cBto;
            Color c = new Color();
            for (int i = 0; i < bmp.Width - 3; i = i + 3)
                for (int j = 0; j < bmp.Height - 3; j = j + 3)
                {

                    cRto = 0; cGto = 0; cBto = 0;
                    for (int k = i; k < i + 3; k++)
                        for (int l = j; l < j + 3; l++)
                        {
                            c = bmp.GetPixel(k, l);
                            cRto = c.R + cRto; cGto = c.G + cGto; cBto = c.B + cBto;
                        }
                    cRto = cRto / 9;
                    cGto = cGto / 9;
                    cBto = cBto / 9;
                    c = bmp.GetPixel(i, j);
                    // if (((0 <= cRto) && (cRto <= 35)) && ((cGto<= 74) && (6 <= cGto)) && ((cBto<= 255) && (24 <= cBto))&&(cGto<cBto))
                    if ((cRto >= cGto) && (cGto >= cBto))
                        for (int k = i; k < i + 3; k++)
                            for (int l = j; l < j + 3; l++)
                            {
                                bmp2.SetPixel(k, l, Color.Black);
                            }
                    else
                        for (int k = i; k < i + 3; k++)
                            for (int l = j; l < j + 3; l++)
                            {
                                c = bmp.GetPixel(k, l);
                                bmp2.SetPixel(k, l, c);
                            }
                }
            pictureBox1.Image = bmp2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
             bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            int cRto, cGto, cBto;
            Color c = new Color();
            for (int i = 0; i < bmp.Width - 3; i = i + 3)
                for (int j = 0; j < bmp.Height - 3; j = j + 3)
                {

                    cRto = 0; cGto = 0; cBto = 0;
                    for (int k = i; k < i + 3; k++)
                        for (int l = j; l < j + 3; l++)
                        {
                            c = bmp.GetPixel(k, l);
                            cRto = c.R + cRto; cGto = c.G + cGto; cBto = c.B + cBto;
                        }
                    cRto = cRto / 9;
                    cGto = cGto / 9;
                    cBto = cBto / 9;
                    c = bmp.GetPixel(i, j);
                    // if (((0 <= cRto) && (cRto <= 35)) && ((cGto<= 74) && (6 <= cGto)) && ((cBto<= 255) && (24 <= cBto))&&(cGto<cBto))
                    if ((cRto< cBto) && (cGto >= cBto))
                        for (int k = i; k < i + 3; k++)
                            for (int l = j; l < j + 3; l++)
                            {
                                bmp2.SetPixel(k, l, Color.Black);
                            }
                    else
                        for (int k = i; k < i + 3; k++)
                            for (int l = j; l < j + 3; l++)
                            {
                                c = bmp.GetPixel(k, l);
                                bmp2.SetPixel(k, l, c);
                            }
                }
            pictureBox1.Image = bmp2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            int cRto, cGto, cBto;
            Color c = new Color();
            for (int i = 0; i < bmp.Width - 3; i = i + 3)
                for (int j = 0; j < bmp.Height - 3; j = j + 3)
                {

                    cRto = 0; cGto = 0; cBto = 0;
                    for (int k = i; k < i + 3; k++)
                        for (int l = j; l < j + 3; l++)
                        {
                            c = bmp.GetPixel(k, l);
                            cRto = c.R + cRto; cGto = c.G + cGto; cBto = c.B + cBto;
                        }
                    cRto = cRto / 9;
                    cGto = cGto / 9;
                    cBto = cBto / 9;
                    c = bmp.GetPixel(i, j);
                    // if (((0 <= cRto) && (cRto <= 35)) && ((cGto<= 74) && (6 <= cGto)) && ((cBto<= 255) && (24 <= cBto))&&(cGto<cBto))
                    if ((cRto >=200) && (cGto >= 200)&&(cBto>=200))
                        for (int k = i; k < i + 3; k++)
                            for (int l = j; l < j + 3; l++)
                            {
                                bmp2.SetPixel(k, l, Color.Black);
                            }
                    else
                        for (int k = i; k < i + 3; k++)
                            for (int l = j; l < j + 3; l++)
                            {
                                c = bmp.GetPixel(k, l);
                                bmp2.SetPixel(k, l, c);
                            }
                }
            pictureBox1.Image = bmp2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = bmp;
        }
    }
}
