namespace exemploo;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Lampanda lamp1 = new Lampanda();
        Lampanda lamp2= new Lampanda();


        lamp1.ligar();
        Console.WriteLine("A lampada1 está ligada?" +  lamp1.estaLigada());
        Console.WriteLine("A lampada2está ligada?" +  lamp2.estaLigada());
    }
}
