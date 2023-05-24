namespace exercicio_2;
class Program
{
    static void Main(string[] args)
    {
        ContratopessoaFisica n1 = new ContratopessoaFisica();
        ContratopessoaJuridica n2 = new ContratopessoaJuridica();
             //PessoaFisica
             n1.Nome = "Arthur";
             n1.Email = "arthurgmari@gmai.com";
             n1.idade = 16;
             n1.Telefone = "+55 11 920016390";
             n1.CPF = "123.456.789-01";
//PessoaJuridica
n2.Nome = "Luis";
n2.Email = "metalsystem8621@gmail.com";
n2.Telefone = "+55 11 912345678";
n2.NomEmpresa = "Metalsystem";
n2.CNPJ = "12.345.678/0003-00.";
 Console.WriteLine(n1.MostrarDados());
Console.WriteLine();
Console.WriteLine(n2.MostrarDados());
    }
}
