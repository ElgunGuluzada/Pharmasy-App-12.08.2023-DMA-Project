using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmasy_App_12._08._2023_DMA_Project
{
    public class Helper
    {
        public void FirstCharUp(string word)
        {
            word.ToLower();
            string newWord = "";
            char FirstCharUp = 'a';
            for (int i = 0; i < word.Length; i++)
            {
                if (i == 0)
                {
                    FirstCharUp = word[i];
                    FirstCharUp = char.ToUpper(FirstCharUp);
                    newWord += FirstCharUp;
                }
                else
                {
                    newWord += word[i];
                }
            }
            Console.WriteLine(newWord);
        }
    }
}
