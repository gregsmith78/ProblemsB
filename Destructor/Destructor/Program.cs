using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // public static void GooglePage(string link)
            {
                Process youTube = new Process();
                youTube.StartInfo.FileName = "https://www.youtube.com/watch?v=hl_9_q_uLF8";
                youTube.StartInfo.Arguments = "ProcessStart.cs";
                youTube.Start();
            }
        }
    }
}

/*Process notePad = new Process();

notePad.StartInfo.FileName   = "notepad.exe";
            notePad.StartInfo.Arguments = "ProcessStart.cs";

            notePad.Start(); */