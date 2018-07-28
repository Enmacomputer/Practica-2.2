using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2._2
{
	class Program
	{
		static void Main(string[] args)
		{
			int n1, n2, n3;
			Console.WriteLine("Introducir primer numero>");
			n1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Introducir segundo numero:");
			n2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Introducir tercer numero:");
			n3 = Convert.ToInt32(Console.ReadLine());

			if (n1 < n2 && n1 < n3)
			{
				if (n2 < n3)
				{
					Console.WriteLine("Primer numero:" + n1);
					Console.WriteLine("Primer numero:" + n2);
					Console.WriteLine("Primer numero:" + n3);
				}
				else
				{
					Console.WriteLine("Primer numero:" + n1);
					Console.WriteLine("Primer numero:" + n3);
					Console.WriteLine("Primer numero:" + n2);
				}

				if (n2 < n1 && n2 < n3)
				{
					if (n1 < n3)
					{
						Console.WriteLine("Primer numero:" + n2);
						Console.WriteLine("Primer numero:" + n1);
						Console.WriteLine("Primer numero:" + n3);
					}

					else
					{
						Console.WriteLine("Primer numero:" + n2);
						Console.WriteLine("Primer numero:" + n3);
						Console.WriteLine("Primer numero:" + n1);
					}

					if (n3 < n1 && n3 < n2)
					{
						if (n1 < n2)
						{
							Console.WriteLine("Primer numero:" + n3);
							Console.WriteLine("Primer numero:" + n1);
							Console.WriteLine("Primer numero:" + n2);
						}

						else
						{
							Console.WriteLine("Primer numero:" + n3);
							Console.WriteLine("Primer numero:" + n2);
							Console.WriteLine("Primer numero:" + n1);
						}
					}

						}
				Console.ReadKey();
			}
		}
	}
}
