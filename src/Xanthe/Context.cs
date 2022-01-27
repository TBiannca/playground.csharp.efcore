using Microsoft.EntityFrameworkCore;

namespace Xanthe;

public class Context : DbContext
{
    public Context()
    {
    }

    public DbSet<EPerson> Persons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(@"Server=127.0.0.1,1439;Database=xanthe;User=sa;Password=Secret1234");

}