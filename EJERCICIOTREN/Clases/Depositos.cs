namespace Clases;

public class Depositos
{
    private List<Locomotora> locomotoras;
    public List<Locomotora> Locomotoras
    {
        get { return locomotoras; }
        set { locomotoras = value; }
    }
    private List<Formacion> formaciones;
    public List<Formacion> Formaciones
    {
        get { return formaciones; }
        set { formaciones = value; }
    }
    public void AgregarLocomotoraEnFormacion(Locomotora locomotora, Formacion formacion)
    {
        if (!formacion.EstaEnMovimiento)
        {
            formacion.Locomotoras.Add(locomotora);
        }
    }
}
