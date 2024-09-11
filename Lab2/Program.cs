using System;

public class Test
{
    public static void Main()
    {
        string firststring = "1лалала";
        Console.WriteLine(firststring);
        string secondstring = "1татата1";
        Console.WriteLine(secondstring);
        string unitedsatring1 = string.Join(' ', firststring, secondstring);
        Console.WriteLine(unitedsatring1);
        Console.WriteLine(unitedsatring1.Trim('1'));
        Console.WriteLine(unitedsatring1.StartsWith('1'));
        Console.WriteLine(unitedsatring1.StartsWith("ла"));
        Console.WriteLine(unitedsatring1.IndexOf("ла"));
        Console.WriteLine(unitedsatring1.Substring(4));
        int[] age = [36, 45, 50, 12];
        string[] name = ["John", "Sara", "Margaret", "Susie"];
        for (int i = 0; i < 4; i++)
            Console.WriteLine($"Name: {name[i]}, age {age[i]}");
        Console.WriteLine(firststring.CompareTo("1лалала"));
        string newstring = "first second third four";
        string[] words = newstring.Split(' ');
        Console.WriteLine(words[2]);
    }
}