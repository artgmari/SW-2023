namespace exercicio_2;

class ContratopessoaJuridica:Contrato
{
    public string? CNPJ {get;set;}
    public string? InsEC {get;set;}
    public string? NomEmpresa  {get;set;}

    public override string MostrarDados(){
        return base.MostrarDados() +"CNPJ: "+this.CNPJ +"Inscrição Estadual da Empresa Contratante: " + this.InsEC + "Nome da Empresa: " + this.NomEmpresa;
     }
     public override double calcularprestacao();
    {
        return((base.calcularPrestacao()/Prazo)+3);
    }
}