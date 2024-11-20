using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Teste Nokia:");
        Smartphone nokia = new Nokia("123456", "Nokia 3310", "111111111", 32);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\nTeste iPhone:");
        Smartphone iphone = new Iphone("654321", "iPhone 13", "222222222", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}