using System;
using System.Collections.Generic;

namespace evenOddChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = Convert.ToInt32(Console.ReadLine());
            List<string> testList = new List<string>();

            for (int i = 0; i < testCount; i++)
            {
                string testItem = Console.ReadLine();
                if (!string.IsNullOrEmpty(testItem))
                {
                    testList.Add(testItem);
                }
            }

            if (testList.Count > 0)
            {
                showListItem(testList);
            }
        }

        static void showListItem(List<string> testList)
        {
            
            foreach (var item in testList)
            {
                char[] itemChars = item.ToCharArray();
                string oddChar=null, evenChar = null;

                for (int i = 0; i < itemChars.Length; i++)
                {
                    if (i % 2 == 0)
                        evenChar += itemChars[i];
                    else if (i % 2 == 1)
                        oddChar += itemChars[i];
                }
                Console.WriteLine($"{evenChar} {oddChar}");
            }
        }
    }
}
