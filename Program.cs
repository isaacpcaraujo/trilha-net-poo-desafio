using DesafioSistemaCelular.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto do tipo Nokia
        Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", "32GB");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");
        // Criando um objeto do tipo Iphone
        Iphone iphone = new Iphone("987654321", "iPhone 13", "987654321098765", "128GB");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}