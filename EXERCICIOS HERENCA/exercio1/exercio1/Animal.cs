namespace exercio1;
class Animal
{
    public string? Nome{get;set;}
    public virtual string Fala()
    {
        return Nome = "";
    }
}