using System;
namespace POO_fundamentos
{
	public class Vector
	{
		int x, y, z;

		public Vector(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public static Vector operator + (Vector a, Vector b)
		{
			Vector resultado = new Vector(0, 0, 0);
			resultado.x = a.x + b.x;
            resultado.y = a.y + b.y;
            resultado.z = a.z + b.z;
			return resultado;
        }

		public override string ToString()
		{
			return "(" + this.x + "," + this.y + "," + this.z + ")";
		}
    }
}

