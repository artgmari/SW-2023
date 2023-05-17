namespace exercio1;
class Homem: Animal
{
    public override string Fala()
    {
        return base.Fala() + " Homem: Eae blz?";
    }
}