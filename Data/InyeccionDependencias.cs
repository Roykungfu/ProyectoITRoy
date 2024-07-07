using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{

	// la inyección de dependencias (Dependency Injection, DI) es un patrón de diseño que facilita la creación de software modular, flexible y fácil de mantener.
	// La idea básica es que una clase (dependiente) no debe crear sus propias dependencias (otros objetos de los que depende), sino que estas dependencias deben
	// ser proporcionadas (inyectadas) por un contenedor de inyección de dependencias. Esto ayuda a reducir el acoplamiento entre las clases y mejora la testabilidad.



	// Ejemplo sin inyeccion de dependencias

	public class Engine
	{
		public void Start()
		{ Console.WriteLine("Engine started"); }	}

	public class Car
	{	private Engine _engine;
		public Car()
			{ _engine = new Engine(); }// La clase Car crea su propia instancia de Engine

		public void Start()
		{	_engine.Start();
			Console.WriteLine("Car started");}


		/////// Con inyeccion de dependencias/////

		public class Engine
		{
			public void Start()
			{
				Console.WriteLine("Engine started");
			}
		}

		public class Car
		{
			private Engine _engine;

			// El motor es inyectado a través del constructor
			public Car(Engine engine)
			{
				_engine = engine;
			}

			public void Start()
			{
				_engine.Start();
				Console.WriteLine("Car started");
			}
		}




	}

















}


