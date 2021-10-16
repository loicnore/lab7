using System;
using System.Collections.Generic;
using System.Text;
using core;

namespace Ann
{
    class AnnLog : LogAbstract, LogInterface
    {
        private static AnnLog i = null;

        public static AnnLog I()
        {
            if (i == null)
            {
                i = new AnnLog();
            }
            return i;
        }
        private AnnLog() { }

        List<string> logs = new List<string>();

        public LogInterface log(string str)
        {
            logs.Add(str);
            return this;
        }

        public LogInterface write()
        {
            writeConsole(logs.ToArray());
            return this;
        }
    }
}
