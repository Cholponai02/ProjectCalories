using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCalories
{/// <summary>
/// Вспомогательный класс для меню
/// </summary>
    public static class MenuHelper
    {/// <summary>
    /// Метод для перемещения с помощью стрелочек
    /// </summary>
        public static void ExecuteMenu(List<MenuOption> options)
        {
            int index = 0;
            PrintMenu(options, index);
            Console.CursorVisible = false;
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true); //не показывает клав.
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (index + 1 < options.Count)
                    {
                        index++;
                    }
                    PrintMenu(options, index);
                }
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                    }
                    PrintMenu(options, index);
                }
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    options[index].Action();
                    index = 0;
                    PrintMenu(options, index);
                }
            }
            while (keyInfo.Key != ConsoleKey.Escape);
        }
        /// <summary>
        /// для логотипа
        /// </summary>
        internal static void ExecuteMenu(Action nameProject)  // для логотипа
        {

            Console.Clear();
            Logo.MainLogo();
            Console.WriteLine("\nНажмите Esc чтобы посмотреть меню");
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
            }
            while (keyInfo.Key != ConsoleKey.Escape);
        }

        /// <summary>
        /// Рисует меню
        /// </summary>
        private static void PrintMenu(List<MenuOption> options, int index = 0)
        {
            Console.Clear();
            for (int i = 0; i < options.Count; i++)
            {
                MenuOption option = options[i];
                if (i == index)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    
                    Console.WriteLine("=>  " + option.Title);
                    Console.ResetColor(); 
                }               
                else
                {
                    Console.WriteLine(option.Title);
                   
                }
                Console.WriteLine("----------------------------------------");
            }

        }
    }
}
