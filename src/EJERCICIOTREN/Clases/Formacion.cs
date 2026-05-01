namespace Clases;

public class Formacion
{
    private bool estaEnMovimiento;
    public bool EstaEnMovimiento
    {
        get { return estaEnMovimiento; }
        set { estaEnMovimiento = value; }
    }
    private List<Locomotora> locomotoras;
    public List<Locomotora> Locomotoras
    {
        get { return locomotoras; }
        set { locomotoras = value; }
    }
    private List<Vagones> vagones;
    public List<Vagones> Vagones
    {
        get { return vagones; }
        set { vagones = value; }
    }
     public double TotalPasajerosFormacion()
    {
        double totalizador = 0;
        foreach (var v in Vagones)
        if (v is DePasajeros vPasajero)
            {
                totalizador += vPasajero.CalcularCantidadPasajeros();
            }       
            return totalizador;
    }

}