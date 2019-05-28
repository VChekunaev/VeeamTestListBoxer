﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ListBox
{
    public static class Worker
    {
            public static void AppendLine(this TextBox source, string value)
            {
                if (source.Text.Length == 0)
                    source.Text = value;
                else
                    source.AppendText("\r\n" + value);
            }
    }
}
