namespace Project_VC
{
    class Program
    {
        static void Main()
        {
            try{
            Console.Write("Жалмауыз, парольынды айт: ");long i = Convert.ToInt64(Console.ReadLine());

             long u1;
            {
            for (u1 = 0; u1 != i; u1++)
            {
                if (u1 == i)
                break;
                System.Console.WriteLine(u1);
            }};
            if (u1 == i)
             Console.WriteLine("Уебищный парольын табылды, Мал: " + i);
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Котакбас!!! Сандар гана!!!");
            }

        }
    }
}