namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {  //while
        // 1den başlayarak consoledan girilen sayı dahil ort hesaplayıp consola yazma
           /* Console.Write("Lütfen bir sayi giriniz:");

            int sayi =int.Parse(Console.ReadLine());
            int sayaç = 1;
            int toplam = 0;
           while (sayaç <= sayi)
           {    
                toplam += sayaç;
                sayaç++; //sonsuz döngü devam etmesin diye 1 arttır.
            
           }

           Console.WriteLine(toplam/sayi);*/

            // adan zye kadar tüm harfleri konsola yazdır.
            /* char character = 'a';
            while (character <= 'z')

            {
                Console.Write(character);
                character ++;
            }            */

            // foreach

            string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};  //Dizi tanımlama
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}