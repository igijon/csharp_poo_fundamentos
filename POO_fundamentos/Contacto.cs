using System;
namespace POO_fundamentos
{
	public class Contacto 
	{
		string nombre, apellidos, movil, fijo;
		public readonly int AA;
		public static string empresa;
		public static int totalContactos = 0;

		public Contacto(string nombre, string apellidos, string movil)
		{
			this.nombre = nombre;
			this.apellidos = apellidos;
			this.movil = movil;
			AA = 666666666;
			totalContactos++;
		}

		public Contacto(string nombre, string apellidos, string movil, string fijo) :
			this(nombre, apellidos, movil)
		{
			this.fijo = fijo;
		}

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        ~Contacto()
		{
			//Liberar recursos	
		}

     
		public static void verEmpresa()
		{
			Console.WriteLine("La empresa es: {0}", empresa);
		}

    }
}

