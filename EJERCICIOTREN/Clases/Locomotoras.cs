namespace Clases;

public class Locomotora
{
    private double peso;
    public double Peso
    {
        get { return peso; }
        set { peso = value; }
    }
    private double velocidadMaxima;
    public double VelocidadMaxima
    {
        get { return velocidadMaxima; }
        set { velocidadMaxima = value; }
    }
    private double pesoMaximo;
    public double PesoMaximo
    {
        get { return pesoMaximo; }
        set { pesoMaximo = value; }
    }
    public Locomotora (double peso, double velocidadMaxima, double pesoMaximo)
    {
        this.Peso = peso;
        this.VelocidadMaxima = velocidadMaxima;
        this.PesoMaximo = pesoMaximo;
    }
    public  double ArrastreUtil()
    {
        return this.PesoMaximo - Peso;
    }
}