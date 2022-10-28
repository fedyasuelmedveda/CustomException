using CustomException;

namespace CustomExeption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StringWithoutYo s = new StringWithoutYo(Console.ReadLine());
            }
            catch(YoException e) 
            {
                Console.WriteLine($"Ошибка {e.Message}");
            }
        }
    }
}