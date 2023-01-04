using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCalories
{
    /// <summary>
    /// Класс главного меню
    /// </summary>
    public static class MainMenu
    {
        /// <summary>
        /// Меню в приложении
        /// </summary>
        public static List<MenuOption> options = new List<MenuOption>()
        {
            new MenuOption()
            {
                Title = "Магазин",
                Action = Shop,
            },

            new MenuOption()
            {
                Title = "Список выбранных продуктов (Корзина)",
                Action = OnShowAll,
            },
            new MenuOption()
            {
                Title = "Ежедневная норма калорий",
                Action = DailyCalorieIntake,
            },
            new MenuOption()
            {
                Title = "Рацион на неделю",
                Action = DietForWeek,
            },

            new MenuOption()
            {
                Title = "Выход",
                Action = OnExit,
            }
        };
        /// <summary>
        /// Магазин с продуктами
        /// </summary>
        public static void Shop()
        {
            Console.Clear();
            Logo.ProductLogo();
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Название    -  Белки  -     Жиры  -   Углеводы  - Общее количество калорий");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string[] AllProduct = File.ReadAllLines("Product.txt"); 
                foreach (var Producs in AllProduct) 
                    Console.WriteLine(Producs); 
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" введите название продукта, который Вы хотите купить - \n");
                Console.ForegroundColor = ConsoleColor.Blue;
                string poisk = Console.ReadLine()??"".ToLower();
                string[] strs = File.ReadAllLines("Product.txt", Encoding.Default);
                string p = strs.Where(x => x.Contains(poisk)).Select(x => x).ToArray()[0];
                File.AppendAllText("Korzina.txt", poisk + "\n");
                Console.Clear();
                Console.WriteLine(" Ваш товар успешно добавлен в корзину\n ");
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Такого товара нет\n ");
            }
            Advice();
            Escape();
        }
        /// <summary>
        /// Список выбранных продуктов
        /// </summary>
        private static void OnShowAll()
        {
            try
            {
                Console.Clear();
                Logo.BasketLogo();
                Console.WriteLine("Корзина\n ");
                string[] AllProduct = File.ReadAllLines("Korzina.txt");
                foreach (var Producs in AllProduct) 
                Console.WriteLine(Producs); 
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n" + " Вы хотите купить содержимое корзины ?\nда  \nнет \n\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                string inputAnswer = Console.ReadLine()??"";
                if (inputAnswer == "да")
                {
                    File.Delete(@"Korzina.txt");
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Вы только что купили содержимое Вашей корзины\nСпасибо за покупку\n");
                }
                else if (inputAnswer == "нет")
                {
                    File.Delete(@"Korzina.txt");
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Вы не купили ни один продукт\n");
                }
            }
            catch
            {
                Console.WriteLine(" Ваша корзина пока пуста\n");
            }
            Advice();
            Escape();
        }
        /// <summary>
        /// Ежедневная норма калорий
        /// </summary>
        private static void DailyCalorieIntake()
        {
            Console.Clear();
            Logo.CalculateLogo();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Чтобы узнать сколько калорий вы сжигаете, заполните следующие поля");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("1. Напишите пол (\"м\" - для мужчин или \"ж\" - для женщин): ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string inputSex = Console.ReadLine()??"";
            if (inputSex == "м") Console.WriteLine("Ваш выбор - мужчина");
            else if (inputSex == "ж") Console.WriteLine("Ваш выбор - женщина");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("2. Ваш вес: " );
            Console.ForegroundColor = ConsoleColor.Blue;
            string inputWeight = Console.ReadLine()??"";
            double weight = Convert.ToDouble(inputWeight);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("3. Ваш рост (см): ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string inputHeight = Console.ReadLine()??"";
            double height = Convert.ToDouble(inputHeight);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("4. Ваш возраст: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string inputAge = Console.ReadLine()??"";
            double age = Convert.ToDouble(inputAge);

            double bmrMan = 88.36 + (13.4 * weight) + (4.8 * height) - (5.7 * age);
            double bmrWoman = 447.593 + (9.247 * weight) + (3.098 * height) - (4.33 * age);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nВаш образ жизни: \n1.Сидячий  \n2.Тренировки  1-3 раза в неделю  \n3.Занятия 3-5 дней в неделю  \n4.Интенсивные тренировки 6-7 раз в неделю \n5.Спортсмены, выполняющие упражнения чаще, чем раз в день");
            Console.Write("Введите один номер из вышеперечисленных: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            if (inputSex == "м")
            {
                string vibor = Console.ReadLine()??"";
                if (vibor == "1")
                {
                    var result = bmrMan * 1.2;
                    Console.Write(result);
                }
                if (vibor == "2")
                {
                    var result = bmrMan * 1.375;
                    Console.Write(result);
                }
                if (vibor == "3")
                {
                    var result = bmrMan * 1.55;
                    Console.Write(result);
                }
                if (vibor == "4")
                {
                    var result = bmrMan * 1.725;
                    Console.Write(result);
                }
                if (vibor == "5")
                {
                    var result = bmrMan * 1.9;
                    Console.Write(result);
                }
            }
            else if (inputSex == "ж")
            {
                string vibor = Console.ReadLine()??"";
                if (vibor == "1")
                {
                    var result = bmrWoman * 1.18;
                    Console.Write(result);
                }
                if (vibor == "2")
                {
                    var result = bmrWoman * 1.345;
                    Console.Write(result);
                }
                if (vibor == "3")
                {
                    var result = bmrWoman * 1.53;
                    Console.Write(result);
                }
                if (vibor == "4")
                {
                    var result = bmrWoman * 1.705;
                    Console.Write(result);
                }
                if (vibor == "5")
                {
                    var result = bmrWoman * 1.84;
                    Console.Write(result);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  -   это количество калорий, необходимых для правильного функционирования организма");
            Console.Write("Ваша суточная норма белка: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            double weightProtein = weight * 1.5;
            Console.WriteLine(weightProtein);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ваша суточная норма жиров: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            double weightFat = weight * 0.8;
            Console.WriteLine(weightFat);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ваша суточная норма углеводов: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            double weightCarbohydrates = weight * 2;
            Console.WriteLine(weightCarbohydrates);
            Console.ForegroundColor = ConsoleColor.White;
            Advice();
            Escape();

        }
        /// <summary>
        /// Рацион на один день
        /// </summary>
        private static void DietForWeek()
        {
            Console.Clear();
            Logo.DietLogo();
            Console.WriteLine("Хотите диетический недельный рацион? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите день недели (например: Понедельник) и вы получите рацион на целый день: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string day = Console.ReadLine()??"".ToLower();
            Console.ForegroundColor = ConsoleColor.White;
            switch (day)
            {
                case "понедельник":
                    Console.WriteLine("Завтрак:\n пшено — 50 гр., масло сливочное — 1 ч/л, кефир-0.5 л.;\nПерекус:\n творог — 150 гр., яблоко - 1 шт.;\nОбед:\n гречка отварная — 50 гр., говядина запеченная — 150 гр., салат из свежей капусты — 100 гр., сок овощной;\nПерекус:\n яйцо вареное — 1 шт., зеленый горошек — 100 гр.;\nУжин:\n рыба на пару — 150 гр., брокколи — 100 гр., чай черный.");
                    break;
                case "вторник":
                    Console.WriteLine("Завтрак:\n овсянка — 50 гр., масло оливковое — 1 ч/л, йогурт — 200 мл, фруктовый сок;\nПерекус:\n молоко — 1 ст., банан — 1 шт.;\nОбед:\n рис — 50 гр., куриная грудка — 150 гр., огурец свежий — 1 шт., кисель;\nПерекус:\n омлет на 1 яйце, кукуруза — 100 гр.;\nУжин:\n мясо на пару — 150 гр., овощная смесь — 150 гр., сок томатный.");
                    break;
                case "среда":
                    Console.WriteLine("Завтрак:\n овсянка — 40 гр., масло сливочное — 1 ч/л, творог — 150 гр., чай зеленый; \nПерекус:\n финики — 5 шт., йогурт натуральный — 150 мл;\nОбед:\n гречка 50 гр., индейка запеченая — 150 гр., помидор — 1 шт., кисель овсяный;\nПерекус:\n молоко 1 ст., орешки 50 гр.;\nУжин:\n тунец консервированный -150 гр., капуста тушеная — 150 гр., чай зеленый.");
                    break;
                case "четверг":
                    Console.WriteLine("Завтрак:\n гречка — 50 гр., масло сливочное — 1 ч/л, бутерброд из хлеба и сливочного масла — 1 кус., чай, мед — 2 ч/л;\nПерекус:\n фруктовый салат с добавлением натурального йогурта — 200 гр.;\nОбед:\n рис — 50 гр., тушёная курица с овощами — 200 гр., салат из свеклы с оливковым маслом — 100 гр.;\nПерекус:\n банан — 1 шт., молоко — 1 ст.;\nУжин:\n омлет на двух яйцах, огурец свежий — 1 шт., компот.");
                    break;
                case "пятница":
                    Console.WriteLine("Завтрак:\n овсянка — 50гр., масло сливочное — 1 ст., яйца вареные — 2 шт., чай черный;\nПерекус:\n кефир — 1 ст., чернослив — 5 шт.;\nОбед:\n пшено — 50 гр., котлеты рыбные на пару — 2 шт., горошек зеленый — 100 гр., кисель;\nПерекус:\n йогурт натуральный — 1 ст., голубика — 100 гр.;\nУжин:\n телятина отварная — 200 гр., тушёные овощи — 100 гр., чай зеленый.");
                    break;
                case "суббота":
                    Console.WriteLine("Завтрак:\n гречка — 40 гр., масло оливковое — 1 ч/л, тост с медом — 1 шт., чай черный;\nПерекус:\n курага — 10 шт., молоко — 1 ст.;\nОбед:\n рис — 50 гр., индейка запечённая, фаршированная маложирным сыром и зеленью — 150 гр., компот;\nПерекус:\n банан — 1 шт., орехи — 50 гр.;\nУжин:\n рыба отварная — 150 гр., кукуруза — 150 гр., чай зеленый.");
                    break;
                case "воскресенье":
                    Console.WriteLine("Завтрак:\n овсянка — 50 гр., масло сливочное — 1 ч/л, творог — 150 гр., кисель;\nПерекус:\n молочное желе с фруктами — 200 гр.;\nОбед:\n рис — 50 гр., тушёная говядина с овощами — 200 гр., компот;\nПерекус:\n омлет из 1 яйца, помидор — 1 шт.;\nУжин:\n запечённая индейка — 200 гр., салат из свежей капусты с укропом — 150 гр., чай зеленый.");
                    break;
                default:
                    Console.WriteLine("Ошибка при введении!");
                    break;
            }
            Advice();
            Escape();
        }
        /// <summary>
        /// Рандомный совет 
        /// </summary>
        public static void Advice()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("!!!Совет дня!!!  ");
            string[] advice = { " Пейте воду, особенно перед едой", "Ешьте яйца на завтрак", "Пейте кофе (желательно черный)", "Пейте зеленый чай" , "Попробуйте периодическую разгрузку", "Принимайте глюкоманнан", "Ешьте меньше добавленных сахаров", " Ешьте меньше рафинированных углеводов" , " Попробуйте низкоуглеводную диету", "Используйте маленькие тарелки", "Осуществляйте контроль порций или подсчитывать калории", "Имейте при себе здоровую пищу на случай, если вдруг проголодаетесь" };
            Console.WriteLine(advice[new Random().Next(0, advice.Length)]);

        }
        /// <summary>
        /// Выход из приложения
        /// </summary>
        private static void OnExit()
        {
            Console.Clear();
            Logo.ExitLogo();           
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Спасибо за внимание!");
            Environment.Exit(0);
        }
        /// <summary>
        /// Вернуться назад используя Escape
        /// </summary>
        private static void Escape()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Нажмите Esc чтобы вернуться ");
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
            }
            while (keyInfo.Key != ConsoleKey.Escape);
        }
        /// <summary>
        /// Название проекта
        /// </summary>
        public static void NameProject()
        {
            Console.Clear();
            Logo.MainLogo();
            Console.WriteLine("Нажмите Esc чтобы вернуться ");
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
            }
            while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
