using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Spil2
{

 /*   public class Win32
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        static public System.Drawing.Color GetPixelColor(int x, int y)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, x, y);
            ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                         (int)(pixel & 0x0000FF00) >> 8,
                         (int)(pixel & 0x00FF0000) >> 16);
            return color;
        }
    }*/

   

    public partial class Map0 : Form
    {


        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(min, max);
            }
        }

        private void rndmobcheck()
        {

            int a = GetRandomNumber(1, 11);

            if (a == 3)
            {
            //    this.Enabled = false;

                GlobalStaticVars.GlobalVarX = x;
                GlobalStaticVars.GlobalVarY = y;
                Form1 F1 = new Form1();
                F1.ShowDialog();
            }
        }
         
             
        enum Position
        { left, right, up, down
        }
        
        public Map0()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Map0_KeyDown);
            x = 50;
            y = 95;
            objPosition = Position.right;
            panel1.KeyDown += new KeyEventHandler(Map0_KeyDown);
          //  tbxAnswer.KeyUp += new KeyEventHandler(tbxAnswer_KeyUp);
           
        }

        private Position objPosition;

        public int px = 40;
        public int py = 40;

        private int x;
        private int y;
 
        private void Map0_Paint(object sender, PaintEventArgs e)
        {           
       //     e.Graphics.FillRectangle(Brushes.Indigo, x, y, 15, 15);           
        }

        int xx = 0;
        int yy = 0;

    //    int eventCount = 0;
 




        private void Map0_KeyDown(object sender, KeyEventArgs e)
        {


//            e.Handled = true;      
     //       MessageBox.Show("");

          //       eventCount++;
          //       if (eventCount == 2)
          //       {
         //   InitializeComponent();

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.C || e.KeyCode == Keys.S)
            {
                if (e.KeyCode == Keys.Left)
                {
                    //    MessageBox.Show(pictureBox2.Location.ToString());
                    objPosition = Position.left;

                    //       panel1.Controls.Remove(pictureBox2);

                    x -= 10;
                    px = px - 10;
                    pictureBox2.Left = px;

                    panel1.Controls.Add(pictureBox2);
                    xx = pictureBox2.Location.X;
                    yy = pictureBox2.Location.Y;
                    e.Handled = true;

                }
                if (e.KeyCode == Keys.Right)
                {
                    objPosition = Position.right;
                    x += 10;
                    px = px + 10;
                    pictureBox2.Left = px;
                    panel1.Controls.Add(pictureBox2);
                    xx = pictureBox2.Location.X;
                    yy = pictureBox2.Location.Y;
                    e.Handled = true;
                }
                if (e.KeyCode == Keys.Up)
                {
                    objPosition = Position.up;
                    y -= 10;
                    py = py - 10;
                    pictureBox2.Top = py;
                    panel1.Controls.Add(pictureBox2);
                    xx = pictureBox2.Location.X;
                    yy = pictureBox2.Location.Y;
                    e.Handled = true;
                }
                if (e.KeyCode == Keys.Down)
                {
                    objPosition = Position.down;
                    y += 10;
                    py = py + 10;
                    pictureBox2.Top = py;
                    panel1.Controls.Add(pictureBox2);
                    xx = pictureBox2.Location.X;
                    yy = pictureBox2.Location.Y;
                    e.Handled = true;
                }
                if (e.KeyCode == Keys.C)
                {
                    MessageBox.Show("Do you want to camp?");
                }
                if (e.KeyCode == Keys.S)
                {
                    MessageBox.Show("Do you want to save the game?");
                }
                //      }
                //    Color pixelColor = this.GetPixel(50, 50);

                //     MessageBox.Show(pi.Get(50, 50));
                //       MessageBox.Show(GetColorAt(xx, yy).ToString());

                //Jeg tror ikke Refresh() er nødvendig - det virker i hvert tilfælde ikke sådan
             //   Refresh();
                rndmobcheck();
            }
        }


        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr window);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern uint GetPixel(IntPtr dc, int x, int y);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr window, IntPtr dc);

        public Color GetColorAt(int x, int y)
        {
            IntPtr desk = GetDesktopWindow();
            IntPtr dc = GetWindowDC(desk);
            int a = (int)GetPixel(dc, x, y);
            ReleaseDC(desk, dc);
            return Color.FromArgb(255, (a >> 0) & 0xff, (a >> 8) & 0xff, (a >> 16) & 0xff);
        }

   /*     private Color GetPixel(int p1, int p2)
        {
            throw new NotImplementedException();
        }*/

        PictureBox pictureBox2 = new PictureBox();

        private void Map0_Load(object sender, EventArgs e)
        {
       //     MessageBox.Show("");
            pictureBox2.Location = new System.Drawing.Point(px, py);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(10, 10);
            pictureBox2.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
