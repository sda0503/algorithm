using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        for(int i=0; i<s.Length; i++)
        {
            if(Char.IsLower(s[i]))
                Console.Write(Char.ToUpper(s[i]));
            else
                Console.Write(Char.ToLower(s[i]));
        }
    }
}