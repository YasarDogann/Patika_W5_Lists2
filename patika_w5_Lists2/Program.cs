namespace patika_w5_Lists2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List ile dinamik liste oluşturdum.
            List<string> coffees = new List<string>();

            Console.WriteLine("Lütfen 5 adet Kahve giriniz");

            // for döngüsü ile liste içine verileri kaydettim
            for(int i = 0; i< 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red; // yazı rengi kırmızı
                Console.Write($"Kahve {i+1} : ");
                Console.ResetColor(); // yazı rengini resetle

                Console.ForegroundColor = ConsoleColor.Green;
                coffees.Add(Console.ReadLine());
                Console.ResetColor();
            }

            Console.WriteLine("\r\nGirilen Kahve İsimleri: ");
            // foreach döngüsü ile listedeki elemanları çıktı verdim
            foreach(string coffee in coffees)
            {
                Console.WriteLine(coffee);
            }

            Console.Read();
        }
    }
}
