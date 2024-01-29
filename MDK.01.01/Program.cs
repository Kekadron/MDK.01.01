internal class Program
{
    private static void Main(string[] args)
    {
        //главный метод с циклом и switch'ом.
        int choose = 0;
        while (choose != 228)
        {
            switch (choose)
            {
                case 0:
                    choose = Scene0();
                    break;
                case 1:
                    choose = Scene1();
                    break;
                case 2:
                    choose = Scene2();
                    break;
                case 3:
                    choose = Scene3();
                    break;
                case 4:
                    choose = Scene4();
                    break;
                default:
                    break;
            }
        }
    }

    static int Scene0()
    {
        //переменная для хранения выбора пользователя.
        string userChoose = "0";
        //сцена 1.
        Console.WriteLine("==========================");
        Console.WriteLine("|| Подошёл к техникуму  ||");
        Console.WriteLine("==========================");
        Console.WriteLine("Ваши действия: \n1.Пошёл на пары \n2.Пошёл домой\n3.Попал в аварию\n4.Пошёл за шавухой");
        Console.Write(">");
        userChoose = Console.ReadLine();
        int intVal = (int)Char.GetNumericValue(userChoose[0]);

        switch (intVal)
        {
            case 1:
                Console.WriteLine("Вы выбрали 1");
                return 1;
            case 2:
                Console.WriteLine("Вы выбрали 2");
                return 2;
            case 3:
                Console.WriteLine("Вы выбрали 3");
                return 3;
            case 4:
                Console.WriteLine("Вы выбрали 4");
                return 4;
            default:
                Console.WriteLine("Неверное значение, повторите ввод");
                return 0;
        }
    }
    static int Scene1()
    {
        string userChoose = "0";
        //сцена 2.
        Console.WriteLine("Пришли на пару");
        Console.WriteLine("Прошло 15 минут и Вы уснули");
        Console.WriteLine("Пара закончилась, что дальше?");
        Console.WriteLine("Ваши действия: \n1.Дальше идти на пары \n2.Пойти домой");
        Console.Write(">");
        userChoose = Console.ReadLine();
        int intVal = (int)Char.GetNumericValue(userChoose[0]);
        switch (intVal)
        {
            case 1:
                Console.WriteLine("Вы выбрали 1");

                return 1;
            case 2:
                Console.WriteLine("Вы выбрали 2");
                return 2;

            default:
                Console.WriteLine("Неверное значение, повторите ввод");
                return 0;
        }
    }

    static int Scene2()
    {
        string userChoose = "0";
        //сцена 3.
        Console.WriteLine("Вы пришли домой.");
        Console.WriteLine("К вам подошла мама и спросила почему вы так рано вернулись");
        Console.WriteLine("Ваши действия: \n1.Сказать правду \n2.Соврать (шанс 75%)");
        Console.Write(">");
        userChoose = Console.ReadLine();
        int intVal = (int)Char.GetNumericValue(userChoose[0]);
        switch (intVal)
        {
            case 1:
                Console.WriteLine("Вы решили сказать правду");
                Console.WriteLine("Мама сегодня добрая и разрешила остаться дома.");
                return 0;
            case 2:
                Console.WriteLine("Вы решили соврать");
                Random rnd = new Random();
                int success = rnd.Next(1, 4);
                if (success == 1)
                {
                    Console.WriteLine("Мама вам не поверила и отправила на пары");
                    return 1;
                }
                else
                {
                    Console.WriteLine("Мама поверила, вам повезло");
                    return 0;
                }
            default:
                Console.WriteLine("Неверное значение, повторите ввод");
                return 0;
        }
    }
    static int Scene3()
    {
        //сцена 4.
        Console.WriteLine("И зачем вы это сделали?");
        Console.WriteLine("GAME OVER");
        return 0;
    }
    static int Scene4()
    {
        //сцена 5.
        Console.WriteLine("Вы проголодались и решили купить шавухи");
        Console.WriteLine("Вы сделали заказ");
        Console.WriteLine("Прошло 10 минут и вам отдали шавуху");
        Console.WriteLine("Вы наелись и пошли домой");
        return 2;
    }
}