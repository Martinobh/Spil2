using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.Serialization.Json;
using System.Net;

namespace Spil2
{
    public partial class Form1 : Form
    {
        static Random rndmobs = new Random();
        public int mobs;
        public int MonstersAlive;
        public int samletXP;
        public bool exit;

        public Form1()
        {
            InitializeComponent();
            initiate_heroes();
            initiatemonsters(2, 5);
            exit = true;
            
            
        }




        public void initiatemonsters(int a, int c) 
        { 
        mobs = rndmobs.Next(a, c);
        MonstersAlive = mobs;
        flowLayoutPanel1.Controls.Clear();
        flowLayoutPanel1.Enabled = false;
        New_encounter.Enabled = false;
          
            for (int i = 6; i < mobs + 6; i++)
            {
                Button b = new Button();
                b.Name = i.ToString();
                monsterlist.Add(rndmob(i));
                string item = monsterlist[monsterlist.Count - 1].GetName();
                b.Text = item.ToString();
                b.AutoSize = false;
                b.TextAlign = ContentAlignment.MiddleCenter;
                b.Click += new EventHandler(b_Click);
                flowLayoutPanel1.Controls.Add(b);


                l = new Label();
                l.Name = i.ToString();
                l.BorderStyle = BorderStyle.FixedSingle;
                l.Width = 40;
                l.Text = monsterlist[monsterlist.Count - 1].GetHp().ToString();
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.AutoSize = false;
                //    l.Click += new EventHandler(l_Click);
                flowLayoutPanel1.Controls.Add(l);

            }   
        
        }

        private static Random random;
        private static object syncObj = new object();
        private static void InitRandomNumber(int seed)
        {
            random = new Random(seed);
        }

        List<Monster> monsterlist = new List<Monster>();

