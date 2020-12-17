using System;
using System.Collections.Generic;
using System.Text;
using static Practica_5.Program;

namespace Practica_5
{
	interface IColorVentana
	{
		public void CambiarVentana();

	}






	//------------------------------------------------
	class Club
	{
		private string nombre;
		private string nombreClub;
		private string nombreEstadio;


		private string[] opcionesClub = new string[]
		{
			"1. Comprar Entrada",
			"2. Hacerte Socio",
			"3. Ver calendario",
			"4. Salir"
		};

		public Club(string nombreClub, string nombreEstadio)
		{
			this.nombreClub = nombreClub;
			this.nombreEstadio = nombreEstadio;
		}		

		public void ElegirOpcion()
		{
			Console.WriteLine("			Bienvenido al sitio de {0}", nombreClub);

			byte opc = (byte)ElegirOpc.SeleccionOpc("\nIngrese la operación que desea realizar", opcionesClub, 1, 4);

			switch (opc)
			{
				case 1: comprarEntrada(); break;
				case 2: Console.WriteLine("Eligió la opción 2"); break;
				case 3: Console.WriteLine("Eligió la opción 3"); break;
			}

			//Console.WriteLine("\nIngrese la operación que desea realizar");

		}


		public virtual void CambiarVentana()
		{
			
		}

		public void SetNombre()
		{
			Console.Write("Ingrese su nombre: ");
			this.nombre = Console.ReadLine();
		}

		protected void comprarEntrada()
		{
			int cantidad = 0;
			bool AuxBool = false;
			string[] opcionesEntradas =
			{
				"1. Vista Lejana - $3000",
				"2. Vista Media - $5000",
				"3. Vista Cercana - $10000"

			};

			int opc = ElegirOpc.SeleccionOpc("				Comprar Entrada \nElija su lugar en " + nombreEstadio+"\n", opcionesEntradas, 1, 3);

			while (AuxBool == false)
			{
				Console.Write("Ingrese la cantidad de entradas a comprar. (Máximo 3): ");
				if (!(int.TryParse(Console.ReadLine(), out cantidad))) Console.WriteLine("Error! Ingrese solo números");
				else if (cantidad < 1 || cantidad > 3) Console.WriteLine("Error! Ingrese valores dentro del rango 1 - 3");
				else AuxBool = true;
			}

			switch (opc)
			{
				case 1:
					if (ElegirOpc.ConfirmarOpcion(($"1. Vista Lejana - $3000 x {cantidad} \n¿Confirmar?: ")))
					{
						Console.WriteLine("Gracias por la compra.");
					}
					else Console.WriteLine("Usted canceló la operación");
					break;
				case 2:
					if (ElegirOpc.ConfirmarOpcion(($"2. Vista Media - $5000 x {cantidad} \n¿Confirmar?: ")))
					{
						Console.WriteLine("Gracias por la compra.");
					}
					else Console.WriteLine("Usted canceló la operación");
					break;
				case 3:
					if (ElegirOpc.ConfirmarOpcion(($"3. Vista Cercana - $10000 x {cantidad} \n¿Confirmar?: ")))
					{
						Console.WriteLine("Gracias por la compra.");
					}
					else Console.WriteLine("Usted canceló la operación");
					break;
			}

			Console.ReadKey(true);
			Console.Clear();
			
		}



		public string GetNombre() => nombre;
		public string GetNombreClub() => nombreClub;

		public virtual void GetCalendario()
		{

		}
	}



	//-------------------------------------------------------------------------------------------------------------------------------
	//CLASES HIJAS 


	class River : Club
	{
		private string[] calendario = new string[]
		{
			"River vs Banfield. Fecha 1 Campeonado. 05/12/2020",
			"Lanus vs River. Fecha 2 Campeonado. 12/12/2020",
			"River vs Nacional. Partido Ida Copa Libertadores. 15/12/2020",
			"Rosario Central vs River. Fecha 3 Campeonado. 19/12/2020",
			"Nacional vs River. Partido Vuelta Copa Libertadores. 22/12/2020",
			"River vs Godoy Cruz. Fecha 4 Campeonado. 26/12/2020"
		};

