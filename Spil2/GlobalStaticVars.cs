using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spil2
{
    static class GlobalStaticVars
    {

        private static int _globalVarX = 0;
        private static int _globalVarY = 0;

        public static int GlobalVarX
        {
            get { return _globalVarX; }
            set { _globalVarX = value; }
        }
        public static int GlobalVarY
        {
            get { return _globalVarY; }
            set { _globalVarY = value; }
        }
    }
}

