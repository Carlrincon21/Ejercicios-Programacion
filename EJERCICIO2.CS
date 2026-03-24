Vehiculo objAuto = new Vehiculo ("X12312")
{
    Marca = "Toyota",
    Modelo = "Yaris"
};

Console.WriteLine ("Marca: " + objAuto.Marca + " Modelo: " + objAuto.Modelo + " Patente: "+ objAuto.ObtenerPatente()); 
public class Vehiculo
{
    private string marca;
    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }
    private string modelo;
    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }
    private string patente;
   
    public Vehiculo (string patente)
    {
        this.patente = patente;
    }

    public string ObtenerPatente()
    {
        return patente;
    }
}