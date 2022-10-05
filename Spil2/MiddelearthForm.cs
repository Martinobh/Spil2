using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Spil2
{
    public partial class MiddelearthForm : Form
    {

        private int _ticks;

        public MiddelearthForm()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Map0_KeyDown);
          //  x = 50;
          //  y = 95;
            objPosition = Position.right;
            new ToolTip().SetToolTip(pictureBox2, "The desired tool-tip text.");
            //panel1.AutoScroll = true;
            timer1.Start();

            //     MiddelearthForm.KeyDown += new KeyEventHandler(Map0_KeyDown);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void MiddelearthForm_load()
        {

       //     ToolTip tt = new ToolTip();
      //     tt.SetToolTip(this.pictureBox2, "Your username");

                     //   pictureBox2.AutoToolTip = false;

        }

        //private void pictureBox2_MouseHover(object sender, EventArgs e)
        //{
        //    ToolTip tt = new ToolTip();
        //    tt.SetToolTip(this.pictureBox2, "Your username");
        //}


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
        {
            left, right, up, down
        }



        private Position objPosition;


        public int Globalpx = 400;//40;
        public int Globalpy = 280;//40;



        public int px = 400;//40;
        public int py = 280;//40;

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

            //if (px > 1273 || px < 4 || py >1020 || py < 4)
            //{ }
            //else
            //{
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.C || e.KeyCode == Keys.S)
                {
                    if (e.KeyCode == Keys.Left)
                    {
                        //    MessageBox.Show(pictureBox2.Location.ToString());
                        objPosition = Position.left;

                    //       panel1.Controls.Remove(pictureBox2);

                    if (px < 4)
                    {
                        
                        pictureBox3.Image = Image.FromFile(@"C:\Users\mbail\source\repos\Spil2\Spil2\Data\bg1.jpg");
                        px = 1276;
                        Globalpx = Globalpx - 4;
                        pictureBox1.Location = new Point(px, py);
                        e.Handled = true;
                        
                    }
                    else
                    {
                        x -= 4;
                        px = px - 4;
                        Globalpx = Globalpx - 4;
                        pictureBox1.Left = px;

                        //      MiddelearthForm.Controls.Add(pictureBox2);
                        xx = pictureBox1.Location.X;
                        yy = pictureBox1.Location.Y;
                        e.Handled = true;
                    }
                    }
                    if (e.KeyCode == Keys.Right)
                    {
                    if (px > 1272)
                    {
                        
                        pictureBox3.Image = Image.FromFile(@"C:\Users\mbail\source\repos\Spil2\Spil2\Data\bg2.gif");
                        px = 0;
                        Globalpx = Globalpx + 4;
                        pictureBox1.Location = new Point(px, py);
                        e.Handled = true;
                        
                    }
                    else
                    {

                        objPosition = Position.right;
                        x += 4;
                        px = px + 4;
                        Globalpx = Globalpx + 4;
                        pictureBox1.Left = px;
                        //       panel1.Controls.Add(pictureBox2);
                        xx = pictureBox1.Location.X;
                        yy = pictureBox1.Location.Y;
                        e.Handled = true;
                    }
                    }
                    if (e.KeyCode == Keys.Up)
                    {
                    if (py < 4)
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        objPosition = Position.up;
                        y -= 4;
                        py = py - 4;
                        pictureBox1.Top = py;
                        //       panel1.Controls.Add(pictureBox2);
                        xx = pictureBox1.Location.X;
                        yy = pictureBox1.Location.Y;
                        e.Handled = true;
                    }
                    }
                    if (e.KeyCode == Keys.Down)
                    {
                    if (py > 1016)
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        objPosition = Position.down;
                        y += 4;
                        py = py + 4;
                        pictureBox1.Top = py;
                        //       panel1.Controls.Add(pictureBox2);
                        xx = pictureBox1.Location.X;
                        yy = pictureBox1.Location.Y;
                        e.Handled = true;
                    }
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


                    label1.Text = "x=" + px.ToString();
                    label2.Text = "y=" + py.ToString();
                    label3.Text = "G-x=" + Globalpx.ToString();
                    label4.Text = "G-y=" + Globalpy.ToString();

                      rndmobcheck();
                Random rndm = new Random();

               // monsterNest m = new monsterNest();


            }
          //  }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        public GlobalVars GL = new GlobalVars();

        public void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            label5.Text = _ticks.ToString();

            

            int rn = GlobalVars.GetRandomNumber(1, 50);

            if (rn < 20)
            {
                nest n = new nest();
                n.race = "Orc";
                n.racenr = 1;
                n.number = GlobalVars.GetRandomNumber(1, 20);
                n.xCord = GlobalVars.GetRandomNumber(1, 1272);
                n.yCord = GlobalVars.GetRandomNumber(1, 1015);
                GL.Nestlist.Add(n);

            }
            else if(rn >20 && rn< 30)
            {
                nest n = new nest();
                n.race = "Ogre";
                n.racenr = 16;
                n.number= GlobalVars.GetRandomNumber(1, 10);
                n.xCord = GlobalVars.GetRandomNumber(1, 1272);
                n.yCord = GlobalVars.GetRandomNumber(1, 1015);
                GL.Nestlist.Add(n);
            }



            int iterationNr = 1;
            foreach (nest n in GL.Nestlist)
            {
                int rn2 = GlobalVars.GetRandomNumber(1, 100);

                if (rn2 < 10)
                {
                    //nest n = new nest();
                    n.number++;
                    //   GL.Nestlist.Add(n);
                 //   textBox1.Text = textBox1.Text + "," + iterationNr.ToString()+ "," + rn2.ToString() + "," + n.race + "," + n.number + Environment.NewLine + "------------" + Environment.NewLine;
                }
                string a = "";
                iterationNr++;
            }

        }
    }

    public class nest
    {
        public string race;
        public int racenr;
        public int number;
        public int xCord;
        public int yCord;


        //private void t()
        //{

        //    var random = new random();
        //    var list = new list<string> { "orc", "ogre", "goblin", "hill giant" };
        //    int index = random.next(list.count);
        //}
    }

    //class monsterNest 
    //{
    //    int XCord = 8;
    //    int YCord = 8;
    //    string Type;
    //}


}
