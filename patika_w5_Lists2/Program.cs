namespace patika_w5_Lists2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coffees = new List<string>();

            Console.WriteLine("Lütfen 5 adet Kahve giriniz");

            for(int i = 0; i< 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Kahve {i+1} : ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                coffees.Add(Console.ReadLine());
                Console.ResetColor();
            }

            Console.WriteLine("\r\nGirilen Kahve İsimleri: ");
            foreach(string coffee in coffees)
            {
                Console.WriteLine(coffee);
            }

            Console.Read();
        }
    }
}
