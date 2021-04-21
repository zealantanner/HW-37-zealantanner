using System.ComponentModel;
using System.Diagnostics;
using System;

public class Program
{
    static void WhatType(dynamic thingy)
    {
        Console.WriteLine();
        if (thingy.GetType() == typeof(System.String))
        {
            Console.WriteLine(thingy + " is a string");
        }
        if (thingy.GetType() == typeof(System.Double))
        {
            Console.WriteLine(thingy + " is a double");
        }
        if (thingy.GetType() == typeof(System.Int32))
        {
            Console.WriteLine(thingy + " is a int");
        }
        if (thingy.GetType() == typeof(System.Char))
        {
            Console.WriteLine(thingy + " is a char");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        dynamic data;

        data = "Hello";
        WhatType(data);
        data = Math.PI;
        WhatType(data);
        data = 'q';
        WhatType(data);
        data = 1;
        WhatType(data);
    }
}