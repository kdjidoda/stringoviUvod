﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringovi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hrvatska ima more.";
            string s2 = "Italija je prvak svijeta. ";
            string s3 = s1.Substring(0, 8) + s2.Substring(7);
        }
    }
}
