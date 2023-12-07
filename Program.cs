namespace hata_yonetimi;

class Program
{
    static void Main(string[] args)
    {
     
        try
        {
        //Hata olabileceğini düşündüğümüz kod bloğunu bu kısma yazarız.
        //Console dan girilin değer string olabilir bu hataya sebep olur.Kodda bunu kontrolü yapılıyor olmalı
        Console.WriteLine("Bir sayı giriniz");
        int sayi=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Girdimiş ooldupunuz sayı:"+sayi);

        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata:"+ ex.Message);//hata mesajı döner
        }
        finally
        {
            // Bir kod bloğunda hata olsa bile çalışmasını istediğimiz kodları finaly kısmına yazarız.
            Console.WriteLine("İşlem tamamlandı");
        }
////////////////////////////////////////////ArgumentNullException/////////////////////////////////////////////////////////////////////////////
        try
        {
            int a=int.Parse(null);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Boş değer girdiiniz"+ex);            
        }
 ////////////////////////////////////////////FormatException//////////////////////////////////////////////////////////////////////////////////
        try
        {
            int a=int.Parse("test");
            
        }
        catch (FormatException ex)
        {
            
            Console.WriteLine("Veri tipi uygun değil"+ex);            
        
        }
 /////////////////////////////////////////////OverflowException/////////////////////////////////////////////////////////////////////////////////
        try
        {
            int a=int.Parse("-12345678910");
            
        }
        catch (OverflowException ex)
        {
            
            Console.WriteLine("Çok küçük ya da çok büyük bir değer girdininiz"+ex);            
        
        }
    }
}
