using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ApplicationDbContext : DbContext // DbContext esta dentro de las clases de EntityFramework

	// DbContext es una clase en Entity Framework, un popular Object-Relational Mapper (ORM) para .NET.
    // DbContext actúa como un puente entre tu aplicación y la base de datos, permitiéndote interactuar con la base de datos utilizando objetos
    // y clases de C# en lugar de comandos SQL directamente.


    
	{
           
        public ApplicationDbContext() : base() { }   // Este es el constructor, se puede crear rapidamente con las siglas "ctor" + TAB
        {
            
            public static string ConnectionString   { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// base.OnConfiguring(optionsBuilder); Esto no hace falta




		}


	}

        


    }
}
