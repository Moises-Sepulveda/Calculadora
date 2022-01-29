using System;

namespace Calculadora_Menu
{
    class Program
    {
		static void Main(string[] args)
		{
			menu();
		}
		static void menu()
		{
			Console.WriteLine("1-SUMA, ");
			Console.WriteLine("2-RESTA, ");
			Console.WriteLine("3-MULTIPLICACION, ");
			Console.WriteLine("4-DIVISION, ");
			Console.WriteLine("5-RAIZ CUADRADA, ");
			Console.WriteLine("6-POTENCIACION, ");
			Console.WriteLine("CUALQUIER NUMERO O CARACTER DIFERENTE PARA SALIR DEL PROGRAMA");

			string eleccion = Console.ReadLine();
			switch (eleccion)
			{
				case "1":
					suma();
					break;
				case "2":
					resta();
					break;
				case "3":
					multiplicacion();
					break;
				case "4":
					division();
					break;
				case "5":
					raiz();
					break;
				case "6":
					potenciacion();
					break;
				default:
					Environment.Exit(0);
					break;
			}

		}

		static void suma()
		{
			double num1, num2, resultado;
			Console.WriteLine("");
			Valor(0);
			num1 = double.Parse(Console.ReadLine());
			Valor(1);
			num2 = double.Parse(Console.ReadLine());
			resultado = num1 + num2;
			Console.WriteLine("RESULTADO SUMA: " + resultado);
			Console.WriteLine("");
			Console.ReadKey();
			menu();
		}


		static void resta()
		{
			double num1, num2, resultado;
			Console.WriteLine("");
			Valor(0);
			num1 = double.Parse(Console.ReadLine());
			Valor(1);
			num2 = double.Parse(Console.ReadLine());
			resultado = num1 - num2;
			Console.WriteLine("RESULTADO RESTA: " + resultado);
			Console.WriteLine("");
			Console.ReadKey();
			menu();
		}

		static void multiplicacion()
		{
			double num1, num2, resultado;
			Console.WriteLine("");
			Valor(0);
			num1 = double.Parse(Console.ReadLine());
			Valor(1);
			num2 = double.Parse(Console.ReadLine());
			resultado = num1 * num2;
			Console.WriteLine("RESULTADO MULTIPLICACION: " + resultado);
			Console.WriteLine("");
			Console.ReadKey();
			menu();
		}

		static void division()
		{
			double num1, num2, resultado;
			Console.WriteLine("");
			Valor(0);
			num1 = double.Parse(Console.ReadLine());
			Valor(1);
			num2 = double.Parse(Console.ReadLine());
			resultado = num1 / num2;			
			Console.WriteLine("RESULTADO DIVISION: " + resultado);
			Console.WriteLine("");
			Console.ReadKey();
			menu();
		}

		static void raiz()
		{
			double num1, resultado;
			Console.WriteLine("");
			Valor(2);
			num1 = double.Parse(Console.ReadLine());
			resultado = Math.Sqrt(num1);
			Console.WriteLine("RESULTADO RAIZ: " + resultado);
			Console.WriteLine("");
			Console.ReadKey();
			menu();
		}

		static void potenciacion()
		{
			double num1, num2, resultado;
			Console.WriteLine("");
			Valor(0);
			num1 = double.Parse(Console.ReadLine());
			Valor(1);
			num2 = double.Parse(Console.ReadLine());
			resultado = Math.Pow(num1, num2);
			Console.WriteLine("RESULTADO POTENCIACION: " + resultado);
			Console.WriteLine("");
			Console.ReadKey();
			menu();
		}

		static void Valor(int decision)
        {
			if (decision == 0)
			{
				Console.WriteLine("Introduzca el primer Valor");
			}
			else if (decision == 1)
            {
				Console.WriteLine("Introduzca el segundo Valor");
			}

			else
            {
				Console.WriteLine("Introduzca el Valor");
			}

				
        }
	}
}
