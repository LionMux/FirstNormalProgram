using System;
class MaiN
{
    static void Main(string[] args)
    {
        try
        {
            Program program = new Program();
            program.Switch();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}