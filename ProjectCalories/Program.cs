namespace ProjectCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Магазин с расчетом калорий";
           // Console.SetWindowSize(110, 30);

            MenuHelper.ExecuteMenu(MainMenu.NameProject);
            MenuHelper.ExecuteMenu(MainMenu.options);
        }
    }
}