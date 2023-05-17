namespace exercio1;
class Program
{
    static void Main(string[] args)
    {
     Homem n1 = new Homem();
     Cao n2= new Cao();
     Gato n3 = new Gato();

     n1.Nome = "Homem";
     n2.Nome = "Cão";
     n3.Nome = "Gato";

     Console.WriteLine(n1.Nome + ":" + n1.Fala());
     Console.WriteLine(n2.Nome + ":" + n2.Fala());
     Console.WriteLine(n3.Nome + ":" + n3.Fala());
    }
}
