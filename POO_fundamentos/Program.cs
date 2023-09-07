using POO_fundamentos;

Console.WriteLine("Contactos: {0}", Contacto.totalContactos);
Contacto pepe = new Contacto("Pepe", "García", "123456789");
Contacto maria = new Contacto("Maria", "Sánchez", "123456789");
Console.WriteLine(pepe.AA);
Console.WriteLine(maria);
Contacto.empresa = "IES Maestre de Calatrava";
Contacto.verEmpresa();
Console.WriteLine("Contactos: {0}", Contacto.totalContactos);
maria.Nombre = "Maria Luisa";
Console.WriteLine(maria.Nombre);

Vector a = new Vector(2, 3, 5);
Vector b = new Vector(3, 4, 5);
Vector resultado = a + b;
Console.WriteLine(a + " + " + b+ " = "+resultado);
Console.ReadKey();