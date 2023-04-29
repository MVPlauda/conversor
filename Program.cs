//Converta metros para centimetros

internal class Program
{
    private static void Main(string[] args)
    {
        float metros, centimetros;
        Console.Write("Digite os metros: ");
        metros = float.Parse(Console.ReadLine());
        centimetros = metros * 100;

        Console.Write($"A conversão de metros para centimetros ficou: {centimetros}" );
    }
}

