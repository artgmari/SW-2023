namespace Exercicio;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("DIGITE SEU NOME: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("Seu nome é: "+nome);
        Console.Write("Digite um número:");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O número digitado foi:" + numero1);

    }
}
