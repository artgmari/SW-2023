namespace exercio1;
class Program
{
    static void Main(string[] args)
    {
     Homem Arthur = new Homem();
     Cao Creo= new Cao();
     Gato Pipoca = new Gato();

     Console.WriteLine(Arthur.Fala());
     Console.WriteLine(Creo.Fala());
     Console.WriteLine(Pipoca.Fala());
    }
}
