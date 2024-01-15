using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        string b = a % 2 == 0 ? a.ToString() + " is even" : a.ToString() + " is odd";
        Console.Write(b);
    }
}