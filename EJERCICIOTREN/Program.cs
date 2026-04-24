using Clases;

Formacion formacion = new Formacion();
formacion.EstaEnMovimiento = false;
formacion.Locomotoras = new List<Locomotora>();
formacion.Vagones = new List<Vagones>();

Locomotora locomotora1 = new Locomotora(1000,800,10000);
Depositos deposito1 = new Depositos ();
deposito1.AgregarLocomotoraEnFormacion(locomotora1, formacion);

DePasajeros VagonPasajero = new DePasajeros(10, 10);
DePasajeros VagonPasajero2 = new DePasajeros(10, 10);

formacion.Vagones.Add(VagonPasajero);
formacion.Vagones.Add(VagonPasajero2);
Console.WriteLine($"La cantidad de pasajeros que puede transportar una formacion es: {VagonPasajero.CalcularCantidadPasajeros()}");
Console.WriteLine($"La cantidad total de pasajeros en los vagones que hay en la formacion es de: {formacion.TotalPasajerosFormacion()}");




////EJERCICIO MICROS
/// 

