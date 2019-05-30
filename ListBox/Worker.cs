using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.CompilerServices;


namespace ListBoxer
{
    public static class Worker
    {
        public static List<string> UndoBufferedLines { get; set; } = new List<string>();
        public static List<string> BufferedLines { get; set; } = new List<string>();
    }
}