		public River(string nombreClub, string nombreEstadio): base(nombreClub, nombreEstadio)
		{

		}
		public override void CambiarVentana()
		{
			Console.BackgroundColor = ConsoleColor.Red;
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.White;
			Console.Title = "River Plate";
		}


		public override void GetCalendario()
		{
			foreach (string aux in calendario)
			{
				Console.WriteLine(aux);
			}

		}

	}

	class Boca: Club
	{
		private string[] calendario = new string[]
		{
			"Boca vs Newell's. Fecha 1 Campeonado. 05/12/2020",
			"Velez vs Boca. Fecha 2 Campeonado. 12/12/2020",
			"Boca vs Racing. Partido Ida Copa Libertadores. 15/12/2020",
			"Defensa y Justicia vs Boca. Fecha 3 Campeonado. 19/12/2020",
			"Racing vs Boca. Partido Vuelta Copa Libertadores. 22/12/2020",
			"Boca vs Gimnasia. Fecha 4 Campeonado. 26/12/2020"
		};

		public Boca(string nombreClub, string nombreEstadio) : base(nombreClub, nombreEstadio)
		{

		}

		public override void CambiarVentana()
		{
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Title = "Boca Juniors";
		}

		public override void GetCalendario()
		{
			foreach (string aux in calendario)
			{
				Console.WriteLine(aux);
			}

		}
	}

	class Independiente: Club
	{
		private string[] calendario = new string[]
		{
			"Independiente vs Aldosivi. Fecha 1 Campeonado. 05/12/2020",
			"Estudiantes LP vs Independiente. Fecha 2 Campeonado. 12/12/2020",
			"Independiente vs Lanus. Partido Ida Copa Sudamericana. 15/12/2020",
			"Colon vs Independiente. Fecha 3 Campeonado. 19/12/2020",
			"Lanus vs Independiente. Partido Vuelta Copa Sudamericana. 22/12/2020",
			"Independiente vs Union. Fecha 4 Campeonado. 26/12/2020"
		};
		public Independiente(string nombreClub, string nombreEstadio) : base(nombreClub, nombreEstadio)
		{

		}

		public override void CambiarVentana()
		{
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.White;
			Console.Title = "Independiente";
		}

		public override void GetCalendario()
		{
			foreach (string aux in calendario)
			{
				Console.WriteLine(aux);
			}

		}
	}

	class Racing: Club
	{
		private string[] calendario = new string[]
		{
			"Racing vs Patronato. Fecha 1 Campeonado. 05/12/2020",
			"Huracan vs Racing. Fecha 2 Campeonado. 12/12/2020",
			"Boca vs Racing. Partido Ida Copa Libertadores. 15/12/2020",
			"Talleres vs Racing. Fecha 3 Campeonado. 19/12/2020",
			"Racing vs Boca. Partido Vuelta Copa Libertadores. 22/12/2020",
			"Racing vs Atl Tucuman. Fecha 4 Campeonado. 26/12/2020"
		};

		public Racing(string nombreClub, string nombreEstadio) : base(nombreClub, nombreEstadio)
		{

		}

		public override void CambiarVentana()
		{
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.White;
			Console.Title = "Racing Club";
		}

		public override void GetCalendario()
		{
			foreach (string aux in calendario)
			{
				Console.WriteLine(aux);
			}

		}
	}

	class SanLorenzo: Club
	{
		private string[] calendario = new string[]
		{
			"San Lorenzo vs Central Cordoba. Fecha 1 Campeonado. 05/12/2020",
			"Arsenal vs San Lorenzo. Fecha 2 Campeonado. 12/12/2020",
			"Argentinos Jrs vs San Lorenzo. Fecha 3 Campeonado. 19/12/2020",
			"San Lorenzo vs Temperley. Fecha 4 Campeonado. 26/12/2020"
		};
		public SanLorenzo(string nombreClub, string nombreEstadio) : base(nombreClub, nombreEstadio)
		{

		}

		public override void CambiarVentana()
		{
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.Title = "San Lorenzo";
		}

		public override void GetCalendario()
		{
			foreach (string aux in calendario)
			{
				Console.WriteLine(aux);
			}

		}
	}
}
