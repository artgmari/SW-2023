namespace aula;
class Exemplo
{
//artibutos
public string nome = "";
public int idade = 0;
public bool vacinado = false;

//metodos
public void motramsg(){
    Console.WriteLine("Oi 2°F");
    }
    public void motranome(string texto){
    Console.WriteLine("Oi " + texto);
    }
     public string msg(){
        return "Olá lindão";
    }
    public int somar(int a, int b){
        return a+b;
    }
}
