public class Latte : Coffee
{
    public Latte() : base (40)
    {

    }
    public override int Price()
    {
        return 40;
    }

    public override string Strength()
    {
        return "Weak";
    }
}