namespace exercicio_2;

class ContratopessoaFisica:Contrato
{
    public string? CPF{get;set;}
    public int idade{get;set;}
     public override string MostrarDados(){
        return base.MostrarDados() +"CPF: "+this.CPF +"Idade: " + this.idade;
     }
}