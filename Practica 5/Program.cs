using System;
using System.Collections.Generic;

namespace Practica_5
{
	class Program
	{
		static void Main()
		{
			string[] elegirClub = new string[]
			{
				"1. River ",
				"2. Boca",
				"3. Independiente",
				"4. Racing ",
				"5. San Lorenzo "
			};


			//ElegirClub.SeleccionClub();
			int auxClub = ElegirOpc.SeleccionOpc("Elija el club del que es hincha", elegirClub, 0, 5);

			List<Club> AuxUsuario = new List<Club> 
			{
				new River("River Plate", "El Monumental"),
				new Boca("Boca Juniors", "La Bombonera"), 
				new Independiente("Independiente", "El Libertadores de América"), 
				new Racing("Racing Club", "El Cilindro"), 
				new SanLorenzo("San Lorenzo", "El Nuevo Gasómetro") 
			};
			
			Club usuario = AuxUsuario[auxClub-1];
			usuario.SetNombre();

			usuario.CambiarVentana();

			usuario.ElegirOpcion();
			
			


			Console.WriteLine(usuario.GetNombre());
			Console.WriteLine(usuario.GetNombreClub());
			
		}


		//Clase con múltiples métodos de gestión
		public class ElegirOpc
		{

			/*******************
			 * brief: Retorna un valor segun la opcion que se haya elegido de varias opciones
			 * param: Mensaje a desplegar en consola
			 * param: array de string que representan las multiples opciones
			 * param: cantidad mínima de opciones a elegir
			 * param: cantidad máxmima de opciones a elegir
			 * return: Valor entero de la opcion elegida
			 * ********************************************/
			public static int SeleccionOpc(string mensaje, string[] opciones, int valMin, int valMax)
			{
				int auxInt;

				Console.WriteLine(mensaje);

				foreach (string str in opciones)
				{
					Console.WriteLine(str);
				}



				bool flag = false;
				while (flag == false)
				{
					Console.Write("Opción: ");
					if (!(int.TryParse(Console.ReadLine(), out auxInt)))
					{
						Console.WriteLine("Error! Ingrese solo números.");
					}
					else
					{
						if (auxInt < valMin || auxInt > valMax)
						{
							Console.WriteLine("Error! Ingrese un valor entre {0} y {1}.", valMin, valMax);
						}
						else
						{
							switch (auxInt)
							{
								case 1: flag = true; return 1;
								case 2: flag = true; return 2;
								case 3: flag = true; return 3;
								case 4: flag = true; return 4;
								case 5: flag = true; return 5;

							}
						}
					}

				}

				return -1;

			}

			public static bool ConfirmarOpcion(string mensaje)
			{
				string confirmar ="";
				bool AuxBool = false;
				Console.WriteLine(mensaje);

				while (AuxBool == false)
				{
					Console.Write("S/N: ");
					confirmar = Console.ReadLine();

					if ((confirmar[0] != 'S') && (confirmar[0] != 's') && (confirmar[0] != 'N') && (confirmar[0] != 'n'))
					{
						Console.WriteLine("Error! Ingrese solo \"S\" o \"N\"");

					}
					else
					{
						AuxBool = true;

						
					}
				}


				if ((confirmar[0] == 'S') || (confirmar[0] == 's')) return true;

				else  return false;


			}

			/*
			public static int setClub()
			{
				int auxInt;
				bool flag = false;
				while (flag == false)
				{
					Console.Write("Opción: ");
					if (!(int.TryParse(Console.ReadLine(), out auxInt)))
					{
						Console.WriteLine("Error! Ingrese solo números.");
					}
					else
					{
						if (auxInt < 1 || auxInt > 5)
						{
							Console.WriteLine("Error! Ingrese un valor entre 1 y 5.");
						}
						else
						{
							switch (auxInt)
							{
								case 1: flag = true; return 0;	
								case 2: flag = true; return 1;
								case 3: flag = true; return 2;
								case 4: flag = true; return 3;
								case 5: flag = true; return 4;

							}
						}
					}
					
				}

				return -1;
			}
			*/
		}
	}
}
