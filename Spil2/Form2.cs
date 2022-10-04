using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Spil2
{
    public partial class Form2 : Form
    {


        Random random = new Random();
        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(min, max);
            }
        }
        // Each of these letters is an interesting icon
        // in the Webdings font,
        // and each icon appears twice in this list
        List<string> icons = new List<string>() 
    { 
       "N"
    };

        Label iconLabel;
        private void AssignIconsToSquares()
        {
            
            tableLayoutPanel1.Padding=new Padding(0,0,0,0);
            tableLayoutPanel1.Margin = new Padding(0, 0, 0, 0);
            // The TableLayoutPanel has 16 labels,
            // and the icon list has 16 icons,
            // so an icon is pulled at random from the list
            // and added to each label
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    // iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }  
        
        string[,] Matrix;
        int dimention = 0;
        int antalSpoegelser = 0;
        string MatrixSomStreng = "";
        int antalMurIProcent = 0;

        public Form2()
        {
            InitializeComponent();
            AssignIconsToSquares();
            KeyPreview = true;
            Shown += Form2_Shown;
        //    this.KeyPress += new KeyPressEventHandler(keypressed);
        //    this.tableLayoutPanel1.CellPaint += new TableLayoutCellPaintEventHandler(tableLayoutPanel1_CellPaint);
        //    for (int i = 0; i < 1; i++)
         //   {

            //    this.tableLayoutPanel1.CellPaint += new TableLayoutCellPaintEventHandler(tableLayoutPanel1_CellPaint);
            /*    Label label1 = new Label();
                this.label1.AutoSize = false;
                
                label1.BackColor = System.Drawing.Color.Gray;
                label1.Dock = System.Windows.Forms.DockStyle.Fill;
                label1.TextAlign = ContentAlignment.MiddleCenter;
                this.label1.Size = new System.Drawing.Size(22, 22);
                this.label1.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                this.label1.Margin = new Padding(0, 0, 0, 0);
                int J = GetRandomNumber(1, 18);
                int K = GetRandomNumber(1, 18);
                if (J == 10 && K == 1)
                { }
                else
                {
                    tableLayoutPanel1.Controls.Add(label1, J, K);
                } */
             //   MessageBox.Show(J.ToString(), K.ToString());
          //  }
            
      /*      Label L2 = new Label();
            L2.AutoSize = false;
            L2.BackColor = System.Drawing.Color.Yellow;
            L2.Size = new System.Drawing.Size(25, 25);
            L2.Padding = new Padding(0, 0, 0, 0);
            L2.Dock = DockStyle.Fill;
            L2.Dock = System.Windows.Forms.DockStyle.Fill;

            int u = GetRandomNumber(1, 20);
            int l = GetRandomNumber(1, 20);
            tableLayoutPanel1.Controls.Add(L2, u, l);
*/

            Control c1 = this.tableLayoutPanel1.GetControlFromPosition(x, y);

            if (GlobalStaticVars.GlobalVarX > 0 || GlobalStaticVars.GlobalVarY > 0)
            {
                x = GlobalStaticVars.GlobalVarX;
                y = GlobalStaticVars.GlobalVarY;
                this.tableLayoutPanel1.SetRow(c1, y);
                this.tableLayoutPanel1.SetColumn(c1, x);
                GlobalStaticVars.GlobalVarX = 0;
                GlobalStaticVars.GlobalVarY = 0;
            }

         //   tableLayoutPanel1.Controls.Add(label1, 2, 2);
            
        //    TextBox1.KeyPress += new KeyPressEventHandler(TextBox1_KeyPress);
            
        }


        void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
    /*        if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                MessageBox.Show("Form.KeyPress: '" +
                    e.KeyChar.ToString() + "' pressed.");

                switch (e.KeyChar)
                {
                    case (char)49:
                    case (char)52:
                    case (char)55:
                        MessageBox.Show("Form.KeyPress: '" +
                            e.KeyChar.ToString() + "' consumed.");
                        e.Handled = true;
                        break;
                }
            }*/
 

        }


        private void keypressed(Object o, KeyPressEventArgs e)
        {

        /*    if (e.KeyChar == (char)Keys.Return)
            {
           //     MessageBox.Show("");
                e.Handled = true;
            }*/
        }

        int backcolorFlag = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
      //      MessageBox.Show("ikke forskellig");
        //    this.tableLayoutPanel1.CellPaint += new TableLayoutCellPaintEventHandler(tableLayoutPanel1_CellPaint);
               
        //    MessageBox.Show(backcolorFlag.ToString());
        //    if (backcolorFlag == 0)
        //    {
           //     button1.Click += new EventHandler(this.button1_Click);
              //  backcolorFlag = 1;
         //   }
           //         string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Martin\Documents\Visual Studio 2013\Projects\Spil2\Map1.txt");
         //   MessageBox.Show(e.CellBounds.Location.ToString());
         //   MessageBox.Show(e.Column.ToString());
    /*        if (e. == 0)
            { }
            
             if (lines[1] == "b")
             {
                 //     MessageBox.Show("ikke forskellig");
                 Graphics g = e.Graphics;
                 Rectangle r = e.CellBounds;
                
                 g.FillRectangle(Brushes.Blue, r);
             }
             else
             {
                 Graphics g = e.Graphics;
                 Rectangle r = e.CellBounds;
               
                 g.FillRectangle(Brushes.Green, r);
             }
            */
            
        }

        private void Form2_Shown(Object sender, EventArgs e)
        {

        //    MessageBox.Show("You are in the Form.Shown event.");
            this.tableLayoutPanel1.CellPaint += new TableLayoutCellPaintEventHandler(tableLayoutPanel1_CellPaint);
            /*  
             J = GetRandomNumber(1, 18);
            
            if (e.Row == J) // || e.Column == K)
             {
                 Graphics g = e.Graphics;
                 Rectangle r = e.CellBounds;
                 g.FillRectangle(Brushes.Green, r);

             }*/

    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dimention = Convert.ToInt32(20);
       //     antalSpoegelser = Convert.ToInt32(2);
            antalMurIProcent = Convert.ToInt32(20);

            Matrix = new string[dimention, dimention];

            Random random = new Random();
            int randomNumberTilPacmanX = random.Next(1, dimention - 1);
            int randomNumberTilPacmanY = random.Next(1, dimention - 1);
            Matrix[randomNumberTilPacmanX, randomNumberTilPacmanY] = "P";

            for (int i = 0; i < dimention; i++)
            {
                for (int j = 0; j < dimention; j++)
                {
                    if (i == 0 || j == 0 || i == dimention - 1 || j == dimention - 1)
                    {
                        Matrix[i, j] = "#";
                    }
                    else
                    {
                        if ((i != randomNumberTilPacmanX || j != randomNumberTilPacmanY))
                        {
                            int randomNumber = random.Next(0, 100);
                            if (randomNumber > antalMurIProcent)
                            {
                                Matrix[i, j] = "*";
                            }
                            else
                            {
                                Matrix[i, j] = "#";
                            }
                        }
                    }
                }
            }

       /*     for (int u = 0; u < antalSpoegelser; u++)
            {
                int randomNumberTilSpoegelseX = random.Next(1, dimention - 1);
                int randomNumberTilSpoegelseY = random.Next(1, dimention - 1);

                if (Matrix[randomNumberTilSpoegelseX, randomNumberTilSpoegelseY] == "G" || Matrix[randomNumberTilSpoegelseX, randomNumberTilSpoegelseY] == "P")
                {
                    u = u - 1;
                }
                else
                {
                    Matrix[randomNumberTilSpoegelseX, randomNumberTilSpoegelseY] = "G";
                }
            }
            */
        }

       /* Point? GetRowColIndex(TableLayoutPanel tlp, Point point)
        {
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return null;

            int w = tlp.Width;
            int h = tlp.Height;
            int[] widths = tlp.GetColumnWidths();

            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
                w -= widths[i];
            int col = i + 1;

            int[] heights = tlp.GetRowHeights();
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
                h -= heights[i];

            int row = i + 1;

            return new Point(col, row);
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            var cellPos = GetRowColIndex(tableLayoutPanel1,tableLayoutPanel1.PointToClient(Cursor.Position));
        }
       */

        int x = 10;
        int y = 1;

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
         //      MessageBox.Show(x.ToString(), y.ToString());
            if (GlobalStaticVars.GlobalVarX > 0 || GlobalStaticVars.GlobalVarY > 0)
            {
          //      MessageBox.Show("underligt");  
           //   x = GlobalStaticVars.GlobalVarX;
            //  y = GlobalStaticVars.GlobalVarY;
            }
      
        //    MessageBox.Show(GlobalStaticVars.GlobalVarX.ToString(), GlobalStaticVars.GlobalVarY.ToString());
       //     GetBrushFor(2, 1);
            if (x < 0 || y < 0)
            { }
            else
            {
             //   MessageBox.Show(x.ToString(), y.ToString());

                Control c1 = this.tableLayoutPanel1.GetControlFromPosition(x, y);
            //    MessageBox.Show(x.ToString(), y.ToString());
/*
                if (GlobalStaticVars.GlobalVarX > 0 || GlobalStaticVars.GlobalVarY > 0)
                {
                    x = GlobalStaticVars.GlobalVarX;
                    y = GlobalStaticVars.GlobalVarY;
                    this.tableLayoutPanel1.SetRow(c1, y);
                    this.tableLayoutPanel1.SetColumn(c1, x);
                    GlobalStaticVars.GlobalVarX = 0;
                    GlobalStaticVars.GlobalVarY = 0;
                }

                */

                string color = "";

                if (e.KeyCode == Keys.Up)
                {
                    c1 = this.tableLayoutPanel1.GetControlFromPosition(x, y);
                    y = y - 1;
                    Control c2 = this.tableLayoutPanel1.GetControlFromPosition(x, y);
                    if (c2 != null)
                    {
               //         MessageBox.Show("forskellig");
                        y = y + 1;
                        c1 = this.tableLayoutPanel1.GetControlFromPosition(x, y);
                    }
                    else
                    {
                //        MessageBox.Show("ikke forskellig");
               this.tableLayoutPanel1.SetRow(c1, y);
                }
                }

                if (e.KeyCode == Keys.Down)
                {
                    c1 = this.tableLayoutPanel1.GetControlFromPosition(x, y);
                    y = y + 1;
                    Control c2 = this.tableLayoutPanel1.GetControlFromPosition(x, y);
                    if (c2 != null)
                    {
               //         MessageBox.Show("forskellig");
                        y = y - 1;
                        c1 = this.tableLayoutPanel1.GetControlFromPosition(x, y);
                    }
                    else
                    {
                //        MessageBox.Show("ikke forskellig");

                        this.tableLayoutPanel1.SetRow(c1, y);
                    }
                }
                if (e.KeyCode == Keys.Left)
                {
                    c1 = this.tableLayoutPanel1.GetControlFromPosition(x, y);
                    x = x - 1;
                    Control c2 = this.tableLayoutPanel1.GetControlFromPosition(x, y);
                    if (c2 != null)
                    {
                     //   MessageBox.Show("forskellig");
                        x = x + 1;
                        c1 = this.tableLayoutPanel1.GetControlFromPosition(x, y);
                    }
                    else
                    {
                  //      MessageBox.Show("ikke forskellig");
                        this.tableLayoutPanel1.SetColumn(c1, x);
                    }
  
                }
                if (e.KeyCode == Keys.Right)
                {
                    c1 = this.tableLayoutPanel1.GetControlFromPosition(x, y);
                    x = x + 1;
                    Control c2 = this.tableLayoutPanel1.GetControlFromPosition(x, y);
                    if (c2 != null)
                    {
                //        MessageBox.Show("forskellig");
                        x = x - 1;
                        c1 = this.tableLayoutPanel1.GetControlFromPosition(x, y);
                    }
                    else
                    {
                //        MessageBox.Show("ikke forskellig");
                        this.tableLayoutPanel1.SetColumn(c1, x);
                    }
                }
            }

            rndmobcheck();

            if (x < 0)
            { x = 0; }

             if (y < 0)
             { y = 0; }

        //     MessageBox.Show(x.ToString() + " - " + y.ToString());
        }

        private void rndmobcheck()
        {

            int a = GetRandomNumber(1,11);
            
            if(a == 3)
            { this.Enabled=false;

            GlobalStaticVars.GlobalVarX = x;
            GlobalStaticVars.GlobalVarY = y;  
            Form1 F1 = new Form1();
         //   GlobalVars.GlobalValuex = x;
         //   GlobalVars.GlobalValuey = y;
            F1.Show();
            }
        }

       /* void tableLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = e.CellBounds;
            g.FillRectangle(GetBrushFor(e.Row, e.Column), r);
        }

        private Brush GetBrushFor(int row, int column)
        {
           
            if (row == 2 && column == 1)
            { return Brushes.Red; }

            return Brushes.Blue;
        }
        */
        private void label2_Click(object sender, EventArgs e)
        {

        }

   /*     private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ikke forskellig");       
            this.tableLayoutPanel1.CellPaint += new TableLayoutCellPaintEventHandler(tableLayoutPanel1_CellPaint);
        }
*/
        int row = 0;
        int col = 0;
        string[] xAry = new string[20];
        string[] yAry = new string[20];
        string[,] Collorarray = new string[20,20];
        int Rowtaeller = 0;
        int Coltaeller = 0;

        void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
        //    MessageBox.Show("ikke forskellig");
        //    if (backcolorFlag == 0)
        //    {
           //     MessageBox.Show("ikke forskellig");
  

            if (backcolorFlag == 1)
            {
                MessageBox.Show("backcolorFlag == 1");
          //      for (int i = 0; i < 60; i++)
          //      {
          //          xAry[i] = GetRandomNumber(1, 18);
          //          yAry[i] = GetRandomNumber(1, 18);
              }
        else
    {
            
                row = GetRandomNumber(1, 18);
                col = GetRandomNumber(1, 18);
         
                    string c = "";
                    int ttt = 0;
                    if (e.Row < 20)
                    {

                        ttt = GetRandomNumber(1, 11);

                        if (ttt < 9)
                        {
                            //     MessageBox.Show("ikke forskellig");
                            Graphics g = e.Graphics;
                            Rectangle r = e.CellBounds;
                            c = "b";
                            g.FillRectangle(Brushes.Blue, r);
                        }
                        else
                        {
                            Graphics g = e.Graphics;
                            Rectangle r = e.CellBounds;
                            c = "g";
                            g.FillRectangle(Brushes.Green, r);
                        }

                    }

              //      MessageBox.Show("Rowtaeller = " + Rowtaeller + " , Coltaeller =" + Coltaeller);
                    //   Collorarray[Rowtaeller][Coltaeller] = c;
               //     Collorarray[Rowtaeller, Coltaeller] = c;
               //     Rowtaeller = Rowtaeller + 1;
                 //   MessageBox.Show("Skriv");
                    if (e.Row == 19)
                    {
                        Rowtaeller = 0;
                        Coltaeller = Coltaeller + 1;
                    }

                    if (e.Row == 19 && e.Column == 19)
                    {
                        MessageBox.Show("Skriv");
                        string filePath = @"C:\Users\mbail\source\repos\Spil2\Map1.txt";

                        int length = Collorarray.GetLength(0);
                        StringBuilder sb = new StringBuilder();
                        for (int index = 0; index < length; index++)
                        {
                            for (int r = 0; r < 20; r++)
                            { sb.AppendLine(string.Join(",", Collorarray[r, index])); }
                        }

                        File.WriteAllText(filePath, sb.ToString());
                        Coltaeller = 0;
                        Rowtaeller = 0;
                        backcolorFlag = 1;
                    }
}
        //        }
        //        else
        //        {
       //             string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Martin\Documents\Visual Studio 2013\Projects\Spil2\Map1.txt");

                  //  MessageBox.Show(e.CellBounds.Location.X.ToString());
                  //  MessageBox.Show(e.CellBounds.Location.Y.ToString());
        //            MessageBox.Show(e.CellBounds.Location.ToString());
        //            MessageBox.Show(e.Column.ToString());
         //           if (e.Column == 0)
          //          { }
                   /*
                    if (lines[1] == "b")
                    {
                        //     MessageBox.Show("ikke forskellig");
                        Graphics g = e.Graphics;
                        Rectangle r = e.CellBounds;
                
                        g.FillRectangle(Brushes.Blue, r);
                    }
                    else
                    {
                        Graphics g = e.Graphics;
                        Rectangle r = e.CellBounds;
               
                        g.FillRectangle(Brushes.Green, r);
                    }*/
                
           //     }
            //    System.IO.File.WriteAllLines(@"C:\Users\Martin\Documents\Visual Studio 2013\Projects\Spil2\Map1.txt", xAry);


                  /*  Graphics gg = e.Graphics;
                    Rectangle rr = ((1),(2),(2),(2));

                    gg.FillRectangle(Brushes.Green, rr);
                    */

               //     Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
               //     e.Graphics.DrawRectangle(blackPen, 10, 10, 100, 100);
            //    }
               /* if (e.Row == row && e.Column == col)
                {
                    Graphics g = e.Graphics;
                    Rectangle r = e.CellBounds;
                    g.FillRectangle(Brushes.Green, r);

                }*/
            
                //    backcolorFlag = 1;

                //}
                
         //   }
    //        GetBrushFor(J, K)

          /*  if (e.Row == 0 || e.Row == 2)
            {
                Graphics g = e.Graphics;
                Rectangle r = e.CellBounds;
                g.FillRectangle(Brushes.Green, r);
            }*/
        }

    }
}
