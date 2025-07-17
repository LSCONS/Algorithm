using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Linq;
using System.IO.IsolatedStorage;
using System.Runtime.InteropServices;

    public class Example
    {
        public static void Main()
        {
            String s;
            Console.Clear();
            s = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            foreach(char c in s)
            {
                sb.Append(char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));
            }
            Console.WriteLine(sb.ToString());
        }
    }