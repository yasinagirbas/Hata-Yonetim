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
            finally
            {
                Console.WriteLine("işlem tamamlandı.");
            }
            
        }
        
        
        
    }
    
}

