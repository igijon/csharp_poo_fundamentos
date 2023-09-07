using POO_fundamentos;

Console.WriteLine("Contactos: {0}", Contacto.totalContactos);
Contacto pepe = new Contacto("Pepe", "García", "123456789");
Contacto maria = new Contacto("Maria", "Sánchez", "123456789");
Console.WriteLine(pepe.AA);
Console.WriteLine(maria);
Contacto.empresa = "IES Maestre de Calatrava";
Contacto.verEmpresa();
Console.WriteLine("Contactos: {0}", Contacto.totalContactos);
Console.ReadKey();