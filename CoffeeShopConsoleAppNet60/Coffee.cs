public abstract class Coffee
{
    public int Pris { get; set; }

    public Coffee(int pris)
    {
        Pris = pris;
    }
    public virtual int Price()
    {
        return 20;
    }
}
