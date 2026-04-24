namespace Clases;


public class DeCarga: Vagones
{
    private double cargaMaxima;
    public double CargaMaxima
    {
        get { return cargaMaxima; }
        set { cargaMaxima = value; }
    }
    public override double CalcularPesoMaximo()
    {
        return this.PesoMaximo = CargaMaxima + 160;
    }

    public DeCarga (double CargaMaxima)
    {
        this.CargaMaxima = cargaMaxima;
    }
}