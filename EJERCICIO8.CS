// 8. Crear una clase Persona que tenga los atributos privados nombre y apellido, con sus setters y
// getters.
// ● Crear una clase llamada Visitante con los mismos atributos.
// ● Crear una clase Guardia con los mismos atributos.
// ● Crear una instancia de cada una de las clases y asignarle valores.
// ● Mostrar por pantalla los valores.
//HECHO EL 8


// 9. Crear una clase Persona que tenga los atributos privados nombre y apellido, con sus setters y
// getters.
// ● Crear una clase llamada Visitante que extienda de Persona.
// ● Crear una clase Guardia que extienda de Persona.
// ● Crear una instancia de cada una de las clases y asignarle valores.
// ● Mostrar por pantalla los valores; estudiar las ventajas del uso de la herencia.
//HECHO EL 9

// 10. Continuando con el ejemplo anterior, realizar las siguientes modificaciones:
// ● Agregar en Persona el método Presentarse() que devuelva nombre y apellido de la
// persona.
// ● Crear una instancia de cada una de las clases y asignarle valores.
// ● Mostrar por pantalla los valores.
// ● Sobreescribir el método Presentarse() en la clase Guardia de modo tal que devuelva el
// siguiente mensaje “Hola, mi nombre es <nombre y apellido> y soy el guardia.” Donde
// <nombre y apellido> debe ser reemplazado por el nombre y apellido del guardia.
// 4
// ● Mostrar por pantalla el resultado de invocar el método Presentarse() y advertir que la
// implementación en la clase Guardia tiene precedencia sobre la de su padre.
// HECHO EL 10

// 11. Continuando con el ejemplo anterior, realizar las siguientes modificaciones:
// ● Agregar en Visitante el atributo privado dni (numérico) con sus setters y getters
// correspondientes.
// ● Agregar en Guardia el método público ControlarDocumento() que reciba como
// parámetro el dni de la persona y devuelva el mensaje “Adelante persona con dni <dni>”
// donde <dni> es el valor recibido por parámetro.
// ● Crear una instancia de cada una de las clases y asignarle valores.
// ● Mostrar por pantalla los valores.
//HECHO EL 11

// 12. Continuando con el ejemplo anterior, realizar las siguientes modificaciones:
// ● Modificar la clase Guardia para que el método público ControlarDocumento() devuelva
// el mensaje “Adelante <nombre completo del visitante> con dni <dni>” reemplazando
// respectivamente con el nombre completo del visitante y su dni.
// ● Crear una instancia de cada una de las clases y asignarle valores.
// ● Mostrar por pantalla los valores.
// ● Analizar si es posible pasar un único parámetro al método ControlarDocumento() y
// estudiar las ventas y desventajas que tendría asociado.
//HECHO EL 12

Visitante objVisitante = new Visitante("Gabriel", "Lopez", 124235);


Console.WriteLine(objVisitante.Saludar());

Guardia objGuardia = new Guardia("Pedro", "Perez");

Console.WriteLine(objGuardia.Saludar());

Console.WriteLine(objGuardia.ControlarDocumento(objVisitante));
public class Persona
{
    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    private string apellido;
    public string Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }
    
    public Persona (string nombre, string apellido)
    {
        this.nombre = nombre;
        this.apellido = apellido;
    }
    
    public virtual string Saludar()
    {
        return "Hola, mi nombre es " + nombre + " " + apellido;
    }
}

public class Visitante : Persona
{

    private int dni;
    public int Dni
    {
        get { return dni; }
        set { dni = value; }
    }
    
    public Visitante (string nombre, string apellido, int dni) : base(nombre, apellido)
    {
        this.dni = dni;
    }
    public override string Saludar()
    {
       return base.Saludar() + " y soy el visitante";
    }
   }

public class Guardia : Persona
{
    public Guardia (string nombre, string apellido) : base(nombre, apellido)
    {
      
    }

    public override string Saludar()
    {
        return base.Saludar() + " y soy el guardia";
    }

    public string ControlarDocumento(Visitante visitante)
    {
        return "Hola " + visitante.Nombre + " " + visitante.Apellido + "," + " con dni " + visitante.Dni + ", puede pasar.";
    }
}