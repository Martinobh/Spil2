using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;


/*
 Racenr:
1 = Orc
2 = Kobold
3 = Hobgoblin
4 = Lizardman
5 = Bugbear  
6 = Wolf
7 = Lion  
8 = Bear
9 = Eagel
10 = Horse
11 = Puma
12 = Giant Spider
13 = Giant Scorpion 
14 = Gorilla
15 = Bull
16 = Ogre
17 = 
18 =
19 =
20 =
21 =
22 =
23 =
24 =
25 =
 */



namespace Spil2
{



public class Monster
    {
        public int Id;
        int racenr;
        string Name;
        public int Hp;
        int Ac;
        int Att;
        int Dmg;
        int IniBase;
        public int Ini;
        public bool Alive;
        int Xp;
        public int LifeXp;

        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(min, max);
            }
        }

        Random rnd = new Random();

        public void SetName(string n)
        { Name = n; }
        public string GetName()
        { return Name; }

        public void SetId(int i)
        { Id = i; }
        public int GetId()
        { return Id; }

        public void iniHp(int h)
        { Hp = h; }
        public void SetHp(int h)
        { Hp = Hp - h; }
        public int GetHp()
        { return Hp; }

        public void SetAc(int a)
        { Ac = a; }
        public int GetAc()
        { return Ac; }

        public void SetAtt(int a)
        { Att = a; }

        public int GetAtt()
        { return GetRandomNumber(1, 10) + Att; }


        public void SetDmg(int d)
        { Dmg = d; }
        public int GetDmg()
        { return GetRandomNumber(2, 5) + Dmg; }

        public void SetIni(int i)
        { IniBase = i; }

        public int MakeIni()
        {
            Ini = GetRandomNumber(1, 10) + IniBase;
            return Ini;
        }

        public int ShowIni()
        { return Ini; }

        public void SetAlive(bool a)
        { Alive = a; }
        public bool GetAlive()
        { return Alive; }

        public void SetXp(int x)
        { Xp = x; }
        public int GetXp()
        { return Xp; }

        public int AddXp(int x)
        {
            Xp = Xp + x;
            return Xp; }

        public void SetLifeXp(int x)
        { LifeXp = LifeXp + x; }
        public int GetLifeXp()
        { return LifeXp; }

        public void SetRacenr(int n)
        { racenr = n; }
        public int GetRacenr()
        { return racenr; }

    }

    public class Orc : Monster 
    {
    }
    public class Kobold : Monster
    {
    }
    public class Bugbear : Monster
    {
    }
    public class Ogre : Monster
    {
    }
    public class HillGiant : Monster
    {
    }

    public class Wolf : Monster
    {
    }
    public class tester { }

    public class Lizardman : Monster
    {
    }


    public class MonsterPOPGrowth{

        public void initiateMonsterPOPGrowth() 
        {


        }

   }




}
