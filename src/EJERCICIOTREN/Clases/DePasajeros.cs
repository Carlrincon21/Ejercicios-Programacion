namespace Clases;


public class DePasajeros : Vagones
{
    private double largoEnMetros;
    public double LargoEnMetros
    {
        get { return largoEnMetros; }
        set { largoEnMetros = value; }
    }
    private double anchoUtil;
    public double AnchoUtil
    {
        get { return anchoUtil; }
        set { anchoUtil = value; }
    }
         
    public double CalcularCantidadPasajeros()
    {
        if (AnchoUtil <= 2.5)
        {
            return this.LargoEnMetros * 8;

        }
        else
        {
            return this.LargoEnMetros * 10;
        }
    }
    public DePasajeros(double largoEnMetros, double anchoUtil )
    {
        this.LargoEnMetros = largoEnMetros;
        this.AnchoUtil = anchoUtil;
    }
    public override double CalcularPesoMaximo()
    {
        return this.CalcularCantidadPasajeros() * 80;
    }

    
   
}