﻿namespace ExercicioAlunoMedia;
class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        aluno1.nome = "Outro Aluno";
        aluno1.nota1 = 4;
        aluno1.nota2 = 5;

        aluno1.mensagem();
    }
}
