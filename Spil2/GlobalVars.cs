using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spil2
{
    public class GlobalVars
    {


        public int xCord = 0;
        public int yCord = 0;

        public void setxCord(int a, int b)
        {
            xCord = a;
            yCord = b;
        }
        public void GetxCord()
        {

        }

        static int _globalValuex;

        /// <summary>
        /// Access routine for global variable.
        /// </summary>
        public static int GlobalValuex
        {
            get
            {
                return _globalValuex;
            }
            set
            {
                _globalValuex = value;
            }
        }

        static int _globalValuey;

        /// <summary>
        /// Access routine for global variable.
        /// </summary>
        public static int GlobalValuey
        {
            get
            {
                return _globalValuey;
            }
            set
            {
                _globalValuey = value;
            }
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

      

    }
}