        public void initiate_heroes()
        {
            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Martin\Documents\Visual Studio 2013\Projects\Spil2\Xp.txt");
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\mbail\source\repos\Spil2\Xp.txt");
            Monster Hero0 = new Monster();
            Hero0.SetId(0);
            Hero0.SetAc(22);
            Hero0.iniHp(300);      
            Hero0.SetAlive(true);
            Hero0.SetAtt(30);
            Hero0.SetDmg(5);
            Hero0.SetIni(3);
            Hero0.SetXp(Int32.Parse(lines[0]));
            H0_Hp.Text = Hero0.GetHp().ToString();
            H0_AC.Text = Hero0.GetAc().ToString();
            H0_Xp.Text = Hero0.GetXp().ToString();
            monsterlist.Add(Hero0);

            Monster Hero1 = new Monster();
            Hero1.SetId(1);
            Hero1.SetAc(30);
            Hero1.iniHp(200);
            Hero1.SetAlive(true);
            Hero1.SetAtt(20);
            Hero1.SetDmg(5);
            Hero1.SetIni(3);
            Hero1.SetXp(Int32.Parse(lines[1]));
            H1_Hp.Text = Hero1.GetHp().ToString();
            H1_AC.Text = Hero1.GetAc().ToString();
            H1_Xp.Text = Hero1.GetXp().ToString();
            monsterlist.Add(Hero1);

            Monster Hero2 = new Monster();
            Hero2.SetId(2);
            Hero2.SetAc(20);
            Hero2.iniHp(100);
            Hero2.SetAlive(true);
            Hero2.SetAtt(10);
            Hero2.SetDmg(5);
            Hero2.SetIni(3);
            Hero2.SetXp(Int32.Parse(lines[2]));
            H2_Hp.Text = Hero2.GetHp().ToString();
            H2_AC.Text = Hero2.GetAc().ToString();
            H2_Xp.Text = Hero2.GetXp().ToString();
            monsterlist.Add(Hero2);

            Monster Hero3 = new Monster();
            Hero3.SetId(3);
            Hero3.SetAc(40);
            Hero3.iniHp(450);
            Hero3.SetAlive(true);
            Hero3.SetAtt(40);
            Hero3.SetDmg(15);
            Hero3.SetIni(1);
            Hero3.SetXp(Int32.Parse(lines[3]));
            H3_Hp.Text = Hero3.GetHp().ToString();
            H3_AC.Text = Hero3.GetAc().ToString();
            H3_Xp.Text = Hero3.GetXp().ToString();
            monsterlist.Add(Hero3);

            Monster Hero4 = new Monster();
            Hero4.SetId(4);
            Hero4.SetAc(22);
            Hero4.iniHp(250);
            Hero4.SetAlive(true);
            Hero4.SetAtt(24);
            Hero4.SetDmg(12);
            Hero4.SetIni(2);
            Hero4.SetXp(Int32.Parse(lines[4]));
            H4_Hp.Text = Hero4.GetHp().ToString();
            H4_AC.Text = Hero4.GetAc().ToString();
            H4_Xp.Text = Hero4.GetXp().ToString();
            monsterlist.Add(Hero4);

            Monster Hero5 = new Monster();
            Hero5.SetId(5);
            Hero5.SetAc(18);
            Hero5.iniHp(290);
            Hero5.SetAlive(true);
            Hero5.SetAtt(26);
            Hero5.SetDmg(1);
            Hero5.SetIni(3);
            Hero5.SetXp(Int32.Parse(lines[5]));
            H5_Hp.Text = Hero5.GetHp().ToString();
            H5_AC.Text = Hero5.GetAc().ToString();
            H5_Xp.Text = Hero5.GetXp().ToString();
            monsterlist.Add(Hero5);



        }

        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(min, max);
            }
        }


        private Monster rndmob(int nr)
        {
         
            Monster rndmob = new Monster();
            int Seed = (int)DateTime.Now.Ticks;
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(.0005).TotalMilliseconds);
            Random rnd = new Random(Seed);

            //Orc o = new Orc();
            

            int rr = rnd.Next(1, 81);
        //    MessageBox.Show(rr.ToString());
            if (rr > 0 && rr < 81)
            {
                //rndmob.SetName("Orc" + nr);
                //rndmob.SetId(nr);
                //rndmob.iniHp(GetRandomNumber(2, 9));
                //rndmob.SetAc(GetRandomNumber(6, 9));
                //rndmob.SetAtt(GetRandomNumber(4, 9));
                //rndmob.SetDmg(GetRandomNumber(1, 4));
                //rndmob.SetIni(GetRandomNumber(1, 4));
                //rndmob.SetAlive(true);
                //rndmob.SetXp(15);
                //return rndmob;
                Orc o = new Orc();
                o.SetName("Orc" + nr);
                o.SetId(nr);
                o.SetRacenr(1);
                o.iniHp(GetRandomNumber(2, 9));
                o.SetAc(GetRandomNumber(6, 9));
                o.SetAtt(GetRandomNumber(4, 9));
                o.SetDmg(GetRandomNumber(1, 4));
                o.SetIni(GetRandomNumber(1, 4));
                o.SetAlive(true);
                o.SetXp(15);
                return o;

            }
            else if (rr > 80 && rr < 93)
            {
                rndmob.SetName("Ogre" + nr);
                rndmob.SetId(nr);
                rndmob.iniHp(GetRandomNumber(8, 29));
                rndmob.SetAc(GetRandomNumber(12, 14));
                rndmob.SetAtt(GetRandomNumber(14, 18));
                rndmob.SetDmg(GetRandomNumber(10, 14));
                rndmob.SetIni(GetRandomNumber(1, 4));
                rndmob.SetAlive(true);
                rndmob.SetXp(175);
                return rndmob;
            }
            else if (rr > 92 && rr < 97)
            {
                rndmob.SetName("Hill giant" + nr);
                rndmob.SetId(nr);
                rndmob.iniHp(GetRandomNumber(24, 91));
                rndmob.SetAc(GetRandomNumber(28, 34));
                rndmob.SetAtt(GetRandomNumber(35, 40));
                rndmob.SetDmg(GetRandomNumber(25, 30));
                rndmob.SetIni(GetRandomNumber(1, 4));
                rndmob.SetAlive(true);
                rndmob.SetXp(3000);
                return rndmob;
            }
            else {
                rndmob.SetName("Storm giant" + nr);
                rndmob.SetId(nr);
                rndmob.iniHp(GetRandomNumber(50, 132));
                rndmob.SetAc(GetRandomNumber(44, 54));
                rndmob.SetAtt(GetRandomNumber(55, 65));
                rndmob.SetDmg(GetRandomNumber(40, 50));
                rndmob.SetIni(GetRandomNumber(1, 4));
                rndmob.SetAlive(true);
                rndmob.SetXp(18000);
                return rndmob;
            }
        }

        Label l;

        private void initiativRolls() 
        {
            H0_Ini.Text = "";
            H1_Ini.Text = "";
            H2_Ini.Text = "";
            H3_Ini.Text = "";
            H4_Ini.Text = "";
            H5_Ini.Text = "";

            for (int i = 0; i < mobs+6; i++)
            {
                  monsterlist[i].MakeIni();
                  System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(.0005).TotalMilliseconds);               
            }



       /*     string toDisplay  ="";
            
            for (int i = 0; i < mobs + 6; i++)
            {
                toDisplay = toDisplay + "monsterlist[" + i + "]" + monsterlist[i].ShowIni() + " id: " + monsterlist[i].GetId() + "\r\n";

            }
         //   string toDisplay = string.Join(Environment.NewLine, monsterlist);
   //         MessageBox.Show(toDisplay);
*/
            monsterlist.Sort((x, y) => x.Ini.CompareTo(y.Ini));

            H0_Ini.Text = monsterlist.Find(y => y.Id == 0).Ini.ToString();
            H1_Ini.Text = monsterlist.Find(y => y.Id == 1).Ini.ToString();
            H2_Ini.Text = monsterlist.Find(y => y.Id == 2).Ini.ToString();
            H3_Ini.Text = monsterlist.Find(y => y.Id == 3).Ini.ToString();
            H4_Ini.Text = monsterlist.Find(y => y.Id == 4).Ini.ToString();
            H5_Ini.Text = monsterlist.Find(y => y.Id == 5).Ini.ToString();

       /*     string toDisplay2 = "";

            for (int i = 0; i < mobs + 6; i++)
            {
                toDisplay2 = toDisplay2 + "monsterlist[" + i + "]" + monsterlist[i].Ini + " id: " + monsterlist[i].GetId() + "\r\n";

            }*/
            //   string toDisplay = string.Join(Environment.NewLine, monsterlist);
       //     MessageBox.Show(toDisplay2);

