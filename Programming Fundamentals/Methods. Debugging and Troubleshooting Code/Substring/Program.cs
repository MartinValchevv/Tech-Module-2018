using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        bool hasMatch = false;
        const char Search = 'p';

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == Search)
            {
                hasMatch = true;

                int endIndex = i + jump;

                if (endIndex >= text.Length)
                {
                    endIndex = text.Length - 1;
                }

                string matchedString = text.Substring(i, endIndex - (i - 1));
                Console.WriteLine(matchedString);

                i = endIndex - 1;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}