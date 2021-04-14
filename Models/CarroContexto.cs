using Microsoft.EntityFrameworkCore;

namespace CrudCarro.Models
{
    public class CarroContexto : DbContext
    {
        public CarroContexto(DbContextOptions<CarroContexto> options) :base(options)
        	{

        	}
        	public DbSet<Marca> Marcas {get; set;}
            public DbSet<Modelo> Modelos {get; set;}
        
    }
}