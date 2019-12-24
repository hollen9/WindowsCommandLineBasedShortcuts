using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ConsoleShortcuts
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start("chrome.exe", "--app=\"https://remotedesktop.google.com/access/\"");
        }
    }
}
