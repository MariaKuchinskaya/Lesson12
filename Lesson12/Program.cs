using System;
using System.Collections.Generic;

namespace Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsProvider provider = new NewsProvider();
            provider.Notify += WritetoConsole;


            News news1 = new News()
            {
                Title = "Navalny",
                Text = "Blat' Navalny",
                Category = NewsCategoriesEnum.Politics

            };
            News news2 = new News()
            {
                Title = "Football",
                Text = "New championship",
                Category = NewsCategoriesEnum.Sport

            };

            provider.AddNews(news1);
            provider.AddNews(news2);
            
        }

        public static void WritetoConsole (string message)
        {
            Console.WriteLine(message);
        }
    }
}
