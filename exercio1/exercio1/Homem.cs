namespace exercio1;
class Homem: Animal
{
    public override string Fala()
    {
        return base.Fala() + " Eae blz?";
    }
}