﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ListBoxer
{
    public static class Worker
    {
        public static List<string> BufferedLines { get; set; } = new List<string>(0);
        public static void AppendLine(this TextBox source, string value)
        {
            if (source.Text.Length == 0)
                source.Text = value;
            else
                source.AppendText("\r\n" + value);
        }

        public static List<string> All(List<string> lines)
        {

            var result = from line in lines
                         where line.StartsWith("", true, null)
                         orderby line
                         select line;
            var result1 = lines.Where(fltr => fltr.ToUpper().StartsWith("", true, null)).OrderBy(t => t).ToList();
            return result1;
        }

        public static async void CheckBufferedLines(this Button button)
        {
            while (true)
            {
                await Task.Delay(1);
                button.Enabled = BufferedLines.Count > 0;
            }
        }

        public static async void RecordsChecker(this Label label, string message)
        {
            while (true)
            {
                await Task.Delay(1);
                label.Text = message;
            }
        }

    }
}
