namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Sobrescreve o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei,memoria)
        {
        }

        // Sobrescreve o método InstalarAplicativo para o Nokia
        public override void InstalarAplicativo(string aplicativo)
        {
            Console.WriteLine($"Instalando {aplicativo} no Nokia {Modelo} com memoria {Memoria} e Imei {Imei}.");
        }
    }
}