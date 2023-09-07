using System;
namespace POO_fundamentos
{
	public class Contacto 
	{
		string nombre, apellidos, movil, fijo;
		public readonly int AA;

		public Contacto(string nombre, string apellidos, string movil)
		{
			this.nombre = nombre;
			this.apellidos = apellidos;
			this.movil = movil;
			AA = 666666666;
		}

		public Contacto(string nombre, string apellidos, string movil, string fijo) :
			this(nombre, apellidos, movil)
		{
			this.fijo = fijo;
		}

		~Contacto()
		{
			//Liberar recursos	
		}

     


    }
}

