internal class Programs
{
    private static void Main(string[] args)
    {
        int Prompt(string msg)
        {

            Console.WriteLine($"{msg}");
            return Convert.ToInt32(Console.ReadLine());
        }
        int number = Prompt("Введите число");
        string ss = "Это не день недели";
        string check(int number)
        {
            if (number >= 6 && number < 8) ss = "Это выходной";  //Если число больше или равно 6 и меньше 8 то выходной
            if (number >= 1 && number < 6) ss = "Это будний день"; //Больше 1 и меньше 6 
            return ss;
        }
        Console.WriteLine(check(number));
    }
}