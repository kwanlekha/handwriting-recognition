using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
//-----command that use in sql just like select, count
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        bool paint = false;
        SolidBrush color;
        int numberToDraw = 0;

        public Form1()
        {
            InitializeComponent();

            labelShowMessage.Text = "--- Drawing and input name ---";
            labelShowMessage.ForeColor = Color.Blue;
        }

        private void panelToDraw_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void panelToDraw_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
        }

        private void panelToDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                color = new SolidBrush(Color.Black);
                //-----drawing graphics
                using(Graphics g = panelToDraw.CreateGraphics())
                {
                    //-----fill ellipse with color which e is mouse, e.X is mouse click at the current X position
                    g.FillEllipse(color, e.X, e.Y, 10, 10);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearScreen();
        }

        private void clearScreen()
        {
            clearPanel();
            richTextBoxShowData.Clear();
        }

        private void clearPanel()
        {
            Graphics g1 = panelToDraw.CreateGraphics();
            g1.Clear(panelToDraw.BackColor);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            //-----create bitmap with width and height are equal to panel1
            Bitmap bmp = new Bitmap(panelToDraw.Width, panelToDraw.Height);
            //-----use using like dispose function to clean up all resources
            using (Graphics g = Graphics.FromImage(bmp))
            {
                //-----fix sixe and location of panel1 in screen
                Rectangle rect = panelToDraw.RectangleToScreen(panelToDraw.ClientRectangle);
                //-----copy panel1 from screen
                g.CopyFromScreen(rect.Location, Point.Empty, panelToDraw.Size);
            }

            //-----save image into bmp
            try
            {
                string directory_name = labelNumberToDraw.Text;
                if (!Directory.Exists(directory_name))
                {
                    Directory.CreateDirectory(directory_name);
                }
                //labelNumberToDraw.text is a name of directory
                string[] filenames = Directory.GetFiles(directory_name);
                string filename = "0.bmp";
                if (filenames.Length != 0)
                {
                    int maxNum = filenames.Where(a => 
                                        {
                                            try
                                            {
                                                Convert.ToInt32(Path.GetFileNameWithoutExtension(a));
                                                return true;
                                            }
                                            catch (Exception)
                                            {
                                                return false;
                                            }
                                        })
                                        .Max(a => {
                                            return Convert.ToInt32(Path.GetFileNameWithoutExtension(a));
                                        });
                    filename = (maxNum + 1) + ".bmp";
                }
                bmp.Save(Path.GetFullPath(directory_name) + "/" + filename, ImageFormat.Bmp);
                labelShowMessage.Text = "--- Image "+ filename +" saved ---";
                labelShowMessage.ForeColor = Color.Blue;
                //MessageBox.Show("Image saved successfully.");
                clearPanel();
                richTextBoxShowData.Clear();
                numberToDraw ++;
                if (numberToDraw > 9)
                {
                    numberToDraw = 0;
                }
                labelNumberToDraw.Text = numberToDraw.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image not save: " + ex.Message);
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            //-----create bitmap with width and height are equal to panel1
            Bitmap bmp = new Bitmap(panelToDraw.Width, panelToDraw.Height);
            //-----use using like dispose function to clean up all resources
            using (Graphics g = Graphics.FromImage(bmp))
            {
                //-----fix sixe and location of panel1 in screen
                Rectangle rect = panelToDraw.RectangleToScreen(panelToDraw.ClientRectangle);
                //-----copy panel1 from screen
                g.CopyFromScreen(rect.Location, Point.Empty, panelToDraw.Size);
            }

            //-----get value of each pixel
            int[][] pixels = new int[bmp.Height][];
            for (int y = 0; y < bmp.Height; y++)
            {
                pixels[y] = new int[bmp.Width];
            }
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    if (bmp.GetPixel(x, y).GetBrightness() < 0.5)
                    {
                        //-----one refers to black
                        pixels[y][x] = 1;
                    }
                    else
                    {
                        //-----zero refers to white
                        pixels[y][x] = 0;
                    }
                }
            }
            //put value in each pixel into array and not show value of pixels == 0, show value of pixels == 1 
            string[] ids = pixels.Select(a => String.Join("", a.Select(b => b == 0 ? " " : "1"))).ToArray();
            //string[] ids = pixels.Select(a => String.Join("", a).ToArray();
            richTextBoxShowData.Lines = ids;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                save();
            }
            else if (e.KeyCode == Keys.Back)
            {
                clearScreen();
            }
        }
        
    }
}
