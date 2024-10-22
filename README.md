# Patika+ Week5 Lists1 Uygulaması
Merhaba,
Bu proje C# ile Patika+ 5.hafta Lists için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- Basit bir C# programı yazmak
- C# konsol uygulamasının yapısını anlamak
- List yapısını öğrenmek
- Döngüler'i kullanmak


## İstenilen Görev
Bir kahve içsek bize iyi gelecek!
kullanıcının konsoldan gireceği 5 kahve ismiyle bir liste oluşturup, bu listeyi foreach döngüsüyle yazdıralım.

Örnek veri giriş ekranı :
![-y_hGXH-davetliler](https://github.com/user-attachments/assets/5e18f653-26a5-4889-a99e-e53607d5da9d)

Örnek Program Çıktısı:
![CO-cHvZ-kkkk](https://github.com/user-attachments/assets/42e171c9-321c-4d15-b745-2c031c84789c)


## Kod 
```csharp
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
```





