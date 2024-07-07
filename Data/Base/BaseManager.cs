using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Base
{
	public abstract class BaseManager<T> where T  : class     	// Con <T> le indicamos que va a recibir una clase de tipo generica
	{
		// La palabra clave abstract en C# se utiliza para definir una clase que no puede ser instanciada directamente.
		// En su lugar, se usa como una clase base para otras clases. Una clase abstracta puede contener métodos abstractos
		// (sin implementación) que deben ser implementados por las clases derivadas, así como métodos con implementación.

		private static ApplicationDbContext contextInstance = null; // ApplicationDbContext va a ser el contecto de nuestra aplicacion, es una variable privada del tipo DbContext

		// private: Este modificador de acceso indica que el campo solo es accesible dentro de la clase en la que se define. Otros métodos y propiedades de la misma clase pueden acceder a él,
		// pero no los métodos y propiedades de otras clases.

		// static: Este modificador indica que el campo pertenece a la clase en sí, en lugar de a instancias individuales de la clase. En otras palabras, solo hay una copia de este campo,
		// independientemente de cuántas instancias de la clase existan.

		// ApplicationDbContext: Este es el tipo del campo. En este caso, ApplicationDbContext es una clase que representa el contexto de base de datos en una aplicación
		// que utiliza Entity Framework

		// contextInstance: Este es el nombre del campo. Los nombres de campo siguen las convenciones de nomenclatura de C#, generalmente comenzando con una letra minúscula y utilizando
		// camel case para separar las palabras.

		// En conjunto, esta línea declara un campo privado y estático de tipo ApplicationDbContext llamado contextInstance y lo inicializa con null. Este tipo de declaración es común
		// en el patrón de diseño Singleton, donde se quiere asegurar que solo exista una única instancia de un objeto en toda la aplicación. Por ejemplo, en el contexto de una aplicación
		// que utiliza una base de datos, se podría usar un Singleton para garantizar que solo haya una única conexión abierta a la base de datos en cualquier momento.

	





	}
}
