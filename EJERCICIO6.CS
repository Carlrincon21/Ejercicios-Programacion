//6. Crear una clase Fruta con variables privadas color, peso, esEstacional.
//● Crear setters y getters.
//● Escribir una función llamada EsComestible() que devuelva verdadero cuando la
//fruta pesa menos de 200 gr y es de estación, y falso en cualquier otro caso.
//● Definir dos constructores de modo tal que la fruta pueda crearse con los valores
//color, peso y estacional al momento de instanciarse, o bien crearse sin valores
//iniciales.




Fruta pera = new Fruta("verde", 200, true);

    bool resultado = pera.EsComestible();

Console.WriteLine ("Es comestible? " + resultado);

Fruta Manzana = new Fruta();
Manzana.Color = "Rojo";
Manzana.Peso = 300;
resultado = Manzana.EsComestible();


Console.WriteLine ("Es comestible? " + resultado);





public class Fruta
{
    private string color;
    public string Color
    {
        get { return color; }
        set { color = value; }
    }
    private int peso;
    public int Peso
    {
        get { return peso; }
        set { peso = value; }
    }
    
    private bool esEstacional;
    public bool EsEstacional
    {
        get { return esEstacional; }
        set { esEstacional = value; }
    }
    

    public Fruta(string color, int peso, bool esEstacional)
    {
        this.color = color;
        this.peso = peso;
        this.esEstacional = esEstacional;
    }

    public Fruta()
    {
        
    }
    
    public bool  EsComestible()
    {
       if (this.peso <= 200  && this.esEstacional == true)
        {
         return true;   

        }
        else
        {
            return false;
        }

       
       
     
    }
}
