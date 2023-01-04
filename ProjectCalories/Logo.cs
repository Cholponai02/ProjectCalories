using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCalories
{
    /// <summary>
    /// класс где расположены все названия
    /// </summary>
    public class Logo
    {/// <summary>
    /// Логотип  Главной страницы
    /// </summary>
        public static void MainLogo()
        {
            string logo = @"
  _       __     __ __          __  ______                              
 | |      \ \   / / \ \        / / |  ____|     /\      _               
 | |       \ \_/ /   \ \  /\  / /  | |__       /  \    (_)              
 | |        \   /     \ \/  \/ /   |  __|     / /\ \                    
 | |____     | |       \  /\  /    | |       / ____ \   _               
 |______|____|_|        \/  \/     |_|   ___/_/    \_\ (_)            _ 
        / ____|                         |  ____|                     | |
       | |  __   _   _   _ __ ___       | |__      ___     ___     __| |
       | | |_ | | | | | | '_ ` _ \      |  __|    / _ \   / _ \   / _` |
       | |__| | | |_| | | | | | | |     | |      | (_) | | (_) | | (_| |
        \_____|  \__, | |_| |_| |_|     |_|       \___/   \___/   \__,_|
                  __/ |                                                 
                 |___/                                                  ";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(logo, Console.ForegroundColor);
            string logo2 = @"
 _                     __   __                 _    _      _       _     _    ______    _      ___          
| |                    \ \ / /                | |  | |    (_)     | |   | |   |  ___|  | |    / _ \         
| |     ___  ___  ___   \ V /___  _   _ _ __  | |  | | ___ _  __ _| |__ | |_  | |_ __ _| |_  / /_\ \___ ___ 
| |    / _ \/ __|/ _ \   \ // _ \| | | | '__| | |/\| |/ _ \ |/ _` | '_ \| __| |  _/ _` | __| |  _  / __/ __|
| |___| (_) \__ \  __/   | | (_) | |_| | |    \  /\  /  __/ | (_| | | | | |_  | || (_| | |_  | | | \__ \__ \
\_____/\___/|___/\___|   \_/\___/ \__,_|_|     \/  \/ \___|_|\__, |_| |_|\__| \_| \__,_|\__| \_| |_/___/___/
                                                              __/ |                                         
                                                             |___/                                          ";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(logo2, Console.ForegroundColor);

        }
        
    /// <summary>
    /// логотип меню для калькулятора калорий
    /// </summary>
        public static void CalculateLogo()
        {
            string logo = @"
   ____      _            _         ____      _            _       _   _             
  / ___|__ _| | ___  ____(_) ___   / ___|__ _| | ___ _   _| | __ _| |_(_) ___  _ __  
 | |   / _` | |/ _ \| '__| |/ _ \ | |   / _` | |/ __| | | | |/ _` | __| |/ _ \| '_ \ 
 | |__| (_| | | (_) | |  | |  __/ | |__| (_| | | (__| |_| | | (_| | |_| | (_) | | | |
  \____\__,_|_|\___/|_|  |_|\___|  \____\__,_|_|\___|\__,_|_|\__,_|\__|_|\___/|_| |_|
";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(logo, Console.ForegroundColor);
        }/// <summary>
        /// логотип меню для продуктов
        /// </summary>
        public static void ProductLogo()
        {
            string logo = @"
  _____                       _                  _         
 |  __ \                     | |                | |        
 | |__) |  _ __    ___     __| |  _   _    ___  | |_   ___ 
 |  ___/  | '__|  / _ \   / _` | | | | |  / __| | __| / __|
 | |      | |    | (_) | | (_| | | |_| | | (__  | |_  \__ \
 |_|      |_|     \___/   \__,_|  \__,_|  \___|  \__| |___/
                                                           
                                                           
";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(logo, Console.ForegroundColor);
        }/// <summary>
        /// логотип для меню рациона приложения
        /// </summary>
        public static void DietLogo()
        {
            string logo = @"
  _____  _      _          __                                        _              
 |  __ \(_)    | |        / _|                                      | |             
 | |  | |_  ___| |_      | |_ ___  _ __      ___  _ __   ___      __| | __ _ _   _  
 | |  | | |/ _ \ __|     |  _/ _ \| '__|    / _ \| '_ \ / _ \    / _` |/ _` | | | | 
 | |__| | |  __/ |_      | || (_) | |      | (_) | | | |  __/   | (_| | (_| | |_| | 
 |_____/|_|\___|\__|     |_| \___/|_|       \___/|_| |_|\___|    \__,_|\__,_|\__, | 
                                                                              __/ | 
                                                                             |___/  ";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(logo, Console.ForegroundColor);
        }
        /// <summary>
        /// логотип для корзины
        /// </summary>
        public static void BasketLogo()
        {
            string logo = @"
  ____                  _             _   
 |  _ \                | |           | |  
 | |_) |   __ _   ___  | | __   ___  | |_ 
 |  _ <   / _` | / __| | |/ /  / _ \ | __|
 | |_) | | (_| | \__ \ |   <  |  __/ | |_ 
 |____/   \__,_| |___/ |_|\_\  \___|  \__|
                                          
                                          ";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(logo, Console.ForegroundColor);
        }
        /// <summary>
        /// Логотип для меню выхода из приложения 
        /// </summary>
        public static void ExitLogo()
        {
            string logo = @"
  _______   _                                     _ 
 |__   __| | |                                   | |
    | |    | |__     ___        ___   _ __     __| |
    | |    | '_ \   / _ \      / _ \ | '_ \   / _` |
    | |    | | | | |  __/     |  __/ | | | | | (_| |
    |_|    |_| |_|  \___|      \___| |_| |_|  \__,_|
                                                    
                                                    ";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(logo, Console.ForegroundColor);
        }
    }
}