/*

            List<Monster> SortedList = monsterlist.OrderBy(o => o.Ini).ToList();
            string toDisplay1 = "";

            for (int i = 0; i < mobs + 6; i++)
            {
                toDisplay1 = toDisplay1 + "SortedList[" + i + "]" + SortedList[i].ShowIni() + "\r\n";

            }
           
            //   string toDisplay = string.Join(Environment.NewLine, monsterlist);
            MessageBox.Show(toDisplay1);
*/
        }


        private async void button1_Click(object sender, EventArgs e)
        {
           
            H0_Att.Text = "";
            H1_Att.Text = "";
            H2_Att.Text = "";
            H3_Att.Text = "";
            H4_Att.Text = "";
            H5_Att.Text = "";
            H0_Dmg.Text = "";
            H1_Dmg.Text = "";
            H2_Dmg.Text = "";
            H3_Dmg.Text = "";
            H4_Dmg.Text = "";
            H5_Dmg.Text = "";
            
            initiativRolls();
            flowLayoutPanel1.Enabled = true;
            Attack.Text = "Next round";
            Attack.Enabled = false;
            int y = 0;
            for (int i = 0; i < mobs + 6; i++)
            {
                if(monsterlist[i].GetAlive() && monsterlist[i].Id >5)
                {
                    Monster AngribendeMonster = monsterlist[i];

                    int Attroll = AngribendeMonster.GetAtt();
                    int dmgroll = AngribendeMonster.GetDmg();

                    Random rnd = new Random();
                    List<Monster> monsterlist1;
                    
                    monsterlist1 = monsterlist.Where(o => o.GetAlive() == true && o.Id < 6).ToList();
                    y = monsterlist1.Count;
                    int r = rnd.Next(monsterlist1.Count);

                    if (monsterlist1.Count == 0)
                    { MessageBox.Show("Your party is over!");
                    break;
                    }

                    Monster ForsvarendeMonster = monsterlist1[r];
                
                         string toDisplay3 = "";

                         for (int c = 0; c < y; c++)
                         {
                             toDisplay3 = toDisplay3 + "monsterlist1[" + c + "]" + monsterlist1[c].Ini + " id: " + monsterlist1[c].GetId() + "\r\n";

                         }
    

                    if (Attroll >= ForsvarendeMonster.GetAc())
                    {
                        ForsvarendeMonster.SetHp(dmgroll);
                        if (ForsvarendeMonster.Id == 0)
                        { H0_Hp.Text = ForsvarendeMonster.GetHp().ToString(); }
                        else if (ForsvarendeMonster.Id == 1)
                        { H1_Hp.Text = ForsvarendeMonster.GetHp().ToString(); }
                        else if (ForsvarendeMonster.Id == 2)
                        { H2_Hp.Text = ForsvarendeMonster.GetHp().ToString(); }
                        else if (ForsvarendeMonster.Id == 3)
                        { H3_Hp.Text = ForsvarendeMonster.GetHp().ToString(); }
                        else if (ForsvarendeMonster.Id == 4)
                        { H4_Hp.Text = ForsvarendeMonster.GetHp().ToString(); }
                        else if (ForsvarendeMonster.Id == 5)
                        { H5_Hp.Text = ForsvarendeMonster.GetHp().ToString(); }
                        string temp2 = FeedbackBox.Text;
                        FeedbackBox.Text = "MonsterATTACK: Forsvarende hero: " + ForsvarendeMonster.Id + ", AngribendeMonster ini: " + AngribendeMonster.Ini + ", " + " AngribendeMonster id: " + AngribendeMonster.Id.ToString() + ", " + " AngribendeMonster.att: " + Attroll + " Hit  dmg:" + dmgroll + Environment.NewLine + temp2;
                        if (ForsvarendeMonster.GetHp() < 1)
                        { ForsvarendeMonster.SetAlive(false);
                        MessageBox.Show("Forsvar Id: " + ForsvarendeMonster.Id + " er død! ");
                        }
                    }
                    else
                    {
                        string temp2 = FeedbackBox.Text;
                        FeedbackBox.Text = "MonsterATTACK: Forsvar Id: " + ForsvarendeMonster.Id + " ini: " + AngribendeMonster.Ini + ", " + " mob nr: " + AngribendeMonster.Id.ToString() + ", " + "AngribendeMonster.Attack: " + Attroll + " Miss" + Environment.NewLine + temp2; // +Environment.NewLine;
                    }

                }

                if (monsterlist[i].GetAlive() && monsterlist[i].Id < 6)
                {

                    string u = "H" + monsterlist[i].Id.ToString() + "_Ini";
                    tempHeroID = monsterlist[i].Id;
                    TextBox tbx = this.Controls.Find(u, true).FirstOrDefault() as TextBox;
          //          tbx.BackColor = System.Drawing.ColorTranslator.FromHtml("#09A687");

                    flowLayoutPanel1.Enabled = true;
                    //   MessageBox.Show("ID:" + Initiativlist[i] + "Din tur!");
                    await Foo();
                    tbx.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                    
                    flowLayoutPanel1.Enabled = false;              
                }

                //            FeedbackBox.Text = FeedbackBox.Text + " Initiativslag[" + i + "] =" + Initiativslag[i] + " , Initiativlist[" + i + "] = " + Initiativlist[i] + ", " + " mob nr: " + Initiativlist[i].ToString() + ", " + Environment.NewLine;
            }
            FeedbackBox.Text = Environment.NewLine + FeedbackBox.Text;
            Attack.Enabled = Enabled; 
        }

        public int tempHeroID;
        TaskCompletionSource<bool> _tcs;

        async Task Foo()
        {
            _tcs = new TaskCompletionSource<bool>();
            await _tcs.Task;
        }

        

        private void b_Click(object sender, EventArgs e) 
        {

            Button b = sender as Button;
            int at = 0;
            int HeroDMG = 0;
            Monster ForsvarendeMonster = monsterlist.Find(x => x.Id == Int32.Parse(b.Name));
            Monster AngribendeHero = monsterlist.Find(y => y.Id == tempHeroID);

            int Att = AngribendeHero.GetAtt();



            string a = FeedbackBox.Text;
            if (Att > ForsvarendeMonster.GetAc())
            {
                HeroDMG = AngribendeHero.GetDmg();
                ForsvarendeMonster.Hp = ForsvarendeMonster.Hp - HeroDMG;
                

                FeedbackBox.Text = "HeroATTACK: Hero id: " + AngribendeHero.Id + " Attroll: " + Att + ", Forsvarende AC" + ForsvarendeMonster.GetAc().ToString() + ", HIT!  HeroDMG:" + HeroDMG + Environment.NewLine + a;
                string u = "H" + AngribendeHero.Id.ToString() + "_Dmg";

                TextBox tbx = this.Controls.Find(u, true).FirstOrDefault() as TextBox;
                tbx.Text = HeroDMG.ToString();



                if (ForsvarendeMonster.Hp < 1)
                {
                    ForsvarendeMonster.Alive =false;
                    samletXP = samletXP + ForsvarendeMonster.GetXp();
                    MonstersAlive = MonstersAlive -1;
                }                
            }
            else
            {
                FeedbackBox.Text = "HeroATTACK: Hero id: " + AngribendeHero.Id + "Attroll: " + Att + ", Forsvarende AC" + ForsvarendeMonster.GetAc().ToString() + ", MISS! " + Environment.NewLine + a;
            }

            if (tempHeroID == 0)
            { H0_Att.Text = Att.ToString(); }
            if (tempHeroID == 1)
            { H1_Att.Text = Att.ToString(); }
            if (tempHeroID == 2)
            { H2_Att.Text = Att.ToString(); }
            if (tempHeroID == 3)
            { H3_Att.Text = Att.ToString(); }
            if (tempHeroID == 4)
            { H4_Att.Text = Att.ToString(); }
            if (tempHeroID == 5)
            { H5_Att.Text = Att.ToString(); }

            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is Label)
                {
                    Label LabelControl = (Label)c;

                    if (LabelControl.Name.Equals(b.Name.ToString()))
                    {                
                        string str = LabelControl.Text;
                        int hp = Int32.Parse(str);
                        int nyehp = (hp - HeroDMG);
                        LabelControl.Text = nyehp.ToString();
                        if (ForsvarendeMonster.GetAlive()==false)
                        LabelControl.BackColor = System.Drawing.ColorTranslator.FromHtml("#ee0505");
                    }
                }
            }
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is Button)
                {
                    Button LabelControl = (Button)c;

                    if (LabelControl.Name.Equals(b.Name.ToString()))
                    {
                        if (ForsvarendeMonster.GetAlive()==false)
                        {
                            LabelControl.Enabled = false;
                            LabelControl.BackColor = System.Drawing.ColorTranslator.FromHtml("#ee0505");
                        }
                    }
                }
            }


          if(MonstersAlive <= 0)
          {
              MessageBox.Show("You are the winner of an epic battle!");
              MessageBox.Show("Each player recives " + samletXP/6 + " XP");
             Monster hh0 = monsterlist.Find(y => y.Id == 0);
             Monster hh1 = monsterlist.Find(y => y.Id == 1);
             Monster hh2 = monsterlist.Find(y => y.Id == 2);
             Monster hh3 = monsterlist.Find(y => y.Id == 3);
             Monster hh4 = monsterlist.Find(y => y.Id == 4);
             Monster hh5 = monsterlist.Find(y => y.Id == 5);

             hh0.AddXp(samletXP / 6);
             hh1.AddXp(samletXP / 6);
             hh2.AddXp(samletXP / 6);
             hh3.AddXp(samletXP / 6);
             hh4.AddXp(samletXP / 6);
             hh5.AddXp(samletXP / 6);

             H0_Xp.Text = (hh0.GetXp() + (samletXP / 6)).ToString();
             H1_Xp.Text = (hh1.GetXp() + (samletXP / 6)).ToString();
             H2_Xp.Text = (hh2.GetXp() + (samletXP / 6)).ToString();
             H3_Xp.Text = (hh3.GetXp() + (samletXP / 6)).ToString();
             H4_Xp.Text = (hh4.GetXp() + (samletXP / 6)).ToString();
             H5_Xp.Text = (hh5.GetXp() + (samletXP / 6)).ToString();

              string h0 = monsterlist.Find(y => y.Id == 0).GetXp().ToString();
              string h1 = monsterlist.Find(y => y.Id == 1).GetXp().ToString();
              string h2 = monsterlist.Find(y => y.Id == 2).GetXp().ToString();
              string h3 = monsterlist.Find(y => y.Id == 3).GetXp().ToString();
              string h4 = monsterlist.Find(y => y.Id == 4).GetXp().ToString();
              string h5 = monsterlist.Find(y => y.Id == 5).GetXp().ToString();

              string[] lines = { h0, h1, h2, h3, h4, h5};
              System.IO.File.WriteAllLines(@"C:\Users\mbail\source\repos\Spil2\Xp.txt", lines);

                //   this.Close();




                //   Form2 F2 = new Form2();

                /*     if (Application.OpenForms[F2.Name] == null)
                     {
                         F2.Show();
                     }
                     else
                     {*/
                //       Application.OpenForms[F2.Name].Focus();
                //   }

                //   F2.Show();
                this.Close();

              exit = false;
           //   if (exit) Application.Exit();
              New_encounter.Enabled = true;
           //    Map0 mp = new Map0();
           //   mp.Show();
          }

            _tcs.SetResult(false);
              
     
        }

        private void New_encounter_Click(object sender, EventArgs e)
        {
            monsterlist.Clear();
            initiate_heroes();
            initiatemonsters(5, 20);
            Attack.Text = "Attack";
            Attack.Enabled = true;
            initiativRolls();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
        
            Application.Exit();
        }


    }
}
