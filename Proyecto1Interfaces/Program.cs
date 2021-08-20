using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Interfaces
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 1;

			int[] array = new int[10];
			List<int> lista = new List<int> { 4, 5};

			String text = "Buenas buenas ";

			Console.WriteLine(text + x + "\n");
			/*for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(text + x);
				x++;
			}*/

			foreach(int i in lista){
				Console.WriteLine("Valor: " + i);
			}

			Console.Read();
		}
	}
}
