namespace Hata_Yonetim
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("bir sayi giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi : " + sayi);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata : "+ex.Message.ToString());
            }
            //finally
            //{
             //   Console.WriteLine("işlem tamamlandı.");
           // }

           try
           {
               //int a = int.Parse(null); // Burada yapılacak işlem consol ekranda boş geçemeyeceğine 
               int a = int.Parse("-200000000");
           }
           catch (ArgumentNullException ex) //
           {
               Console.WriteLine("boş değer girdiniz");
               Console.WriteLine(ex);
           }
           catch (FormatException ex)
           {
               Console.WriteLine("veri tipi uygun değil");
               Console.WriteLine(ex);
           }
           catch (OverflowException ex)
           {
               Console.WriteLine("çok küçük yada çok büyük değer girdiniz");
               Console.WriteLine(ex);
               
           }
        }
        
        
        
    }
    
}

