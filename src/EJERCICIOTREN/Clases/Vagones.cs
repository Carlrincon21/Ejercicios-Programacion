namespace Clases;

public abstract class Vagones
{
    private double pesoMaximo;
    public double PesoMaximo
    {
        get { return pesoMaximo; }
        set { pesoMaximo = value; }
    }
    

    public abstract double CalcularPesoMaximo();
  
}


