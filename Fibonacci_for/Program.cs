using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        double ant = 1, prox = 0;
        int posicao;

        Console.WriteLine(" Informe a posição desejada:  ");
        posicao = int.Parse(Console.ReadLine());

        for( int i=0; i < posicao; i++)
        {
            Console.WriteLine(ant + prox + " ");
            prox = ant + prox;
            ant = prox - ant;
            
        }
    }
}