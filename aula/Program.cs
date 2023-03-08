namespace aula;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
       // Console.ReadKey();
       Exemplo exe01 = new Exemplo();

       exe01.motramsg();

       exe01.motranome(" Arthur");

       Console.WriteLine(exe01.msg());
      
       Console.WriteLine(" a soma é:" + exe01.somar(10,20)); 
    }
   
}
