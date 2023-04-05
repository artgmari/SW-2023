namespace ExercicioAlunoMedia;
class Programdesafio
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        Console.Write("Digite seu nome:");
        string? nome = Console.ReadLine();
        Console.Write("Sua 1° nota:");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite sua 2° nota:");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        aluno1.nome = nome ="";
        aluno1.nota1 = nota1;
        aluno1.nota2 = nota2;

        aluno1.mensagem();
    }
}
