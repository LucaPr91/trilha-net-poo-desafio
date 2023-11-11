using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            // Exemplos de uso
            Nokia nokia = new Nokia(numero:"48988008800",modelo: "Lumia 950",imei: "111111",memoria:32);
            Iphone iphone = new Iphone(numero: "47997678515",modelo: "15 Pro", imei: "111111", memoria: 128);

            //Nokia
            nokia.InstalarAplicativo("WhatsApp");
            TestarInstalacaoAplicativo(nokia, "Facebook");
            TestarLigacao(nokia);
            TestarRecebimentoLigacao(nokia);

            //Iphone
            iphone.InstalarAplicativo("Instagram");
            TestarInstalacaoAplicativo(iphone, "Twitter");
            TestarLigacao(iphone);
            TestarRecebimentoLigacao(iphone);
        }

        // Método de teste genérico para a instalação de aplicativos em qualquer Smartphone e efetuar/receber ligações
        static void TestarInstalacaoAplicativo(Smartphone smartphone, string aplicativo)
        {
            Console.WriteLine($"Testando a instalação do {aplicativo} em um {smartphone.GetType().Name} {smartphone.Modelo}...");
            smartphone.InstalarAplicativo(aplicativo);
        }

        static void TestarLigacao(Smartphone smartphone)
        {
            Console.WriteLine($"Testando ligação com {smartphone.GetType().Name} {smartphone.Modelo}...");
            smartphone.Ligar();
        }

        static void TestarRecebimentoLigacao(Smartphone smartphone)
        {
            Console.WriteLine($"Testando recebimento de ligação com {smartphone.GetType().Name} {smartphone.Modelo}...");
            smartphone.ReceberLigacao();
        }
    }
}