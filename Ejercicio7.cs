//7. Crear una clase Ninja con las variables privadas arteMarcial, arma, fuerza (entero) y salto
//(entero).
//● Crear setters y getters manualmente.
//● Crear una función Saltar() que reciba un parámetro multiplicador (entero); imprimir
//por consola salto x parámetro.
//●/ Crear la función Ataque() que imprima por consola el arma que usa el ninja y el
//arte marcial.
//● Crear dos instancias de Ninja, asignar distintos valores para cada uno de los
//atributos e invocar las funciones Saltar() y Ataque().

Ninja objNinja = new Ninja();
objNinja.Fuerza = 15;
objNinja.ArteMarcial = "Kung Fu";
objNinja.Salto = 5;
objNinja.Arma = "Katana";
objNinja.Saltar(objNinja.Salto);
objNinja.Ataque();



public class Ninja
{
    private string arteMarcial;
    public string ArteMarcial
    {
        get { return arteMarcial; }
        set { arteMarcial = value; }
    }
    private string arma;
    public string Arma
    {
        get { return arma; }
        set { arma = value; }
    }
    private int fuerza;
    public int Fuerza
    {
        get { return fuerza; }
        set { fuerza = value; }
    }
    private int salto;
    public int Salto
    {
        get { return salto; }
        set { salto = value; }
    }
    
    public void Saltar(int multiplicador)
    {
        Console.WriteLine("El ninja salta " + (salto * multiplicador) + " metros de altura.");
    }

    public void Ataque()
    {
        Console.WriteLine("El ninja ataca con su " + arma + " y su arte marcial es " + arteMarcial);
    }
}